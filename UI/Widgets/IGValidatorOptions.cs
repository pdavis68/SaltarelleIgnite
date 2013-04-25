using System;
using System.Collections.Generic;
using System.Html;
using System.Runtime.CompilerServices;
using System.Text;

namespace Ignite.UI.Widgets
{
    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGValidatorOptions
    {

        public string Alignment { get; set; }

        public int AnimationHide { get; set; }

        public int AnimationShow { get; set; }

        public bool BodyAsParent { get; set; }

        public bool CheckboxesName { get; set; }

        public Element Element { get; set; }

        public bool EnableTargetErrorCss { get; set; }

        public Element ErrorLabel { get; set; }

        public string ErrorMessage { get; set; }

        public bool FormSubmit { get; set; }

        public TypeOption<string, int> KeepFocus { get; set; }

        public object Locale { get; set; }

        public int Max { get; set; }

        public int MaxLength { get; set; }

        public int Min { get; set; }

        public int MinLength { get; set; }

        public bool OnBlur { get; set; }

        public bool OnChange { get; set; }

        public bool OnSubmit { get; set; }

        /// <summary>
        /// Infragistics site says "Enumeration" but provides a string example.
        /// </summary>
        public string RegExp { get; set; }

        public bool Required { get; set; }

        public bool ShowIcon { get; set; }

        public string Theme { get; set; }

    }
}
