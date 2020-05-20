using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Data;
using SalesWebMvc.Models;

namespace SalesWebMvc.Servicos
{
    public class ServicoVendedor
    {
        private readonly SalesWebMvcContext _Context; 

        public ServicoVendedor(SalesWebMvcContext context)
        {
            _Context = context;
        }

        public List<Vendedor> FindAll()
        {
            return _Context.Vendedor.ToList();
        }

    }
}
