﻿namespace _7dtd_ConfigEditorCUI.XMLWrapper
{
    public class AttributeInfo
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return $"{Name}=\"{Value}\"";
        }
    }
}
