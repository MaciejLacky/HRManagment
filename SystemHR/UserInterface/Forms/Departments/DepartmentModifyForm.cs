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
    public partial class DepartmentModifyForm : BaseAddModifyForm
    {
        #region Fields
        private DepartmentModel department;
        public EventHandler ReloadDepartment;
        #endregion
        #region Ctor
        public DepartmentModifyForm(int departmentId)
        {
            InitializeComponent();
            //PrepareDepartmentData(department); dane tymaczsowe
            //department = GetFakeDepartment(departmentId);
            ValidateControls();
        }

    
        #endregion
        #region Methods
        private void PrepareDepartmentData(DepartmentModel department)
        {
            tbModifyNameDepartment.Text = department.Name;
            tbLocationModifyDepartment.Text = department.Location;
            lblModifyDepartment.Text = $"Modyfikacja działu: {department.Name}";
        }
        private DepartmentModel GetFakeDepartment(int departmentId)
        {
            IList<DepartmentModel> fakeDepartmentsModel = new List<DepartmentModel>()
            {
                new DepartmentModel()
                {
                    Name = "Sprzedaż",
                    Id = 1,
                    Location = "Biuro"

                },
                 new DepartmentModel()
                {
                    Name = "Promocja",
                    Id = 2,
                    Location = "Biuro"

                },
                  new DepartmentModel()
                {
                    Name = "Zamówienia",
                    Id = 1,
                    Location = "Magazyn"

                }
            };

            DepartmentModel fakeDepartmentModel = fakeDepartmentsModel.Where(x => x.Id == department.Id).FirstOrDefault();
            return fakeDepartmentModel;
        }
        private void ValidateControls()
        {
            if (string.IsNullOrWhiteSpace(tbModifyNameDepartment.Text))
            {
                epNameDepartment.SetError(tbModifyNameDepartment, "Pole nazwa działu jest wymagana");
            }
            else
            {
                epNameDepartment.Clear();
            }
        }
        private bool ValidateForm()
        {
            StringBuilder sbErrorMessage = new StringBuilder();
            string nameErrorDepartment = epNameDepartment.GetError(tbModifyNameDepartment);
            if (!string.IsNullOrEmpty(nameErrorDepartment))
            {
                sbErrorMessage.Append(nameErrorDepartment);
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
        #endregion
        #region Overrides
        protected override void Save()
        {
            if (ValidateForm())
            {


                department.Name = tbModifyNameDepartment.Text;
                department.Location = tbLocationModifyDepartment.Text;
                //Manager = tbManagerAddDepartment.Text,


               
                //department = ModifyDepartment(department);
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
