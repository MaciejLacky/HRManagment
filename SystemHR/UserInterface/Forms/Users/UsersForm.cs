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

namespace SystemHR.UserInterface.Forms.Users
{
    public partial class UsersForm : BaseAddEditForm
    {
        #region Fields
        private static UsersForm _instance = null;
        #endregion
        #region Propeteries
        public static UsersForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UsersForm();
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
        #region ctor
        public UsersForm()
        {
            InitializeComponent();
        }
        #endregion
        #region Events
        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            UserAddForm frm = new UserAddForm();
            frm.ShowDialog();

        }


        #endregion




    }
}
