namespace WebApiEEP.Controllers
{
    public class MonthlyContract:Contract
    {
        /// <summary>
        /// Constructor of the class. Initialize atributes
        /// </summary>
        /// <param name="hourlySalary">Value of hourlySalary</param>
        /// <param name="monthlySalary">Value of monthlySalary</param>
        public MonthlyContract(double hourlySalary, double monthlySalary)
        {
            (this.hourlySalary, this.monthlySalary ) = (hourlySalary, monthlySalary);
            contractType = ContractType.Monthly_Salary;
        }

        /// <summary>
        /// Calculates the yearly Salary by this formula
        /// monthlySalary * 12
        /// </summary>
        /// <returns></returns>
        public override double getYearlySalary()
        {
            return this.monthlySalary * 12;
        }

        /// <summary>
        /// return the type of salary
        /// </summary>
        /// <returns>Type of salary</returns>
        public override string ToString()
        {
            return $"{contractType}";
        }
        
    }
}