using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    public class ContaCorrente : Conta
    {
        public double LimiteCredito;

        public override void Depositar(double valor)
        {
            Console.WriteLine("Valor Que deseja Depositar:");
            valor = double.Parse(Console.ReadLine());
            Saldo = Saldo + valor;
            Console.WriteLine($"Valor Depositado com sucesso!!\n Saldo Atual: {Saldo}");
        }
        public override bool Sacar(double valor)
        {
            Console.WriteLine("Quantos deseja Sacar?");
            valor = double.Parse(Console.ReadLine());

            if (valor > 0 && valor <= Saldo+LimiteCredito)
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

            Console.WriteLine("------------------Conta Corrente-------------------");
            Console.WriteLine($"Titular: {Titular}" +
                              $"\nSaldo: {Saldo}");
            Console.WriteLine("----------------------------------------------------");
        }
    }
}
