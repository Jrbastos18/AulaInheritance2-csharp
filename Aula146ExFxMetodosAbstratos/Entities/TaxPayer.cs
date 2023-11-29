namespace Aula146ExFxMetodosAbstratos.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        //Construtores
        public TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        //Método abstrato
        public abstract double Tax();//Quando criando um método abstrato, não retorna valor e tem que finalizar com ponto e virgula ';'


    }
}
