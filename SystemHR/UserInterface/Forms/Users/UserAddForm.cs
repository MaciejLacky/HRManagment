using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemHR.UserInterface.Forms.Users.Base;

namespace SystemHR.UserInterface.Forms.Users
{
    public partial class UserAddForm : BaseAddModifyForm
    {
        public UserAddForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        protected override void Save()
        {
            MessageBox.Show("Zapisano poprawnie");
            Close();
        }
        protected override void Cancel()
        {
            MessageBox.Show("Anulowano dokument");
            Close();
        }
    }
}
