using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using Trinity;
using Trinity.Storage;

namespace cleanup3
{
    public class cleanup3
    {
        [Fact]
        public void T1()
        {
            Global.LocalStorage.ResetStorage();
            Global.Uninitialize();
        }
    }
}
