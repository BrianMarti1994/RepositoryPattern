using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOM.Repository.Contract
{
    public interface IRepositoryWrapper
    {
        IUserRepository User { get; }
        IItemRepository Item { get; }

        void Save();
    }
}
