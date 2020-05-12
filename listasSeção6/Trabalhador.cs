using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace listasSeção6
{
    class Trabalhador
    {
        public int Id;
        public string Nome;
        public double Salario;

        public Trabalhador(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentarSalario(int porcentAumento)
        {
            Salario = Salario + Salario * porcentAumento / 100;
        }

        public override string ToString()
        {
            return Id + ", " + Nome + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
