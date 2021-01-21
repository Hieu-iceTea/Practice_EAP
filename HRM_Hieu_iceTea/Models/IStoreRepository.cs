using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRM_Hieu_iceTea.Models
{
    public interface IStoreRepository
    {
        IQueryable<Employees> Employees { get; }
    }
}
