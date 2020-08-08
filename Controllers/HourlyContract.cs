namespace WebApiEEP.Controllers
{
    public class HourlyContract:Contract
    {   
        /// <summary>
        /// initialize the attributes of the class. Used to identify the type of contract
        /// and to calculate yearly salary
        /// </summary>
        /// <param name="hourlySalary">Value of hourlySalary</param>
        /// <param name="monthlySalary">Value of monthlySalary</param>
        public HourlyContract(double hourlySalary, double monthlySalary)
        {
            (this.hourlySalary, this.monthlySalary ) = 
            (hourlySalary, monthlySalary);
            this.contractType = ContractType.Hourly_Salary;
        }

        /// <summary>
        /// Apply the formula 120 * hourlySalary * 12 to calculate then yearly salary.
        /// </summary>
        /// <returns>Employee's yearly Salary by type of contract hourlySalary.</returns>
        public override double getYearlySalary()
        {
            return 120 * this.hourlySalary * 12;
        }

        /// <summary>
        /// Return the type of contract as string. The type of contract is 
        /// taken from the enum ContractType.
        /// </summary>
        /// <returns>Type of contract.</returns>
        public override string ToString()
        {
            return $"{contractType}";
        }
        
    }
}