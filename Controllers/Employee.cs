namespace WebApiEEP.Controllers
{
    public class Employee
    {
        public int id {get; set;}
	    public string name {get; set;}
	    
        private Contract contract;

        private Role role;

        public Employee(int id, string name, Contract contract, Role role ) =>
            (this.id, this.name, this.contract, this.role) = (id, name, contract, role);
        /// <summary>
        /// Return the result of getYearlySalary method from the attribute contract 
        /// </summary>
        /// <returns>Double. Employee's yearly Salary by type of contract.</returns>
        public double getYearlySalary()
        {
            return contract.getYearlySalary();
        }
        public string getContractType()
        {
            return contract.ToString();
        }

        public string getRoleName()
        {
            return role.roleName;
        }
        
    }
}