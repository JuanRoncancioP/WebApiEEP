using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Text.Json;
using System.Linq;
using WebApiEEP.DataAccess;
using WebApiEEP.Models;

namespace WebApiEEP.Controllers
{
    public static class EmployeeFactory
    {
        /// <summary>
        /// Private metod that connects to the API and download de json serialized on 
        /// a data repository list
        /// </summary>
        /// <returns>Returns a lists of Repository</returns>
        private static async Task<List<DataRepository>> loadRepository()
        {
            var repositories = await RepositoryDataAccess.ProcessRepositories();
            return repositories;
        }
        
        /// <summary>
        /// Takes a Repositories List and bulids a List of Employees
        /// for the Employee id given at the parametter
        /// </summary>
        /// <param name="id">Id of the employee</param>
        /// <returns>A list with then employee with id as the parametter if exist
        /// other way returns a List without elements
        /// </returns>
        public static async Task<List<Employee>> getEmployee(int id)
        {
            
            List<Employee> employees;
            List<DataRepository> repositories = await loadRepository();
            
            DataRepository dataRepo = repositories.FirstOrDefault(x=> x.id == id);

            employees = new List<Employee>();
            if (dataRepo != null)
            {
                Employee employee;
                Contract contract;
                Role role;

                if(dataRepo.contractTypeName == "HourlySalaryEmployee")
                    contract = new HourlyContract(dataRepo.hourlySalary, dataRepo.monthlySalary);
                else
                    contract = new MonthlyContract(dataRepo.hourlySalary, dataRepo.monthlySalary);

                role = new Role(dataRepo.roleId, dataRepo.roleName, dataRepo.roleDescription);
                employee = new Employee(dataRepo.id, dataRepo.name, contract, role);
                employees.Add(employee);    
            }
            return employees;

        }    

        /// <summary>
        /// Conects the Api to get a repositories List and bulids a 
        /// List of Employees if exists
        /// </summary>
        /// <returns>Return a List with al employees at the Api</returns>    
        public static async Task<List<Employee>> getEmployees(){
            List<Employee> employees;
            List<DataRepository> repositories = await loadRepository();

            employees = new List<Employee>();

            foreach (var dataRepo in repositories)
            {
                Employee employee;
                Contract contract;
                Role role;

                if(dataRepo.contractTypeName == "HourlySalaryEmployee")
                    contract = new HourlyContract(dataRepo.hourlySalary, dataRepo.monthlySalary);
                else
                    contract = new MonthlyContract(dataRepo.hourlySalary, dataRepo.monthlySalary);

                role = new Role(dataRepo.roleId, dataRepo.roleName, dataRepo.roleDescription);
                employee = new Employee(dataRepo.id, dataRepo.name, contract, role);
                employees.Add(employee);    

            }
            
            return employees;
        }

    }
}