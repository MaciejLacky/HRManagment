using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemHR.UserInterface.Forms.Contracts;
using SystemHR.UserInterface.Forms.Departments;
using SystemHR.UserInterface.Forms.EmailConfig;
using SystemHR.UserInterface.Forms.Employees;
using SystemHR.UserInterface.Forms.OrganizationalStructure;
using SystemHR.UserInterface.Forms.Positions;
using SystemHR.UserInterface.Forms.Salaries;
using SystemHR.UserInterface.Forms.Users;
using SystemHR.UserInterface.Helpers;

namespace SystemHR.UserInterface.Forms
{


    public partial class MainForm : Form
    {

        #region Fields
        private TabPage _tpEmployees;
        private TabPage _tpContracts;
        private TabPage _tpDepartments;
        private TabPage _tpOrganizationalStructure;
        private TabPage _tpPosition;
        private TabPage _tpSalaries;
        private TabPage _tpUsers;
        
        
        #endregion

        #region Ctor
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion
        #region Events
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void tpGeneral_Click(object sender, EventArgs e)
        {

        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {

            if (EmployeesForm.IsNull)
            {
                _tpEmployees = new TabPage();
                ShowFormInTabPage(_tpEmployees, EmployeesForm.Instance);
            }
            else
            {
                tcTab.SelectedTab = _tpEmployees;
            }

        }

        private void btnContracts_Click(object sender, EventArgs e)
        {

            if (ContractsForm.IsNull)
            {
                _tpContracts = new TabPage();
                ShowFormInTabPage(_tpContracts, ContractsForm.Instance);
            }
            else
            {
                tcTab.SelectedTab = _tpContracts;
            }
        }
        private void btnDepartments_Click(object sender, EventArgs e)
        {
            if (DepartmentsForm.IsNull)
            {
                _tpDepartments = new TabPage();
                ShowFormInTabPage(_tpDepartments, DepartmentsForm.Instance);
            }
            else
            {
                tcTab.SelectedTab = _tpDepartments;
            }
        }

        private void btnOrganizationalStructure_Click(object sender, EventArgs e)
        {
            if (OrganizationalStructureForm.IsNull)
            {
                _tpOrganizationalStructure = new TabPage();
                ShowFormInTabPage(_tpOrganizationalStructure, OrganizationalStructureForm.Instance);
            }
            else
            {
                tcTab.SelectedTab = _tpOrganizationalStructure;
            }
        }

        private void btnPositions_Click(object sender, EventArgs e)
        {
            if (PositionForm.IsNull)
            {
                _tpPosition = new TabPage();
                ShowFormInTabPage(_tpPosition, PositionForm.Instance);
            }
            else
            {
                tcTab.SelectedTab = _tpPosition;
            }
        }
        private void btnSalaries_Click(object sender, EventArgs e)
        {
            if (SalariesForm.IsNull)
            {
                _tpSalaries = new TabPage();
                ShowFormInTabPage(_tpSalaries, SalariesForm.Instance);
            }
            else
            {
                tcTab.SelectedTab = _tpSalaries;
            }
        }
        private void btnUsers_Click(object sender, EventArgs e)
        {
            if (UsersForm.IsNull)
            {
                _tpUsers = new TabPage();
                ShowFormInTabPage(_tpUsers, UsersForm.Instance);
            }
            else
            {
                tcTab.SelectedTab = _tpUsers;
            }
        }
        private void btnEmailConfig_Click(object sender, EventArgs e)
        {
            EmailConfigForm frm = new EmailConfigForm();
            frm.ShowDialog();
        }


        private void tabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                var tabPage = this.tcTab.TabPages[e.Index];
                var tabRect = this.tcTab.GetTabRect(e.Index);


                // draw Close button to all other TabPages

                var closeImage = new Bitmap($"{ResourcesHelper.ResourcesFilePath}\\{ResourcesHelper.CloseButtonName}");
                e.Graphics.DrawImage(closeImage,
                    (tabRect.Right - closeImage.Width),
                    tabRect.Top + (tabRect.Height - closeImage.Height) / 2);
                TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font,
                    tabRect, tabPage.ForeColor, TextFormatFlags.Left);

            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void tabControl_MouseDown(object sender, MouseEventArgs e)
        {
            // Process MouseDown event only till (tabControl.TabPages.Count - 1) excluding the last TabPage
            for (var i = 0; i < this.tcTab.TabPages.Count; i++)
            {
                var tabRect = this.tcTab.GetTabRect(i);
                tabRect.Inflate(-2, -2);
                var closeImage = new Bitmap($"{ResourcesHelper.ResourcesFilePath}\\{ResourcesHelper.CloseButtonName}");
                var imageRect = new Rectangle(
                    (tabRect.Right - closeImage.Width),
                    tabRect.Top + (tabRect.Height - closeImage.Height) / 2,
                    closeImage.Width,
                    closeImage.Height);
                if (imageRect.Contains(e.Location))
                {
                    var frm = tcTab.TabPages[i].Controls[0] as Form;
                    frm.Close();

                    this.tcTab.TabPages.RemoveAt(i);


                    break;
                }
            }
        }
        #endregion

        #region Private Methods
        private void ShowFormInTabPage(TabPage tabPage, Form frm)
        {

            TabPage tpTab = new TabPage();
            tcTab.Controls.Add(tpTab);

            tpTab.Text = frm.Text;
            frm.TopLevel = false;
            frm.Visible = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            tpTab.Controls.Add(frm);
            tcTab.SelectedTab = tpTab;
        }








        #endregion

       
    }
}
