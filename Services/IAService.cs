using APIViagem.Models;


namespace APIViagem.Services
{
    public class IAService
    {
        public ResultadoViagem ObterResultadoDaIA(DadosViagem dados)
        {
            // Aqui vou apenas simular os dados, no futuro vou realizar a chamada real da IA.
            // Esses valores todos são pegos das minhas classes.
            return new ResultadoViagem
            {
                Rota = $"{dados.LocalPartida} -> {dados.LocalDestino}",
                DistanciaKM = 150.5,
                TempoEstimado = "2h 30min",
                TipoTransporte = "UberX",
                PrecoEstimado = 120.75
            };
        }
    }
}
