namespace WebApiEEP.Controllers
{
    public class MonthlyContract:Contract
    {
        public MonthlyContract(ContractType contractType, double hourlySalary, double monthlySalary) =>
            (this.contractType, this.hourlySalary, this.monthlySalary ) = 
            (contractType, hourlySalary, monthlySalary);
        
        public override double getYearlySalary()
        {
            return this.monthlySalary * 12;
        }

        public override string ToString()
        {
            return $"{contractType}";
        }
        
    }
}