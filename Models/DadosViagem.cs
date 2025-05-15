using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIViagem.Models
{
    // Essa classe recebe os dados de input do app mobile.
    public class DadosViagem
    {
        public string LocalPartida { get; set; }
        public string LocalDestino { get; set; }
    }
}