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
    public class IGNumericEditorObject : IGEditorObject
    {
        #region Methods
        [InlineCode("{this}.igNumericEditor('addListItem', {item})")]
        new public object AddListItem(object item)
        {
            return null;
        }

        [InlineCode("{this}.igNumericEditor('addListItem', {item}, {index})")]
        new public object AddListItem(object item, int index)
        {
            return null;
        }

        [InlineCode("{this}.igNumericEditor('addListItems', {item})")]
        new public object AddListItems(object item)
        {
            return null;
        }

        [InlineCode("{this}.igNumericEditor('addListItems', {item}, {index})")]
        new public object AddListItems(object item, int index)
        {
            return null;
        }

        [InlineCode("{this}.igNumericEditor('clearListItems')")]
        new public object ClearListItems()
        {
            return null;
        }

        [InlineCode("{this}.igNumericEditor('destroy')")]
        new public object Destroy()
        {
            return null;
        }

        [InlineCode("{this}.igNumericEditor('dropDownElement')")]
        new public object DropDownElement()
        {
            return null;
        }

        [InlineCode("{this}.igNumericEditor('dropDownVisible')")]
        new public bool DropDownVisible()
        {
            return false;
        }

        [InlineCode("{this}.igNumericEditor('dropDownVisible', {showHide})")]
        new public object DropDownVisible(bool showHide)
        {
            return null;
        }

        [InlineCode("{this}.igNumericEditor('field')")]
        new public jQueryObject Field()
        {
            return null;
        }

        [InlineCode("{this}.igNumericEditor('findListItemIndex', {text})")]
        new public int FindListItemIndex(string text)
        {
            return 0;
        }

        [InlineCode("{this}.igNumericEditor('findListItemIndex', {text}, {paramOne})")]
        new public int FindListItemIndex(string text, bool paramOne)
        {
            return 0;
        }

        [InlineCode("{this}.igNumericEditor('findListItemIndex', {text}, {paramOne}, {paramTwo})")]
        new public int FindListItemIndex(string text, bool paramOne, bool paramTwo)
        {
            return 0;
        }

        [InlineCode("{this}.igNumericEditor('findListItemIndex', {text}, {paramOne}, {paramTwo}, {paramThree})")]
        new public int FindListItemIndex(string text, bool paramOne, bool paramTwo, bool paramThree)
        {
            return 0;
        }

        [InlineCode("{this}.igNumericEditor('getRegionalOption', {name})")]
        new public string GetRegionalOption(string name)
        {
            return null;
        }

        [InlineCode("{this}.igNumericEditor('getSelectedListItem')")]
        new public TypeOption<string, int, DateTime, object> GetSelectedListItem()
        {
            return null;
        }

        [InlineCode("{this}.igNumericEditor('getSelectedText')")]
        new public string GetSelectedText()
        {
            return null;
        }

        [InlineCode("{this}.igNumericEditor('getSelection')")]
        new public int GetSelection()
        {
            return 0;
        }

        [InlineCode("{this}.igNumericEditor('getSelection', {start})")]
        new public int GetSelection(bool start)
        {
            return 0;
        }

        [InlineCode("{this}.igNumericEditor('getValueByMode', {mode})")]
        new public TypeOption<string, int, DateTime, object> GetValueByMode(string mode)
        {
            return null;
        }

        [InlineCode("{this}.igNumericEditor('getValueByMode', {mode}, {v})")]
        new public TypeOption<string, int, DateTime, object> GetValueByMode(string mode, object v)
        {
            return null;
        }

        [InlineCode("{this}.igNumericEditor('getValueByMode', {mode}, {v}, getVal)")]
        new public TypeOption<string, int, DateTime, object> GetValueByMode(string mode, object v, object getVal)
        {
            return null;
        }

        [InlineCode("{this}.igNumericEditor('hasFocus')")]
        new public bool HasFocus()
        {
            return false;
        }

        [InlineCode("{this}.igNumericEditor('hasInvalidMessage')")]
        new public bool HasInvalidMessage()
        {
            return false;
        }

        [InlineCode("{this}.igNumericEditor('hide')")]
        new public object Hide()
        {
            return null;
        }

        [InlineCode("{this}.igNumericEditor('isValid')")]
        new public bool IsValid()
        {
            return false;
        }

        [InlineCode("{this}.igNumericEditor('mainElement')")]
        new public jQueryObject MainElement()
        {
            return null;
        }

        [InlineCode("{this}.igNumericEditor('paste', {txt})")]
        new public object Paste(string txt)
        {
            return null;
        }

        [InlineCode("{this}.igNumericEditor('paste', {txt}, {flag})")]
        new public object Paste(string txt, bool flag)
        {
            return null;
        }

        [InlineCode("{this}.igNumericEditor('remove')")]
        new public object Remove()
        {
            return null;
        }

        [InlineCode("{this}.igNumericEditor('removeListItem', {item})")]
        new public object RemoveListItem(object item)
        {
            return null;
        }

        [InlineCode("{this}.igNumericEditor('removeListItemAt', {index})")]
        new public object RemoveListItemAt(int index)
        {
            return null;
        }

        [InlineCode("{this}.igNumericEditor('select')")]
        new public object Select()
        {
            return null;
        }

        [InlineCode("{this}.igNumericEditor('select', {sel0})")]
        new public object Select(int sel0)
        {
            return null;
        }

        [InlineCode("{this}.igNumericEditor('select', {sel0}, {val})")]
        new public object Select(int sel0, string val)
        {
            return null;
        }

        [InlineCode("{this}.igNumericEditor('select', {sel0}, {sel1})")]
        new public object Select(int sel0, int sel1)
        {
            return null;
        }

        [InlineCode("{this}.igNumericEditor('select', {sel0}, {sel1}, {val})")]
        new public object Select(int sel0, int sel1, string val)
        {
            return null;
        }

        [InlineCode("{this}.igNumericEditor('selectedListIndex')")]
        new public int SelectedListIndex()
        {
            return 0;
        }

        [InlineCode("{this}.igNumericEditor('selectedListIndex', {index})")]
        new public int SelectedListIndex(int index)
        {
            return 0;
        }

        [InlineCode("{this}.igNumericEditor('setFocus')")]
        new public object SetFocus()
        {
            return null;
        }

        [InlineCode("{this}.igNumericEditor('setFocus', {delay})")]
        new public object SetFocus(int delay)
        {
            return null;
        }

        [InlineCode("{this}.igNumericEditor('show')")]
        new public object Show()
        {
            return null;
        }

        [InlineCode("{this}.igNumericEditor('spin', {delta})")]
        new public object Spin(int delta)
        {
            return null;
        }

        [InlineCode("{this}.igNumericEditor('text')")]
        new public string Text()
        {
            return null;
        }

        [InlineCode("{this}.igNumericEditor('text', {val})")]
        new public object Text(string val)
        {
            return null;
        }

        [InlineCode("{this}.igNumericEditor('text', {flag})")]
        new public object Text(int flag)
        {
            return null;
        }

        [InlineCode("{this}.igNumericEditor('text', {val}, {flag})")]
        new public object Text(string val, int flag)
        {
            return null;
        }

        [InlineCode("{this}.igNumericEditor('validate')")]
        new public bool Validate()
        {
            return false;
        }

        [InlineCode("{this}.igNumericEditor('validate', {noLabel})")]
        new public bool Validate(bool noLabel)
        {
            return false;
        }

        [InlineCode("{this}.igNumericEditor('validator')")]
        new public bool Validator()
        {
            return false;
        }

        [InlineCode("{this}.igNumericEditor('value')")]
        new public TypeOption<string, int, DateTime, object> Value()
        {
            return null;
        }

        [InlineCode("{this}.igNumericEditor('value', {val})")]
        new public TypeOption<string, int, DateTime, object> Value(object val)
        {
            return null;
        }
        #endregion Methods

        #region Events
        new public event jQueryUIEventHandler<IGEditorEvent> Blur
        {
            [InlineCode("{this}.bind('ignumericeditorblur', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('ignumericeditorblur', {value})")]
            remove
            {
            }
        }

        new public event jQueryUIEventHandler<IGEditorEvent> ButtonClick
        {
            [InlineCode("{this}.bind('ignumericeditorbuttonclick', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('ignumericeditorbuttonclick', {value})")]
            remove
            {
            }
        }

        new public event jQueryUIEventHandler<IGEditorEvent> Focus
        {
            [InlineCode("{this}.bind('ignumericeditorfocus', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('ignumericeditorfocus', {value})")]
            remove
            {
            }
        }

        new public event jQueryUICancelableEventHandler<IGEditorHideDropDownEvent> HideDropDown
        {
            [InlineCode("{this}.bind('ignumericeditorhidedropdown', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('ignumericeditorhidedropdown', {value})")]
            remove
            {
            }
        }

        new public event jQueryUIEventHandler<IGEditorInvalidValueEvent> InvalidValue
        {
            [InlineCode("{this}.bind('ignumericeditorinvalidvalue', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('ignumericeditorinvalidvalue', {value})")]
            remove
            {
            }
        }

        new public event jQueryUICancelableEventHandler<IGEditorKeyEvent> Keydown
        {
            [InlineCode("{this}.bind('ignumericeditorkeydown', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('ignumericeditorkeydown', {value})")]
            remove
            {
            }
        }

        new public event jQueryUICancelableEventHandler<IGEditorKeyEvent> Keypress
        {
            [InlineCode("{this}.bind('ignumericeditorkeypress', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('ignumericeditorkeypress', {value})")]
            remove
            {
            }
        }

        new public event jQueryUIEventHandler<IGEditorEvent> Keyup
        {
            [InlineCode("{this}.bind('ignumericeditorkeyup', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('ignumericeditorkeyup', {value})")]
            remove
            {
            }
        }

        new public event jQueryUIEventHandler<IGEditorListEvent> ListSelected
        {
            [InlineCode("{this}.bind('ignumericeditorlistselected', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('ignumericeditorlistselected', {value})")]
            remove
            {
            }
        }

        new public event jQueryUICancelableEventHandler<IGEditorListEvent> ListSelecting
        {
            [InlineCode("{this}.bind('ignumericeditorlistselecting', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('ignumericeditorlistselecting', {value})")]
            remove
            {
            }
        }

        new public event jQueryUIEventHandler<IGEditorMouseEvent> Mousedown
        {
            [InlineCode("{this}.bind('ignumericeditormousedown', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('ignumericeditormousedown', {value})")]
            remove
            {
            }
        }

        new public event jQueryUIEventHandler<IGEditorMouseEvent> Mouseleave
        {
            [InlineCode("{this}.bind('ignumericeditormouseleave', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('ignumericeditormouseleave', {value})")]
            remove
            {
            }
        }

        new public event jQueryUIEventHandler<IGEditorMouseEvent> Mousemove
        {
            [InlineCode("{this}.bind('ignumericeditormousemove', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('ignumericeditormousemove', {value})")]
            remove
            {
            }
        }

        new public event jQueryUIEventHandler<IGEditorMouseEvent> Mouseover
        {
            [InlineCode("{this}.bind('ignumericeditormouseover', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('ignumericeditormouseover', {value})")]
            remove
            {
            }
        }

        new public event jQueryUIEventHandler<IGEditorMouseEvent> Mouseup
        {
            [InlineCode("{this}.bind('ignumericeditormouseup', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('ignumericeditormouseup', {value})")]
            remove
            {
            }
        }

        new public event jQueryUICancelableEventHandler<IGEditorEvent> ShowDropDown
        {
            [InlineCode("{this}.bind('ignumericeditorshowdropdown', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('ignumericeditorshowdropdown', {value})")]
            remove
            {
            }
        }

        new public event jQueryUICancelableEventHandler<IGEditorSpinEvent> SpinEvent
        {
            [InlineCode("{this}.bind('ignumericeditorspin', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('ignumericeditorspin', {value})")]
            remove
            {
            }
        }

        new public event jQueryUIEventHandler<IGEditorChangeEvent> TextChanged
        {
            [InlineCode("{this}.bind('ignumericeditortextchanged', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('ignumericeditortextchanged', {value})")]
            remove
            {
            }
        }

        new public event jQueryUIEventHandler<IGEditorChangeEvent> ValueChanged
        {
            [InlineCode("{this}.bind('ignumericeditorvaluechanged', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('ignumericeditorvaluechanged', {value})")]
            remove
            {
            }
        }

        new public event jQueryUICancelableEventHandler<IGEditorChangeEvent> ValueChanging
        {
            [InlineCode("{this}.bind('ignumericeditorvaluechanging', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('ignumericeditorvaluechanging', {value})")]
            remove
            {
            }
        }
        #endregion
    }
}
