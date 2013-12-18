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
using System.Html;
using System.Runtime.CompilerServices;

namespace Ignite.UI.Widgets
{
    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGValidatorOptions
    {
        public string Alignment;
        public int AnimationHide;
        public int AnimationShow;
        public bool BodyAsParent;
        public bool CheckboxesName;
        public Element Element;
        public bool EnableTargetErrorCss;
        public TypeOption<string, Element> ErrorLabel;
        public string ErrorMessage;
        public bool FormSubmit;
        public TypeOption<string, int> KeepFocus;
        public object Locale;
        public int Max;
        public int MaxLength;
        public int Min;
        public int MinLength;
        public bool Onblur;
        public bool Onchange;
        public bool Onsubmit;
        public TypeOption<string, int, object> RegExp;
        public bool Required;
        public bool ShowIcon;
        public string Theme;

        #region Events
        public jQueryUICancelableEventHandler<IGValidatorCheckValue> CheckValue;
        public jQueryUIEventHandler<IGValidatorError> ErrorHidden;
        public jQueryUICancelableEventHandler<IGValidatorError> ErrorHiding;
        public jQueryUICancelableEventHandler<IGValidatorError> ErrorShowing;
        public jQueryUIEventHandler<IGValidatorError> ErrorShown;
        public jQueryUICancelableEventHandler<IGValidatorValidation> Validation;
        #endregion Events
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGValidatorCheckValue
    {
        public string Message { get; set; }
        public TypeOption<int, decimal, string, object> Value { get; set; }
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGValidatorError
    {
        public string Message { get; set; }
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGValidatorValidation
    {
        public string Message { get; set; }
        public bool Invalid { get; set; }
    }
}
