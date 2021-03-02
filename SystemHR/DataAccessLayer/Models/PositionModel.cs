using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemHR.DataAccessLayer.Models
{
    public class PositionModel : EntityModel
    {
       
        public string Name { get; set; }
        public decimal MaxSalary { get; set; }
        public decimal MinSalary { get; set; }
        public List<ContractsModel> Contracts { get; set; }

    }
}
