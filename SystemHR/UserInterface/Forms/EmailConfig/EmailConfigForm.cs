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

namespace SystemHR.UserInterface.Forms.EmailConfig
{
    public partial class EmailConfigForm : BaseAddEditForm
    {
        #region Fields
        private static EmailConfigForm _instance = null;
        #endregion
        #region Properties
        public static EmailConfigForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EmailConfigForm();
                }
                return _instance;
            }



        }
        public static bool IsNull
        {
            get
            {
                if (_instance == null)
                {
                    return true;
                }
                return false;
            }

        }
        #endregion
        #region Ctor
        public EmailConfigForm()
        {
            InitializeComponent();
        }
        #endregion
        #region Events
        private void EmailConfigForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
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
            MessageBox.Show("Zapisano poprawnie konfiguracje email");
            Close();
        }
        protected override void Cancel()
        {
            MessageBox.Show("Anulowano konfiguracje email");
            Close();
        }




        #endregion
    }
}
