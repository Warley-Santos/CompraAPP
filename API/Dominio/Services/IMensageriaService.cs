﻿using System.Threading.Tasks;
using API.Dominio.Model;
using Confluent.Kafka;

namespace API.Dominio.Services
{
    public interface IMensageriaService
    {
        public Task<DeliveryResult<Null, string>> ProcessarPedido(Pedido pedido);
    }
}