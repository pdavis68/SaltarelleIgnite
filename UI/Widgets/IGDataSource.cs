using jQueryApi;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Ignite.UI.Widgets
{
    [IgnoreNamespace, Imported]
    public class IGDataSource : jQueryObject
    {
        public int TotalLocalRecordsCount
        {
            [InlineCode("{this}.dataSource.totalLocalRecordsCount()")]
            get
            {
                return 0;
            }
        }
    }
}
