using jQueryApi;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

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
