using APIViagem.Models;

namespace APIViagem.Services
{
    public static class IAService
    {
        public static Task<object> CalcularMelhorRota(DadosViagem dados)
        {
            // Simulando cálculo inteligente da IA
            var resultado = new
            {
                RotaEscolhida = $"{dados.LocalPartida} -> {dados.LocalDestino}",
                TempoEstimado = "5h 30min",
                CustoEstimado = 350.00,
                RodaRecomendada = "Roda Premium 18\""
            };

            return Task.FromResult<object>(resultado);
        }
    }
}
