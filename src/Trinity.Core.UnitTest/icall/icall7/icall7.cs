using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using Trinity;
using Trinity.Storage;

namespace icall7
{
    public class icall7
    {
        [Fact]
        public void icall_instantiate_local_storage()
        {
            var storage = Global.LocalStorage;
        }
    }
}
