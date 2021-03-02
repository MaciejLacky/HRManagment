using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemHR.DataAccessLayer.ViewModels
{
    public class DepartmentViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manager { get; set; }
        public string Location { get; set; }
        public string ParentDepartment { get; set; }
    }
}
