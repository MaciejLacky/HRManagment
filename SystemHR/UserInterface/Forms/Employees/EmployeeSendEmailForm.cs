using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemHR.UserInterface.Forms.Employees.Base;

namespace SystemHR.UserInterface.Forms.Employees
{
    public partial class EmployeeSendEmailForm : BaseAddEditForm
    {
        public EmployeeSendEmailForm()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Save();
        }

       
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        protected override void Save()
        {
            
            MessageBox.Show("Wysyłanie wiadomości email zakończono pomyślnie","Wysyłanie wiadomości", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
        protected override void Cancel()
        {
            MessageBox.Show("Wysyłanie wiadomości email zakończone niepowodzeniem","Wysyłanie wiadomości", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            
            
            Close();
            
        }
    }
}
