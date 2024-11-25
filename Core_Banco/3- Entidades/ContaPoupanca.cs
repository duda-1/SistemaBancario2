using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    public class ContaPoupanca : Conta
    {
        public double TaxaJuros;

        public override void Depositar(double valor)
        {
            Console.WriteLine("Valor Que deseja Depositar:");
            valor = double.Parse(Console.ReadLine());
            Saldo = valor + (Saldo * TaxaJuros);
            Console.WriteLine($"Valor Depositado com sucesso!!\n Saldo Atual: {Saldo}");
        }

        public override bool Sacar(double valor)
        {
            Console.WriteLine("Quantos deseja Sacar?");
            valor = double.Parse(Console.ReadLine());

            if (valor > 0 && valor <= Saldo)
            {
                Saldo = Saldo - valor;
                Console.WriteLine($"Valor retirado com sucesso!! Saldo Atual {Saldo}");
                return true;
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente");
                return false;
            }
        }
        public override void Transferir(double valor, IConta contaDestino)
        {
            if (Sacar(valor))
            {
                contaDestino.Depositar(valor);
            }
        }
        public override void ExibirInformacoes()
        {
            Console.WriteLine("------------------Conta Poupança-------------------");
            Console.WriteLine($"Titular: {Titular}" +
                              $"\nSaldo: {Saldo}");
            Console.WriteLine("----------------------------------------------------");
        }
    }
}
