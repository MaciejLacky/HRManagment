using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemHR.DataAccessLayer.Models;
using SystemHR.DataAccessLayer.ViewModels;

namespace SystemHR.UserInterface.Helpers
{
     public class MappingHelper
    {
        public static IList<EmployeeViewModel> MapEmployeeModelToEmployeeViewModel(IEnumerable<EmployeeModel> employeesModel)
        {
            IList<EmployeeViewModel> employeesViewModel = new List<EmployeeViewModel>();

            foreach (EmployeeModel employeeModel in employeesModel)
            {
                EmployeeViewModel employeeViewModel = new EmployeeViewModel();
                employeeViewModel.Id = employeeModel.Id;
                employeeViewModel.LastName = employeeModel.LastName;
                employeeViewModel.FirstName = employeeModel.FirstName;
                employeeViewModel.Code = employeeModel.Code.ToString();
                employeeViewModel.Position = string.Empty;
                employeeViewModel.Status = employeeModel.Status.ToString();
                employeesViewModel.Add(employeeViewModel);
            }

            return employeesViewModel;
        }
        public static EmployeeViewModel MapEmployeeModelToEmployeeViewModel(EmployeeModel employeeModel)
        {
            

           
                EmployeeViewModel employeeViewModel = new EmployeeViewModel();
                employeeViewModel.Id = employeeModel.Id;
                employeeViewModel.LastName = employeeModel.LastName;
                employeeViewModel.FirstName = employeeModel.FirstName;
                employeeViewModel.Code = employeeModel.Code.ToString();
                employeeViewModel.Position = string.Empty;
                employeeViewModel.Status = employeeModel.Status.ToString();
                
            

            return employeeViewModel;
        }
        public static ContractViewModel MapContractModelToContractViewModel(ContractsModel contractModel)
        {



            ContractViewModel contractViewModel = new ContractViewModel();
            //contractViewModel.Id = contractModel.Id;
            contractViewModel.DateFrom = contractModel.DateFrom;
            contractViewModel.DateTo = contractModel.DateTo;
            contractViewModel.ConclusionDate = contractModel.ConclusionDate;
            //contractViewModel.TerminationWay = contractModel.TerminationWay.Value;
            contractViewModel.TypeContract = contractModel.TypeContract.Value;
           
            //contractViewModel.FirstName = EmployeeModel.
            //contractViewModel.LastName = EmployeeModel.



            return contractViewModel;
        }
        

        public static DepartmentViewModel MapDepartmentModelToDepartmentViewModel(DepartmentModel departmentModel)
        {
            DepartmentViewModel departmentViewModel = new DepartmentViewModel();    
            departmentViewModel.Name = departmentModel.Name;
            departmentViewModel.Location = departmentModel.Location;

            return departmentViewModel;
        }

        public static PositionViewModel MapPositionModelToPositionViewModel(PositionModel positionModel)
        {
            PositionViewModel positionViewModel = new PositionViewModel();
            positionViewModel.Name = positionModel.Name;
            positionViewModel.MinSalary = positionModel.MinSalary;
            positionViewModel.MaxSalary = positionModel.MaxSalary;
         
            return positionViewModel;
        }
    }
}
