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

using System;
using System.Html;
using System.Runtime.CompilerServices;

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
