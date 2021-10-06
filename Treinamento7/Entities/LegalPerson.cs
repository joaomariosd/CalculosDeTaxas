using System;


namespace Treinamento7.Entities
{
    class LegalPerson : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public LegalPerson()
        {

        }

        public LegalPerson(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double sum = 0.0;
            if (NumberOfEmployees > 10)
            {
                sum += AnualIncome * 0.14;
            } else
            {
                sum += AnualIncome * 0.16;
            }
            return sum;
        }

    }
}
