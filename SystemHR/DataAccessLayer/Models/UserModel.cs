using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemHR.DataAccessLayer.Models
{
    public class UserModel : EntityModel
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string EmailAdress { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public bool IsAdministrator { get; set; }
        public PermissionModel Permission { get; set; }
    }
}
