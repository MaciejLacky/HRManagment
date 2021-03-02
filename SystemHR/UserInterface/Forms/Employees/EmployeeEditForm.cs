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
    public partial class EmployeeEditForm : BaseAddEditForm
    {
        #region Fields
        private EmployeeModel employee;
        public EventHandler ReloadEmployees;
        #endregion
        #region Ctor
        public EmployeeEditForm(int employeeId)
        {
            InitializeComponent();
            InitializeData();

            employee = GlobalConfig.Connection.GetEmployee(employeeId);
            PrepareEmployeeData(employee);
            
            ValidateControls();
        }

        private void PrepareEmployeeData(EmployeeModel employee)
        {
            txtLastName.Text = employee.LastName;
            txtFirstName.Text = employee.FirstName;
            cmbGender.Text = employee.Gender != null ? employee.Gender.Value : null;
            dtbDateBirth.SetDateTimePickerValue(employee.DateBirth);
            txtPesel.Text = employee.Pesel;
            txtPhoneNumber.Text = employee.PhoneNumber;
            txtEmailAdress.Text = employee.EmailAdress;
            txttIdentityCardNumber.Text = employee.IdentityCardNumber;
            dtpIssueIdentityCardNumber.SetDateTimePickerValue(employee.IssueDateIdentityCard);
            dtpExpiredIdentityCardNumber.SetDateTimePickerValue(employee.ExpirationDateIdentityCard);
            txtPassportNumber.Text = employee.PassportNumber;
            dtpIssueDatePassport.SetDateTimePickerValue(employee.IssueDatePassport);
            dtpExpirationDatePassport.SetDateTimePickerValue(employee.ExpirationDatePassport);

            lblEditEmployee.Text = $"{employee.FirstName} {employee.LastName} ({employee.Code.ToString().PadLeft(4, '0')}) - {employee.Status.ToString()}";
        }


        #endregion
        #region Methods

        private EmployeeModel GetFakeEmployee(int employeeId)
        {
            IList<EmployeeModel> fakeEmployessModel = new List<EmployeeModel>()
            {
                new EmployeeModel()
                {
                    Id = 1,
                    LastName = "Łącki",
                    FirstName = "Maciej",
                    Code = 1,
                    Gender= new GenderModel("mężczyzna"),
                    DateBirth = new DateTime(1986,10,10),
                    Pesel = "1234567890",
                    EmailAdress = "lacky@lacky.pl",
                    PhoneNumber = "0145689742",
                    IdentityCardNumber = "023 051 482 02515",
                    IssueDateIdentityCard = new DateTime(1986,10,10),
                    ExpirationDateIdentityCard = new DateTime(1986,10,10),
                    PassportNumber = "556548868",
                    IssueDatePassport = new DateTime(1986,10,10),
                    ExpirationDatePassport = new DateTime(1986,10,10),
                    Status = new StatusModel("Wprowadzony")

                },

                 new EmployeeModel()
                {
                    Id = 2,
                    LastName = "Łącka",
                    FirstName = "Magdalena",
                    Code = 2,
                    Gender= new GenderModel("kobieta"),
                    DateBirth = new DateTime(1986,10,10),
                    Pesel = "2234567890",
                    EmailAdress = "lacka@lacka.pl",
                    PhoneNumber = "0145689742",
                    IdentityCardNumber = "023 051 482 02516",
                    IssueDateIdentityCard = new DateTime(1986,10,10),
                    ExpirationDateIdentityCard = new DateTime(1986,10,10),
                    PassportNumber = "656548868",
                    IssueDatePassport = new DateTime(1986,10,10),
                    ExpirationDatePassport = new DateTime(1986,10,10),
                    Status = new StatusModel("Wprowadzony")

                }
            };

            EmployeeModel fakeEmployeeModel = fakeEmployessModel.Where(x => x.Id == employeeId).FirstOrDefault();
            return fakeEmployeeModel;
        }

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
            if (!string.IsNullOrWhiteSpace(txtPesel.Text) && !ValidatorsHelper.IsValidPESEL(txtPesel.Text))
            {
                epPesel.SetError(txtPesel, "Cyfra kontrolna numeru pesel jest nieprawidłowa");
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

                employee.LastName = txtLastName.Text;
                employee.FirstName = txtFirstName.Text;
                employee.Gender = new GenderModel(cmbGender.Text);
                employee.DateBirth = dtbDateBirth.Value;
                employee.Pesel = txtPesel.Text;
                employee.PhoneNumber = txtPhoneNumber.Text;
                employee.EmailAdress = txtEmailAdress.Text;
                employee.IdentityCardNumber = txttIdentityCardNumber.Text;
                employee.IssueDateIdentityCard = dtpIssueIdentityCardNumber.Value;
                employee.ExpirationDateIdentityCard = dtpExpiredIdentityCardNumber.Value;
                employee.PassportNumber = txtPassportNumber.Text;
                employee.IssueDatePassport = dtpIssueDatePassport.Value;
                employee.ExpirationDatePassport = dtpExpirationDatePassport.Value;                           
               //employee = ModifyEmployee(employee);
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
