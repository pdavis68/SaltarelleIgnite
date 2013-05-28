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
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Ignite.UI.Widgets
{
    [IgnoreNamespace, Imported]
    public class IGLoaderObject
    {
        [ScriptSkip]
        public static explicit operator jQueryObject(IGLoaderObject o)
        {
            return null;
        }
        [ScriptSkip]
        public static explicit operator IGLoaderObject(jQueryObject o)
        {
            return null;
        }

        #region Methods
        [InlineCode("$.ig.loader().load({resources})")]
        public void Load(string resources)
        {

        }

        [InlineCode("$.ig.loader().load({resources}, {callback})")]
        public void Load(string resources, Function callback)
        {

        }

        [InlineCode("$.ig.loader().load({resources}, {preinit})")]
        public void Load(string resources, object preinit)
        {

        }

        [InlineCode("$.ig.loader().load({resources}, {callback}, {preinit})")]
        public void Load(string resources, Function callback, object preinit)
        {

        }

        [InlineCode("$.ig.loader()")]
        public void Loader()
        {

        }

        [InlineCode("$.ig.loader({param1})")]
        public void Loader(object param1)
        {

        }

        [InlineCode("$.ig.loader({param1}, {param2})")]
        public void Loader(object param1, string param2)
        {

        }

        [InlineCode("$.ig.loader({param1}, {param3})")]
        public void Loader(object param1, object param3)
        {

        }

        [InlineCode("$.ig.loader({param1}, {param2}, {param3})")]
        public void Loader(object param1, string param2, object param3)
        {

        }

        [InlineCode("$.ig.loader().log()")]
        public void Log()
        {

        }

        [InlineCode("$.ig.loader().preinit({callback})")]
        public void Preinit(object callback)
        {

        }
        #endregion Methods
    }
}
