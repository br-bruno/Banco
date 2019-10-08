using System;
namespace Banco
{
    internal class Funcionario
    {

        public string Nome { get; set; }
        public long Cpf { get; set; }
        public double Salario { get; set; }
        public DateTime DataAdmissao { get; set; }
        public Empresa Empresa { get; set; }

        public Funcionario()
        {

        }
        public double CalculaBonus(double valor)
        {
            return ((double)valor/ 100) * Salario;
        }
        public int TempoDeCasa()
        {
            return (DateTime.Now.Year - DataAdmissao.Year);
        }
    }
}