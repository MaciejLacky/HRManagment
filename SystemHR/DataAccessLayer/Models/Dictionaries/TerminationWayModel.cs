using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemHR.DataAccessLayer.Models.Dictionaries
{
    public class TerminationWayModel : EntityModel
    {
        public string Value { get; set; }

        public TerminationWayModel(string value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
