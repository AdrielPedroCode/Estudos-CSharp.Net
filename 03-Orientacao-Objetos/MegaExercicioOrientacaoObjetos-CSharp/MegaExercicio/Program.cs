using MegaExercicio;
using System.Globalization;

DadosBancarios Conta;

Console.Write("Entre o Numero Da Conta: ");
int numerodaconta = int.Parse(Console.ReadLine());
Console.Write("Entre o titular da conta: ");
string titular = Console.ReadLine();
Console.Write("havera deposito inicial (s/n) ");
char Resp = char.Parse(Console.ReadLine());
if(Resp == 's' || Resp == 'S') {
    Console.Write("Entre o valor de deposito inicial: ");
    double depositoinicial = double.Parse(Console.ReadLine());
    Conta = new DadosBancarios(numerodaconta, titular, depositoinicial);
}

else { Conta = new DadosBancarios(numerodaconta, titular); }

Console.WriteLine();
Console.WriteLine("Dados da conta:");
Console.WriteLine(Conta);

Console.WriteLine();
Console.Write("Entre um valor para deposito: ");
double deposito = double.Parse(Console.ReadLine());
Conta.Deposito(deposito);

Console.WriteLine("Dados atualizados da conta: ");
Console.WriteLine(Conta);

Console.WriteLine();
Console.Write("Entre um valor para saque: ");
double saque = double.Parse(Console.ReadLine());
Conta.Saque(saque);
Console.WriteLine("Dados Atualizados: ");
Console.WriteLine(Conta);
    



