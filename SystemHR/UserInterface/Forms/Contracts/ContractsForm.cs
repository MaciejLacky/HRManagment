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

namespace SystemHR.UserInterface.Forms.Contracts
{
    public partial class ContractsForm : Form
    {
        #region Fields
        private static ContractsForm _instance = null;
        #endregion

        #region Properties
        public static ContractsForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ContractsForm();
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
        public ContractsForm()
        {
            InitializeComponent();
        }
        #endregion
        #region Events
        private void ContractsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ContractAddForm frm = new ContractAddForm();
            frm.ReloadContracts += (s, ea) =>
            {
                ContractEventArgs eventArgs = ea as ContractEventArgs;
                if (eventArgs != null)
                {
                    ContractViewModel contracts = MappingHelper.MapContractModelToContractViewModel(eventArgs.contract);
                    bsContracts.Add(contracts);
                    dgvContracts.ClearSelection();
                    dgvContracts.Rows[dgvContracts.Rows.Count - 1].Selected = true;
                }
            };

            frm.ShowDialog();
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            ContractViewForm frm = new ContractViewForm();
            frm.ShowDialog();
        }


        #endregion

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show("Czy napewno usunąć umowe", "Usuń umowe", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


            if (result == DialogResult.Yes)
            {
                int contractId = Convert.ToInt32(dgvContracts.CurrentRow.Cells["colId"].Value);
                int selectedRowIndex = dgvContracts.CurrentRow.Index;
               
                
                
            }
        }
    }
}
