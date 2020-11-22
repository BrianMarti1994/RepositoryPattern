using ECOM.Data;
using ECOM.Repository.Contract;
using EcomAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOM.Repository
{
    public class ItemRepository : RepositoryBase<EcomAPI.Models.Item>, IItemRepository
    {

        public ItemRepository(EcomRepoContext repoContext)
            : base(repoContext)
        {

        }
    }
}
