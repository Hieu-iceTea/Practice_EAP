using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRM_Hieu_iceTea.Models
{
    public class EFStoreRespository:IStoreRepository
    {
        private StoreDbContext context;
        public EFStoreRespository(StoreDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Employees> Employees => context.Employees;
    }
}
