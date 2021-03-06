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
    [Serializable]
    public class IGDialogOptions
    {
        #region Options
        public object CloseAnimation { get; set; }

        public string CloseButtonTitle { get; set; }

        public bool CloseOnEscape { get; set; }

        public object Container { get; set; }

        public bool Draggable { get; set; }

        public Enum EnableDblClick { get; set; }

        public bool EnableHeaderFocus { get; set; }

        public bool FooterText { get; set; }

        public string HeaderText { get; set; }

        public TypeOption<int, string> Height { get; set; }

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

        public string State { get; set; }

        public int TabIndex { get; set; }

        public string TemporaryUrl { get; set; }

        public bool TrackFocus { get; set; }

        public string UnpinButtonTitle { get; set; }

        public TypeOption<int, string> Width { get; set; }

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
    public sealed class IGDialogState 
    {
        private readonly String name;
        private readonly int value;

        public static readonly IGDialogState Opened = new IGDialogState(1, "opened");
        public static readonly IGDialogState Minimized = new IGDialogState(2, "minimized");
        public static readonly IGDialogState Maximized = new IGDialogState(3, "maximized");
        public static readonly IGDialogState Closed = new IGDialogState(3, "closed");

        private IGDialogState(int value, String name)
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