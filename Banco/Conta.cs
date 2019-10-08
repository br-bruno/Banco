using System;

namespace Banco
{
    public class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public Cliente Titular { get; internal set; }

        public Conta()
        {

        }

        public void Deposita (double valor)
        {
            this.Saldo += valor;
        }

        public bool Saca(double valor)
        {
            if (Saldo < valor)
            {
                return false;
            }
            
            
            Saldo -= valor;
            return true;
            
        }
        public bool Transferir(double valor, Conta contaDestino)
        {
            if (Saldo < valor)
            {
                return false;
            }
            
            
            Saldo -= valor;
            contaDestino.Deposita(valor);
            return true;
            
        }
    }
}