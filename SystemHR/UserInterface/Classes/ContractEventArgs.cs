using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemHR.DataAccessLayer.Models;

namespace SystemHR.UserInterface.Classes
{
    public class ContractEventArgs : EventArgs
    {
        public ContractsModel contract { private set; get; }
        public ContractEventArgs(ContractsModel contract)
        {
            this.contract = contract;
        }
    }
}
