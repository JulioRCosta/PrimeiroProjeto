namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
           
        {
            string nome = "julio";
            int idade = 16 ;
            string cidade = "CJO" ;

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("E sua idade mongol?");
            idade= int.Parse(Console.ReadLine());
            Console.WriteLine("De onde c mora?");
            cidade= Console.ReadLine();

            Console.WriteLine("Nome: {0} \n Idade: {1} anos \n Cidade: {2}", nome, idade, cidade);

        }
    }
}
