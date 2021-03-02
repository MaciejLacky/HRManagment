using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemHR.DataAccessLayer;
using SystemHR.DataAccessLayer.Models;
using SystemHR.DataAccessLayer.Models.Dictionaries;
using SystemHR.UserInterface.Classes;
using SystemHR.UserInterface.Extensions;
using SystemHR.UserInterface.Forms.Employees.Base;
using SystemHR.UserInterface.Helpers;

namespace SystemHR.UserInterface.Forms.Employees
{
    public partial class EmployeeAddForm :BaseAddEditForm
    {
        #region Fields
        
        public EventHandler ReloadEmployees;
        #endregion
        #region Ctor
        public EmployeeAddForm()
        {
            InitializeComponent();
            InitializeData();
           
            ValidateControls();
        }
        #endregion
        #region Private Method
        private void ValidateControls()
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                epLastName.SetError(txtLastName, "Pole nazwisko jest wymagane");
            }
            else
            {
                epLastName.Clear();
            }
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                epFirstName.SetError(txtFirstName, "Pole imie jest wymagane");
            }
            else
            {
                epFirstName.Clear();
            }
        }

        private void InitializeData()
        {
            IList<GenderModel> genders = new List<GenderModel>()
            {
                new GenderModel("kobieta"),
                new GenderModel("mężczyzna"),
                new GenderModel(string.Empty)

            };

            bsGender.DataSource = genders;
            cmbGender.Text = string.Empty;
        }

        private bool ValidateForm()
        {
            StringBuilder sbErrorMesage = new StringBuilder();
            string lastNameErrorMessage = epLastName.GetError(txtLastName);
            if (!string.IsNullOrEmpty(lastNameErrorMessage))
            {
                sbErrorMesage.Append(lastNameErrorMessage);
            }
            string firstNameErrorMessage = epFirstName.GetError(txtFirstName);
            if (!string.IsNullOrEmpty(firstNameErrorMessage))
            {
                sbErrorMesage.Append(firstNameErrorMessage);
            }

            if (sbErrorMesage.Length > 0)
            {
                MessageBox.Show(sbErrorMesage.ToString(), "Dodawanie pracownika", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            string peselWarningMessage = epPesel.GetError(txtPesel);
            if (!string.IsNullOrEmpty(peselWarningMessage))
            {
                DialogResult answer = MessageBox.Show(peselWarningMessage + Environment.NewLine + "Czy mimo to chcesz dodać nowego pracownika",
                    "Dodawanie pracownika", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (answer == DialogResult.No)
                {
                    return false;
                }

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
        private void dtb_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtb = sender as DateTimePicker;
            dtb.DateTimePickerValueChanged();


        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }

        private void txtPesel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPesel_Validated(object sender, EventArgs e)
        {
            string pesel = txtPesel.Text;

            if (!string.IsNullOrWhiteSpace(pesel) && !ValidatorsHelper.IsValidPESEL(pesel))
            {
                epPesel.SetError(txtPesel, "Cyfra kontrolna numeru pesel jest nieprawidłowa");
            }
            else
            {
                epPesel.Clear();
            }
        }
        #endregion

        #region Overrides
        protected override void Save()
        {
            if (ValidateForm())
            {
                EmployeeModel employee = new EmployeeModel()
                {
                    LastName = txtLastName.Text,
                    FirstName = txtFirstName.Text,
                    Gender = new GenderModel(cmbGender.Text),
                    DateBirth = dtbDateBirth.Value,
                    Pesel = txtPesel.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    EmailAdress = txtEmailAdress.Text,
                    IdentityCardNumber = txtIdentityCardNumber.Text,
                    IssueDateIdentityCard = dtpIssueDateIdentityCardNumber.Value,
                    ExpirationDateIdentityCard = dtpExpirationDateIdentityCard.Value,
                    PassportNumber = txtPassportNumber.Text,
                    IssueDatePassport = dtpIssueDatePassport.Value,
                    ExpirationDatePassport = dtpExpirationDatePassport.Value,
                    Status = new StatusModel("Wprowadzony")


                };
                //employee = CreateEmployee(employee);
                employee.Id = 4;
                employee.Code = 4;
                ReloadEmployees?.Invoke(btnSave, new EmployeeEventArgs(employee));
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
