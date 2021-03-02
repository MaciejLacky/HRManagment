using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemHR.DataAccessLayer.Models.Dictionaries
{
    public class TypeContractModel : EntityModel
    {
        public string Value { get; set; }

        public TypeContractModel(string value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
