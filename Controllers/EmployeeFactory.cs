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
        private static async Task<List<DataRepository>> loadRepository()
        {
            var repositories = await RepositoryDataAccess.ProcessRepositories();
            return repositories;
        }
        
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
                    contract = new HourlyContract(ContractType.Hourly_Salary, 
                    dataRepo.hourlySalary, dataRepo.monthlySalary);
                else
                    contract = new MonthlyContract(ContractType.Monthly_Salary, 
                    dataRepo.hourlySalary, dataRepo.monthlySalary);

                role = new Role(dataRepo.roleId, dataRepo.roleName, dataRepo.roleDescription);
                employee = new Employee(dataRepo.id, dataRepo.name, contract, role);
                employees.Add(employee);    
            }
            return employees;

        }    

            
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
                    contract = new HourlyContract(ContractType.Hourly_Salary,
                    dataRepo.hourlySalary, dataRepo.monthlySalary);
                else
                    contract = new MonthlyContract(ContractType.Monthly_Salary, 
                    dataRepo.hourlySalary, dataRepo.monthlySalary);

                role = new Role(dataRepo.roleId, dataRepo.roleName, dataRepo.roleDescription);
                employee = new Employee(dataRepo.id, dataRepo.name, contract, role);
                employees.Add(employee);    

            }
            
            return employees;
        }

    }
}