﻿/*
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
    public class IGEditorObject : jQueryObject
    {
        public Element Element;
        #region Methods
        [InlineCode("{this}.igEditor('addListItem', {item})")]
        public object AddListItem(object item)
        {
            return null;
        }

        [InlineCode("{this}.igEditor('addListItem', {item}, {index})")]
        public object AddListItem(object item, int index)
        {
            return null;
        }
        
        [InlineCode("{this}.igEditor('addListItems', {item})")]
        public object AddListItems(object item)
        {
            return null;
        }

        [InlineCode("{this}.igEditor('addListItems', {item}, {index})")]
        public object AddListItems(object item, int index)
        {
            return null;
        }
        
        [InlineCode("{this}.igEditor('clearListItems')")]
        public object ClearListItems()
        {
            return null;
        }
        
        [InlineCode("{this}.igEditor('destroy')")]
        public object Destroy()
        {
            return null;
        }
        
        [InlineCode("{this}.igEditor('dropDownElement')")]
        public object DropDownElement()
        {
            return null;
        }
        
        [InlineCode("{this}.igEditor('dropDownVisible')")]
        public bool DropDownVisible()
        {
            return false;
        }

        [InlineCode("{this}.igEditor('dropDownVisible', {showHide})")]
        public object DropDownVisible(bool showHide)
        {
            return null;
        }
        
        [InlineCode("{this}.igEditor('field')")]
        public jQueryObject Field()
        {
            return null;
        }
        
        [InlineCode("{this}.igEditor('findListItemIndex', {text})")]
        public int FindListItemIndex(string text)
        {
            return 0;
        }
        
        [InlineCode("{this}.igEditor('findListItemIndex', {text}, {paramOne})")]
        public int FindListItemIndex(string text, bool paramOne)
        {
            return 0;
        }
        
        [InlineCode("{this}.igEditor('findListItemIndex', {text}, {paramOne}, {paramTwo})")]
        public int FindListItemIndex(string text, bool paramOne, bool paramTwo)
        {
            return 0;
        }
        
        [InlineCode("{this}.igEditor('findListItemIndex', {text}, {paramOne}, {paramTwo}, {paramThree})")]
        public int FindListItemIndex(string text, bool paramOne, bool paramTwo, bool paramThree)
        {
            return 0;
        }
        
        [InlineCode("{this}.igEditor('getRegionalOption', {name})")]
        public string GetRegionalOption(string name)
        {
            return null;
        }
        
        [InlineCode("{this}.igEditor('getSelectedListItem')")]
        public TypeOption<string, int, DateTime, object> GetSelectedListItem()
        {
            return null;
        }
        
        [InlineCode("{this}.igEditor('getSelectedText')")]
        public string GetSelectedText()
        {
            return null;
        }
        
        [InlineCode("{this}.igEditor('getSelection')")]
        public int GetSelection()
        {
            return 0;
        }

        [InlineCode("{this}.igEditor('getSelection', {start})")]
        public int GetSelection(bool start)
        {
            return 0;
        }
        
        [InlineCode("{this}.igEditor('getValueByMode', {mode})")]
        public TypeOption<string, int, DateTime, object> GetValueByMode(string mode)
        {
            return null;
        }

        [InlineCode("{this}.igEditor('getValueByMode', {mode}, {v})")]
        public TypeOption<string, int, DateTime, object> GetValueByMode(string mode, object v)
        {
            return null;
        }

        [InlineCode("{this}.igEditor('getValueByMode', {mode}, {v}, getVal)")]
        public TypeOption<string, int, DateTime, object> GetValueByMode(string mode, object v, object getVal)
        {
            return null;
        }
        
        [InlineCode("{this}.igEditor('hasFocus')")]
        public bool HasFocus()
        {
            return false;
        }
        
        [InlineCode("{this}.igEditor('hasInvalidMessage')")]
        public bool HasInvalidMessage()
        {
            return false;
        }
        
        [InlineCode("{this}.igEditor('hide')")]
        public new object Hide()
        {
            return null;
        }
        
        [InlineCode("{this}.igEditor('isValid')")]
        public bool IsValid()
        {
            return false;
        }
        
        [InlineCode("{this}.igEditor('mainElement')")]
        public jQueryObject MainElement()
        {
            return null;
        }
        
        [InlineCode("{this}.igEditor('paste', {txt})")]
        public object Paste(string txt)
        {
            return null;
        }

        [InlineCode("{this}.igEditor('paste', {txt}, {flag})")]
        public object Paste(string txt, bool flag)
        {
            return null;
        }
        
        [InlineCode("{this}.igEditor('remove')")]
        public new object Remove()
        {
            return null;
        }
        
        [InlineCode("{this}.igEditor('removeListItem', {item})")]
        public object RemoveListItem(object item)
        {
            return null;
        }
        
        [InlineCode("{this}.igEditor('removeListItemAt', {index})")]
        public object RemoveListItemAt(int index)
        {
            return null;
        }
        
        [InlineCode("{this}.igEditor('select')")]
        public new object Select()
        {
            return null;
        }
        
        [InlineCode("{this}.igEditor('select', {sel0})")]
        public object Select(int sel0)
        {
            return null;
        }
        
        [InlineCode("{this}.igEditor('select', {sel0}, {val})")]
        public object Select(int sel0, string val)
        {
            return null;
        }
        
        [InlineCode("{this}.igEditor('select', {sel0}, {sel1})")]
        public object Select(int sel0, int sel1)
        {
            return null;
        }
        
        [InlineCode("{this}.igEditor('select', {sel0}, {sel1}, {val})")]
        public object Select(int sel0, int sel1, string val)
        {
            return null;
        }
        
        [InlineCode("{this}.igEditor('selectedListIndex')")]
        public int SelectedListIndex()
        {
            return 0;
        }

        [InlineCode("{this}.igEditor('selectedListIndex', {index})")]
        public int SelectedListIndex(int index)
        {
            return 0;
        }
        
        [InlineCode("{this}.igEditor('setFocus')")]
        public object SetFocus()
        {
            return null;
        }

        [InlineCode("{this}.igEditor('setFocus', {delay})")]
        public object SetFocus(int delay)
        {
            return null;
        }
        
        [InlineCode("{this}.igEditor('show')")]
        public new object Show()
        {
            return null;
        }
        
        [InlineCode("{this}.igEditor('spin', {delta})")]
        public object Spin(int delta)
        {
            return null;
        }
        
        [InlineCode("{this}.igEditor('text')")]
        public string Text()
        {
            return null;
        }

        [InlineCode("{this}.igEditor('text', {val})")]
        public new object Text(string val)
        {
            return null;
        }

        [InlineCode("{this}.igEditor('text', {flag})")]
        public object Text(int flag)
        {
            return null;
        }

        [InlineCode("{this}.igEditor('text', {val}, {flag})")]
        public object Text(string val, int flag)
        {
            return null;
        }
        
        [InlineCode("{this}.igEditor('validate')")]
        public bool Validate()
        {
            return false;
        }
        
        [InlineCode("{this}.igEditor('validate', {noLabel})")]
        public bool Validate(bool noLabel)
        {
            return false;
        }
        
        [InlineCode("{this}.igEditor('validator')")]
        public bool Validator()
        {
            return false;
        }

        [InlineCode("{this}.igEditor('value')")]
        public TypeOption<string, int, DateTime, object> Value()
        {
            return null;
        }

        [InlineCode("{this}.igEditor('value', {val})")]
        public TypeOption<string, int, DateTime, object> Value(object val)
        {
            return null;
        }
        #endregion Methods

        #region Events
        public new event jQueryUIEventHandler<IGEditorEvent> Blur
        {
            [InlineCode("{this}.bind('igeditorblur', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igeditorblur', {value})")]
            remove
            {
            }
        }
        
        public event jQueryUIEventHandler<IGEditorEvent> ButtonClick
        {
            [InlineCode("{this}.bind('igeditorbuttonclick', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igeditorbuttonclick', {value})")]
            remove
            {
            }
        }
        
        public new event jQueryUIEventHandler<IGEditorEvent> Focus
        {
            [InlineCode("{this}.bind('igeditorfocus', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igeditorfocus', {value})")]
            remove
            {
            }
        }
        
        public event jQueryUICancelableEventHandler<IGEditorHideDropDownEvent> HideDropDown
        {
            [InlineCode("{this}.bind('igeditorhidedropdown', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igeditorhidedropdown', {value})")]
            remove
            {
            }
        }
        
        public event jQueryUIEventHandler<IGEditorInvalidValueEvent> InvalidValue
        {
            [InlineCode("{this}.bind('igeditorinvalidvalue', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igeditorinvalidvalue', {value})")]
            remove
            {
            }
        }
        
        public new event jQueryUICancelableEventHandler<IGEditorKeyEvent> Keydown
        {
            [InlineCode("{this}.bind('igeditorkeydown', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igeditorkeydown', {value})")]
            remove
            {
            }
        }
        
        public new event jQueryUICancelableEventHandler<IGEditorKeyEvent> Keypress
        {
            [InlineCode("{this}.bind('igeditorkeypress', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igeditorkeypress', {value})")]
            remove
            {
            }
        }
        
        public new event jQueryUIEventHandler<IGEditorEvent> Keyup
        {
            [InlineCode("{this}.bind('igeditorkeyup', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igeditorkeyup', {value})")]
            remove
            {
            }
        }
        
        public event jQueryUIEventHandler<IGEditorListEvent> ListSelected
        {
            [InlineCode("{this}.bind('igeditorlistselected', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igeditorlistselected', {value})")]
            remove
            {
            }
        }
        
        public event jQueryUICancelableEventHandler<IGEditorListEvent> ListSelecting
        {
            [InlineCode("{this}.bind('igeditorlistselecting', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igeditorlistselecting', {value})")]
            remove
            {
            }
        }
        
        public event jQueryUIEventHandler<IGEditorMouseEvent> Mousedown
        {
            [InlineCode("{this}.bind('igeditormousedown', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igeditormousedown', {value})")]
            remove
            {
            }
        }
        
        public event jQueryUIEventHandler<IGEditorMouseEvent> Mouseleave
        {
            [InlineCode("{this}.bind('igeditormouseleave', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igeditormouseleave', {value})")]
            remove
            {
            }
        }
        
        public event jQueryUIEventHandler<IGEditorMouseEvent> Mousemove
        {
            [InlineCode("{this}.bind('igeditormousemove', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igeditormousemove', {value})")]
            remove
            {
            }
        }
        
        public event jQueryUIEventHandler<IGEditorMouseEvent> Mouseover
        {
            [InlineCode("{this}.bind('igeditormouseover', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igeditormouseover', {value})")]
            remove
            {
            }
        }
        
        public event jQueryUIEventHandler<IGEditorMouseEvent> Mouseup
        {
            [InlineCode("{this}.bind('igeditormouseup', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igeditormouseup', {value})")]
            remove
            {
            }
        }
        
        public event jQueryUICancelableEventHandler<IGEditorEvent> ShowDropDown
        {
            [InlineCode("{this}.bind('igeditorshowdropdown', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igeditorshowdropdown', {value})")]
            remove
            {
            }
        }
        
        public event jQueryUICancelableEventHandler<IGEditorSpinEvent> SpinEvent
        {
            [InlineCode("{this}.bind('igeditorspin', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igeditorspin', {value})")]
            remove
            {
            }
        }
        
        public event jQueryUIEventHandler<IGEditorChangeEvent> TextChanged
        {
            [InlineCode("{this}.bind('igeditortextchanged', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igeditortextchanged', {value})")]
            remove
            {
            }
        }
        
        public event jQueryUIEventHandler<IGEditorChangeEvent> ValueChanged
        {
            [InlineCode("{this}.bind('igeditorvaluechanged', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igeditorvaluechanged', {value})")]
            remove
            {
            }
        }
        
        public event jQueryUICancelableEventHandler<IGEditorChangeEvent> ValueChanging
        {
            [InlineCode("{this}.bind('igeditorvaluechanging', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igeditorvaluechanging', {value})")]
            remove
            {
            }
        }
        #endregion
    }
}
