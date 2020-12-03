using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HummanResourcesManagement.Models
{
    public interface IFRepository
    {
        IQueryable<Employee> Employees { get; }
    }
}
