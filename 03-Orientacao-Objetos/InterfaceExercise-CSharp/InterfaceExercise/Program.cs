using InterfaceExercise.Entities;
using InterfaceExercise.Services;
using System.Globalization;

Console.WriteLine("Enter contract data:");
Console.Write("Number: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Date (dd/MM/yyyy): ");
DateTime date = DateTime.Parse(Console.ReadLine());
Console.Write("Contract value: ");
double contractlValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Number of installments: ");
int Months = int.Parse(Console.ReadLine());

Contract myContract = new Contract(number, date, contractlValue);

ContractService contractService = new ContractService(new PaypalService());
contractService.ProcessContract(myContract, Months);

Console.WriteLine("Installments:");

foreach(Installment installment in myContract.Installments) {
    Console.WriteLine(installment);
}

