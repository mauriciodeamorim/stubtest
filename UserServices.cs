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
            internal get { if (this.managerStore == null) { this.managerStore = GetDefaultManager(); } return this.managerStore; }
            set { managerStore=value; }
        }

        public int RemoveStore(User user)
        {
            if (user == null)
            {
                throw (new NullReferenceException("Argument is null."));
            }

            return ManagerStore.Remove(user);
        }

        protected IManagerStore GetDefaultManager()
        {
            return new SimpleManagerStore();
        }
    }
}
