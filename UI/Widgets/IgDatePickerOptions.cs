using System;
using System.Collections.Generic;
using System.Html;
using System.Runtime.CompilerServices;
using System.Text;

namespace Ignite.UI.Widgets
{
    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGDatePickerOptions
    {

        public const string BUTTON_DROPDOWN = "dropdown";
        public const string BUTTON_CLEAR = "clear";
        public const string BUTTON_SPIN = "splin";

        public const string DROPDOWNTRIGGER_ARROW = "arrow";
        public const string DROPDOWNTRIGGER_BUTTON = "button";
        public const string DROPDOWNTRIGGER_FOCUS = "focus";

        public const string TEXTMODE_TEXT = "text";
        public const string TEXTMODE_PASSWORD = "password";
        public const string TEXTMODE_MULTILINE = "multiline";
        public const string TEXTMODE_TEXTAREA = "textarea";

      
        public int AnimationHideDuration { get; set; }
        public int AnimationShowDuration { get; set; }
        public string Button { get; set; }
        public bool ButtonHidden { get; set; }
        public int CenturyThreshold;
        public TypeOption<string, int> DataMode;
        public string DateDisplayFormat { get; set; }
        public string DateInputFormat { get; set; }
        public string Display { get; set; }
        public bool DropDownOnReadOnly { get; set; }
        public string DropDownTriggers { get; set; }
        public bool EnableUTCDates { get; set; }
        public string ExcludeKeys { get; set; }
        public bool FocusOnSpin { get; set; }
        public int Height { get; set; }
        public bool HideEnterKey { get; set; }
        public bool HideMaskOnFocus { get; set; }
        public string IncludeKeys { get; set; }
        public string InputName { get; set; }
        public bool ListAutoComplete { get; set; }
        public int ListColumns { get; set; }
        public bool ListDropDownAsChild { get; set; }
        public Element[] Listitems { get; set; }
        public bool ListMatchContains { get; set; }
        public bool ListMatchIgnoreCase { get; set; }
        public bool ListMatchOnly { get; set; }
        public int ListMaxHeight { get; set; }
        public int ListWidth { get; set; }
        public object Locale { get; set; }
        public int MaxLength { get; set; }
        public DateTime MaxValue { get; set; }
        public int MinNumberOfDateFields { get; set; }
        public DateTime MinValue { get; set; }
        public bool Nullable { get; set; }
        public string NullText { get; set; }
        public string PromptChar { get; set; }
        public bool ReadOnly { get; set; }
        public bool ReduceDayOfInvalidDate { get; set; }
        public object Regional { get; set; }
        public string SelectionOnFocus { get; set; }
        public bool Spin1Field { get; set; }
        public int SpinDelta { get; set; }
        public bool SpinOnReadOnly { get; set; }
        public bool SpinWrapAround { get; set; }
        public int TabIndex { get; set; }
        public string TextAlign { get; set; }
        public string TextMode { get; set; }
        public string Theme { get; set; }
        public bool ToLower { get; set; }
        public bool ToUpper { get; set; }
        public TypeOption<string, int> Type { get; set; }
        public bool UseLastGoodDate { get; set; }
        public IGValidatorOptions ValidatorOptions { get; set; }
        public object Value { get; set; }
        public int Width { get; set; }
        public int YearShift { get; set; }
    }
}
