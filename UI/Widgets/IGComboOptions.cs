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
    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGComboOptions
    {
        ///<summary>
        /// Type: bool 
        /// Default: false 
        /// Gets sets ability to enter and keep custom value in field. 
        /// Notes for enabled: 
        ///     1. The matching item in list becomes active, but not selected. 
        ///     2. If load on demand or dataBindOnOpen is enabled, then after the load, the matching item can be selected. 
        ///     3. If text option was not set, the selectedItems contain only one item and that item was not found in dataSource, then the "value" member of that selected item will be used as the custom text. 
        ///</summary>
        public bool AllowCustomValue { get; set; }
        ///<summary>
        /// Type: number 
        /// Default: 50 
        /// Gets sets duration of hide drop-down list animation in milliseconds. 
        ///</summary>
        public int AnimationHideDuration { get; set; }
        ///<summary>
        /// Type: number 
        /// Default: 100 
        /// Gets sets duration of show drop-down list animation in milliseconds. 
        ///</summary>
        public int AnimationShowDuration { get; set; }
        ///<summary>
        /// Type: bool 
        /// Default: false 
        /// Gets sets ability to autocomplete field from matching item in list. 
        /// Note: if "autoComplete" option is enabled, then the "startsWith" is used for "filteringCondition" option. 
        ///</summary>
        public bool AutoComplete { get; set; }
        ///<summary>
        /// Type: bool 
        /// Default: false 
        /// Gets sets ability to use case sensitive or ignore case searching for matches defined by "renderMatchItems" and "filteringCondition" options. 
        ///</summary>
        public bool CaseSensitive { get; set; }
        ///<summary>
        /// Type: string 
        /// Default: null 
        /// Gets sets title for html element which represend clear button. That is an override for the $.ig.Combo.locale.clearButtonTitle. 
        ///</summary>
        public string ClearButtonTitle { get; set; }
        ///<summary>
        /// Type: bool 
        /// Default: true 
        /// Sets gets ability to close drop-down list when control loses focus. Note: if application disables that option, then it is responsible for closing drop-down list. 
        ///</summary>
        public bool CloseDropDownOnBlur { get; set; }
        ///<summary>
        /// Type: bool 
        /// Default: true 
        /// Sets gets ability to close drop-down list when item is the list is selected. 
        ///</summary>
        public bool CloseDropDownOnSelect { get; set; }
        ///<summary>
        /// Type: bool 
        /// Default: false 
        /// Gets sets ability to load data (bind dataSource) at the time when drop-down list is opened. 
        /// Notes: 
        ///     1. Before data is loaded the selectedItems, value, text and other options/methods will fail. 
        ///     2. Initial selection, text and value will have no effect. 
        ///     3. If on first drop-down the dataSource does not contain selectedItems (for example, enabled load on demand), then selection will be destroyed. 
        ///     4. To get around with values, an application may enable "allowCustomValue" option and use the "text" option instead of "selectedItems". 
        ///</summary>
        public bool DataBindOnOpen { get; set; }
        ///<summary>
        /// Type: object 
        /// Default: null 
        /// Gets sets a valid data source accepted by $.ig.DataSource, or an instance of an $.ig.DataSource itself. 
        /// Note: if it is set to string and "dataSourceType" option is not set, then $.ig.JSONPDataSource is used. 
        ///</summary>
        public object DataSource { get; set; }
        ///<summary>
        /// Type: string 
        /// Default: null 
        /// Gets sets data source type (such as "json", "xml", etc). Please refer to the documentation of $.ig.DataSource and its type property. 
        ///</summary>
        public string DataSourceType { get; set; }
        ///<summary>
        /// Type: string 
        /// Default: null 
        /// Gets sets url which is used for sending JSON on request for remote filtering (MVC for example). That option is required when load on demand is enabled and its type is remote. 
        ///</summary>
        public string DataSourceUrl { get; set; }
        ///<summary>
        /// Type: bool 
        /// Default: false 
        /// Gets sets ability to append container of drop-down list to the body or to the parent of combo. 
        ///</summary>
        public bool DropDownAsChild { get; set; }
        ///<summary>
        /// Type: string 
        /// Default: null 
        /// Gets sets title for html element which represend drop-down button. That is an override for the $.ig.Combo.locale.dropDownButtonTitle. 
        ///</summary>
        public string DropwDownButtonTitle { get; set; }
        ///<summary>
        /// Type: number 
        /// Default: 300 
        /// Gets sets maximum height of drop-down list in pixels. 
        ///</summary>
        public int DropDownMaxHeight { get; set; }
        ///<summary>
        /// Type: number 
        /// Default: 0 
        /// Gets sets minimum height of drop-down list in pixels. 
        ///</summary>
        public int DropDownMinHeight { get; set; }
        ///<summary>
        /// Type: bool 
        /// Default: false 
        /// Sets gets ability to show drop-down list when combo gets focus. 
        ///</summary>
        public bool DrowDownOnFocus { get; set; }
        ///<summary>
        /// Type: number 
        /// Default: 0 
        /// Gets sets width of drop-down list in pixels. If it is 0, then width of combo is used. 
        ///</summary>
        public int DropDownWidth { get; set; }
        ///<summary>
        /// Type: bool 
        /// Default: true 
        /// Gets sets ability to render focus/active item in drop-down list. 
        /// Notes: If list had active item and it was closed and opened again, then active item is reset to the first selected item. 
        /// It there is no selected items, then active item is not reset. 
        /// If that option is disabled, then functionality becomes similar to the SELECT html element. 
        /// For example, if list is opened then action keys like up/down arrows/page, home and end will change selected item instead of active item. 
        /// If list is closed, then up/down arrow keys will change selected item and update text field for it. 
        /// If list is opened, then text-changes in field will select matching item in list instead of activating it. 
        ///</summary>
        public bool EnableActiveItem { get; set; }
        ///<summary>
        /// Type: bool 
        /// Default: true 
        /// Gets sets ability to show a button which allows to clear field. 
        /// Button is automatically hidden when field is empty and it automatically appears when field is not empty. 
        ///</summary>
        public bool EnableClearButton { get; set; }
        ///<summary>
        /// Type: bool 
        /// Default: false 
        /// Gets sets style.display "block" or "inline-block" applied to main/outer html element. 
        ///</summary>
        public bool EnableDisplayBlock { get; set; }
        ///<summary>
        /// Type: string 
        /// Default: null 
        /// Gets sets url key name that specifies how the remote filtering expressions will be encoded for remote requests, e.g. &filter('col') = startsWith. Default is OData. 
        ///</summary>
        public string FilterExprUrlKey { get; set; }
        ///<summary>
        /// Type: string 
        /// Default: contains 
        /// Gets sets condition used for filtering. 
        /// Note: if the "autoComplete" option is enabled, then the "startsWith" is used regardless of value for this option. 
        ///</summary>
        public string FilteringCondition { get; set; }
        ///<summary>
        /// Type: enumeration 
        /// Default: null 
        /// Gets sets type of filtering. 
        /// Members 
        ///     remote  | Type:string | filtering is performed by server. 
        ///     local   | Type:string | filtering is performed by $.ig.DataSource. 
        ///     none    | Type:string | filtering is disabled. 
        ///     null    | Type:object | filtering is disabled. 
        ///</summary>
        public TypeOption<string, object> FilteringType { get; set; }
        ///<summary>
        /// Type: string 
        /// Default: null 
        /// Gets sets template used to render footer in drop-down list. Note: template is rendered inside of DIV html element. 
        ///</summary>
        public string FooterTemplate { get; set; }
        ///<summary>
        /// Type: string 
        /// Default: true 
        /// Gets sets format which is applied to items in list. Values null or false will disable format. 
        /// Value "auto" or true will use automatic format for Date and number objects. 
        /// Value null or false will disable automatic format. 
        /// Custom values can be something like "currency", "percent", "dateLong", "time", "MMM-dd-yyyy H:mm tt", etc. 
        /// However, custom format should be valid for a specific data type in "textKey" column. 
        ///</summary>
        public string Format { get; set; }
        ///<summary>
        /// Type: string 
        /// Default: null 
        /// Gets sets template used to render header in drop-down list. Template is rendered inside of DIV html element. 
        ///</summary>
        public string HeaderTemplate { get; set; }
        ///<summary>
        /// Type: string 
        /// Default: null 
        /// Gets sets height of combo. The numeric and string values (valid html units for size) are supported. It includes %, px, em and other units. 
        ///</summary>
        public string Height { get; set; }
        public string Id { get; set; }
        ///<summary>
        /// Type: string
        /// Default: null 
        /// Gets sets name of (hidden) INPUT element, which value will be set to values of selected items separated by "," character on any change in igCombo. 
        ///</summary>
        public string InputName { get; set; }
        ///<summary>
        /// Type: string 
        /// Default: , 
        /// Gets sets separator between items in field. Note: that option has effect only when "multiSelection" option is enabled. 
        ///</summary>
        public string ItemSeparator { get; set; }
        ///<summary>
        /// Type: string 
        /// Default: null 
        /// Gets sets template used to render an item in list. Notes: 
        ///     1. The jquery.tmpl.js of Microsoft is used and application should provide supported syntax for content. 
        ///     2. Template is rendered inside of LI html element. 
        /// So, application should consider restriction for layout: do not use "block" html elements and in case of absolutely positioned elements, they should not overlap with checkbox icons. 
        ///</summary>
        public string ItemTemplate { get; set; }
        ///<summary>
        /// Type: object 
        /// Default: {} 
        /// Gets sets container of variables which define load on demand functionality. 
        /// Note: that option has effect only when data is loaded remotely using dataSourceUrl. 
        ///</summary>
        public IGComboLoadOnDemandSettings LoadOnDemandSettings { get; set; }
        ///<summary>
        /// Type: enumeration 
        /// Default: null 
        /// Sets gets functionality mode. 
        /// Members 
        ///     editable        | Type:string | Allows to modify value by edit field and drop-down list. 
        ///     dropdown        | Type:string | Allows to modify value by drop-down list only. 
        ///     readonlylist    | Type:string | Allows to open list, but does not allow any changes in field or selection in drop-down list. 
        ///     readonly        | Type:string | Does not allow to open list or change value in field. 
        ///     0               | Type:number | Allows to modify value by edit field and drop-down list. 
        ///     1               | Type:number | Allows to modify value by drop-down list. 
        ///     2               | Type:number | Allows to open list, but does not allow any changes. 
        ///     3               | Type:number | Does not allow to open list or change value in field. 
        ///</summary>
        public TypeOption<string, int> Mode { get; set; }
        ///<summary>
        /// Type: enumeration 
        /// Default: null 
        /// Gets sets ability to select multiple items in list and enter multiple items in field which are separated by the 'itemSeparator'.
        /// Members
        ///     null                | Type:object  | multiselection is disabled.
        ///     false               | Type:bool   | multiselection is disabled.
        ///     0                   | Type:number   | multiselection is disabled.
        ///     off                 | Type:string   | multiselection is disabled.
        ///     true                | Type:bool     | multiselection is enabled.
        ///     1                   | Type:number   | multiselection is enabled.
        ///     on                  | Type:string   | multiselection is enabled.
        ///     2                   | Type:number   | multiselection is enabled and checkboxes are used for list items. Those checkboxes allow to add/remove selection without pressing Ctrl key on mouse click.
        ///     onWithCheckboxes    | Type:string   | multiselection is enabled and checkboxes are used for list items. Those checkboxes allow to add/remove selection without pressing Ctrl key on mouse click.
        ///</summary>
        public TypeOption<string, int, bool, object> MultiSelection { get; set; }
        ///<summary>
        /// Type: string 
        /// Default: null 
        /// Gets sets text of list item for condition when "filteringType" option is enabled and no match was found. That is an override for the $.ig.Combo.locale.noMatchFoundText. 
        ///</summary>
        public string NoMatchFoundText { get; set; }
        ///<summary>
        /// Type: string 
        /// Default: null 
        /// Sets gets text which appears in field in no-focus state and there is no value. 
        ///</summary>
        public string NullText { get; set; }
        ///<summary>
        /// Type: string 
        /// Default: null 
        /// Sets gets text which appears in field in no-focus state and there is no value. 
        ///</summary>
        public string ParentCombo { get; set; }
        public string ParentComboKey { get; set; }
        ///<summary>
        /// Type: enumeration 
        /// Default: multi 
        /// Gets sets condition used for rendering of matching parts in items of drop-down list. 
        /// Members 
        ///     multi       | Type:string | multiple matches in a single item are rendered. 
        ///     contains    | Type:string | match at any position in item is rendered. 
        ///     startsWith  | Type:string | only match which starts from the beginning of text is rendered. 
        ///     full        | Type:string | only fully matched items are rendered. 
        ///     null        | Type:object | matches are not rendered. 
        ///</summary>
        public TypeOption<string, object> RenderMatchItems { get; set; }
        ///<summary>
        /// Type: string 
        /// Default: null 
        /// See $.ig.DataSource. This is basically the property in the responses where data records are held, if the response is wrapped. 
        ///</summary>
        public string ResponseDataKey { get; set; }
        ///<summary>
        /// Type: string 
        /// Default: null 
        /// See $.ig.DataSource. property in the response specifying the total number of records on the server. 
        ///</summary>
        public string ResponseTotalRecCountKey { get; set; }
        ///<summary>
        /// Type: array 
        /// Default: [] 
        /// Elements Type: object 
        /// Gets sets list of selected items. It should contain array of objects. 
        /// Each object should contain the member "index" equals to the index of selected item or the member "value" equals to value of item in dataSource in "valueKey" column. 
        /// The member "text" contains value of item in "textKey" column. 
        /// Missing values are filled automatically while rendering list items and on other actions. If application set more than one member, then it is responsible for match. 
        ///</summary>
        public object[] SelectedItems { get; set; }
        ///<summary>
        /// Type: bool 
        /// Default: false 
        /// Gets sets ability to select active item in list by Space key. 
        /// Note: if that options is enabled, then it will be not possible to type-in the Space character when list is opened. 
        ///</summary>
        public bool SelectItemBySpaceKey { get; set; }
        ///<summary>
        /// Type: bool 
        /// Default: true 
        /// Gets sets visibility of drop-down button. 
        ///</summary>
        public bool ShowDropDownButton { get; set; }
        ///<summary>
        /// Type: number 
        /// Default: null 
        /// Gets sets tabIndex for field of combo. 
        ///</summary>
        public int TabIndex { get; set; }
        ///<summary>
        /// Type: string 
        /// Default: null 
        /// Gets sets text which appears in combo on initialization. If it is not set, then the value from target html element is used automatically. 
        /// If selectedItems option is not set and allowCustomValue option is enabled, then first matching item in list will be selected. 
        /// Notes: After initialization that option is reset to null. To get text in field, the text() method can be used. 
        ///</summary>
        public string Text { get; set; }
        ///<summary>
        /// Type: string 
        /// Default: null 
        /// Gets sets name of column which contains the displayed text. If it is missing, then "valueKey" option will be used. 
        ///</summary>
        public string TextKey { get; set; }
        ///<summary>
        /// Type: enumeration 
        /// Default: null 
        /// Gets sets type of values used for data cells/items with textKey. That value is assign to schema of $.ig.DataSource.
        /// Members
        ///     string  | Type:string | data source uses strings objects. 
        ///     number  | Type:string | data source uses numbers objects. 
        ///     bool    | Type:string | data source uses booleans objects. 
        ///     date    | Type:string | data source uses Date objects. 
        ///     auto    | Type:string | data source uses type defined by cell/items located in first row. 
        ///     null    | Type:object | data source uses type defined by cell/items located in first row.
        ///</summary>
        public TypeOption<string, object> TextKeyType { get; set; }
        ///<summary>
        /// Type: object 
        /// Default: null 
        /// Gets or sets object which contains options supported by igValidator.
        /// Notes: in order for validator to work, application should ensure that igValidator is loaded (ig.ui.validator.js/css files).
        /// Example:
        ///     $('#combo1').igCombo({ validatorOptions: { required: true } });.
        ///</summary>
        public IGValidatorOptions ValidatorOptions { get; set; }
        ///<summary>
        /// Type: string 
        /// Default: null 
        /// Gets sets name of column which contains the "value". If it is missing, then name of first column will be used.
        ///</summary>
        public string ValueKey { get; set; }
        ///<summary>
        /// Type: enumeration 
        /// Default: null 
        /// Gets sets type of values used for data cell/items with valueKey. That value is assign to schema of $.ig.DataSource.
        /// Members
        ///     string  | Type:string | data source uses strings objects. 
        ///     number  | Type:string | data source uses numbers objects. 
        ///     bool    | Type:string | data source uses booleans objects. 
        ///     date    | Type:string | data source uses Date objects.autoType:stringdata source uses type defined by cell/items located in first row. 
        ///     null    | Type:object | data source uses type defined by cell/items located in first row.
        ///</summary>
        public TypeOption<string, object> ValueKeyType { get; set; }
        ///<summary>
        /// Type: bool 
        /// Default: false 
        /// Gets sets ability to use virtual rendering for drop-down list.
        /// If that option is enabled, then only visible items are created and top edge of first visible item in list is alligned to the top edge of list.
        ///</summary>
        public bool Virtualization { get; set; }
        ///<summary>
        /// Type: string 
        /// Default: null 
        /// Gets sets width of combo. The numeric and string values (valid html units for size) are supported. It includes %, px, em and other units.
        ///</summary>
        public string Width { get; set; }

        public class IGComboLoadOnDemandSettings
        {
            public bool Enabled { get; set; }

            public int PageSize { get; set; }
        }

        // Events
        ///<summary>
        /// Cancellable: false 
        /// Event which is raised after change of active item in list.
        /// Function takes arguments evt and ui.
        /// Use evt.originalEvent to obtain reference to event of browser. That can be null.
        /// Use ui.owner to obtain reference to igCombo.
        /// Use ui.index to obtain index of new active item.
        /// Use ui.oldIndex to obtain index of old active item.
        ///</summary>
        public jQueryUIEventHandler<IGComboActiveItemEvent> ActiveItemChanged;
        ///<summary>
        /// Cancellable: true 
        /// Event which is raised before change of active item in list.
        /// Return false in order to cancel change.
        /// Function takes arguments evt and ui.
        /// Use evt.originalEvent to obtain reference to event of browser. That can be null.
        /// Use ui.owner to obtain reference to igCombo.
        /// Use ui.index to obtain index of new active item.
        /// Use ui.oldIndex to obtain index of old active item.
        ///</summary>
        public jQueryUIEventHandler<IGComboActiveItemEvent> ActiveItemChanging;
        ///<summary>
        /// Cancellable: true 
        /// Event which is raised before data binding.
        /// Function takes first argument null and second argument ui.
        /// Use ui.owner to obtain reference to igCombo.
        /// Use ui.dataSource to obtain reference to instance of $.ig.DataSource used by combo.
        ///</summary>
        public jQueryUIEventHandler<IGComboDataEvent> DataBinding;
        ///<summary>
        /// Cancellable: false 
        /// Event which is raised after data binding.
        /// Function takes first argument null and second argument ui.
        /// Use ui.owner to obtain reference to igCombo.
        /// Use ui.dataSource to obtain reference to instance of $.ig.DataSource used by combo.
        ///</summary>
        public jQueryUIEventHandler<IGComboDataEvent> DataBound;
        ///<summary>
        /// Cancellable: false 
        /// Event which is raised after drop-down list was closed.
        /// Function takes arguments evt and ui.
        /// Use evt.originalEvent to obtain reference to event of browser.
        /// Use ui.owner to obtain reference to igCombo.
        /// Use ui.element to obtain reference to jquery DOM element which represents container of list.
        ///</summary>
        public jQueryUIEventHandler<IGComboDropDownEvent> DropDownClosed;
        ///<summary>
        /// Cancellable: true 
        /// Event which is raised before drop-down list is closed.
        /// Return false in order to cancel hide action.
        /// Function takes arguments evt and ui.
        /// Use evt.originalEvent to obtain reference to event of browser.
        /// Use ui.owner to obtain reference to igCombo.
        /// Use ui.element to obtain reference to jquery DOM element which represents container of list.
        ///</summary>
        public jQueryUIEventHandler<IGComboDropDownEvent> DropDownClosing;
        ///<summary>
        /// Cancellable: false 
        /// Event which is raised after drop-down list was opened.
        /// Function takes arguments evt and ui.
        /// Use evt.originalEvent to obtain reference to event of browser.
        /// Use ui.owner to obtain reference to igCombo.
        /// Use ui.element to obtain reference to jquery DOM element which represents container of list.
        ///</summary>
        public jQueryUIEventHandler<IGComboDropDownEvent> DropDownOpened;
        ///<summary>
        /// Cancellable: true 
        /// Event which is raised before drop-down list is opened. 
        /// Return false in order to cancel drop-down action. 
        /// Function takes arguments evt and ui. 
        /// Use evt.originalEvent to obtain reference to event of browser. 
        /// Use ui.owner to obtain reference to igCombo. 
        /// Use ui.element to obtain reference to jquery DOM element which represents container of list. 
        /// Note: on the very first opening or option-change that member is null and application should check that before using that member.
        ///</summary>
        public jQueryUIEventHandler<IGComboDropDownEvent> DropDownOpening;
        ///<summary>
        /// Cancellable: false 
        /// Event which is raised after filtering. 
        /// Function takes arguments evt and ui. 
        /// Use evt.originalEvent to obtain reference to event of browser. That can be null. 
        /// Use ui.owner to obtain reference to igCombo. 
        /// Use ui.expression to obtain reference to array which contains expressions supported by $.ig.DataSource. 
        /// Each expression-item contains following members: fieldName (textKey), cond (filteringCondition), expr (value/string to filter). 
        ///</summary>
        public jQueryUIEventHandler<IGComboFilterEvent> Filtered;
        ///<summary>
        /// Cancellable: true 
        /// Event which is raised before filtering. 
        /// Return false in order to cancel filtering. 
        /// Function takes arguments evt and ui. 
        /// Use evt.originalEvent to obtain reference to event of browser. That can be null. 
        /// Use ui.owner to obtain reference to igCombo. 
        /// Use ui.expression to obtain reference to array which contains expressions supported by $.ig.DataSource. 
        /// Each expression-item contains following members: fieldName (textKey), cond (filteringCondition), expr (value/string to filter). 
        ///</summary>
        public jQueryUIEventHandler<IGComboFilterEvent> Filtering;
        ///<summary>
        /// Cancellable: false 
        /// Event which is raised after field was modified by end user and autoComplete was not able to find matching item in list. 
        /// Function takes arguments evt and ui. 
        /// Use evt.originalEvent to obtain reference to event of browser. That can be null. 
        /// Use ui.owner to obtain reference to igCombo. 
        /// Use ui.text to obtain text in field. 
        ///</summary>
        public jQueryUIEventHandler<IGComboMatchEvent> NoMatchFound;
        ///<summary>
        /// Cancellable: false 
        /// Event which is raised after selection change. 
        /// Function takes arguments evt and ui. 
        /// Use evt.originalEvent to obtain reference to event of browser. That can be null. 
        /// Use ui.owner to obtain reference to igCombo. 
        /// Use ui.items to obtain reference to array of new selected items. That can be null. 
        /// Use ui.oldItems to obtain reference to array of old selected items. That can be null.
        ///</summary>
        public jQueryUIEventHandler<IGComboSelectionEvent> SelectionChanged;
        ///<summary>
        /// Cancellable: true 
        /// Event which is raised before selection change. 
        /// Return false in order to cancel change. 
        /// Function takes arguments evt and ui. 
        /// Use evt.originalEvent to obtain reference to event of browser. That can be null. 
        /// Use ui.owner to obtain reference to igCombo. 
        /// Use ui.items to obtain reference to array of new selected items. That can be null. 
        /// Use ui.oldItems to obtain reference to array of old selected items. That can be null.
        ///</summary>
        public jQueryUIEventHandler<IGComboSelectionEvent> SelectionChanging;
        ///<summary>
        /// Cancellable: false 
        /// Event which is raised after value in field was modified by user. 
        /// It is not raised when value of field was modified internally, for example, after filling-up from matching item while autoComplete. 
        /// Function takes arguments evt and ui. 
        /// Use evt.originalEvent to obtain reference to event of browser. 
        /// Use ui.owner to obtain reference to igCombo. 
        /// Use ui.text to obtain new text in field. 
        /// Use ui.oldText to obtain old text in field.
        ///</summary>
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