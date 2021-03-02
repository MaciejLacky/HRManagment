using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemHR.DataAccessLayer.ViewModels
{
    public class SalaryViewModel
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string TypeRate { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
    }
}
