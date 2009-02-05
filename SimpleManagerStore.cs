using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stub
{
    public class SimpleManagerStore: IManagerStore
    {
        public int Remove(User user)
        {
            //if (user.StoreName == "dev-loja01")
            //{
            //    return 0;
            //}
            //else
            //{
            //    return 1;
            //}

            return (user.StoreName == "dev-loja01") ? 0 : 1;
        }
    }
}
