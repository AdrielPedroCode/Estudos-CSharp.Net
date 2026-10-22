using System.Globalization;

namespace MegaExercicio {
    internal class DadosBancarios {
        public int NumeroDaConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo {get; private set;}

        public DadosBancarios(int numerodaconta, string titular) {
            NumeroDaConta = numerodaconta;
            Titular = titular;
        }
        public DadosBancarios(int numerodaconta, string titular, double depositoInicial) : this(numerodaconta, titular) {
            Deposito(depositoInicial);
        }
        public void Deposito(double quantia) {
            Saldo += quantia;
        }
        public void Saque(double quantia) {
            Saldo -= quantia;
            Saldo -= 5;
        }
        public override string ToString() {
            return
                "Conta: "
                + NumeroDaConta +

                ", Titular: "
                + Titular +

                ", Saldo: $"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
