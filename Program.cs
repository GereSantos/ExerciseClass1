using System;

namespace ExerciseClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1,p2;

            p1 = new Person();
            p2 = new Person();
            Console.WriteLine("Dados da Primeira pessoa: ");

            p1.Name = Console.ReadLine();
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da Segunda pessoa: ");
            p2.Name = Console.ReadLine();
            p2.Idade = int.Parse(Console.ReadLine());

            if(p1.Idade > p2.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + p1.Name);
            }else if(p2.Idade > p1.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + p2.Name);
            }
        }
    }
}
