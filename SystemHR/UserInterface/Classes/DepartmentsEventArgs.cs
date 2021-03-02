using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemHR.DataAccessLayer.Models;

namespace SystemHR.UserInterface.Classes
{
    public class DepartmentsEventArgs : EventArgs
    {
        public DepartmentModel department { private set; get; }
        public DepartmentsEventArgs(DepartmentModel department)
        {
            this.department = department;
        }
    }
}
