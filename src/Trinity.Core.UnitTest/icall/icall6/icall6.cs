using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using Trinity;
using Trinity.Storage;

namespace icall6
{
    public class icall6
    {
        [Fact]
        public void icall_loadcell()
        {
            byte[] content;
            ushort type;
            var val = Global.LocalStorage.LoadCell(0, out content, out type);
        }
    }
}
