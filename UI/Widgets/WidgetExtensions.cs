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

using System.Runtime.CompilerServices;

using jQueryApi;

namespace Ignite.UI.Widgets
{
    public delegate bool jQueryUICancelableEventHandler<in T>(jQueryEvent e, T uiEvent);

    [IgnoreNamespace, Imported]
    public static class WidgetExtensions
    {

        [InstanceMethodOnFirstArgument, InlineCode("{q}.igLoading().data(\"igLoading\").indicator()")]
        public static IGLoadingIndicatorObject IGLoadingIndicator(this jQueryObject q)
        {
            return null;
        }

        [InstanceMethodOnFirstArgument, ScriptName("igCombo")]
        public static IGComboObject IGCombo(this jQueryObject q)
        {
            return null;
        }

        [InstanceMethodOnFirstArgument, ScriptName("igCombo")]
        public static IGComboObject IGCombo(this jQueryObject q, IGComboOptions options)
        {
            return null;
        }

        [InstanceMethodOnFirstArgument, ScriptName("igGrid")]
        public static IGGridObject IGGrid(this jQueryObject q)
        {
            return null;
        }

        [InstanceMethodOnFirstArgument, ScriptName("igGrid")]
        public static IGGridObject IGGrid(this jQueryObject q, IGGridOptions options)
        {
            return null;
        }

        [InstanceMethodOnFirstArgument, ScriptName("igHtmlEditor")]
        public static IGHtmlEditorObject IGHtmlEditor(this jQueryObject q)
        {
            return null;
        }

        [InstanceMethodOnFirstArgument, ScriptName("igHtmlEditor")]
        public static IGHtmlEditorObject IGHtmlEditor(this jQueryObject q, IGHtmlEditorOptions options)
        {
            return null;
        }
        /*
        [InstanceMethodOnFirstArgument, ScriptName("igDialog")]
        public static IGDialogObject IGDialog(this jQueryObject q)
        {
            return null;
        }

        [InstanceMethodOnFirstArgument, ScriptName("igDialog")]
        public static IGDialogObject IGDialog(this jQueryObject q, IGDialogOptions options)
        {
            return null;
        }
        */
    }
}
