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
using SystemHR.DataAccessLayer.Models.Dictionaries;
using SystemHR.UserInterface.Classes;
using SystemHR.UserInterface.Extensions;
using SystemHR.UserInterface.Forms.Contracts.Base;
using SystemHR.UserInterface.Forms.Employees;
using SystemHR.UserInterface.Forms.Employees.Base;

namespace SystemHR.UserInterface.Forms.Contracts
{

  
    public partial class ContractAddForm : BaseAddViewContract
    {
        #region Fields
        public EventHandler ReloadContracts;
        #endregion
        #region Ctor
        public ContractAddForm()
        {
            InitializeComponent();
            InitializeData();
            ValidateControls();
        }

       
        #endregion
        #region Methods
        private void InitializeData()
        {
            IList<TypeContractModel> typeContract = new List<TypeContractModel>()
            {
                new TypeContractModel("Umowa o prace"),
                new TypeContractModel("Umowa zlecenie"),
                new TypeContractModel("Umowa o dzieło"),
                new TypeContractModel(string.Empty)

            };
            bsTypeContract.DataSource = typeContract;
            cmbGenreAddContract.Text = string.Empty;

            IList<CurrencyModel> currencies = new List<CurrencyModel>()
            {
                new CurrencyModel("zł"),
                new CurrencyModel("EUR"),
                new CurrencyModel("$"),
                new CurrencyModel(string.Empty)

            };

            bsCurrency.DataSource = currencies;
            cbCurrencyOfSalaryAddContract.Text = string.Empty;

            IList<TypeRateModel> typeRate = new List<TypeRateModel>()
            {
                new TypeRateModel("godzinowa"),
                new TypeRateModel("akord"),
                new TypeRateModel(string.Empty)

            };

            bsRate.DataSource = typeRate;
            cbRateOfSalaryAddContract.Text = string.Empty;

        }

        private void ValidateControls()
        {
            if (string.IsNullOrWhiteSpace(txtFirstNameAddContract.Text))
            {
                epFirstName.SetError(txtFirstNameAddContract, "Pole imie nie może byc puste");
            }
            else
            {
                epFirstName.Clear();
            }
            if (string.IsNullOrWhiteSpace(txtLastNameAddContract.Text))
            {
                epLastName.SetError(txtLastNameAddContract, "Pole nazwisko nie może byc puste");
            }
            else
            {
                epLastName.Clear();
            }
            if (string.IsNullOrWhiteSpace(txtSalaryAddContract.Text))
            {
                epSalary.SetError(txtSalaryAddContract, "Pole wynagrodzenie nie może byc puste");
            }
            else
            {
                epSalary.Clear();
            }
            if (cmbGenreAddContract.Text == string.Empty)
            {
                epGenreContract.SetError(cmbGenreAddContract, "Pole rodzaj umowy nie może być puste");
            }
            else
            {
                epGenreContract.Clear();
            }
            if (!(dtpIssueDateAddContract.Checked))
            {
                epDateAddContract.SetError(dtpIssueDateAddContract, "Pole data nie może być puste");

            }
            else
            {
                epDateAddContract.Clear();
            }
            if (!(dtpDateFromAddContract.Checked))
            {
                epDateFromContract.SetError(dtpDateFromAddContract, "Pole data nie może być puste");

            }
            else
            {
                epDateFromContract.Clear();
            }
            if (!(dtpDateToAddContract.Checked))
            {
                epDateToContract.SetError(dtpDateToAddContract, "Pole data nie może być puste");

            }
            else
            {
                epDateToContract.Clear();
            }
            if (cbCurrencyOfSalaryAddContract.Text == string.Empty)
            {
                epCurrencyContract.SetError(cbCurrencyOfSalaryAddContract, "Pole waluta nie może być puste");
            }
            else
            {
                epCurrencyContract.Clear();
            }
            if (cbRateOfSalaryAddContract.Text == string.Empty)
            {
                epRateSalaryContract.SetError(cbRateOfSalaryAddContract, "Pole waluta nie może być puste");
            }
            else
            {
                epRateSalaryContract.Clear();
            }

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
        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = sender as DateTimePicker;
            dtp.DateTimePickerValueChanged();
            ValidateControls();
            
        }
        private void txtFirstNameAddContract_TextChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }

        private void txtLastNameAddContract_TextChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }
        private void txtSalaryAddContract_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtSalaryAddContract_TextChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }
        private void cmbGenreAddContract_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }
        private void cbCurrencyOfSalaryAddContract_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateControls();

        }

        private void cbRateOfSalaryAddContract_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateControls();

        }

        #endregion
        #region Overrides
        protected override void Save()
        {
            if (ValidateForm())
            {
                ContractsModel contract = new ContractsModel()
                {
                    ConclusionDate = dtpIssueDateAddContract.Value,
                    DateFrom = dtpDateFromAddContract.Value,
                    DateTo = dtpDateToAddContract.Value,
                    Salary = Convert.ToDecimal(txtSalaryAddContract.Text),
                    Currency = new CurrencyModel(cbCurrencyOfSalaryAddContract.Text),
                    TypeContract = new TypeContractModel(cmbGenreAddContract.Text),
                    TypeRate = new TypeRateModel(cbRateOfSalaryAddContract.Text),
                    
                    

                };

                //contract.Id = 4;

                ReloadContracts?.Invoke(btnSave, new ContractEventArgs(contract));
               
            }
            Close();

        }

        private bool ValidateForm()
        {
            StringBuilder sbErrorMessage = new StringBuilder();

            string lastNameErrorMessage = epLastName.GetError(txtLastNameAddContract);
            if (!string.IsNullOrEmpty(lastNameErrorMessage))
            {
                sbErrorMessage.Append(lastNameErrorMessage + ". ");
            }
            string firstNameErrorMessage = epFirstName.GetError(txtFirstNameAddContract);
            if (!string.IsNullOrEmpty(firstNameErrorMessage))
            {
                sbErrorMessage.Append(firstNameErrorMessage + ". ");
            }
            string salaryErrorMessage = epSalary.GetError(txtSalaryAddContract);
            if (!string.IsNullOrEmpty(salaryErrorMessage))
            {
                sbErrorMessage.Append(salaryErrorMessage + ". ");
            }
            string genreContractErrorMessage = epGenreContract.GetError(cmbGenreAddContract);
            if (!string.IsNullOrEmpty(genreContractErrorMessage))
            {
                sbErrorMessage.Append(genreContractErrorMessage + ". ");
            }
            string IssueDateContractErrorMessage = epDateAddContract.GetError(dtpIssueDateAddContract);
            if (!string.IsNullOrEmpty(IssueDateContractErrorMessage))
            {
                sbErrorMessage.Append(IssueDateContractErrorMessage + ". ");
            }
            string DateFromContractErrorMessage = epDateFromContract.GetError(dtpDateFromAddContract);
            if (!string.IsNullOrEmpty(DateFromContractErrorMessage))
            {
                sbErrorMessage.Append(DateFromContractErrorMessage + ". ");
            }
            string DateToContractErrorMessage = epDateToContract.GetError(dtpDateToAddContract);
            if (!string.IsNullOrEmpty(DateToContractErrorMessage))
            {
                sbErrorMessage.Append(DateToContractErrorMessage + ". ");
            }
            string currencyContractErrorMessage = epCurrencyContract.GetError(cbCurrencyOfSalaryAddContract);
            if (!string.IsNullOrEmpty(currencyContractErrorMessage))
            {
                sbErrorMessage.Append(currencyContractErrorMessage + ". ");
            }
            string rateOfSalaryContractErrorMessage = epRateSalaryContract.GetError(cbRateOfSalaryAddContract);
            if (!string.IsNullOrEmpty(rateOfSalaryContractErrorMessage))
            {
                sbErrorMessage.Append(rateOfSalaryContractErrorMessage + ". ");
            }


            if (sbErrorMessage.Length >0)
            {
                MessageBox.Show(sbErrorMessage.ToString(), "Dodawanie umowy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;

        }

        protected override void Cancel()
        {
            MessageBox.Show("Anulowano dokument");
            Close();
        }


        #endregion

        private void btnAddEmployeeContract_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPositionContract_Click(object sender, EventArgs e)
        {

        }

        private void btnAddDepartmentContract_Click(object sender, EventArgs e)
        {

        }
    }
}
