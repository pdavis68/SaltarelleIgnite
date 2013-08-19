/*
  Copyright 2012-2013 George's, Inc

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/

using jQueryApi.UI;
using System;
using System.Runtime.CompilerServices;

namespace Ignite.UI.Widgets
{
    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGCurrencyEditorOptions : IGNumericEditorOptions
    {
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGDateEditorOptions : IGEditorOptions
    {
        public int CenturyThreshold;
        public TypeOption<string, int> DataMode;
        public string DateDisplayFormat;
        public string DateInputFormat;
        public bool EnableUTCDates;
        public bool HideMaskOnFocus;
        public DateTime MaxValue;
        public int MinNumberOfDateFields;
        public DateTime MinValue;
        public string PromptChar;
        public bool ReduceDayOfInvalidDate;
        public bool Spin1Field;
        public bool UseLastGoodDate;
        public int YearShift;
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGEditorOptions
    {
        public int AnimationHideDuration;
        public int AnimationShowDuration;
        public TypeOption<string, int> Button;
        public bool ButtonHidden;
        public string Display;
        public bool DropDownOnReadOnly;
        public TypeOption<string, int, object> DropDownTriggers;
        public string ExcludeKeys;
        public bool FocusOnSpin;
        public int Height;
        public bool HideEnterKey;
        public string IncludeKeys;
        public string InputName;
        public bool ListAutoComplete;
        public int ListColumns;
        public bool ListDropDownAsChild;
        public object[] ListItems;
        public bool ListMatchContains;
        public bool ListMatchIgnoreCase;
        public bool ListMatchOnly;
        public int ListMaxHeight;
        public int ListWidth;
        public object Locale;
        public int MaxLength;
        public bool Nullable;
        public string NullText;
        public bool ReadOnly;
        public object Regional;
        public bool RenderInContainer;
        public bool Required;
        public TypeOption<string, int> SelctionOnFocus;
        public int SpinDelta;
        public bool SpinOnReadOnly;
        public bool SpinWrapAround;
        public int TabIndex;
        public TypeOption<string, object> TextAlign;
        public TypeOption<string, int> TextMode;
        public string Theme;
        public bool ToLower;
        public bool ToUpper;
        public TypeOption<string, int> Type;
        public IGValidatorOptions ValidatorOptions;
        public object Value;
        public int Width;

        #region Events
        public jQueryUIEventHandler<IGEditorEvent> Blur;
        public jQueryUIEventHandler<IGEditorEvent> ButtonClick;
        public jQueryUIEventHandler<IGEditorEvent> Focus;
        public jQueryUICancelableEventHandler<IGEditorHideDropDownEvent> HideDropDown;
        public jQueryUIEventHandler<IGEditorInvalidValueEvent> InvalidValue;
        public jQueryUICancelableEventHandler<IGEditorKeyEvent> Keydown;
        public jQueryUICancelableEventHandler<IGEditorKeyEvent> Keypress;
        public jQueryUIEventHandler<IGEditorKeyEvent> Keyup;
        public jQueryUIEventHandler<IGEditorListEvent> ListSelected;
        public jQueryUICancelableEventHandler<IGEditorListEvent> ListSelecting;
        public jQueryUIEventHandler<IGEditorMouseEvent> Mousedown;
        public jQueryUIEventHandler<IGEditorMouseEvent> Mouseleave;
        public jQueryUIEventHandler<IGEditorMouseEvent> Mousemove;
        public jQueryUIEventHandler<IGEditorMouseEvent> Mouseover;
        public jQueryUIEventHandler<IGEditorMouseEvent> Mouseup;
        public jQueryUICancelableEventHandler<IGEditorEvent> ShowDropDown;
        public jQueryUICancelableEventHandler<IGEditorSpinEvent> Spin;
        public jQueryUIEventHandler<IGEditorChangeEvent> TextChanged;
        public jQueryUIEventHandler<IGEditorChangeEvent> ValueChanged;
        public jQueryUICancelableEventHandler<IGEditorChangeEvent> ValueChanging;
        #endregion Events
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGMaskEditorOptions : IGEditorOptions
    {
        public TypeOption<string, int> DataMode;
        public string EmptyChar;
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGTextEditorOptions : IGEditorOptions
    {
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGNumericEditorOptions : IGEditorOptions
    {
        #region Options
        public TypeOption<string, int> DataMode;
        public string DecimalSeparator;
        public int DisplayFactor;
        public object Groups;
        public string GroupSeparator;
        public int MaxDecimals;
        public int MaxValue;
        public int MinDecimals;
        public int MinValue;
        public string NegativePattern;
        public string NegativeSign;
        public int NullValue;
        public string PositivePattern;
        public TypeOption<string, object> ScientificFormat;
        public string Symbol;
        #endregion Options
    }

    

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGPercentEditorOptions : IGNumericEditorOptions
    {
    }

    #region Event Classes
    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGEditorEvent
    {
        public IGEditorObject Owner;
        public object OriginalEvent;
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGEditorHideDropDownEvent : IGEditorEvent
    {
        public object Value;
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGEditorInvalidValueEvent
    {
        public IGEditorObject Owner;
        public object Value;
        public string Text;
        public string Reason;
        public int Year;
        public int Month;
        public int Day;
        public int Hours;
        public int Minutes;
        public int Seconds;
        public int Milliseconds;
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGEditorKeyEvent
    {
        public IGEditorObject Owner;
        public int Key;
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGEditorListEvent
    {
        public IGEditorObject Owner;
        public object OriginalEvent;
        public int Index;
        public int OldIndex;
        public object Item;
    }


    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGEditorMouseEvent
    {
        public IGEditorObject Owner;
        public object ElementType;
        public int Id;
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGEditorSpinEvent
    {
        public IGEditorObject Owner;
        public int Delta;
        public object Value;
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGEditorChangeEvent
    {
        public IGEditorObject Owner;
        public object Value;
        public object OldValue;
    }
    #endregion Event Classes
}