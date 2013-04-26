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
using System.Runtime.CompilerServices;

using jQueryApi;
using jQueryApi.UI;

namespace Ignite.UI.Widgets
{
    public class IGHtmlEditorObject
    {
        [ScriptSkip]
        public static explicit operator jQueryObject(IGHtmlEditorObject o)
        {
            return null;
        }
        [ScriptSkip]
        public static explicit operator IGHtmlEditorObject(jQueryObject o)
        {
            return null;
        }

        #region Methods
        [InlineCode("{this}.igHtmlEditor('destroy')")]
        public void Destroy()
        {

        }

        [InlineCode("{this}.igHtmlEditor('executeAction', {actionName})")]
        public void ExecuteAction(String actionName)
        {

        }

        [InlineCode("{this}.igHtmlEditor('executeAction', {actionName}, {args})")]
        public void ExecuteAction(String actionName, String[] args)
        {

        }
             
        [InlineCode("{this}.igHtmlEditor('getContent', {format})")]
        public string GetContent(string format)
        {
            return null;
        }
        
        [InlineCode("{this}.igHtmlEditor('isDirty')")]
        public bool IsDirty()
        {
            return false;
        }
        
        [InlineCode("{this}.igHtmlEditor('setContent', {content}, {format})")]
        public void SetContent(String content, String format)
        {
        }
        
        [InlineCode("{this}.igHtmlEditor('widget')")]
        public object Widget()
        {
            return null;
        }
        #endregion Methods

        #region Events
        public event jQueryUIEventHandler<object> ActionExecuted
        {
            [InlineCode("{this}.bind('actionExecuted', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('actionExecuted', {value})")]
            remove
            {
            }
        }
        
        public event jQueryUIEventHandler<object> ActionExecuting
        {
            [InlineCode("{this}.bind('actionExecuting', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('actionExecuting', {value})")]
            remove
            {
            }
        }
        
        public event jQueryUIEventHandler<object> Copy
        {
            [InlineCode("{this}.bind('copy', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('copy', {value})")]
            remove
            {
            }
        }
        
        public event jQueryUIEventHandler<object> Cut
        {
            [InlineCode("{this}.bind('cut', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('cut', {value})")]
            remove
            {
            }
        }
        
        public event jQueryUIEventHandler<object> Paste
        {
            [InlineCode("{this}.bind('paste', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('paste', {value})")]
            remove
            {
            }
        }
        
        public event jQueryUIEventHandler<object> Redo
        {
            [InlineCode("{this}.bind('redo', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('redo', {value})")]
            remove
            {
            }
        }
        
        public event jQueryUIEventHandler<object> Rendered
        {
            [InlineCode("{this}.bind('rendered', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('rendered', {value})")]
            remove
            {
            }
        }
        
        public event jQueryUIEventHandler<object> Rendering
        {
            [InlineCode("{this}.bind('rendering', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('rendering', {value})")]
            remove
            {
            }
        }
        
        public event jQueryUIEventHandler<object> ToolbarCollapsed
        {
            [InlineCode("{this}.bind('toolbarCollapsed', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('toolbarCollapsed', {value})")]
            remove
            {
            }
        }
        
        public event jQueryUIEventHandler<object> ToolbarCollapsing
        {
            [InlineCode("{this}.bind('toolbarCollapsing', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('toolbarCollapsing', {value})")]
            remove
            {
            }
        }
        
        public event jQueryUIEventHandler<object> ToolbarExpanded
        {
            [InlineCode("{this}.bind('toolbarExpanded', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('toolbarExpanded', {value})")]
            remove
            {
            }
        }
        
        public event jQueryUIEventHandler<object> ToolbarExpanding
        {
            [InlineCode("{this}.bind('toolbarExpanding', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('toolbarExpanding', {value})")]
            remove
            {
            }
        }
        
        public event jQueryUIEventHandler<object> Undo
        {
            [InlineCode("{this}.bind('undo', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('undo', {value})")]
            remove
            {
            }
        }
        #endregion Events
    }
}
