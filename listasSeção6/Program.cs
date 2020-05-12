using System;
using System.Collections.Generic;
using System.Globalization;


namespace listasSeção6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Trabalhador> list = new List<Trabalhador>();

            Console.WriteLine("Quantos empregados serão registrados?");
            int qteEmpregados = int.Parse(Console.ReadLine());

            for (int i = 0; i < qteEmpregados; i++)
            {
                Console.Write("Informe o Id do empregado: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Informe o nome do empregado: ");
                string nome = Console.ReadLine();
                Console.Write("Informe o salario do empregado: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Trabalhador(id, nome, salario));
            }

            foreach (Trabalhador trab in list)
            {
                Console.WriteLine(trab);
                Console.WriteLine();
            }

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();


            Console.Write("Entre com o id do empregado que tera aumento do salario: ");
            int idAumento = int.Parse(Console.ReadLine());
            Trabalhador trabAumento = list.Find(x => x.Id == idAumento);


            if (trabAumento == null)
            {
                Console.WriteLine("Este Id não existe");
            }
            else
            {
                Console.Write("Entre com a porcentagem de aumento: ");
                Console.WriteLine();
                int porcAumento = int.Parse(Console.ReadLine());
                trabAumento.AumentarSalario(porcAumento);
            }


            foreach (Trabalhador trab in list)
            {
                Console.WriteLine(trab);
                Console.WriteLine();
            }
        }
    }
}
