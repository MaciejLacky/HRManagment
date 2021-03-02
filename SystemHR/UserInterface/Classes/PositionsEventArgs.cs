using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemHR.DataAccessLayer.Models;

namespace SystemHR.UserInterface.Classes
{
    public class PositionsEventArgs : EventArgs
    {
        public PositionModel position { private set; get; }
        public PositionsEventArgs(PositionModel position)
        {
            this.position = position;
        }
    }
}
