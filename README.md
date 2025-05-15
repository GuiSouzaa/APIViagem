# Fluxograma

![image](https://github.com/user-attachments/assets/cae10f09-afa8-421a-b988-8096e2f961a7)


# 🚗 API de Viagem - C# .NET

Esta é uma API desenvolvida em ASP.NET Core que simula o cálculo de uma rota entre dois locais. Ela recebe dados de partida e destino, e retorna informações como tipo de transporte, distância, tempo estimado e preço — simulando o comportamento de uma IA integrada com a API do Google Maps.

## 🔧 Tecnologias Utilizadas

- ASP.NET Core
- C#
- Postman
- JSON

## ✅ Testando com o Postman

### Endpoint de Teste

- `GET http://localhost:5136/api/viagem`
  - Retorna: `"API OK!"`

### Endpoint Principal

- `POST http://localhost:5136/api/viagem/calcular-rota`
- Body (JSON):
```json
{
  "LocalPartida": "São Paulo",
  "LocalDestino": "Campinas"
}
```

- Resposta esperada:
```json
{
  "rota": "São Paulo -> Campinas",
  "distanciaKM": 150.5,
  "tempoEstimado": "2h 30min",
  "tipoTransporte": "UberX",
  "precoEstimado": 120.75
}
```

## 📌 Observações

- A lógica atual simula uma resposta da IA. Em versões futuras, vou integrar com a API do Google Maps e lógica de IA real.
