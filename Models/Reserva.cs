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

        public void CadastrarHospedes(List<Pessoa> pessoas) { }

        public void CadastrarSuite(Suite suite) { }

        public int ObterQuantidadeDeHospedes() { return 0; }
        
        public decimal CalcularValorHospedagem(){ return 1; }
    }
}