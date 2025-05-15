using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// Essa classe é responsavel para receber os dados já tratados da IA.
namespace APIViagem.Models
{
    public class ResultadoViagem
    {
        public string Rota { get; set; }
        public double DistanciaKM { get; set; }
        public string TempoEstimado { get; set; }
        public string TipoTransporte { get; set; }
        public double PrecoEstimado { get; set; }
    }
}