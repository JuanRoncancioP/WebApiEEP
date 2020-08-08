namespace WebApiEEP.Controllers
{
    public abstract class Contract
    {
        public ContractType contractType {get; set;}
        public double hourlySalary  {get; set;}
        public double monthlySalary {get; set;}
        public abstract double getYearlySalary();
        
    }
}