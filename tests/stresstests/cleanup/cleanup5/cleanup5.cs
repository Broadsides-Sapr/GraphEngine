using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using Trinity;
using Trinity.Storage;

namespace cleanup5
{
    public class cleanup5
    {
        [Theory]
        [InlineData(10)]
        [InlineData(50)]
        [InlineData(100)]
        public void InitUninitStressTest(int count)
        {
            for (int i=0; i<count; ++i)
            {
                Global.Initialize();
                for (int j=0; j<10000; ++j)
                {
                    Global.LocalStorage.SaveCell(j, new byte[128]);
                }
                Global.Uninitialize();
            }
        }
    }
}
