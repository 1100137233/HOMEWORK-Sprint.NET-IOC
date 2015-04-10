using KuasCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuasCore.Dao.Impl
{
     public class NewEmployeeDao :IEmployeeDao
    {
         public IList<Employee> GetAllEmployees() {
             List<Employee> allEmployee = new List<Employee>();
             Employee e = new Employee();
             e.Age= 11;
             e.Name = "he";
             e.Id = "1100";
             allEmployee.Add(e);
             return allEmployee;

         }

         public Employee GetEmployeeById(string id) {
             Employee ee = new Employee();
             ee.Id = "12";
             ee.Name =id;
             ee.Age = 15;

             return ee;




         }
    }
}
