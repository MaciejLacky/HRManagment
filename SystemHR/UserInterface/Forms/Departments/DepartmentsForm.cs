using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemHR.DataAccessLayer.ViewModels;
using SystemHR.UserInterface.Classes;
using SystemHR.UserInterface.Helpers;

namespace SystemHR.UserInterface.Forms.Departments
{
    public partial class DepartmentsForm : Form
    {
        #region Fields
        private static DepartmentsForm _instance = null;
        #endregion
        #region Propeteries
        public static DepartmentsForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DepartmentsForm();
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
        public DepartmentsForm()
        {
            InitializeComponent();
        }
        #endregion
        #region Events
        private void DepartmentsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            DepartmentAddForm frm = new DepartmentAddForm();

            frm.ReloadDepartment += (s, ea) =>
            {
                DepartmentsEventArgs eventArgs = ea as DepartmentsEventArgs;
                if (eventArgs != null)
                {
                    DepartmentViewModel department = MappingHelper.MapDepartmentModelToDepartmentViewModel(eventArgs.department);
                    bsDepartment.Add(department);
                    dgvDepartments.ClearSelection();
                    dgvDepartments.Rows[dgvDepartments.Rows.Count - 1].Selected = true;
                }
            };

            frm.ShowDialog();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            int departmentId = Convert.ToInt32( dgvDepartments.CurrentRow.Cells["colId"].Value);
            int selectedRowIdex = dgvDepartments.CurrentRow.Index;
            DepartmentModifyForm frm = new DepartmentModifyForm(departmentId);
            frm.ReloadDepartment += (s, ea) =>
            {
                DepartmentsEventArgs eventArgs = ea as DepartmentsEventArgs;
                if (eventArgs != null)
                {
                    DepartmentViewModel department = MappingHelper.MapDepartmentModelToDepartmentViewModel(eventArgs.department);
                    bsDepartment[selectedRowIdex] = department;
                    
                }
            };

           
            frm.ShowDialog();
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show("Czy napewno usunąć dział", "Usuń dział", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


            if (result == DialogResult.Yes)
            {
                int contractId = Convert.ToInt32(dgvDepartments.CurrentRow.Cells["colId"].Value);
                int selectedRowIndex = dgvDepartments.CurrentRow.Index;

            }
        }



        #endregion


    }
}
