using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemHR.DataAccessLayer.Models;
using SystemHR.UserInterface.Classes;
using SystemHR.UserInterface.Forms.Departments.Base;

namespace SystemHR.UserInterface.Forms.Departments
{
    public partial class DepartmentAddForm : BaseAddModifyForm
    {
        #region Fields
        public EventHandler ReloadDepartment;
        #endregion
        #region Ctor
        public DepartmentAddForm()
        {
            InitializeComponent();
            ValidateControls();
        }
        #endregion
        #region Methods
        private void ValidateControls()
        {
            if (string.IsNullOrWhiteSpace(tbAddNameDepartment.Text))
            {
                epNameDepartment.SetError(tbAddNameDepartment, "Pole nazwa działu jest wymagana. ");
            }
            else
            {
                epNameDepartment.Clear();
            }
            if (string.IsNullOrWhiteSpace(tbManagerAddDepartment.Text))
            {
                epManagerDepartment.SetError(tbManagerAddDepartment, "Pole manager działu jest wymagana. ");
            }
            else
            {
                epManagerDepartment.Clear();
            }
            if (string.IsNullOrWhiteSpace(tbDepartmentAdd.Text))
            {
                epMainDepartment.SetError(tbDepartmentAdd, "Pole nazwa nadrzędnego działu jest wymagana. ");
            }
            else
            {
                epMainDepartment.Clear();
            }
        }
        private bool ValidateForm()
        {
            StringBuilder sbErrorMessage = new StringBuilder();
            string nameErrorDepartment = epNameDepartment.GetError(tbAddNameDepartment);
            if (!string.IsNullOrEmpty(nameErrorDepartment))
            {
                sbErrorMessage.Append(nameErrorDepartment);
            }
            string managerErrorDepartment = epManagerDepartment.GetError(tbManagerAddDepartment);
            if (!string.IsNullOrEmpty(managerErrorDepartment))
            {
                sbErrorMessage.Append(managerErrorDepartment);
            }
            string mainDepartmentErrorDepartment = epMainDepartment.GetError(tbDepartmentAdd);
            if (!string.IsNullOrEmpty(mainDepartmentErrorDepartment))
            {
                sbErrorMessage.Append(mainDepartmentErrorDepartment);
            }

            if (sbErrorMessage.Length > 0)
            {
                MessageBox.Show(sbErrorMessage.ToString(), "Dodanie działu", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
        private void tbAddNameDepartment_TextChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }

        private void tbManagerAddDepartment_TextChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }

        private void tbDepartmentAdd_TextChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }
        private void btnAddMainDepartment_Click(object sender, EventArgs e)
        {

        }

        private void btnAddEmployeeDepartment_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region Overrides
        protected override void Save()
        {
            if (ValidateForm())
            {
                DepartmentModel department = new DepartmentModel()
                {
                    Name = tbAddNameDepartment.Text,
                    Location = tbLocationAddDepartment.Text,
                    //Manager = tbManagerAddDepartment.Text,


                };

                ReloadDepartment?.Invoke(btnSave, new DepartmentsEventArgs(department));

                
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
