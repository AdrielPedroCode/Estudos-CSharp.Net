using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercicio_List {
    internal class Funcionarios {
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionarios(int id, string nome, double salario) {
            ID = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentoSalario(double porcentagem) {
            Salario += Salario * porcentagem / 100.0;
        }

        public override string ToString() {
            return ID
                    + ", "
                    + Nome
                    + ", "
                    + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
