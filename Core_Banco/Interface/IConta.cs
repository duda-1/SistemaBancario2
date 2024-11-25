using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    public interface IConta
    {
        void Depositar(double valor);
        bool Sacar(double valor);
        void Transferir(double valor, IConta contaDestino);
        void ExibirInformacoes();

    }
}
