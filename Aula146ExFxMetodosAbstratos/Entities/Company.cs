namespace Aula146ExFxMetodosAbstratos.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployee { get; set; }

        //Construtores
        public Company(string name, double anualIncome, int numberOfEmployee)
            : base(name, anualIncome)
        {
            NumberOfEmployee = numberOfEmployee;
        }

        //Método Abstrato
        public override double Tax()
        {
            if (NumberOfEmployee <= 10)
            {
                return AnualIncome * 0.16;
            }
            else
            {
                return AnualIncome * 0.14;
            }
        }

    }
}
