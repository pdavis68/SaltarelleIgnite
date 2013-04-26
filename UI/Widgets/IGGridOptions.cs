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

using jQueryApi.UI;

namespace Ignite.UI.Widgets
{
    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGGridOptions
    {
        public bool AccessibilityRendering { get; set; }

        public bool AdjustVirtualHeights { get; set; }

        public bool AggregateTransactions { get; set; }

        public bool AlternateRowStyles { get; set; }

        public bool AutoAdjustHeight { get; set; }

        public bool AutoCommit { get; set; }

        public bool AutoFitLastColumn { get; set; }

        public TypeOption<string, bool> AutoFormat { get; set; }

        public bool AutoGenerateColumns { get; set; }

        public TypeOption<int, string> AvgColumnWidth { get; set; }

        public TypeOption<int, string> AvgRowHeight { get; set; }

        public string Caption { get; set; }

        public IGGridColumn[] Columns { get; set; }

        public bool ColumnVirtualization { get; set; }

        public object DataSource { get; set; }

        public string DataSourceType { get; set; }

        public string DataSourceUrl { get; set; }

        public TypeOption<string, int> DefaultColumnWidth { get; set; }

        public bool EnableHoverStyles { get; set; }

        public bool EnableUTCDates { get; set; }

        public IGGridFeatureBase[] Features { get; set; }

        public bool FixedFooters { get; set; }

        public bool FixedHeaders { get; set; }

        public TypeOption<string, int, object> Height { get; set; }

        public bool JQueryTemplating { get; set; }

        public bool LocalSchemaTransform { get; set; }

        public bool MergeUnboundColumns { get; set; }

        public string PrimaryKey { get; set; }

        public bool RenderCheckboxes { get; set; }

        public bool RequiresDataBinding { get; set; }

        public string ResponseDataKey { get; set; }

        public string ResponseTotalRecCountKey { get; set; }

        public string RowTemplate { get; set; }

        public bool RowVirtualization { get; set; }

        public bool SerializeTransactionLog { get; set; }

        public bool ShowFooter { get; set; }

        public bool ShowHeader { get; set; }

        public int TabIndex { get; set; }

        public string UpdateUrl { get; set; }

        public bool Virtualization { get; set; }

        public string VirtualizationMode { get; set; }

        public int VirtualizationMouseWheelStep { get; set; }

        public TypeOption<string, int, object> Width { get; set; }



        public jQueryUIEventHandler<IGGridEvent> DataRendered;
        public jQueryUICancelableEventHandler<IGGridEvent> DataRendering;
        public jQueryUIEventHandler<IGGridEvent> Rendered;
        public jQueryUICancelableEventHandler<IGGridEvent> Rendering;

    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGGridColumn
    {
        public string DataType { get; set; }

        public string Format { get; set; }

        public TypeOption<Delegate, string> Formatter { get; set; }

        public string HeaderText { get; set; }

        public bool Hidden { get; set; }

        public string Key { get; set; }

        public string Template { get; set; }

        public TypeOption<string, int> Width { get; set; }
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public abstract class IGGridFeatureBase
    {
        public string Name { get; set; }
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGGridFilterFeature : IGGridFeatureBase
    {
        public bool AdvancedModeEditorsVisible { get; set; }

        public string AdvancedModeHeaderButtonLocation { get; set; }

        public bool CaseSensitive { get; set; }

        public IGGridFilteringColumnSettings[] ColumnSettings { get; set; }

        public string FeatureChooserText { get; set; }

        public string FeatureChooserTextAdvancedFilter { get; set; }

        public string FeatureChooserTextHide { get; set; }

        public string FilterButtonLocation { get; set; }

        public int FilterDelay { get; set; }

        public TypeOption<string, int> FilterDialogAddButtonWidth { get; set; }

        public string FilterDialogAddConditionDropDownTemplate { get; set; }

        public string FilterDialogAddConditionTemplate { get; set; }

        public TypeOption<string, int> FilterDialogColumnDropwDownDefaultWidth { get; set; }

        public TypeOption<string, int> FilterDialogExprInputDefaultWidth { get; set; }

        public string FilterDialogFilterConditionTemplate { get; set; }

        public TypeOption<string, int> FilterDialogFilterDropwDownDefaultWidth { get; set; }

        public string FilterDialogFilterTemplate { get; set; }

        public TypeOption<string, int> FilterDialogHeight { get; set; }

        public int FilterDialogMaxFilterCount { get; set; }

        public TypeOption<string, int> FilterDialogOkCancelButtonWidth { get; set; }

        public TypeOption<string, int> FilterDialogWidth { get; set; }

        public int FilterDropDownAnimationDuration { get; set; }

        public string FilterDropDownAnimations { get; set; }

        public TypeOption<string, int> FilterDropDownHeight { get; set; }

        public bool FilterDropDownItemIcons { get; set; }

        public TypeOption<string, int> FilterDropDownWidth { get; set; }

        public string FilterExprUrlKey { get; set; }

        public bool FilterSummaryAlwaysVisible { get; set; }

        public string FilterSummaryTemplate { get; set; }

        public IGGridFilterLabels Labels { get; set; }

        public string Mode { get; set; }

        public IGGridFilterLabels NullTexts { get; set; }

        public bool RenderFC { get; set; }

        public bool RenderFilterButton { get; set; }

        public bool ShowEmptyConditions { get; set; }

        public bool ShowNullConditions { get; set; }

        public string TooltipTemplate { get; set; }

        public string Type { get; set; }

    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGGridFilteringColumnSettings
    {
        public bool AllowFiltering { get; set; }

        public int ColumnIndex { get; set; }

        public string ColumnKey { get; set; }

        public TypeOption<string, bool> Condition { get; set; }
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGGridFilterLabels
    {
        public string AdvancedButtonLabel { get; set; }
        public string After { get; set; }
        public string Before { get; set; }
        public string Clear { get; set; }
        public string Contains { get; set; }
        public string DoesNotContain { get; set; }
        public string DoesNotEqual { get; set; }
        public string Empty { get; set; }
        public string EndsWith { get; set; }
        public string equals { get; set; }
        public string FalseLabel { get; set; }
        public string FilterDialogAddLabel { get; set; }
        public string FilterDialogAllLabel { get; set; }
        public string FilterDialogAnyLabel { get; set; }
        public string FilterDialogCancelLabel { get; set; }
        public string FilterDialogCaptionLabel { get; set; }
        public string FilterDialogClearAllLabel { get; set; }
        public string FilterDialogCondiitonLabel1 { get; set; }
        public string FilterDialogCondiitonLabel2 { get; set; }
        public string FilterDialogErrorLabel { get; set; }
        public string FilterDialogOkLabel { get; set; }
        public string FilterDialogSummaryTitleLabel { get; set; }
        public string GreaterThan { get; set; }
        public string GreaterThanOrEqualTo { get; set; }
        public string LastMonth { get; set; }
        public string LastYear { get; set; }
        public string LessThan { get; set; }
        public string LessThanOrEqualTo { get; set; }
        public string NextMonth { get; set; }
        public string NextYear { get; set; }
        public string NoFilter { get; set; }
        public string NotEmpty { get; set; }
        public string NotNull { get; set; }
        public string NotOn { get; set; }
        public string NullLabel { get; set; }
        public string On { get; set; }
        public string StartsWith { get; set; }
        public string ThisMonth { get; set; }
        public string ThisYear { get; set; }
        public string Today { get; set; }
        public string TrueLabel { get; set; }
        public string Yesterday { get; set; }
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGGridPagingFeature : IGGridFeatureBase
    {

        public string CurrentPageDropDownLeadingLabel { get; set; }

        public string CurrentPageDropDownTooltip { get; set; }

        public string CurrentPageDropDownTrailingLabel { get; set; }

        public int CurrentPageIndex { get; set; }

        public int DefaultDropDownWidth { get; set; }

        public string FirstPageLabelText { get; set; }

        public string FirstPageTooltip { get; set; }

        public string LastPageLabelText { get; set; }

        public string LastPageTooltip { get; set; }

        public string NextPageLabelText { get; set; }

        public string NextPageTooltip { get; set; }

        public int PageCountLimit { get; set; }

        public string PageIndexUrlKey { get; set; }

        public string PagerRecordsLabelTemplate { get; set; }

        public string PagerRecordsLabelTooltip { get; set; }

        public int PageSize { get; set; }

        public string PageSizeDropwDownTemplate { get; set; }

        public string PageSizeDropwDownLocation { get; set; }

        public string PageSizeDropwDownTooltip { get; set; }

        public string PageSizeDropwDownTrailingLabel { get; set; }

        public int[] PageSizeList { get; set; }

        public string PageSizeUrlKey { get; set; }

        public string PageTooltipFormat { get; set; }

        public string PrevPageLabelText { get; set; }

        public string PrevPageTooltip { get; set; }

        public string RecordCountKey { get; set; }

        public bool ShowFirstLastPages { get; set; }

        public bool ShowPagerRecordsLabel { get; set; }

        public bool ShowPageSizeDropDown { get; set; }

        public bool ShowPrevNextPage { get; set; }

        public string Type { get; set; }

        public int VisiblePagesCount { get; set; }

    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGGridSelectionFeature : IGGridFeatureBase
    {
        public bool Activation { get; set; }

        public string Mode { get; set; }

        public bool MouseDragSelect { get; set; }

        public bool MultipleSelectOnClick { get; set; }

        public bool MultipleSelection { get; set; }

        public bool SkipChildren { get; set; }

        public bool TouchDragSelect { get; set; }

        public bool WrapAround { get; set; }

        #region Events

        public jQueryUIEventHandler<IGGridRowSelectionEvent> RowSelectionChanged;

        public jQueryUIEventHandler<IGGridRowSelectionEvent> RowSelectionChanging;

        #endregion

    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGGridEvent
    {
        public object Owner;
    }



    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGGridRowSelectionEvent
    {
        public object Owner;
        public IGGridSelectedRowItem Row;
        public IGGridSelectedRowItem[] SelectedRows;
        public bool Manual;
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGGridSelectedRowItem
    {
        public TableRowElement[] Element { get; set; }
        public int Index { get; set; }
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGGridResizingFeature : IGGridFeatureBase
    {
        public bool AllowDoubleClickToResize { get; set; }

        public bool DeferredResizing { get; set; }

        public int HandleThreshold { get; set; }
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGGridResizingColumnSettings
    {
        public bool AllowResizing { get; set; }

        public int ColumnIndex { get; set; }

        public string ColumnKey { get; set; }

        public int MaximumWidth { get; set; }

        public int MinimumWidth { get; set; }
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGGridSortingFeature : IGGridFeatureBase
    {
        public bool ApplySortedColumnCss { get; set; }

        public bool CaseSensitive { get; set; }

        public IGGridSortingColumnSettings[] ColumnSettings { get; set; }

        public Delegate CustomSortFunction { get; set; }

        public string FeatureChooserText { get; set; }

        /// <summary>
        /// Valid values: "ascending" and "descending"
        /// </summary>
        public string FirstSortDirection { get; set; }

        public int ModalDialogAnimationDuration { get; set; }

        public string ModalDialogButtonApplyText { get; set; }

        public string ModalDialogButtonCancelText { get; set; }

        public string ModalDialogCaptionButtonAsc { get; set; }

        public string ModalDialogCaptionButtonDesc { get; set; }

        public string ModalDialogCaptionButtonUnsort { get; set; }

        public string ModalDialogCaptionText { get; set; }

        public int ModalDialogHeight { get; set; }

        public string ModalDialogResetButtonLabel { get; set; }

        public string ModalDialogResetButtonText { get; set; }

        public bool ModalDialogSortOnClick { get; set; }

        public int ModalDialogWidth { get; set; }

        /// <summary>
        /// Valid values: "single" and "multi"
        /// </summary>
        public string Mode { get; set; }

        public string SortedColumnTooltip { get; set; }

        public string SortUrlKey { get; set; }

        public string SortUrlKeyAscValue { get; set; }

        public string SortUrlKeyDescValue { get; set; }

        /// <summary>
        /// Valid values: "remote" and "local"
        /// </summary>
        public string Type { get; set; }

        public string UnsortedColumnTooltip { get; set; }

    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGGridSortingColumnSettings
    {
        public bool AllowSorting { get; set; }

        public int ColumnIndex { get; set; }

        public string ColumnKey { get; set; }

        /// <summary>
        /// Valid values: "asc" and "desc"
        /// </summary>
        public string CurrentSortDirection { get; set; }

        /// <summary>
        /// Valid values: "asc" and "desc"
        /// </summary>
        public string FirstSortDirection { get; set; }
    }
}
