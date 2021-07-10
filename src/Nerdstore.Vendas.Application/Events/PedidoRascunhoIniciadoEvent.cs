﻿using System;
using NerdStore.Core.Messages;

namespace Nerdstore.Vendas.Application.Events
{
    public class PedidoRascunhoIniciadoEvent: Event
    {
        public Guid ClientId { get; }

        public Guid PedidoId { get; }

        public PedidoRascunhoIniciadoEvent(Guid clienteId, Guid pedidoId)
        {
            AggregateId = pedidoId;
            ClientId = clienteId;
            PedidoId = pedidoId;
        }
    }
}