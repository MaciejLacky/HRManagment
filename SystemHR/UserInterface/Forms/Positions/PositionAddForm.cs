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
    public partial class PositionAddForm : BaseAddModifyPositions
    {
        #region Fields
        public EventHandler ReloadPositions;
        #endregion
        #region Ctor
        public PositionAddForm()
        {
            InitializeComponent();
            ValidateControls();
        }
        #endregion
        #region Methods
        private void ValidateControls()
        {
            if (string.IsNullOrWhiteSpace(tbAddNamePosition.Text))
            {
                eppositionName.SetError(tbAddNamePosition, "Pole nazwa stanowiska nie może być puste. ");
            }
            else
            {
                eppositionName.Clear();
            }
            if (nudAddMaxSalaryPosition.Value == 0 || nudAddMaxSalaryPosition.Value < nudAddMinSalaryPosition.Value )
            {
                epMaxSalary.SetError(nudAddMaxSalaryPosition, "Pole maksymalne wynagrodzenie nie może być puste lub musi być większe od minimalnego wynagrodzenia. ");
            }
            else
            {
                epMaxSalary.Clear();
            }
            if (nudAddMinSalaryPosition.Value == 0 || nudAddMinSalaryPosition.Value > nudAddMaxSalaryPosition.Value )
            {
                epMaxSalary.SetError(nudAddMinSalaryPosition, "Pole minimalne wyngrodzenie nie może być puste lub musi być mniejsze od maksymalnego wynagrodzenia. ");
            }
            else
            {
                epMinSalary.Clear();
            }
        }
        private bool ValidateForm()
        {
            StringBuilder sbErrorMessage = new StringBuilder();
            string nameErrorDepartment = eppositionName.GetError(tbAddNamePosition);
            if (!string.IsNullOrEmpty(nameErrorDepartment))
            {
                sbErrorMessage.Append(nameErrorDepartment);
            }
            string MaxSalaryErrorDepartment = epMaxSalary.GetError(nudAddMaxSalaryPosition);
            if (!string.IsNullOrEmpty(MaxSalaryErrorDepartment))
            {
                sbErrorMessage.Append(MaxSalaryErrorDepartment);
            }
            string MinSalaryErrorDepartment = epMinSalary.GetError(nudAddMinSalaryPosition);
            if (!string.IsNullOrEmpty(MinSalaryErrorDepartment))
            {
                sbErrorMessage.Append(MinSalaryErrorDepartment);
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
        private void nudAddMaxSalaryPosition_ValueChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }

        private void nudAddMinSalaryPosition_ValueChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }
        #endregion
        #region Overrides
        protected override void Save()
        {
            if (ValidateForm())
            {
                PositionModel position = new PositionModel()
                {
                    Name = tbAddNamePosition.Text,
                    MaxSalary = nudAddMaxSalaryPosition.Value,
                    MinSalary = nudAddMinSalaryPosition.Value,
                };

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
