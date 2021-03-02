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
using SystemHR.UserInterface.Forms.Positions.Base;

namespace SystemHR.UserInterface.Forms.Positions
{
    public partial class PositionModifyForm : BaseAddModifyPositions
    {
        #region Fields
        private PositionModel position;
        public EventHandler ReloadPositions;
        #endregion
        #region Ctor
        public PositionModifyForm()
        {
            InitializeComponent();
            //PreparePositionData(position); dane tymaczasowe
            ValidateControls();
        }

        private void PreparePositionData(PositionModel position)
        {

            cmbNameModifyPosition.Text = position.Name;
            nudModifyMaxSalaryPosition.Value = position.MaxSalary;
            nudModifyMinSalaryPosition.Value = position.MinSalary;
           
        }
        #endregion


        #region Methods
        private void ValidateControls()
        {
            if (string.IsNullOrWhiteSpace(cmbNameModifyPosition.Text))
            {
                eppositionName.SetError(cmbNameModifyPosition, "Pole nazwa stanowiska nie może być puste");
            }
            else
            {
                eppositionName.Clear();
            }
        }
        private bool ValidateForm()
        {
            StringBuilder sbErrorMessage = new StringBuilder();
            string nameErrorDepartment = eppositionName.GetError(cmbNameModifyPosition);
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
        private void tbAddNamePosition_TextChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }
        #endregion
        #region Overrides
        protected override void Save()
        {
            if (ValidateForm())
            {


                position.Name = cmbNameModifyPosition.Text;
                position.MaxSalary = nudModifyMaxSalaryPosition.Value;
                position.MinSalary = nudModifyMinSalaryPosition.Value;
                

                ReloadPositions?.Invoke(btnSave, new PositionsEventArgs(position));


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
