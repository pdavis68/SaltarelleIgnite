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
    public class IGDialogObject : jQueryObject
    {    
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
