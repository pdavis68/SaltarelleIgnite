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

using jQueryApi;
using jQueryApi.UI;

namespace Ignite.UI.Widgets
{
    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGLoaderOptions
    {
        public IGLoaderSettings Settings { get; set; }
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGLoaderSettings
    {
        public bool AutoDetectLocale { get; set; }

        public string CssPath { get; set; }

        public string Locale { get; set; }

        public string LocalePath { get; set; }

        public Function Preinit { get; set; }

        public Function Ready { get; set; }

        public string Regional { get; set; }

        public string Resources { get; set; }

        public string ScriptPath { get; set; }

        public string Theme { get; set; }
    }
}
