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
using System.Html;
using System.Runtime.CompilerServices;

namespace Ignite.UI.Widgets
{
    [IgnoreNamespace, Imported]
    public class IGTreeObject : jQueryObject
    {
        #region Methods
        [InlineCode("{this}.igTree('checkedNodes')")]
        public object[] CheckedNodes()
        {
            return null;
        }

        [InlineCode("{this}.igTree('checkState', {node})")]
        public string CheckState(object node)
        {
            return null;
        }

        [InlineCode("{this}.igTree('children', {parent})")]
        public Element[] Children(Element parent)
        {
            return null;
        }

        [InlineCode("{this}.igTree('childrenByPath', {path})")]
        public object ChildrenByPath(string path)
        {
            return null;
        }

        [InlineCode("{this}.igTree('clearSelection')")]
        public void ClearSelection()
        {

        }

        [InlineCode("{this}.igTree('collapse', {node})")]
        public void Collapse(object node)
        {

        }

        [InlineCode("{this}.igTree('dataBind')")]
        public void DataBind()
        {

        }

        [InlineCode("{this}.igTree('deselect', {node})")]
        public void Deselect(object node)
        {

        }

        [InlineCode("{this}.igTree('destroy')")]
        public void Destroy()
        {

        }

        [InlineCode("{this}.igTree('expand', {node})")]
        public void Expand(object node)
        {

        }

        [InlineCode("{this}.igTree('expandToNode', {node})")]
        public void ExpandToNode(object node)
        {

        }

        [InlineCode("{this}.igTree('findImmediateNodesByText', {text}, {parent})")]
        public object FindImmediateNodesByText(string text, object parent)
        {
            return null;
        }

        [InlineCode("{this}.igTree('findImmediateNodesByText', {text})")]
        public object FindImmediateNodesByText(string text)
        {
            return null;
        }

        [InlineCode("{this}.igTree('findNodesByText', {text}, {parent})")]
        public object FindNodesByText(string text, object parent)
        {
            return null;
        }

        [InlineCode("{this}.igTree('findNodesByText', {text})")]
        public object FindNodesByText(string text)
        {
            return null;
        }

        [InlineCode("{this}.igTree('isChecked', {node})")]
        public bool IsChecked(object node)
        {
            return false;
        }

        [InlineCode("{this}.igTree('isExpanded', {node})")]
        public bool IsExpanded(object node)
        {
            return false;
        }

        [InlineCode("{this}.igTree('nodeByIndex', {index}, {parent})")]
        public object NodeByIndex(int index, object parent)
        {
            return null;
        }

        [InlineCode("{this}.igTree('nodeByIndex', {index})")]
        public object NodeByIndex(int index)
        {
            return null;
        }

        [InlineCode("{this}.igTree('nodeByPath', {nodePath})")]
        public object NodeByPath(string nodePath)
        {
            return null;
        }

        [InlineCode("{this}.igTree('nodeDataFor', {path})")]
        public object NodeDataFor(string path)
        {
            return null;
        }

        [InlineCode("{this}.igTree('nodeFromElement', {element})")]
        public object NodeFromElement(object element)
        {
            return null;
        }

        [InlineCode("{this}.igTree('nodesByValue', {value})")]
        public object NodesByValue(string value)
        {
            return null;
        }

        [InlineCode("{this}.igTree('parentNode', {node})")]
        public object ParentNode(object node)
        {
            return null;
        }

        [InlineCode("{this}.igTree('partiallyCheckedNodes')")]
        public object[] PartiallyCheckedNodes()
        {
            return null;
        }

        [InlineCode("{this}.igTree('select', {node}, {evnt})")]
        public void Select(object node, object evnt)
        {
            
        }

        [InlineCode("{this}.igTree('select', {node})")]
        public void Select(object node)
        {

        }

        [InlineCode("{this}.igTree('selectedNode')")]
        public object SelectedNode()
        {
            return null;
        }

        [InlineCode("{this}.igTree('toggle', {node}, {evnt})")]
        public void Toggle(object node, object evnt)
        {

        }

        [InlineCode("{this}.igTree('toggle', {node})")]
        public void Toggle(object node)
        {

        }

        [InlineCode("{this}.igTree('toggleCheckstate', {node}, {evnt})")]
        public void ToggleCheckstate(object node, object evnt)
        {

        }

        [InlineCode("{this}.igTree('toggleCheckstate', {node})")]
        public void ToggleCheckstate(object node)
        {

        }

        [InlineCode("{this}.igTree('uncheckedNodes')")]
        public object[] UncheckedNodes()
        {
            return null;
        }

        [InlineCode("{this}.igTree('widget')")]
        public object Widget()
        {
            return null;
        }

        #endregion Methods

        #region Events
        public event jQueryUIEventHandler<object> DataBinding
        {
            [InlineCode("{this}.bind('igtreedatabinding', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igtreedatabinding', {value})")]
            remove
            {
            }
        }

        public event jQueryUIEventHandler<object> DataBound
        {
            [InlineCode("{this}.bind('igtreedatabound', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igtreedatabound', {value})")]
            remove
            {
            }
        }

        public event jQueryUIEventHandler<object> NodeCheckstateChanged
        {
            [InlineCode("{this}.bind('igtreenodecheckstatechanged', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igtreenodecheckstatechanged', {value})")]
            remove
            {
            }
        }

        public event jQueryUIEventHandler<object> NodeCheckstateChanging
        {
            [InlineCode("{this}.bind('igtreenodecheckstatechanging', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igtreenodecheckstatechanging', {value})")]
            remove
            {
            }
        }

        public event jQueryUIEventHandler<IGTreeNodeClick> NodeClick
        {
            [InlineCode("{this}.bind('igtreenodeclick', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igtreenodeclick', {value})")]
            remove
            {
            }
        }

        public event jQueryUIEventHandler<object> NodeCollapsed
        {
            [InlineCode("{this}.bind('igtreenodecollapsed', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igtreenodecollapsed', {value})")]
            remove
            {
            }
        }

        public event jQueryUIEventHandler<object> NodeCollapsing
        {
            [InlineCode("{this}.bind('igtreenodecollapsing', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igtreenodecollapsing', {value})")]
            remove
            {
            }
        }

        public event jQueryUIEventHandler<object> NodeDoubleClick
        {
            [InlineCode("{this}.bind('igtreenodedoubleclick', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igtreenodedoubleclick', {value})")]
            remove
            {
            }
        }

        public event jQueryUIEventHandler<object> NodeExpanded
        {
            [InlineCode("{this}.bind('igtreenodeexpanded', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igtreenodexpanded', {value})")]
            remove
            {
            }
        }

        public event jQueryUIEventHandler<object> NodeExpanding
        {
            [InlineCode("{this}.bind('igtreenodeexpanding', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igtreenodeexpanding', {value})")]
            remove
            {
            }
        }

        public event jQueryUIEventHandler<object> NodePopulated
        {
            [InlineCode("{this}.bind('igtreenodepopulated', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igtreenodepopulated', {value})")]
            remove
            {
            }
        }

        public event jQueryUIEventHandler<object> NodePopulating
        {
            [InlineCode("{this}.bind('igtreenodepopulating', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igtreenodepopulating', {value})")]
            remove
            {
            }
        }

        public event jQueryUIEventHandler<object> Rendered
        {
            [InlineCode("{this}.bind('igtreerendered', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igtreerendered', {value})")]
            remove
            {
            }
        }

        public event jQueryUIEventHandler<object> Rendering
        {
            [InlineCode("{this}.bind('igtreerendering', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igtreerendering', {value})")]
            remove
            {
            }
        }

        public event jQueryUIEventHandler<object> SelectionChanged
        {
            [InlineCode("{this}.bind('igtreeselectionchanged', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igtreeselectionchanged', {value})")]
            remove
            {
            }
        }

        public event jQueryUIEventHandler<object> SelectionChanging
        {
            [InlineCode("{this}.bind('igtreeselectionchanging', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('igtreeselectionchanging', {value})")]
            remove
            {
            }
        }
        #endregion Events
    }
}
