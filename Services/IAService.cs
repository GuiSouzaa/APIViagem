using APIViagem.Models;
using System.Collections.Generic;

namespace APIViagem.Services
{
    public class IAService
    {
        public List<ResultadoViagem> ObterResultadoDaIA(DadosViagem dados)
        {
            
            return new List<ResultadoViagem>
            {
                new ResultadoViagem
                {
                    Rota = $"{dados.LocalPartida} -> {dados.LocalDestino}",
                    DistanciaKM = 10.0,
                    TempoEstimado = "1h 40min",
                    TipoTransporte = "Taxi",
                    PrecoEstimado = 100.00  
                },
                new ResultadoViagem
                {
                    Rota = $"{dados.LocalPartida} -> {dados.LocalDestino}",
                    DistanciaKM = 12.0,
                    TempoEstimado = "1h 50min",
                    TipoTransporte = "Uber",
                    PrecoEstimado = 108.00  
                },
                new ResultadoViagem
                {
                    Rota = $"{dados.LocalPartida} -> {dados.LocalDestino}",
                    DistanciaKM = 9.5,
                    TempoEstimado = "1h 35min",
                    TipoTransporte = "99",
                    PrecoEstimado = 115.00  
                },
                new ResultadoViagem
                {
                    Rota = $"{dados.LocalPartida} -> {dados.LocalDestino}",
                    DistanciaKM = 11.5,
                    TempoEstimado = "1h 45min",
                    TipoTransporte = "Taxi",
                    PrecoEstimado = 125.00  
                },
                new ResultadoViagem
                {
                    Rota = $"{dados.LocalPartida} -> {dados.LocalDestino}",
                    DistanciaKM = 14.0,
                    TempoEstimado = "2h 00min",
                    TipoTransporte = "Uber",
                    PrecoEstimado = 140.00  
                },
                new ResultadoViagem
                {
                    Rota = $"{dados.LocalPartida} -> {dados.LocalDestino}",
                    DistanciaKM = 16.0,
                    TempoEstimado = "2h 15min",
                    TipoTransporte = "99",
                    PrecoEstimado = 160.00  
                }
            };
        }
    }
}
