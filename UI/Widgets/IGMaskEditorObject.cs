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
    public class IGMaskEditorObject : IGEditorObject
    {
        #region Methods
        [InlineCode("{this}.igMaskEditor('addListItem', {item})")]
        new public object AddListItem(object item)
        {
            return null;
        }

        [InlineCode("{this}.igMaskEditor('addListItem', {item}, {index})")]
        new public object AddListItem(object item, int index)
        {
            return null;
        }

        [InlineCode("{this}.igMaskEditor('addListItems', {item})")]
        new public object AddListItems(object item)
        {
            return null;
        }

        [InlineCode("{this}.igMaskEditor('addListItems', {item}, {index})")]
        new public object AddListItems(object item, int index)
        {
            return null;
        }

        [InlineCode("{this}.igMaskEditor('clearListItems')")]
        new public object ClearListItems()
        {
            return null;
        }

        [InlineCode("{this}.igMaskEditor('destroy')")]
        new public object Destroy()
        {
            return null;
        }

        [InlineCode("{this}.igMaskEditor('dropDownElement')")]
        new public object DropDownElement()
        {
            return null;
        }

        [InlineCode("{this}.igMaskEditor('dropDownVisible')")]
        new public bool DropDownVisible()
        {
            return false;
        }

        [InlineCode("{this}.igMaskEditor('dropDownVisible', {showHide})")]
        new public object DropDownVisible(bool showHide)
        {
            return null;
        }

        [InlineCode("{this}.igMaskEditor('field')")]
        new public jQueryObject Field()
        {
            return null;
        }

        [InlineCode("{this}.igMaskEditor('findListItemIndex', {text})")]
        new public int FindListItemIndex(string text)
        {
            return 0;
        }

        [InlineCode("{this}.igMaskEditor('findListItemIndex', {text}, {paramOne})")]
        new public int FindListItemIndex(string text, bool paramOne)
        {
            return 0;
        }

        [InlineCode("{this}.igMaskEditor('findListItemIndex', {text}, {paramOne}, {paramTwo})")]
        new public int FindListItemIndex(string text, bool paramOne, bool paramTwo)
        {
            return 0;
        }

        [InlineCode("{this}.igMaskEditor('findListItemIndex', {text}, {paramOne}, {paramTwo}, {paramThree})")]
        new public int FindListItemIndex(string text, bool paramOne, bool paramTwo, bool paramThree)
        {
            return 0;
        }

        [InlineCode("{this}.igMaskEditor('getRegionalOption', {name})")]
        new public string GetRegionalOption(string name)
        {
            return null;
        }

        [InlineCode("{this}.igMaskEditor('getSelectedListItem')")]
        new public TypeOption<string, int, DateTime, object> GetSelectedListItem()
        {
            return null;
        }

        [InlineCode("{this}.igMaskEditor('getSelectedText')")]
        new public string GetSelectedText()
        {
            return null;
        }

        [InlineCode("{this}.igMaskEditor('getSelection')")]
        new public int GetSelection()
        {
            return 0;
        }

        [InlineCode("{this}.igMaskEditor('getSelection', {start})")]
        new public int GetSelection(bool start)
        {
            return 0;
        }

        [InlineCode("{this}.igMaskEditor('getValueByMode', {mode})")]
        new public TypeOption<string, int, DateTime, object> GetValueByMode(string mode)
        {
            return null;
        }

        [InlineCode("{this}.igMaskEditor('getValueByMode', {mode}, {v})")]
        new public TypeOption<string, int, DateTime, object> GetValueByMode(string mode, object v)
        {
            return null;
        }

        [InlineCode("{this}.igMaskEditor('getValueByMode', {mode}, {v}, getVal)")]
        new public TypeOption<string, int, DateTime, object> GetValueByMode(string mode, object v, object getVal)
        {
            return null;
        }

        [InlineCode("{this}.igMaskEditor('hasFocus')")]
        new public bool HasFocus()
        {
            return false;
        }

        [InlineCode("{this}.igMaskEditor('hasInvalidMessage')")]
        new public bool HasInvalidMessage()
        {
            return false;
        }

        [InlineCode("{this}.igMaskEditor('hide')")]
        new public object Hide()
        {
            return null;
        }

        [InlineCode("{this}.igMaskEditor('isValid')")]
        new public bool IsValid()
        {
            return false;
        }

        [InlineCode("{this}.igMaskEditor('mainElement')")]
        new public jQueryObject MainElement()
        {
            return null;
        }

        [InlineCode("{this}.igMaskEditor('paste', {txt})")]
        new public object Paste(string txt)
        {
            return null;
        }

        [InlineCode("{this}.igMaskEditor('paste', {txt}, {flag})")]
        new public object Paste(string txt, bool flag)
        {
            return null;
        }

        [InlineCode("{this}.igMaskEditor('remove')")]
        new public object Remove()
        {
            return null;
        }

        [InlineCode("{this}.igMaskEditor('removeListItem', {item})")]
        new public object RemoveListItem(object item)
        {
            return null;
        }

        [InlineCode("{this}.igMaskEditor('removeListItemAt', {index})")]
        new public object RemoveListItemAt(int index)
        {
            return null;
        }

        [InlineCode("{this}.igMaskEditor('select')")]
        new public object Select()
        {
            return null;
        }

        [InlineCode("{this}.igMaskEditor('select', {sel0})")]
        new public object Select(int sel0)
        {
            return null;
        }

        [InlineCode("{this}.igMaskEditor('select', {sel0}, {val})")]
        new public object Select(int sel0, string val)
        {
            return null;
        }

        [InlineCode("{this}.igMaskEditor('select', {sel0}, {sel1})")]
        new public object Select(int sel0, int sel1)
        {
            return null;
        }

        [InlineCode("{this}.igMaskEditor('select', {sel0}, {sel1}, {val})")]
        new public object Select(int sel0, int sel1, string val)
        {
            return null;
        }

        [InlineCode("{this}.igMaskEditor('selectedListIndex')")]
        new public int SelectedListIndex()
        {
            return 0;
        }

        [InlineCode("{this}.igMaskEditor('selectedListIndex', {index})")]
        new public int SelectedListIndex(int index)
        {
            return 0;
        }

        [InlineCode("{this}.igMaskEditor('setFocus')")]
        new public object SetFocus()
        {
            return null;
        }

        [InlineCode("{this}.igMaskEditor('setFocus', {delay})")]
        new public object SetFocus(int delay)
        {
            return null;
        }

        [InlineCode("{this}.igMaskEditor('show')")]
        new public object Show()
        {
            return null;
        }

        [InlineCode("{this}.igMaskEditor('spin', {delta})")]
        new public object Spin(int delta)
        {
            return null;
        }

        [InlineCode("{this}.igMaskEditor('text')")]
        new public string Text()
        {
            return null;
        }

        [InlineCode("{this}.igMaskEditor('text', {val})")]
        new public object Text(string val)
        {
            return null;
        }

        [InlineCode("{this}.igMaskEditor('text', {flag})")]
        new public object Text(int flag)
        {
            return null;
        }

        [InlineCode("{this}.igMaskEditor('text', {val}, {flag})")]
        new public object Text(string val, int flag)
        {
            return null;
        }

        [InlineCode("{this}.igMaskEditor('validate')")]
        new public bool Validate()
        {
            return false;
        }

        [InlineCode("{this}.igMaskEditor('validate', {noLabel})")]
        new public bool Validate(bool noLabel)
        {
            return false;
        }

        [InlineCode("{this}.igMaskEditor('validator')")]
        new public bool Validator()
        {
            return false;
        }

        [InlineCode("{this}.igMaskEditor('value')")]
        new public TypeOption<string, int, DateTime, object> Value()
        {
            return null;
        }

        [InlineCode("{this}.igMaskEditor('value', {val})")]
        new public TypeOption<string, int, DateTime, object> Value(object val)
        {
            return null;
        }
        #endregion Methods

        #region Events
        new public event jQueryUIEventHandler<IGEditorEvent> Blur
        {
            [InlineCode("{this}.bind('igmaskeditorblur', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igmaskeditorblur', {value})")]
            remove
            {
            }
        }

        new public event jQueryUIEventHandler<IGEditorEvent> ButtonClick
        {
            [InlineCode("{this}.bind('igmaskeditorbuttonclick', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igmaskeditorbuttonclick', {value})")]
            remove
            {
            }
        }

        new public event jQueryUIEventHandler<IGEditorEvent> Focus
        {
            [InlineCode("{this}.bind('igmaskeditorfocus', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igmaskeditorfocus', {value})")]
            remove
            {
            }
        }

        new public event jQueryUICancelableEventHandler<IGEditorHideDropDownEvent> HideDropDown
        {
            [InlineCode("{this}.bind('igmaskeditorhidedropdown', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igmaskeditorhidedropdown', {value})")]
            remove
            {
            }
        }

        new public event jQueryUIEventHandler<IGEditorInvalidValueEvent> InvalidValue
        {
            [InlineCode("{this}.bind('igmaskeditorinvalidvalue', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igmaskeditorinvalidvalue', {value})")]
            remove
            {
            }
        }

        new public event jQueryUICancelableEventHandler<IGEditorKeyEvent> Keydown
        {
            [InlineCode("{this}.bind('igmaskeditorkeydown', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igmaskeditorkeydown', {value})")]
            remove
            {
            }
        }

        new public event jQueryUICancelableEventHandler<IGEditorKeyEvent> Keypress
        {
            [InlineCode("{this}.bind('igmaskeditorkeypress', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igmaskeditorkeypress', {value})")]
            remove
            {
            }
        }

        new public event jQueryUIEventHandler<IGEditorEvent> Keyup
        {
            [InlineCode("{this}.bind('igmaskeditorkeyup', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igmaskeditorkeyup', {value})")]
            remove
            {
            }
        }

        new public event jQueryUIEventHandler<IGEditorListEvent> ListSelected
        {
            [InlineCode("{this}.bind('igmaskeditorlistselected', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igmaskeditorlistselected', {value})")]
            remove
            {
            }
        }

        new public event jQueryUICancelableEventHandler<IGEditorListEvent> ListSelecting
        {
            [InlineCode("{this}.bind('igmaskeditorlistselecting', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igmaskeditorlistselecting', {value})")]
            remove
            {
            }
        }

        new public event jQueryUIEventHandler<IGEditorMouseEvent> Mousedown
        {
            [InlineCode("{this}.bind('igmaskeditormousedown', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igmaskeditormousedown', {value})")]
            remove
            {
            }
        }

        new public event jQueryUIEventHandler<IGEditorMouseEvent> Mouseleave
        {
            [InlineCode("{this}.bind('igmaskeditormouseleave', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igmaskeditormouseleave', {value})")]
            remove
            {
            }
        }

        new public event jQueryUIEventHandler<IGEditorMouseEvent> Mousemove
        {
            [InlineCode("{this}.bind('igmaskeditormousemove', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igmaskeditormousemove', {value})")]
            remove
            {
            }
        }

        new public event jQueryUIEventHandler<IGEditorMouseEvent> Mouseover
        {
            [InlineCode("{this}.bind('igmaskeditormouseover', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igmaskeditormouseover', {value})")]
            remove
            {
            }
        }

        new public event jQueryUIEventHandler<IGEditorMouseEvent> Mouseup
        {
            [InlineCode("{this}.bind('igmaskeditormouseup', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igmaskeditormouseup', {value})")]
            remove
            {
            }
        }

        new public event jQueryUICancelableEventHandler<IGEditorEvent> ShowDropDown
        {
            [InlineCode("{this}.bind('igmaskeditorshowdropdown', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igmaskeditorshowdropdown', {value})")]
            remove
            {
            }
        }

        new public event jQueryUICancelableEventHandler<IGEditorSpinEvent> SpinEvent
        {
            [InlineCode("{this}.bind('igmaskeditorspin', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igmaskeditorspin', {value})")]
            remove
            {
            }
        }

        new public event jQueryUIEventHandler<IGEditorChangeEvent> TextChanged
        {
            [InlineCode("{this}.bind('igmaskeditortextchanged', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igmaskeditortextchanged', {value})")]
            remove
            {
            }
        }

        new public event jQueryUIEventHandler<IGEditorChangeEvent> ValueChanged
        {
            [InlineCode("{this}.bind('igmaskeditorvaluechanged', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igmaskeditorvaluechanged', {value})")]
            remove
            {
            }
        }

        new public event jQueryUICancelableEventHandler<IGEditorChangeEvent> ValueChanging
        {
            [InlineCode("{this}.bind('igmaskeditorvaluechanging', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igmaskeditorvaluechanging', {value})")]
            remove
            {
            }
        }
        #endregion
    }
}
