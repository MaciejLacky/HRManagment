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

namespace SystemHR.UserInterface.Forms.Positions
{
    public partial class PositionForm : Form
    {
        #region Fields
        private static PositionForm _instance = null;
        #endregion
        #region Propeteries
        public static PositionForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PositionForm();
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
        public PositionForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void PositionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            PositionAddForm frm = new PositionAddForm();

            frm.ReloadPositions += (s, ea) =>
            {
                PositionsEventArgs eventArgs = ea as PositionsEventArgs;
                if (eventArgs != null)
                {
                    PositionViewModel position = MappingHelper.MapPositionModelToPositionViewModel(eventArgs.position);
                    bsPositions.Add(position);
                    dgvPositions.ClearSelection();
                    dgvPositions.Rows[dgvPositions.Rows.Count - 1].Selected = true;
                }
            };

            frm.ShowDialog();
        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            int positionId = Convert.ToInt32(dgvPositions.CurrentRow.Cells["colId"].Value);
            int selectedRowIndex = dgvPositions.CurrentRow.Index;
            PositionModifyForm frm = new PositionModifyForm();
            frm.ReloadPositions += (s, ea) =>
            {
                PositionsEventArgs eventArgs = ea as PositionsEventArgs;
                if (eventArgs != null)
                {
                    PositionViewModel position = MappingHelper.MapPositionModelToPositionViewModel(eventArgs.position);
                    bsPositions[selectedRowIndex] = position;
                   
                }
            };

            frm.ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            DialogResult result;

            result = MessageBox.Show("Czy napewno usunąć stanowisko", "Usuń stanowisko", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


            if (result == DialogResult.Yes)
            {
                int contractId = Convert.ToInt32(dgvPositions.CurrentRow.Cells["colId"].Value);
                int selectedRowIndex = dgvPositions.CurrentRow.Index;

            }

        }

        #endregion

    }
}
