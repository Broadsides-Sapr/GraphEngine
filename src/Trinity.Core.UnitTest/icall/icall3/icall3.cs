using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using Trinity;
using Trinity.Storage;

namespace icall3
{
    public class icall3
    {
        [Fact]
        public void icall_cellcount()
        {
            var val = Global.LocalStorage.CellCount;
        }
    }
}
