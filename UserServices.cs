using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stub
{
    public class UserServices
    {

        private IManagerStore managerStore;

        public IManagerStore ManagerStore
        {
            get { return managerStore; }
            internal set { if (managerStore == null) { managerStore = this.GetDefaultManager(); } }
        }

        public int RemoveStore(string storeName)
        {
            return managerStore.Remove(storeName);
        }

        protected IManagerStore GetDefaultManager()
        {
            return new SimpleManagerStore();
        }
    }
}
