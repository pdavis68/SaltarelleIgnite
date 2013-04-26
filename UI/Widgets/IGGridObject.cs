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
    public class IGGridObject
    {
        [ScriptSkip]
        public static explicit operator jQueryObject(IGGridObject o)
        {
            return null;
        }
        [ScriptSkip]
        public static explicit operator IGGridObject(jQueryObject o)
        {
            return null;
        }

        [InlineCode("{this}.igGrid('dataBind')")]
        public void DataBind()
        {
        }

        [InlineCode("{this}.igGrid('getCellText', {rowId}, {columnKey})")]
        public string GetCellText(TypeOption<object, int> rowId, string columnKey)
        {
            return null;
        }

        [InlineCode("{this}.igGrid('getCellValue', {rowId}, {columnKey})")]
        public object GetCellValue(TypeOption<object, int> rowId, string columnKey)
        {
            return null;
        }

        [InlineCode("{this}.igGrid('totalRecordsCount')")]
        public int TotalRecordsCount()
        {
            return 0;
        }


        #region Events

        public event jQueryUIEventHandler<IGGridRowSelectionEvent> RowSelectionChanged
        {
            [InlineCode("{this}.bind('iggridselectionrowselectionchanged', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('iggridselectionrowselectionchanged', {value})")]
            remove
            {
            }
        }

        public event jQueryUICancelableEventHandler<IGGridRowSelectionEvent> RowSelectionChanging
        {
            [InlineCode("{this}.bind('iggridselectionrowselectionchanging', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('iggridselectionrowselectionchanging', {value})")]
            remove
            {
            }
        }
        
        public event jQueryUIEventHandler<IGGridEvent> DataRendered
        {
            [InlineCode("{this}.bind('iggriddatarendered', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('iggriddatarendered', {value})")]
            remove
            {
            }
        }

        public event jQueryUICancelableEventHandler<IGGridEvent> DataRendering
        {
            [InlineCode("{this}.bind('iggriddatarendering', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('iggriddatarendering', {value})")]
            remove
            {
            }
        }

        public event jQueryUIEventHandler<IGGridEvent> Rendered
        {
            [InlineCode("{this}.bind('iggridrendered', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('iggridrendered', {value})")]
            remove
            {
            }
        }

        public event jQueryUICancelableEventHandler<IGGridEvent> Rendering
        {
            [InlineCode("{this}.bind('iggridrendering', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('iggridrendering', {value})")]
            remove
            {
            }
        }

        #endregion

    }
}
