﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;
using Brushes = System.Windows.Media.Brushes;
using Color = System.Windows.Media.Color;
using Size = System.Windows.Size;

namespace _7dtd_svmanager_fix_mvvm.Views.Update
{
    public class RichTextItemsToDocumentConverter : IValueConverter
    {
        public object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var doc = new FlowDocument();

            var items = value as ICollection<RichTextItem>;
            InsertParagraph(doc.Blocks, null, items);

            return doc;
        }

        public void InsertParagraph(BlockCollection block, InlineCollection inlineCollection, IEnumerable<RichTextItem> items)
        {
            var isNoBreakLine = false;
            foreach (var item in items)
            {
                if (item == null)
                    continue;

                if (item.TextType == RichTextType.NoBreakLine)
                {
                    isNoBreakLine = true;
                }
                else if (item.TextType == RichTextType.Space)
                {
                    var paragraph = block.LastOrDefault() as Paragraph;
                    paragraph?.Inlines.Add(new Run(" "));
                }
                else if (item.TextType == RichTextType.Text)
                {
                    inlineCollection.Add(new Run(item.Text)
                    {
                        Foreground = new SolidColorBrush(item.Foreground)
                    });
                }
                else if (item.TextType == RichTextType.Hyperlink)
                {
                    var hyperlink = new Hyperlink()
                    {
                        NavigateUri = new Uri(item.Link)
                    };
                    InsertParagraph(block, hyperlink.Inlines, item.Children);
                    inlineCollection.Add(hyperlink);
                }
                else
                {
                    var paragraph = new Paragraph()
                    {
                        Margin = new Thickness(0, 3, 0, 3)
                    };

                    if (isNoBreakLine)
                    {
                        paragraph = block.LastOrDefault() as Paragraph;
                        isNoBreakLine = false;
                    }

                    InsertParagraph(block, paragraph.Inlines, item.Children);
                    block.Add(paragraph);
                }
            }
        }

        public object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new System.NotImplementedException();
        }
    }

    public enum RichTextType
    {
        Text,
        Hyperlink,
        Paragraph,
        NoBreakLine,
        Space
    }

    public class RichTextItem
    {
        public RichTextType TextType { get; set; } = RichTextType.Text;
        public string Text { get; set; }
        public string Link { get; set; }
        public Color Foreground { get; set; } = Colors.White;
        public FontWeight FontWeight { get; set; }
        public Thickness Margin { get; set; }

        public IEnumerable<RichTextItem> Children
        {
            get => _children;
            set => _children = new List<RichTextItem>(value);
        }

        private List<RichTextItem> _children = new List<RichTextItem>();

        public void AddChildren(RichTextItem item)
        {
            _children.Add(item);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var item in Children)
            {
                sb.Append(item.Text + " ");
            }
            return sb.ToString();
        }
    }

    public class BindableRichTextBox : RichTextBox
    {
        #region 依存関係プロパティ
        public static readonly DependencyProperty DocumentProperty = DependencyProperty.Register("Document", typeof(FlowDocument),
            typeof(BindableRichTextBox), new UIPropertyMetadata(null, DocumentChanged));
        public static readonly DependencyProperty WordWrappingProperty = DependencyProperty.Register("WordWrapping", typeof(bool),
            typeof(BindableRichTextBox), new UIPropertyMetadata(true, WordWrappingChangedCallback));
        #endregion  // 依存関係プロパティ

        #region 公開プロパティ
        public new FlowDocument Document
        {
            get => (FlowDocument)GetValue(DocumentProperty);
            set => SetValue(DocumentProperty, value);
        }

        public bool WordWrapping
        {
            get => (bool)GetValue(WordWrappingProperty);
            set => SetValue(WordWrappingProperty, value);
        }
        #endregion  // 公開プロパティ

        #region イベントハンドラ
        private static void DocumentChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            SetDocument(sender, e.NewValue);
        }

        private static void WordWrappingChangedCallback(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            if (sender is BindableRichTextBox bindableRichTextBox)
            {
                SetDocument(bindableRichTextBox, bindableRichTextBox.Document);
            }
        }

        private static void SetDocument(object sender, object newValue)
        {
            if (sender is not RichTextBox control || newValue is not FlowDocument flowDocument)
                return;

            control.Document = flowDocument;

            if (control is not BindableRichTextBox bindableRichTextBox)
                return;

            if (bindableRichTextBox.WordWrapping)
            {
                control.Document.PageWidth = double.NaN;
            }
            else
            {
                control.HorizontalScrollBarVisibility = ScrollBarVisibility.Auto;
                
                var size = MeasureString(bindableRichTextBox);
                control.Document.PageWidth = size.Width + 12;
            }
        }
        #endregion  // イベントハンドラ

        private static Size MeasureString(RichTextBox control)
        {
            using var graphics = Graphics.FromHwnd(IntPtr.Zero);
            var dpiX = graphics.DpiX;

            var text = new TextRange(control.Document.ContentStart, control.Document.ContentEnd).Text;
            var formattedText = new FormattedText(text,
                CultureInfo.CurrentCulture,
                FlowDirection.LeftToRight,
                new Typeface(control.FontFamily, control.FontStyle, control.FontWeight, control.FontStretch),
                control.FontSize,
                Brushes.Black,
                dpiX);

            return new Size(formattedText.Width, formattedText.Height);
        }
    }
}
