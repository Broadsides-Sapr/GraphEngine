using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using Trinity;
using Trinity.Storage;

namespace icall12
{
    public class icall12
    {
        [Fact]
        public void icall_config_trunkcount_get()
        {
            var val = TrinityConfig.TrunkCount;
        }
    }
}
