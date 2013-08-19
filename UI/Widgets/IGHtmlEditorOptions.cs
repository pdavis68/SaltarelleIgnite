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
    public class IGHtmlEditorOptions
    {
        #region Options
        public object[] CustomToolbars { get; set; }
        public int Height { get; set; }
        public string InputName { get; set; }
        public bool ShowCopyPasteToolbar { get; set; }
        public bool ShowFormattingToolbar { get; set; }
        public bool ShowInsertObjectToolbar { get; set; }
        public bool ShowTextToolbar { get; set; }
        public object[] ToolbarSettings { get; set; }
        public string Value { get; set; }
        public int Width { get; set; }
        #endregion Options

        #region Events
        public jQueryUIEventHandler<object> ActionExecuted;
        public jQueryUICancelableEventHandler<object> ActionExecuting;
        public jQueryUIEventHandler<object> Copy;
        public jQueryUIEventHandler<object> Cut;
        public jQueryUIEventHandler<object> Paste;
        public jQueryUIEventHandler<object> Redo;
        public jQueryUIEventHandler<object> Rendered;
        public jQueryUIEventHandler<object> Rendering;
        public jQueryUIEventHandler<object> ToolbarCollapsed;
        public jQueryUICancelableEventHandler<object> ToolbarCollapsing;
        public jQueryUIEventHandler<object> ToolbarExpanded;
        public jQueryUICancelableEventHandler<object> ToolbarExpanding;
        public jQueryUIEventHandler<object> Undo;
        #endregion Events
    }
}
