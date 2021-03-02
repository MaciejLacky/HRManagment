using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemHR.DataAccessLayer.Models.Dictionaries;

namespace SystemHR.DataAccessLayer.Models
{
    public class ContractsModel : EntityModel
    {
        public Dictionaries.TypeContractModel TypeContract { get; set; }
        public DateTime ConclusionDate { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public TypeContractModel Position { get; set; }
        public DepartmentModel Department { get; set; }
        public decimal Salary { get; set; }
        public CurrencyModel Currency { get; set; }
        public TypeRateModel TypeRate { get; set; }
        public TerminationWayModel TerminationWay { get; set; }
    }
}
