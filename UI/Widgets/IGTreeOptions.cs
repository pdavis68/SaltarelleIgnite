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
using System.Html;
using System.Runtime.CompilerServices;

using jQueryApi;
using jQueryApi.UI;

namespace Ignite.UI.Widgets
{
    [IgnoreNamespace,Imported,Serializable]
    public class DataBase
    {
        
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGTreeOptions
    {
        #region Options
        public int AnimationDuration { get; set; }

        public IGTreeBindings Bindings { get; set; }

        public IGTreeCheckBoxMode CheckBoxMode { get; set; }

        public object DataSource { get; set; }

        public string DataSourceType { get; set; }

        public string DataSourceUrl { get; set; }

        public TypeOption<string, int> Height { get; set; }

        public bool HotTracking { get; set; }

        public int InitialExpandDepth { get; set; }

        public string LeafNodeImageClass { get; set; }

        public string LeafNodeImageTooltip { get; set; }

        public string LeafNodeImageUrl { get; set; }

        public bool LoadOnDemand { get; set; }

        public string ParentNodeImageClass { get; set; }

        public string ParentNodeImageTooltip { get; set; }

        public string ParentNodeImageUrl { get; set; }

        public string PathSeparator { get; set; }

        public string ResponseDataKey { get; set; }

        public string ResponseDataType { get; set; }

        public bool SingleBranchExpand { get; set; }

        public TypeOption<string, int> Width { get; set; }
        #endregion Options

        #region Events
        public jQueryUIEventHandler<IGTreeDataBinding> DataBinding;

        public jQueryUIEventHandler<IGTreeDataBound> DataBound;

        public jQueryUIEventHandler<IGTreeNodeCheckstateChanged> NodeCheckstateChanged;

        public jQueryUIEventHandler<IGTreeNodeCheckstateChanging> NodeCheckstateChanging;

        public jQueryUIEventHandler<IGTreeNodeClick> NodeClick;

        public jQueryUIEventHandler<IGTreeNodeCollapsed> NodeCollapsed;

        public jQueryUIEventHandler<IGTreeNodeCollapsing> NodeCollapsing;

        public jQueryUIEventHandler<IGTreeNodeDoubleClick> NodeDoubleClick;

        public jQueryUIEventHandler<IGTreeNodeExpanded> NodeExpanded;

        public jQueryUIEventHandler<IGTreeNodeExpanding> NodeExpanding;

        public jQueryUIEventHandler<IGTreeNodePopulated> NodePopulated;

        public jQueryUIEventHandler<IGTreeNodePopulating> NodePopulating;

        public jQueryUIEventHandler<IGTreeRendered> Rendered;

        public jQueryUIEventHandler<IGTreeRendering> Rendering;

        public jQueryUIEventHandler<IGTreeSelectionChanged> SelectionChanged;

        public jQueryUIEventHandler<IGTreeSelectionChanging> SelectionChanging;
        #endregion Events
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGTreeBindings
    {
        public IGTreeBindings Bindings { get; set; }

        public string ChildDataProperty { get; set; }

        public string ChildDataXPath { get; set; }

        public string ExpandKey { get; set; }

        public string ImageUrlKey { get; set; }

        public string ImageUrlXPath { get; set; }

        public string NavigateUrlKey { get; set; }

        public string NavigateUrlXPath { get; set; }

        public string NodeContentTemplate { get; set; }

        public string PrimaryKey { get; set; }

        public string SearchFieldXPath { get; set; }

        public string TargetKey { get; set; }

        public string TextKey { get; set; }

        public string TextXPath { get; set; }

        public string ValueKey { get; set; }

        public string ValueXPath { get; set; }
    }

    [IgnoreNamespace, Imported]
    public sealed class IGTreeCheckBoxMode //from http://stackoverflow.com/questions/424366/c-sharp-string-enums
    {
        private readonly String name;
        private readonly int value;

        public static readonly IGTreeCheckBoxMode Off = new IGTreeCheckBoxMode(1, "off");
        public static readonly IGTreeCheckBoxMode BiState = new IGTreeCheckBoxMode(2, "biState");
        public static readonly IGTreeCheckBoxMode TriState = new IGTreeCheckBoxMode(3, "triState");

        private IGTreeCheckBoxMode(int value, String name)
        {
            this.name = name;
            this.value = value;
        }

        public override String ToString()
        {
            return name;
        }
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGTreeDataBinding
    {
        public jQueryObject Owner { get; set; }
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGTreeDataBound
    {
        public jQueryObject Owner { get; set; }
        public jQueryObject DataView { get; set; }
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGTreeNodeCheckstateChanged
    {
        public jQueryObject Owner { get; set; }
        public jQueryObject Node { get; set; }
        public jQueryObject NewState { get; set; }
        public jQueryObject CurrentCheckedNodes { get; set; }
        public jQueryObject NewPartiallyCheckedNodes { get; set; }
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGTreeNodeCheckstateChanging
    {
        public jQueryObject Owner { get; set; }
        public jQueryObject Node { get; set; }
        public jQueryObject CurrentState { get; set; }
        public jQueryObject NewState { get; set; }
        public jQueryObject CurrentCheckedNodes { get; set; }
    }

    [IgnoreNamespace,Serializable]
    public class IGNode
    {
        public String Path;
        public IGNodeData Data;
    }

    [IgnoreNamespace, Serializable]
    public class IGNodeData
    {
        
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGTreeNodeClick
    {
   
        public IGTreeObject Owner;
        public IGNode Node;
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGTreeNodeCollapsed
    {
        public jQueryObject Owner { get; set; }
        public jQueryObject Node { get; set; }
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGTreeNodeCollapsing
    {
        public jQueryObject Owner { get; set; }
        public jQueryObject Node { get; set; }
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGTreeNodeDoubleClick
    {
        public jQueryObject Path { get; set; }
        public jQueryObject Element { get; set; }
        public jQueryObject Data { get; set; }
        public jQueryObject Binding { get; set; }
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGTreeNodeExpanded
    {
        public jQueryObject Owner { get; set; }
        public jQueryObject Node { get; set; }
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGTreeNodeExpanding
    {
        public jQueryObject Owner { get; set; }
        public jQueryObject Node { get; set; }
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGTreeNodePopulated
    {
        public jQueryObject Path { get; set; }
        public jQueryObject Element { get; set; }
        public jQueryObject Data { get; set; }
        public jQueryObject Dinding { get; set; }
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGTreeNodePopulating
    {
        public jQueryObject Path { get; set; }
        public jQueryObject Element { get; set; }
        public jQueryObject Data { get; set; }
        public jQueryObject Dinding { get; set; }
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGTreeRendered
    {
        public jQueryObject Owner { get; set; }
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGTreeRendering
    {
        public jQueryObject Owner { get; set; }
        public jQueryObject DataView { get; set; }
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGTreeSelectionChanged
    {
        public jQueryObject Owner { get; set; }
        public jQueryObject SelectedNodes { get; set; }
        public jQueryObject NewNodes { get; set; }
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGTreeSelectionChanging
    {
        public jQueryObject Owner { get; set; }
        public jQueryObject SelectedNodes { get; set; }
        public jQueryObject NewNodes { get; set; }
    }
}