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

using jQueryApi;
using jQueryApi.UI;
using System;
using System.Html;
using System.Runtime.CompilerServices;

namespace Ignite.UI.Widgets
{
    [IgnoreNamespace, Imported]
    public class IGGridObject : jQueryObject
    {
        #region igGrid
        #region Methods
        [InlineCode("{this}.igGrid('activeCell')")]
        public object ActiveCell()
        {
            return null;
        }

        [InlineCode("{this}.igGrid('activeRow')")]
        public object ActiveRow()
        {
            return null;
        }

        [InlineCode("{this}.igGrid('allRows')")]
        public object[] AllRows()
        {
            return null;
        }

        [InlineCode("{this}.igGrid('allTransactions')")]
        public object[] AllTransactions()
        {
            return null;
        }

        [InlineCode("{this}.igGrid('cellAt', {x}, {y})")]
        public object CellAt(int x, int y)
        {
            return null;
        }
        
        [InlineCode("{this}.igGrid('children')")]
        public new object[] Children()
        {
            return null;
        }

        [InlineCode("{this}.igGrid('childrenWidgets')")]
        public object[] ChildrenWidgets()
        {
            return null;
        }
        
        [InlineCode("{this}.igGrid('columnByKey', {key})")]
        public object ColumnByKey(string key)
        {
            return null;
        }
        
        [InlineCode("{this}.igGrid('columnByText', {text})")]
        public object ColumnByText(string text)
        {
            return null;
        }
        
        [InlineCode("{this}.igGrid('commit')")]
        public void Commit()
        {
            
        }

        [InlineCode("{this}.igGrid('commit', {id})")]
        public void Commit(string id)
        {

        }
        
        [InlineCode("{this}.igGrid('container')")]
        public object Container(string id)
        {
            return null;
        }

        [InlineCode("{this}.igGrid('dataBind')")]
        public void DataBind()
        {

        }

        [InlineCode("{this}.igGrid('dataSourceObject', {dataSource})")]
        public void DataSourceObject(object dataSource)
        {

        }

        [InlineCode("{this}.igGrid('destroy')")]
        public void Destroy()
        {

        }

        [InlineCode("{this}.igGrid('findRecordByKey', {key})")]
        public object FindRecordByKey(string key)
        {
            return null;
        }
        
        [InlineCode("{this}.igGrid('footersTable')")]
        public object FootersTable()
        {
            return null;
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

        [InlineCode("{this}.igGrid('getDetachedRecord', {t})")]
        public object GetDetatchedRecord(object t)
        {
            return null;
        }
        
        [InlineCode("{this}.igGrid('headersTable')")]
        public object HeadersTable(object t)
        {
            return null;
        }
        
        [InlineCode("{this}.igGrid('hideColumn', {column})")]
        public void HideColumn(object column)
        {
            
        }
        
        [InlineCode("{this}.igGrid('id')")]
        public string Id(object column)
        {
            return null;
        }
        
        [InlineCode("{this}.igGrid('immediateChildren')")]
        public object[] ImmediateChildren()
        {
            return null;
        }
        
        [InlineCode("{this}.igGrid('immediateChildrenWidgets')")]
        public object[] ImmediateChildrenWidgets()
        {
            return null;
        }
        
        [InlineCode("{this}.igGrid('pendingTransactions')")]
        public object[] PendingTransactions()
        {
            return null;
        }
        
        [InlineCode("{this}.igGrid('renderNewRow', {rec})")]
        public void RenderRow(object rec)
        {
            
        }
        
        [InlineCode("{this}.igGrid('renderNewRow', {rec}, {key})")]
        public void RenderRow(object rec, string key)
        {

        }
        
        [InlineCode("{this}.igGrid('rollback')")]
        public void Rollback()
        {

        }
        
        [InlineCode("{this}.igGrid('rollback', {id})")]
        public void Rollback(string id)
        {

        }
        
        [InlineCode("{this}.igGrid('rollback', {update})")]
        public void Rollback(bool update)
        {

        }
        
        [InlineCode("{this}.igGrid('rollback', {id}, {update})")]
        public void Rollback(string id, bool update)
        {

        }
        
        [InlineCode("{this}.igGrid('rowAt', {i})")]
        public object RowAt(int i)
        {
            return null;
        }
        
        [InlineCode("{this}.igGrid('rows')")]
        public TableRowElement[] Rows()
        {
            return null;
        }
        
        [InlineCode("{this}.igGrid('saveChanges')")]
        public void SaveChanges()
        {
            
        }
        
        [InlineCode("{this}.igGrid('scrollContainer')")]
        public object ScrollContainer()
        {
            return null;
        }
        
        [InlineCode("{this}.igGrid('selectedCell')")]
        public object SelectedCell()
        {
            return null;
        }
        
        [InlineCode("{this}.igGrid('selectedCells')")]
        public object[] SelectedCells()
        {
            return null;
        }
        
        [InlineCode("{this}.igGrid('selectedRow')")]
        public object SelectedRow()
        {
            return null;
        }
        
        [InlineCode("{this}.igGrid('selectedRows')")]
        public object[] SelectedRows()
        {
            return null;
        }
        
        [InlineCode("{this}.igGrid('showColumn', {column})")]
        public void ShowColumn(object column)
        {

        }
        
        [InlineCode("{this}.igGrid('totalRecordsCount')")]
        public int TotalRecordsCount()
        {
            return 0;
        }

        [InlineCode("{this}.igGrid('transactionsAsString')")]
        public string TransactionsAsString()
        {
            return null;
        }
        
        [InlineCode("{this}.igGrid('virtualScrollTo', {virtualScrollerY})")]
        public void VirtualScrollTo(object virtualScrollerY)
        {
            
        }
        
        [InlineCode("{this}.igGrid('widget')")]
        public object Widget()
        {
            return null;
        }
        
        #endregion Methods

        #region Events
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
        #endregion Events
        #endregion igGrid

        #region igGridFiltering
        #region Methods
        [InlineCode("{this}.igGridFiltering('destroy')")]
        public void DestroyFiltering()
        {

        }

        [InlineCode("{this}.igGridFiltering('filter', {expressions})")]
        public void Filter(object[] expressions)
        {

        }

        [InlineCode("{this}.igGridFiltering('filter', {expressions}, {updateUI})")]
        public void Filter(object[] expressions, bool updateUI)
        {

        }

        [InlineCode("{this}.igGridFiltering('filter', {evt}, {columnKey})")]
        public void ToggleFilterRowByFeatureChooser(object evt, string columnKey)
        {

        }
        #endregion Methods

        #region Events
        public event jQueryUIEventHandler<IGGridFilterEvent> DataFiltered
        {
            [InlineCode("{this}.bind('iggridfilteringdatafiltered', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('iggridfilteringdatafiltered', {value})")]
            remove
            {
            }
        }

        public event jQueryUICancelableEventHandler<IGGridFilterEvent> DataFiltering
        {
            [InlineCode("{this}.bind('iggridfilteringdatafiltering', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('iggridfilteringdatafiltering', {value})")]
            remove
            {
            }
        }

        public event jQueryUIEventHandler<IGGridFilterDropDownEvent> DropDownClosed
        {
            [InlineCode("{this}.bind('iggridfilteringdropdownclosed', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('iggridfilteringdropdownclosed', {value})")]
            remove
            {
            }
        }

        public event jQueryUICancelableEventHandler<IGGridFilterDropDownEvent> DropDownClosing
        {
            [InlineCode("{this}.bind('iggridfilteringdropdownclosing', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('iggridfilteringdropdownclosing', {value})")]
            remove
            {
            }
        }

        public event jQueryUIEventHandler<IGGridFilterDropDownEvent> DropDownOpened
        {
            [InlineCode("{this}.bind('iggridfilteringdropdownopened', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('iggridfilteringdropdownopened', {value})")]
            remove
            {
            }
        }

        public event jQueryUICancelableEventHandler<IGGridFilterDropDownEvent> DropDownOpening
        {
            [InlineCode("{this}.bind('iggridfilteringdropdownopening', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('iggridfilteringdropdownopening', {value})")]
            remove
            {
            }
        }

        public event jQueryUIEventHandler<IGGridEvent> FilterDialogClosed
        {
            [InlineCode("{this}.bind('iggridfilteringfilterdialogclosed', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('iggridfilteringfilterdialogclosed', {value})")]
            remove
            {
            }
        }

        public event jQueryUICancelableEventHandler<IGGridFilterEvent> FilterDialogClosing
        {
            [InlineCode("{this}.bind('iggridfilteringfilterdialogclosing', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('iggridfilteringfilterdialogclosing', {value})")]
            remove
            {
            }
        }

        public event jQueryUIEventHandler<IGGridFilterDialogEvent> FilterDialogContentsRendered
        {
            [InlineCode("{this}.bind('iggridfilteringfilterdialogcontentsrendered', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('iggridfilteringfilterdialogcontentsrendered', {value})")]
            remove
            {
            }
        }

        public event jQueryUICancelableEventHandler<IGGridFilterDialogEvent> FilterDialogContentsRendering
        {
            [InlineCode("{this}.bind('iggridfilteringfilterdialogcontentsrendering', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('iggridfilteringfilterdialogcontentsrendering', {value})")]
            remove
            {
            }
        }

        public event jQueryUIEventHandler<IGGridFilterDialogFilterEvent> FilterDialogFilterAdded
        {
            [InlineCode("{this}.bind('iggridfilteringfilterdialogfilteradded', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('iggridfilteringfilterdialogfilteradded', {value})")]
            remove
            {
            }
        }

        public event jQueryUICancelableEventHandler<IGGridFilterDialogFilterAddingEvent> FilterDialogFilterAdding
        {
            [InlineCode("{this}.bind('iggridfilteringfilterdialogfilteradding', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('iggridfilteringfilterdialogfilteradding', {value})")]
            remove
            {
            }
        }

        public event jQueryUICancelableEventHandler<IGGridFilterDialogEvent> FilterDialogFiltering
        {
            [InlineCode("{this}.bind('iggridfilteringfilterdialogfiltering', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('iggridfilteringfilterdialogfiltering', {value})")]
            remove
            {
            }
        }

        public event jQueryUICancelableEventHandler<IGGridFilterDialogEvent> FilterDialogMoving
        {
            [InlineCode("{this}.bind('iggridfilteringfilterdialogmoving', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('iggridfilteringfilterdialogmoving', {value})")]
            remove
            {
            }
        }

        public event jQueryUIEventHandler<IGGridFilterDialogEvent> FilterDialogOpened
        {
            [InlineCode("{this}.bind('iggridfilteringfilterdialogopened', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('iggridfilteringfilterdialogopened', {value})")]
            remove
            {
            }
        }

        public event jQueryUICancelableEventHandler<IGGridFilterDialogEvent> FilterDialogOpening
        {
            [InlineCode("{this}.bind('iggridfilteringfilterdialogopened', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('iggridfilteringfilterdialogopened', {value})")]
            remove
            {
            }
        }
        #endregion Events
        #endregion igGridFiltering

        #region igGridSelection
        #region Methods
        [InlineCode("{this}.igGridSelection('activeCell', {cell})")]
        public object ActiveCell(object cell)
        {
            return null;
        }

        [InlineCode("{this}.igGridSelection('activeRow', {row})")]
        public object ActiveRow(object row)
        {
            return null;
        }

        [InlineCode("{this}.igGridSelection('clearSelection')")]
        public void ClearSelection()
        {
        }

        [InlineCode("{this}.igGridSelection('clearSelectionAll', {internalObject}, {uiDirty})")]
        public void ClearSelectionAll(object internalObject, object uiDirty)
        {
        }

        [InlineCode("{this}.igGridSelection('clearSelectionAllChildren', {internalObject}, {uiDirty})")]
        public void ClearSelectionAllChildren(object internalObject, object uiDirty)
        {
        }

        [InlineCode("{this}.igGridSelection('deselectCell', {row}, {col})")]
        public void DeselectCell(int row, int col)
        {
        }

        [InlineCode("{this}.igGridSelection('deselectRow', {index})")]
        public void DeselectCell(int index)
        {
        }

        [InlineCode("{this}.igGridSelection('destroy')")]
        public void DestroySelection()
        {
        }

        [InlineCode("{this}.igGridSelection('selectCell', {rowIndex}, {colIndex})")]
        public void SelectCell(int rowIndex, int colIndex)
        {
        }

        [InlineCode("{this}.igGridSelection('selectedCell')")]
        public object SelectionSelectedCell()
        {
            return null;
        }

        [InlineCode("{this}.igGridSelection('selectedCells')")]
        public object[] SelectionSelectedCells()
        {
            return null;
        }

        [InlineCode("{this}.igGridSelection('selectedRow')")]
        public object SelectionSelectedRow()
        {
            return null;
        }

        [InlineCode("{this}.igGridSelection('selectedRows')")]
        public object[] SelectionSelectedRows()
        {
            return null;
        }

        [InlineCode("{this}.igGridSelection('selectRow', {index})")]
        public void SelectRow(int index)
        {

        }
        #endregion Methods

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
            #endregion Events
        #endregion igGridSelection

        #region igGridUpdating
        #region Methods

        [InlineCode("{this}.data('igGridUpdating')")]
        public IGGridUpdatingFeature Data()
        {
            return null;
        }


        [InlineCode("{this}.igGridUpdating('addRow', {values})")]
        public void AddRow(object values)
        {

        }

        [InlineCode("{this}.igGridUpdating('deleteRow', {rowId})")]
        public void DeleteRow(object rowId)
        {

        }

        [InlineCode("{this}.igGridUpdating('deleteRow', {rowId}, {tr})")]
        public void DeleteRow(object rowId, object tr)
        {

        }

        [InlineCode("{this}.igGridUpdating('destroy')")]
        public object DestroyIGGridUpdating()
        {
            return null;
        }

        [InlineCode("{this}.igGridUpdating('editorForCell', {td})")]
        public object EditorForCell(jQueryObject td)
        {
            return null;
        }

        [InlineCode("{this}.igGridUpdating('editorForCell', {td}, {add})")]
        public object EditorForCell(jQueryObject td, bool add)
        {
            return null;
        }

        [InlineCode("{this}.igGridUpdating('editorForKey', {key})")]
        public IGEditorObject EditorForKey(object key)
        {
            return null;
        }

        [InlineCode("{this}.igGridUpdating('option', 'enableDeleteRow', {yesno})")]
        public void EnableDeleteRow(bool yesno)
        {

        }

        [InlineCode("{this}.igGridUpdating('endEdit')")]
        public bool EndEdit()
        {
            return false;
        }

        [InlineCode("{this}.igGridUpdating('endEdit', {update})")]
        public bool EndEdit(bool update)
        {
            return false;
        }

        [InlineCode("{this}.igGridUpdating('endEdit', {update}, {e})")]
        public bool EndEdit(bool update, object e)
        {
            return false;
        }

        [InlineCode("{this}.igGridUpdating('findInvalid')")]
        public void FindInvalid()
        {

        }

        [InlineCode("{this}.igGridUpdating('isEditing')")]
        public bool IsEditing()
        {
            return false;
        }

        [InlineCode("{this}.igGridUpdating('setCellValue', {rowId}, {colKey}, {value})")]
        public void SetCellValue(object rowId, string colKey, object value)
        {

        }

        [InlineCode("{this}.igGridUpdating('setCellValue', {rowId}, {colKey}, {value}, {tr})")]
        public void SetCellValue(object rowId, string colKey, object value, object tr)
        {

        }

        [InlineCode("{this}.igGridUpdating('startAddRowEdit')")]
        public bool StartAddRowEdit()
        {
            return false;
        }

        [InlineCode("{this}.igGridUpdating('startAddRowEdit', {e})")]
        public bool StartAddRowEdit(object e)
        {
            return false;
        }

        [InlineCode("{this}.igGridUpdating('startEdit', {row}, {col})")]
        public bool StartEdit(int row, int col)
        {
            return false;
        }

        [InlineCode("{this}.igGridUpdating('startEdit', {row}, {col}, {e})")]
        public bool StartEdit(int row, int col, object e)
        {
            return false;
        }

        [InlineCode("{this}.igGridUpdating('updateRow', {rowId}, {values})")]
        public void UpdateRow(object rowId, object values)
        {

        }

        [InlineCode("{this}.igGridUpdating('updateRow', {rowId}, {values}, {tr})")]
        public void UpdateRow(object rowId, object values, object tr)
        {

        }
        #endregion Methods

        #region Events
        public event jQueryUICancelableEventHandler<IGGridUpdatingDataDirty> DataDirty
        {
            [InlineCode("{this}.bind('iggridupdatingdatadirty', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('iggridupdatingdatadirty', {value})")]
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

        public event jQueryUIEventHandler<IGGridUpdatingEditRowEnded> EditRowEnded
        {
            [InlineCode("{this}.bind('iggridupdatingeditrowended', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('iggridupdatingeditrowended', {value})")]
            remove
            {
            }
        }

        public event jQueryUICancelableEventHandler<IGGridUpdatingEditRowEnding> EditRowEnding
        {
            [InlineCode("{this}.bind('iggridupdatingeditrowending', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('iggridupdatingeditrowending', {value})")]
            remove
            {
            }
        }

        public event jQueryUIEventHandler<IGGridUpdatingEditRowStart> EditRowStarted
        {
            [InlineCode("{this}.bind('iggridupdatingeditrowstarted', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('iggridupdatingeditrowstarted', {value})")]
            remove
            {
            }
        }

        public event jQueryUICancelableEventHandler<IGGridUpdatingEditRowStart> EditRowStarting
        {
            [InlineCode("{this}.bind('iggridupdatingeditrowstarting', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('iggridupdatingeditrowstarting', {value})")]
            remove
            {
            }
        }

        public event jQueryUIEventHandler<IGGridUpdatingGeneratePrimaryKeyValue> GeneratePrimaryKeyValue
        {
            [InlineCode("{this}.bind('iggridupdatinggenerateprimarykeyvalue', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('iggridupdatinggenerateprimarykeyvalue', {value})")]
            remove
            {
            }
        }

        public event jQueryUIEventHandler<IGGridUpdatingRowAdd> RowAdded
        {
            [InlineCode("{this}.bind('iggridupdatingrowadded', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('iggridupdatingrowadded', {value})")]
            remove
            {
            }
        }

        public event jQueryUICancelableEventHandler<IGGridUpdatingRowAdd> RowAdding
        {
            [InlineCode("{this}.bind('iggridupdatingrowadding', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('iggridupdatingrowadding', {value})")]
            remove
            {
            }
        }

        public event jQueryUIEventHandler<IGGridUpdatingRowDelete> RowDeleted
        {
            [InlineCode("{this}.bind('iggridupdatingrowdeleted', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('iggridupdatingrowdeleted', {value})")]
            remove
            {
            }
        }

        public event jQueryUICancelableEventHandler<IGGridUpdatingRowDelete> RowDeleting
        {
            [InlineCode("{this}.bind('iggridupdatingrowdeleting', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('iggridupdatingrowdeleting', {value})")]
            remove
            {
            }
        }
        #endregion Events
        #endregion igGridUpdating

        #region igGridHiding

        #region Methods
        [InlineCode("{this}.igGridUpdating('hideColumn', {colIndex})")]
        public void HideColumn(int colIndex)
        {

        }

        [InlineCode("{this}.igGridUpdating('hideColumn', {colKey})")]
        public void HideColumn(string colKey)
        {

        }

        [InlineCode("{this}.igGridUpdating('hideColumnChooser')")]
        public void HideColumnChooser()
        {

        }

        [InlineCode("{this}.igGridUpdating('removeColumnChooserResetButton')")]
        public void RemoveColumnChooserResetButton()
        {

        }

        [InlineCode("{this}.igGridUpdating('showColumn', {colIndex})")]
        public void ShowColumn(int colIndex)
        {

        }

        [InlineCode("{this}.igGridUpdating('showColumn', {colKey})")]
        public void ShowColumn(string colKey)
        {

        }

        [InlineCode("{this}.igGridUpdating('showColumnChooser')")]
        public void ShowColumnChooser()
        {

        }

        #endregion


        #endregion
    }
}
