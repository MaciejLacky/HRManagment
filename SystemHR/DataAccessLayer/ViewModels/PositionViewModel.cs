using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemHR.DataAccessLayer.ViewModels
{
    public class PositionViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal MaxSalary { get; set; }
        public decimal MinSalary { get; set; }
    }
}
