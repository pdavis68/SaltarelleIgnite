using System;
using System.Runtime.CompilerServices;

using jQueryApi;
using jQueryApi.UI;
using System.Html;

namespace Ignite.UI.Widgets
{
    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGDialogOptions
    {
        #region Options
        public object CloseAnimation { get; set; }

        public string CloseButtonTitle { get; set; }

        public bool CloseOnEscape { get; set; }

        public object Container { get; set; }

        public string DialogClass { get; set; }

        public bool Draggable { get; set; }

        public Enum EnableDblClick { get; set; }

        public bool EnableHeaderFocus { get; set; }

        public bool FooterText { get; set; }

        public string HeaderText { get; set; }

        public int Height { get; set; }

        public string ImageClass { get; set; }

        public Element MainElement { get; set; }

        public int MaxHeight { get; set; }

        public string MaximizeButtonTitle { get; set; }

        public int MaxWidth { get; set; }

        public int MinHeight { get; set; }

        public string MinimizeButtonTitle { get; set; }

        public int MinWidth { get; set; }

        public bool Modal { get; set; }

        public object OpenAnimation { get; set; }

        public string PinButtonTitle { get; set; }

        public bool Pinned { get; set; }

        public bool PinOnMinimized { get; set; }

        public object Position { get; set; }

        public bool Resizable { get; set; }

        public string RestoreButtonTitle { get; set; }

        public bool ShowCloseButton { get; set; }

        public bool ShowFooter { get; set; }

        public bool ShowHeader { get; set; }

        public bool ShowMaximizeButton { get; set; }

        public bool ShowMinimizeButton { get; set; }

        public bool ShowPinButton { get; set; }

        public Enum State { get; set; }

        public int TabIndex { get; set; }

        public string TemporaryUrl { get; set; }

        public bool TrackFocus { get; set; }

        public string UnpinButtonTitle { get; set; }

        public int Width { get; set; }

        public int ZIndex { get; set; }
        #endregion Options

        #region Events
        public jQueryUIEventHandler<IGDialogAnimationEnded> AnimationEnded;
        public jQueryUIEventHandler<IGDialogBlur> Blur;
        public jQueryUIEventHandler<IGDialogFocus> Focus;
        public jQueryUIEventHandler<IGDialogStateChanged> StateChanged;
        public jQueryUIEventHandler<IGDialogStateChanging> StateChanging;
        #endregion Events
    }
    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGDialogAnimationEnded
    {
        public jQueryObject Owner { get; set; }
        public jQueryObject Action { get; set; }
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGDialogBlur
    {
        public jQueryObject Owner { get; set; }
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGDialogFocus
    {
        public jQueryObject Owner { get; set; }
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGDialogStateChanged
    {
        public jQueryObject Owner { get; set; }
        public jQueryObject Button { get; set; }
        public jQueryObject OldState { get; set; }
        public jQueryObject OldPinned { get; set; }
        public jQueryObject Action { get; set; }
    }

    [IgnoreNamespace, Imported]
    [Serializable]
    public class IGDialogStateChanging
    {
        public jQueryObject Owner { get; set; }
        public jQueryObject Button { get; set; }
        public jQueryObject OldState { get; set; }
        public jQueryObject OldPinned { get; set; }
        public jQueryObject Action { get; set; }
    }
}