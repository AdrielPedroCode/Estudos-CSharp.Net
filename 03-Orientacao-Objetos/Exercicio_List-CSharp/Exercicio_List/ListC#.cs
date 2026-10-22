using Exercicio_List;
using System.ComponentModel;

Console.Write("Quantos funcionarios vao se registrar?: ");
int N = int.Parse(Console.ReadLine());

List<Funcionarios> list = new List<Funcionarios>();

for (int i = 0; i < N; i++) {
    Console.WriteLine("Funcionario #" + (i + 1) + ":");
    Console.Write("Id: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Salario: ");
    double salario = double.Parse(Console.ReadLine());
    list.Add(new Funcionarios(id, nome, salario ));
    Console.WriteLine();
}

Console.Write("escolha qual funcionario ira receber um aumento: ");
int ProcurarId = int.Parse(Console.ReadLine());

Funcionarios funcionarios = list.Find(x => x.ID == ProcurarId);
if (funcionarios != null) {
Console.Write("ensira a porcentagem: ");
double porcentagem = double.Parse(Console.ReadLine());
funcionarios.AumentoSalario(porcentagem); 
}
else {
    Console.WriteLine("esse id ja existe!");
}

Console.WriteLine();
Console.WriteLine("Lista Atualizada dos funcionarios: ");
foreach (Funcionarios obj in list) {
    Console.WriteLine(obj);
}



    














