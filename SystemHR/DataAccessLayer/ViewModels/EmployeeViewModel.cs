﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemHR.DataAccessLayer.Models.Dictionaries;

namespace SystemHR.DataAccessLayer.ViewModels
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        private string lastName { get; set; }
        private string firstName { get; set; }
        public string LastName 
        { 
            get
            {
                return lastName.ToUpper();
            }
            set
            {
                lastName = value;
            }
        }
        public string FirstName 
        { 
            get
            {
                return firstName.ToUpper();
            }
            set
            {
                firstName = value;
            }
        }
        private string code;
        public string Code 
        {
            get { return code.PadLeft(4, '0'); }
            set { code = value; }
        }

        public string Position { get; set; }
        public string Status { get; set; }
    }
}
