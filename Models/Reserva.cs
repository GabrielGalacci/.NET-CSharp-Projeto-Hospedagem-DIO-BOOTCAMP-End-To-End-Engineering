using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            Hospedes = hospedes;

            if (Hospedes.Count <= Suite.Capacidade)
            {
                Console.WriteLine($"Hospedes Cadastrados na Suíte {Suite.TipoSuite.ToUpper()}");
                foreach (Pessoa hospede in Hospedes)
                {
                    Console.WriteLine($"Hóspede: {hospede.NomeCompleto.ToUpper()}");
                }
            }
            else
            {
                throw new Exception("Número de Hospedes acima da capacidade da Suíte!");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeDeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorEstadia()
        {
            decimal valorHospedagem = Suite.ValorDiaria * DiasReservados;

            if (DiasReservados >= 10)
            {
                valorHospedagem *= 0.9M;
            }
            return valorHospedagem;
        }
    }
}