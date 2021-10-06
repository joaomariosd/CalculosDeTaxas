using System;

namespace Treinamento7.Entities
{
    class PhysicalPerson : TaxPayer
    {        
        public double HealthExpenditures { get; set; }

        public PhysicalPerson()
        {

        }
        
        public PhysicalPerson(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double sum = 0.0;
            if (AnualIncome < 20000)
            {
                if (HealthExpenditures != 0)
                {
                    sum += (0.15 * AnualIncome) - (0.5 * HealthExpenditures);
                } else
                {
                    sum += (0.15 * AnualIncome);
                }
            } else
            {
                if (HealthExpenditures != 0)
                {
                    sum += (0.25 * AnualIncome) - (0.5 * HealthExpenditures);
                } else
                {
                    sum += (0.25 * AnualIncome);
                }

            }
            return sum;
        }
    }     
}
