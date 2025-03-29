using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS2AJadeGarcia_MVCProject.BusLogic.Model;
using CS2AJadeGarcia_MVCProject.BusLogic.Repositories;

namespace CS2AJadeGarcia_MVCProject.BusLogic.Service
{
    public class StudentService
    {
        public readonly StudentRepository _studentRepository = new StudentRepository();

        public IEnumerable<TblStudent> GetAll()
        {
            return _studentRepository.GetAll();
        }
        public bool Add(TblStudent student)
        {
            return _studentRepository.Add(student);
        }
     }
}
