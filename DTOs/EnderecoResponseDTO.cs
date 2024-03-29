﻿using System.Text.Json.Serialization;

namespace IntegracaoBrasilApi.DTOs
{
    public class EnderecoResponseDTO
    {
        public string? Cep { get; set; }

        public string? Estado { get; set; }

        public string? Cidade { get; set; }

        public string? Bairro { get; set; }

        public string? Rua { get; set; }

        [JsonIgnore]
        public string? Servico { get; set; }
    }
}