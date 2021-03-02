using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemHR.DataAccessLayer.Models
{
    public class DepartmentModel : EntityModel
    {
        public string Name { get; set; }
        public EmployeeModel Manager { get; set; }
        public string Location { get; set; }
        public DepartmentModel ParentDepartment { get; set; }
        public List<ContractsModel> Contracts { get; set; }

    }
}
