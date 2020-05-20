﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

namespace SalesWebMvc.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Vendedor> Vendedores { get; set; } = new List<Vendedor>();

        public Departamento()
        {
        }

        public Departamento(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void AddVendedor(Vendedor vendendor)
        {
            Vendedores.Add(vendendor);
        }

        public double TotalDeVendas(DateTime inicial, DateTime final)
        {
            return Vendedores.Sum(Vendedor => Vendedor.TotalDeVendas(inicial, final));
        }
    }
}
