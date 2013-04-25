using System;
using System.Runtime.CompilerServices;

using jQueryApi;
using jQueryApi.UI;
using System.Html;

namespace Ignite.UI.Widgets
{
    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGComboOptions
    {
        public bool AllowCustomValue { get; set; }

        public int AnimationHideDuration { get; set; }
        
        public int AnimationShowDuration { get; set; }

        public bool AutoComplete { get; set; }

        public bool CaseSensitive { get; set; }

        public string ClearButtonTitle { get; set; }

        public bool CloseDropDownOnBlur { get; set; }

        public bool CloseDropDownOnSelect { get; set; }

        public bool DataBindOnOpen { get; set; }

        public object DataSource { get; set; }

        public string DataSourceType { get; set; }

        public string DataSourceUrl { get; set; }

        public bool DropDownAsChild { get; set; }

        public string DropwDownButtonTitle { get; set; }

        public int DropDownMaxHeight { get; set; }

        public int DropDownMinHeight { get; set; }

        public bool DrowDownOnFocus { get; set; }

        public int DropDownWidth { get; set; }

        public bool EnableActiveItem { get; set; }

        public bool EnableClearButton { get; set; }

        public bool EnableDisplayBlock { get; set; }

        public string FilterExprUrlKey { get; set; }

        public string FilteringCondition { get; set; }

        public TypeOption<string, object> FilteringType { get; set; }

        public string FooterTemplate { get; set; }

        public string Format { get; set; }

        public string HeaderTemplate { get; set; }

        public string Height { get; set; }

        public string InputName { get; set; }

        public string ItemSeparator { get; set; }

        public string ItemTemplate { get; set; }

        public IGComboLoadOnDemandSettings LoadOnDemandSettings { get; set; }

        public TypeOption<string, int> Mode { get; set; }

        public TypeOption<string, int, bool, object> MultiSelection { get; set; }

        public string NoMatchFoundText { get; set; }

        public string NullText { get; set; }

        public TypeOption<string, object> RenderMatchItems { get; set; }

        public string ResponseDataKey { get; set; }

        public string ResponseTotalRecCountKey { get; set; }

        public object[] SelectedItems { get; set; }

        public bool SelectItemBySpaceKey { get; set; }

        public bool ShowDropDownButton { get; set; }

        public int TabIndex { get; set; }

        public string Text { get; set; }

        public string TextKey { get; set; }

        public TypeOption<string, object> TextKeyType { get; set; }

        public IGValidatorOptions ValidatorOptions { get; set; }

        public string ValueKey { get; set; }

        public TypeOption<string, object> ValueKeyType { get; set; }

        public bool Virtualization { get; set; }

        public string Width { get; set; }

        public class IGComboLoadOnDemandSettings
        {
            public bool Enabled { get; set; }

            public int PageSize { get; set; }
        }

        // Events
        public jQueryUIEventHandler<IGComboActiveItemEvent> ActiveItemChanged;

        public jQueryUIEventHandler<IGComboActiveItemEvent> ActiveItemChanging;

        public jQueryUIEventHandler<IGComboDataEvent> DataBinding;

        public jQueryUIEventHandler<IGComboDataEvent> DataBound;

        public jQueryUIEventHandler<IGComboDropDownEvent> DropDownClosed;

        public jQueryUIEventHandler<IGComboDropDownEvent> DropDownClosing;

        public jQueryUIEventHandler<IGComboDropDownEvent> DropDownOpened;

        public jQueryUIEventHandler<IGComboDropDownEvent> DropDownOpening;

        public jQueryUIEventHandler<IGComboFilterEvent> Filtered;

        public jQueryUIEventHandler<IGComboFilterEvent> Filtering;

        public jQueryUIEventHandler<IGComboMatchEvent> NoMatchFound;

        public jQueryUIEventHandler<IGComboSelectionEvent> SelectionChanged;

        public jQueryUIEventHandler<IGComboSelectionEvent> SelectionChanging;

        public jQueryUIEventHandler<IGComboTextChangedEvent> TextChanged;


    }
    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGComboActiveItemEvent
    {
        public jQueryObject Owner { get; set; }
        public int Index { get; set; }
        public int OldIndex { get; set; }
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGComboDataEvent
    {
        public jQueryObject Owner { get; set; }
        public object DataSource { get; set; }
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGComboDropDownEvent
    {
        public jQueryObject Owner { get; set; }
        public Element Element { get; set; }
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGComboFilterEvent
    {
        public jQueryObject Owner { get; set; }
        public IGComboFilterExpression Expression { get; set; }
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGComboFilterExpression
    {
        public string FieldName { get; set; }
        public string Cond { get; set; }
        public object Expr { get; set; }
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGComboMatchEvent
    {
        public jQueryObject Owner { get; set; }
        public string Text { get; set; }
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGComboSelectionEvent
    {
        public jQueryObject Owner { get; set; }
        public IGComboSelectedItem[] Items { get; set; }
        public IGComboSelectedItem[] OldItems { get; set; }
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGComboTextChangedEvent
    {
        public jQueryObject Owner { get; set; }
        public string Text { get; set; }
        public string OldText { get; set; }
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGComboSelectedItem
    {
        public int Index { get; set; }
        public object Value { get; set; }
        public string Text { get; set; }
    }
}
