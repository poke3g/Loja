﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
  class PedidoEstoque
  {
    private Produto prod;
    private double ValorPedido;
    private int Quantidade;
    private bool concluido;

    public PedidoEstoque(Produto prod, int quantidade)
    {
      this.prod = prod;
      this.Quantidade = quantidade;
      this.concluido = true;
      this.ValorPedido = prod.getPrecoCusto() * quantidade;
    }

    public override string ToString()
    {
      return this.prod.getNome() + ":" + this.Quantidade + ":" + this.ValorPedido.ToString("c") + ":Concluido";
    }
  }
}
