﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace _7dtd_svmanager_fix_mvvm.LangResources {
    using System;
    
    
    /// <summary>
    ///   ローカライズされた文字列などを検索するための、厳密に型指定されたリソース クラスです。
    /// </summary>
    // このクラスは StronglyTypedResourceBuilder クラスが ResGen
    // または Visual Studio のようなツールを使用して自動生成されました。
    // メンバーを追加または削除するには、.ResX ファイルを編集して、/str オプションと共に
    // ResGen を実行し直すか、または VS プロジェクトをビルドし直します。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class SettingsResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SettingsResources() {
        }
        
        /// <summary>
        ///   このクラスで使用されているキャッシュされた ResourceManager インスタンスを返します。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("_7dtd_svmanager_fix_mvvm.LangResources.SettingsResources", typeof(SettingsResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   すべてについて、現在のスレッドの CurrentUICulture プロパティをオーバーライドします
        ///   現在のスレッドの CurrentUICulture プロパティをオーバーライドします。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   {0}が空です。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string _0_is_Empty {
            get {
                return ResourceManager.GetString("_0_is_Empty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   コンフィグファイルパス に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string ConfigFilePath {
            get {
                return ResourceManager.GetString("ConfigFilePath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   実行可能ファイル (*.exe)|*.exe に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string Filter_ExcutableFile {
            get {
                return ResourceManager.GetString("Filter_ExcutableFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   XMLファイル (*.xml)|*.xml|すべてのファイル(*.*)|*.* に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string Filter_XmlFile {
            get {
                return ResourceManager.GetString("Filter_XmlFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   メッセージ送信を行う間隔です。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string Help_AutoRestartIntervalTime {
            get {
                return ResourceManager.GetString("Help_AutoRestartIntervalTime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   サーバーが終了した際に起動を行うまでに待機する方法です。
        ///
        ///1. クールタイム
        ///Telnet接続終了後、指定した時間（クールタイム）を待機した後に起動処理を実行します。
        ///ローカルサーバが多い場合や、SSHを利用した接続の場合に有効です。
        ///
        ///2. プロセス待機
        ///サーバーのプロセスの動作を確認し、終了が確認でき次第、起動処理を実行します。
        ///待機時間を最小限にし、安全に起動処理が実行できます。
        ///ただし、複数サーバーが動いている場合はプロセスを手動で設定する必要があります。
        ///また、SSH環境では使用できません。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string Help_AutoRestartRebootWaitMode {
            get {
                return ResourceManager.GetString("Help_AutoRestartRebootWaitMode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   再起動の残り時間が指定した時間になるとメッセージを送信します。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string Help_AutoRestartStartTime {
            get {
                return ResourceManager.GetString("Help_AutoRestartStartTime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   復元する際のディレクトリパスです。
        ///空の場合は「%AppData%\7DaysToDie」が復元先として使用されます。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string Help_BackupRestorePath {
            get {
                return ResourceManager.GetString("Help_BackupRestorePath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   ベータモードでは開発中の機能を使用することができます。
        ///正式に実装する保証はなければ、動作保証もできないので使用には注意してください。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string Help_BetaMode {
            get {
                return ResourceManager.GetString("Help_BetaMode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   このオプションで指定した時間が経過するとサーバーの再起動を行います。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string Help_ScheduledTime {
            get {
                return ResourceManager.GetString("Help_ScheduledTime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   このオプションで指定した時間だけログ出力を停止させます。
        ///Get Timeなどのコンソールログに出力しないで解析する機能でログ出力されてしまう問題を解決します。
        ///取得できた段階でログ出力を再開させますが、短すぎると処理する前にログ出力されてしまいます。ネットワーク環境に合わせて設定しましょう。
        ///ローカル環境であれば通常は2000ミリ秒 (2秒) あれば十分なはずです。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string Help_TelnetWaitTime {
            get {
                return ResourceManager.GetString("Help_TelnetWaitTime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   値を入力してください。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string Input_Some_Value {
            get {
                return ResourceManager.GetString("Input_Some_Value", resourceCulture);
            }
        }
        
        /// <summary>
        ///   サーバーファイルパス に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string ServerFilePath {
            get {
                return ResourceManager.GetString("ServerFilePath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   アドミンファイルパス に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UI_AdminFilePathLabel {
            get {
                return ResourceManager.GetString("UI_AdminFilePathLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   自動でアップデートをチェックする に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UI_AutoCheckUpdLabel {
            get {
                return ResourceManager.GetString("UI_AutoCheckUpdLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   バックアップ保存先のパス に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UI_BackupDestinationPath {
            get {
                return ResourceManager.GetString("UI_BackupDestinationPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   ベータモードの有効化 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UI_BetaModeEnabledLabel {
            get {
                return ResourceManager.GetString("UI_BetaModeEnabledLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   ベータモード に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UI_BetaModeLabel {
            get {
                return ResourceManager.GetString("UI_BetaModeLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   キャンセル に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UI_CancelBT {
            get {
                return ResourceManager.GetString("UI_CancelBT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   コンフィグファイルパス に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UI_ConfigFilePathLabel {
            get {
                return ResourceManager.GetString("UI_ConfigFilePathLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   再起動時にチャットメッセージを送信する に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UI_EnabledRestartMessage {
            get {
                return ResourceManager.GetString("UI_EnabledRestartMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   暗号化 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UI_Encryption {
            get {
                return ResourceManager.GetString("UI_Encryption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   パスワードを暗号化 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UI_EncryptPassword {
            get {
                return ResourceManager.GetString("UI_EncryptPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   全般 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UI_GeneralLabel {
            get {
                return ResourceManager.GetString("UI_GeneralLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   時間 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UI_Hour {
            get {
                return ResourceManager.GetString("UI_Hour", resourceCulture);
            }
        }
        
        /// <summary>
        ///   送信間隔 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UI_IntervalTime {
            get {
                return ResourceManager.GetString("UI_IntervalTime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   キー に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UI_KeyConfigLabel {
            get {
                return ResourceManager.GetString("UI_KeyConfigLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   キー編集 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UI_KeyEditBTLabel {
            get {
                return ResourceManager.GetString("UI_KeyEditBTLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   ログ取得の有効化 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UI_LogGetterEnabledLabel {
            get {
                return ResourceManager.GetString("UI_LogGetterEnabledLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   ログ に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UI_LogLabel {
            get {
                return ResourceManager.GetString("UI_LogLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   コンソールテキストの長さ に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UI_LogLength {
            get {
                return ResourceManager.GetString("UI_LogLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   チャット形式 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UI_MessageFormat {
            get {
                return ResourceManager.GetString("UI_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   分 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UI_Minute {
            get {
                return ResourceManager.GetString("UI_Minute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   その他 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UI_OthersLabel {
            get {
                return ResourceManager.GetString("UI_OthersLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   再起動待機モード に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UI_RebootWaitMode {
            get {
                return ResourceManager.GetString("UI_RebootWaitMode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   パスワードをリセット に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UI_ResetPassword {
            get {
                return ResourceManager.GetString("UI_ResetPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   自動再起動 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UI_Restart {
            get {
                return ResourceManager.GetString("UI_Restart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   復元先のパス に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UI_RestoreDestinationPath {
            get {
                return ResourceManager.GetString("UI_RestoreDestinationPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   保存 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UI_SaveBT {
            get {
                return ResourceManager.GetString("UI_SaveBT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   予約時間 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UI_ScheduledTime {
            get {
                return ResourceManager.GetString("UI_ScheduledTime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   秒 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UI_Second {
            get {
                return ResourceManager.GetString("UI_Second", resourceCulture);
            }
        }
        
        /// <summary>
        ///   サーバーファイルパス に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UI_ServerFilePathLabel {
            get {
                return ResourceManager.GetString("UI_ServerFilePathLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   設定 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UI_SettingsNameLabel {
            get {
                return ResourceManager.GetString("UI_SettingsNameLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   ショートカットキー に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UI_ShortcutKeyLabel {
            get {
                return ResourceManager.GetString("UI_ShortcutKeyLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   開始時間 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UI_StartTime {
            get {
                return ResourceManager.GetString("UI_StartTime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   文字 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UI_TextLength {
            get {
                return ResourceManager.GetString("UI_TextLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   アップデート に類似しているローカライズされた文字列を検索します。
        /// </summary>
        public static string UI_UpdateLabel {
            get {
                return ResourceManager.GetString("UI_UpdateLabel", resourceCulture);
            }
        }
    }
}
