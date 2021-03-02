using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemHR.DataAccessLayer.Models
{
    public class PermissionModel : EntityModel
    {
        public bool ShowEmployees {get; set;}
        public bool EditEmployees { get; set; }
        public bool SendEmail { get; set; }
        public bool ShowContracts { get; set; }
        public bool DeleteContracts { get; set; }
        public bool ShowPosition { get; set; }
        public bool EditPosition { get; set; }
        public bool ShowDepartments { get; set; }
        public bool EditDepartments { get; set; }
        public bool ShowOrganizationalStructure { get; set; }
        public bool ShowSalary { get; set; }
        public UserModel User { get; set; }
    }
}
