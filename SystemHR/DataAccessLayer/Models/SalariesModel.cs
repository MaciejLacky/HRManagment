using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemHR.DataAccessLayer.Models.Dictionaries;

namespace SystemHR.DataAccessLayer.Models
{
    public class SalariesModel : EntityModel
    {
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public TypeRateModel TypeRate { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public List<EmployeeModel> Employee { get; set; }

    }
}
