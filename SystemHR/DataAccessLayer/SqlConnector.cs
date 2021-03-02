using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using SystemHR.DataAccessLayer.Models;
using SystemHR.DataAccessLayer.Models.Dictionaries;

namespace SystemHR.DataAccessLayer
{
    public class SqlConnector : IDataConnection
    {
        IList<EmployeeModel> fakeSqlEmployessModel = new List<EmployeeModel>()
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

        public IEnumerable<EmployeeModel> GetEmployees()
        {
            return fakeSqlEmployessModel;
        }

        public EmployeeModel GetEmployee(int id)
        {
            return fakeSqlEmployessModel.Single(x => x.Id == id);
        }

        public EmployeeModel CreateEmployee(EmployeeModel model)
        {
            return model;
        }

        public EmployeeModel ModifyEmployee(EmployeeModel model)
        {
            return model;
        }

        public void RemoveEmployee(int id)
        {

        }
    }
}
