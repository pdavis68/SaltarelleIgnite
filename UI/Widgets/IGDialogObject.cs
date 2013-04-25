using jQueryApi;
using jQueryApi.UI;
using System;
using System.Collections.Generic;
using System.Html;
using System.Runtime.CompilerServices;
using System.Text;

namespace Ignite.UI.Widgets
{
    public class IGDialogObject
    {
        [ScriptSkip]
        public static explicit operator jQueryObject(IGDialogObject o)
        {
            return null;
        }
        [ScriptSkip]
        public static explicit operator IGDialogObject(jQueryObject o)
        {
            return null;
        }

        #region Events
        public event jQueryUIEventHandler<IGDialogAnimationEnded> AnimationEnded
        {
            [InlineCode("{this}.bind('animationEnded', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('animationEnded', {value})")]
            remove
            {
            }
        }

        public event jQueryUIEventHandler<IGDialogBlur> Blur
        {
            [InlineCode("{this}.bind('blur', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('blur', {value})")]
            remove
            {
            }
        }

        public event jQueryUIEventHandler<IGDialogFocus> Focus
        {
            [InlineCode("{this}.bind('focus', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('focus', {value})")]
            remove
            {
            }
        }

        public event jQueryUIEventHandler<IGDialogStateChanged> StateChanged
        {
            [InlineCode("{this}.bind('stateChanged', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('stateChanged', {value})")]
            remove
            {
            }
        }

        public event jQueryUIEventHandler<IGDialogStateChanging> StateChanging
        {
            [InlineCode("{this}.bind('stateChanging', {value})")]
            add
            {
            }
            [InlineCode("{this}.unbind('stateChanging', {value})")]
            remove
            {
            }
        }
        #endregion Events

        #region Methods
        [InlineCode("{this}.igDialog('close')")]
        public void Close()
        {

        }

        [InlineCode("{this}.igDialog('close', {e})")]
        public void Close(object e)
        {

        }

        [InlineCode("{this}.igDialog('destroy')")]
        public void Destroy()
        {

        }

        [InlineCode("{this}.igDialog('getTopModal')")]
        public object GetTopModal()
        {
            return null;
        }

        [InlineCode("{this}.igDialog('isTopModal')")]
        public bool IsTopModal()
        {
            return false;
        }

        public Element MainElement
        {
            [InlineCode("{this}.igDialog('mainElement')")]
            get;
            [InlineCode("{this}.igDialog('mainElement', {value})")]
            set;
        }

        [InlineCode("{this}.igDialog('maximize')")]
        public void Maximize()
        {

        }

        [InlineCode("{this}.igDialog('minimize')")]
        public void Minimize()
        {

        }

        [InlineCode("{this}.igDialog('moveToTop', {e})")]
        public void MoveToTop(object e)
        {

        }

        [InlineCode("{this}.igDialog('moveToTop')")]
        public void MoveToTop()
        {

        }

        [InlineCode("{this}.igDialog('open')")]
        public void Open()
        {

        }

        [InlineCode("{this}.igDialog('pin')")]
        public void Pin()
        {

        }

        [InlineCode("{this}.igDialog('restore')")]
        public void Restore()
        {

        }

        public string State
        {
            [InlineCode("{this}.igCombo('state')")]
            get;
            [InlineCode("{this}.igCombo('state', {value})")]
            set;
        }

        [InlineCode("{this}.igDialog('unpin')")]
        public void Unpin()
        {

        }
        #endregion Methods
    }
}
