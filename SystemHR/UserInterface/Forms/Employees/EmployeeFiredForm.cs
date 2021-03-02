using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemHR.DataAccessLayer.Models.Dictionaries;
using SystemHR.UserInterface.Forms.Employees.Base;

namespace SystemHR.UserInterface.Forms.Employees
{
    public partial class EmployeeFiredForm : BaseAddEditForm
    {
        #region Fields

        #endregion
        #region Ctor
        public EmployeeFiredForm()
        {
            InitializeComponent();
            InitializeData();
            ValidateControls();
        }


        #endregion
        #region Methods
        private void InitializeData()
        {
            IList<TerminationWayModel> terminationWays = new List<TerminationWayModel>()
            {
                new TerminationWayModel("Porozumienie stron"),
                new TerminationWayModel("Wypowiedzenie"),
                new TerminationWayModel("Rozwiązanie bez wypowiedzenia "),
                new TerminationWayModel(string.Empty)
            };
            cmbWayDeleteContract.DataSource = terminationWays;
            cmbWayDeleteContract.Text = string.Empty;
        }
        private void ValidateControls()
        {
            if (cmbWayDeleteContract.Text == string.Empty)
            {
                epWayOfFiredEmployee.SetError(cmbWayDeleteContract, "Pole sposób rozwiązania umowy nie może być puste ");
            }
            else
            {
                epWayOfFiredEmployee.Clear();
            }
           
            if (!(dtbDateDeletContract.Checked) )
            {
                epDateOfFiredEmployee.SetError(dtbDateDeletContract, "Pole data nie może być puste");
                
            }
            else
            {
                epDateOfFiredEmployee.Clear();
            }
        }
        private bool ValidateForm()
        {
            StringBuilder sbErrorMesage = new StringBuilder();
            string WayOfFiredErrorMessage = epWayOfFiredEmployee.GetError(cmbWayDeleteContract);
            if (!string.IsNullOrEmpty(WayOfFiredErrorMessage))
            {
                sbErrorMesage.Append(WayOfFiredErrorMessage);
            }
            string DateOfFiredErrorMessage = epDateOfFiredEmployee.GetError(dtbDateDeletContract);
            if (!string.IsNullOrEmpty(DateOfFiredErrorMessage))
            {
                sbErrorMesage.Append(DateOfFiredErrorMessage);
            }

            if (sbErrorMesage.Length > 0)
            {
                MessageBox.Show(sbErrorMesage.ToString(), "Zwolnienie pracownika", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        #endregion
        #region Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }
        private void dtbDateDeletContract_ValueChanged(object sender, EventArgs e)
        {
           
            dtbDateDeletContract.Format = DateTimePickerFormat.Short;
            ValidateControls();
           

        }

        private void cmbWayDeleteContract_TextChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }
        private void cmbWayDeleteContract_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }
        #endregion
        #region Overrides
        protected override void Save()
        {
            if(ValidateForm())
            {
                MessageBox.Show("Zapisano poprawnie");
            }
           
            Close();
        }

       

        protected override void Cancel()
        {
            MessageBox.Show("Anulowano dokument");
            Close();
        }









        #endregion

     
    }
}
