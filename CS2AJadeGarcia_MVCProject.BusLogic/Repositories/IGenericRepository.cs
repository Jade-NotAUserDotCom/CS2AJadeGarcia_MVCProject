using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS2AJadeGarcia_MVCProject.BusLogic.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        T GetById(int id);
    }
}
