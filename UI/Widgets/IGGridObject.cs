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
    [IgnoreNamespace, Imported]
    public class IGGridObject : jQueryObject
    {
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

        [InlineCode("{this}.igGrid('destroy')")]
        public void Destroy()
        {
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

        public event jQueryUIEventHandler<IGEditCellStartEvent> EditCellStarted
        {
            [InlineCode("{this}.bind('iggridupdatingeditcellstarted', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('iggridupdatingeditcellstarted', {value})")]
            remove
            {
            }
        }

        public event jQueryUICancelableEventHandler<IGEditCellStartEvent> EditCellStarting
        {
            [InlineCode("{this}.bind('iggridupdatingeditcellstarting', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('iggridupdatingeditcellstarting', {value})")]
            remove
            {
            }
        }

        public event jQueryUIEventHandler<IGEditCellEndEvent> EditCellEnded
        {
            [InlineCode("{this}.bind('iggridupdatingeditcellended', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('iggridupdatingeditcellended', {value})")]
            remove
            {
            }
        }

        public event jQueryUICancelableEventHandler<IGEditCellEndEvent> EditCellEnding
        {
            [InlineCode("{this}.bind('iggridupdatingeditcellending', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('iggridupdatingeditcellending', {value})")]
            remove
            {
            }
        }


        #endregion

    }
}
