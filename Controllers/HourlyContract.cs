namespace WebApiEEP.Controllers
{
    public class HourlyContract:Contract
    {
        public HourlyContract(ContractType contractType, double hourlySalary, double monthlySalary) =>
            (this.contractType, this.hourlySalary, this.monthlySalary ) = 
            (contractType, hourlySalary, monthlySalary);
        
        public override double getYearlySalary()
        {
            return 120 * this.hourlySalary * 12;
        }

        public override string ToString()
        {
            return $"{contractType}";
        }
        
    }
}