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
using SystemHR.DataAccessLayer.ViewModels;
using SystemHR.UserInterface.Classes;
using SystemHR.UserInterface.Forms.Employees.Base;
using SystemHR.UserInterface.Helpers;

namespace SystemHR.UserInterface.Forms.Employees
{
    public partial class EmployeesForm : BaseForm
    {
        #region Fields
        private static EmployeesForm _instance = null;

        private static IList<EmployeeViewModel> fakeEmployees;
        #endregion

        #region Properties
        public static EmployeesForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EmployeesForm();
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

        #region Constructor
        private EmployeesForm()
        {
            InitializeComponent();
            IEnumerable<EmployeeModel> employees = GlobalConfig.Connection.GetEmployees();
            fakeEmployees = MappingHelper.MapEmployeeModelToEmployeeViewModel(employees);
            PrepareEmployeesData();

        }
        #endregion
        #region PrivateMethods
        private void PrepareEmployeesData()
        {
            var fakeEmployeesSorted = fakeEmployees.OrderBy(x => x.Code).ToList();
            bsEmployees.DataSource = new BindingList<EmployeeViewModel>(fakeEmployeesSorted);
            dgvEmployees.DataSource = bsEmployees;
        }

        private IList<EmployeeViewModel> GetFakeEmployess()
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

            return MappingHelper.MapEmployeeModelToEmployeeViewModel(fakeEmployessModel);
        }


        #endregion
        #region Events
        private void EmployeesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            EmployeeAddForm frm = new EmployeeAddForm();
            frm.ReloadEmployees += (s, ea) =>
            {
                EmployeeEventArgs eventArgs = ea as EmployeeEventArgs;
                if (eventArgs != null)
                {
                    EmployeeViewModel employee = MappingHelper.MapEmployeeModelToEmployeeViewModel (eventArgs.Employee);
                    bsEmployees.Add(employee);
                    dgvEmployees.ClearSelection();
                    dgvEmployees.Rows[dgvEmployees.Rows.Count - 1].Selected = true;
                }
            };
            frm.ShowDialog();
            
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            int emplpyeeId = Convert.ToInt32( dgvEmployees.CurrentRow.Cells["colId"].Value);
            int selectedRowIndex = dgvEmployees.CurrentRow.Index;
            EmployeeEditForm frm = new EmployeeEditForm(emplpyeeId);

            frm.ReloadEmployees += (s, ea) =>
            {
                EmployeeEventArgs eventArgs = ea as EmployeeEventArgs;
                if (eventArgs != null)
                {
                    EmployeeViewModel employee = MappingHelper.MapEmployeeModelToEmployeeViewModel(eventArgs.Employee);
                    bsEmployees[selectedRowIndex] = employee;
                    
                }
            };

            frm.ShowDialog();
        }

        private void btnDismiss_Click(object sender, EventArgs e)
        {
            EmployeeFiredForm frm = new EmployeeFiredForm();
            frm.ShowDialog();
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show("Czy napewno usunąć pracownika", "Usuwanie pracownika", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                      

            if(result == DialogResult.Yes )
            {
                int employeeId = Convert.ToInt32(dgvEmployees.CurrentRow.Cells["colId"].Value);
                int selectedRowIndex = dgvEmployees.CurrentRow.Index;

                //RemoveEmployee(employeeId);
                EmployeeViewModel employee = fakeEmployees.Where(x => x.Id == employeeId).FirstOrDefault();
                if (employee != null)
                {
                    bsEmployees.Remove(employee);
                    if (dgvEmployees.Rows.Count > 1)
                    {
                        dgvEmployees.ClearSelection();
                        dgvEmployees.Rows[dgvEmployees.Rows.Count - 1].Selected = true;
                    }

                }
            }
            
           
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            EmployeeSendEmailForm frm = new EmployeeSendEmailForm();
            frm.ShowDialog();
        }


        #endregion


    }
}
