using System;
using System.Runtime.CompilerServices;

using jQueryApi;
using jQueryApi.UI;
using System.Html;

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
        
        public jQueryUIEventHandler<object> ActionExecuting;
        
        public jQueryUIEventHandler<object> Copy;
        
        public jQueryUIEventHandler<object> Cut;
        
        public jQueryUIEventHandler<object> Paste;
        
        public jQueryUIEventHandler<object> Redo;
        
        public jQueryUIEventHandler<object> Rendered;
        
        public jQueryUIEventHandler<object> Rendering;
        
        public jQueryUIEventHandler<object> ToolbarCollapsed;
        
        public jQueryUIEventHandler<object> ToolbarCollapsing;
        
        public jQueryUIEventHandler<object> ToolbarExpanded;
        
        public jQueryUIEventHandler<object> ToolbarExpanding;
        
        public jQueryUIEventHandler<object> Undo;
        #endregion Events
    }
}
