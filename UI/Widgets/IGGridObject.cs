using jQueryApi;
using jQueryApi.UI;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

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
