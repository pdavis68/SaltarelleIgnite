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

using System.Html;
using System.Runtime.CompilerServices;

using jQueryApi;
using jQueryApi.UI;

namespace Ignite.UI.Widgets
{
    [IgnoreNamespace, Imported]
    public class IGComboObject : jQueryObject
    {

        #region Methods
        public int ActiveIndex
        {
            [InlineCode("{this}.igCombo('activeIndex')")]
            get;
            [InlineCode("{this}.igCombo('activeIndex', {value})")]
            set;
        }

        public bool DropDownVisible
        {
            [InlineCode("{this}.igCombo('dropDownVisible')")]
            get;
            [InlineCode("{this}.igCombo('dropDownVisible', {value})")]
            set;
        }

        public new string Text
        {
            [InlineCode("{this}.igCombo('text')")]
            get;
            [InlineCode("{this}.igCombo('text', {value})")]
            set;
        }

        public new object Value
        {
            [InlineCode("{this}.igCombo('value')")]
            get;
            [InlineCode("{this}.igCombo('value', {value})")]
            set;
        }

        public object SelectedIndex
        {
            [InlineCode("{this}.igCombo('selectedIndex')")]
            get;
            [InlineCode("{this}.igCombo('selectedIndex', {value})")]
            set;
        }

        [InlineCode("{this}.igCombo('activeIndex', {index}, {fire})")]
        public void SetActiveIndex(int index, bool fire)
        {

        }

        [InlineCode("{this}.igCombo('activeIndex', {fire})")]
        public void SetActiveIndex(bool fire)
        {

        }

        [InlineCode("{this}.igCombo('dataBind')")]
        public void DataBind()
        {

        }

        [InlineCode("{this}.igCombo('destroy')")]
        public void Destroy()
        {

        }

        [InlineCode("{this}.igCombo('dropDownVisible', {showHide}, {fire})")]
        public void SetDropDownVisible(bool showHide, bool fire)
        {

        }

        [InlineCode("{this}.igCombo('filter')")]
        public void Filter()
        {

        }

        [InlineCode("{this}.igCombo('getFooter')")]
        public Element GetFooter()
        {
            return null;
        }

        [InlineCode("{this}.igCombo('getRecordsCount')")]
        public int GetRecordsCount()
        {
            return 0;
        }

        [InlineCode("{this}.igCombo('getRecordsCount', {flag})")]
        public int GetRecordsCount(string flag)
        {
            return 0;
        }

        [InlineCode("{this}.igCombo('hasFocus')")]
        public int HasFocus()
        {
            return 0;
        }

        [InlineCode("{this}.igCombo('isSelected', {index} )")]
        public int IsSelected(int index)
        {
            return 0;
        }

        [InlineCode("{this}.igCombo('itemByIndex', {id})")]
        public object ItemByIndex(int id)
        {
            return null;
        }

        [InlineCode("{this}.igCombo('itemByValue', {value})")]
        public object ItemByValue(object value)
        {
            return null;
        }

        [InlineCode("{this}.igCombo('remove')")]
        public new void Remove()
        {
        }

        [InlineCode("{this}.igCombo('selectedIndex', {index}, {fire})")]
        public object SetSelectedIndex(int index, bool fire)
        {
            return null;
        }

        [InlineCode("{this}.igCombo('setFocus')")]
        public void SetFocus()
        {
        }
        [InlineCode("{this}.igCombo('setFocus', {delay})")]
        public void SetFocus(int delay)
        {
        }

        [InlineCode("{this}.igCombo('text', {text}, {fire})")]
        public void SetText(string text, bool fire)
        {
        }

        [InlineCode("{this}.igCombo('validate')")]
        public int Validate()
        {
            return 0;
        }

        [InlineCode("{this}.igcombo('validator')")]
        public object Validator()
        {
            return null;
        }

        [InlineCode("{this}.igcombo('validator', {destroy})")]
        public object Validator(bool destroy)
        {
            return null;
        }

        [InlineCode("{this}.igcombo('value', {value}, {fire})")]
        public void SetValue(object value, bool fire)
        {
        }
        #endregion Methods

        #region Events

        public event jQueryUIEventHandler<IGComboActiveItemEvent> ActiveItemChanged
        {
            [InlineCode("{this}.bind('activeItemChanged', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('activeItemChanged', {value})")]
            remove
            {
            }
        }

        public event jQueryUIEventHandler<IGComboActiveItemEvent> ActiveItemChanging
        {
            [InlineCode("{this}.bind('activeItemChanging', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('activeItemChanging', {value})")]
            remove
            {
            }
        }

        public event jQueryUIEventHandler<IGComboDataEvent> DataBinding
        {
            [InlineCode("{this}.bind('dataBinding', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('dataBinding', {value})")]
            remove
            {
            }
        }

        public event jQueryUIEventHandler<IGComboDataEvent> DataBound
        {
            [InlineCode("{this}.bind('dataBound', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('dataBound', {value})")]
            remove
            {
            }
        }

        public event jQueryUIEventHandler<IGComboDropDownEvent> DropDownClosed
        {
            [InlineCode("{this}.bind('dropDownClosed', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('dropDownClosed', {value})")]
            remove
            {
            }
        }

        public event jQueryUIEventHandler<IGComboDropDownEvent> DropDownClosing
        {
            [InlineCode("{this}.bind('dropDownClosing', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('dropDownClosing', {value})")]
            remove
            {
            }
        }

        public event jQueryUIEventHandler<IGComboDropDownEvent> DropDownOpened
        {
            [InlineCode("{this}.bind('dropDownOpened', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('dropDownOpened', {value})")]
            remove
            {
            }
        }

        public event jQueryUIEventHandler<IGComboDropDownEvent> DropDownOpening
        {
            [InlineCode("{this}.bind('dropDownOpening', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('dropDownOpening', {value})")]
            remove
            {
            }
        }

        public event jQueryUIEventHandler<IGComboFilterEvent> Filtered
        {
            [InlineCode("{this}.bind('filtered', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('filtered', {value})")]
            remove
            {
            }
        }

        public event jQueryUIEventHandler<IGComboFilterEvent> Filtering
        {
            [InlineCode("{this}.bind('filtering', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('filtering', {value})")]
            remove
            {
            }
        }

        public event jQueryUIEventHandler<IGComboMatchEvent> NoMatchFound
        {
            [InlineCode("{this}.bind('noMatchFound', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('noMatchFound', {value})")]
            remove
            {
            }
        }

        public event jQueryUIEventHandler<IGComboSelectionEvent> SelectionChanged
        {
            [InlineCode("{this}.bind('selectionChanged', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('selectionChanged', {value})")]
            remove
            {
            }
        }

        public event jQueryUIEventHandler<IGComboSelectionEvent> SelectionChanging
        {
            [InlineCode("{this}.bind('selectionChanging', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('selectionChanging', {value})")]
            remove
            {
            }
        }

        public event jQueryUIEventHandler<IGComboTextChangedEvent> TextChanged
        {
            [InlineCode("{this}.bind('textChanged', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('textChanged', {value})")]
            remove
            {
            }
        }

        #endregion
    }
}
