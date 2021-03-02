using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemHR.DataAccessLayer.ViewModels
{
    public class ContractViewModel
    {
        public int Id { get; set; }
        private string lastName { get; set; }
        private string firstName { get; set; }
        public string LastName
        {
            get
            {
                return lastName.ToUpper();
            }
            set
            {
                lastName = value;
            }
        }
        public string FirstName
        {
            get
            {
                return firstName.ToUpper();
            }
            set
            {
                firstName = value;
            }
        }
        public string TypeContract;
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public DateTime ConclusionDate { get; set; }
        public string TerminationWay { get; set; }
    }
}
