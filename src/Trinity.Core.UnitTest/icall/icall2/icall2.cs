using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using Trinity;
using Trinity.Storage;

namespace icall2
{
    public class icall2
    {
        [Fact]
        public void icall_committedtrunk()
        {
            var val = Global.LocalStorage.CommittedTrunkMemory;
        }
    }
}
