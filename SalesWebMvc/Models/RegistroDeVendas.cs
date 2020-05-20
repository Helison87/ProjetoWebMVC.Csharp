using SalesWebMvc.Models.Enums;
using System;


namespace SalesWebMvc.Models
{
    public class RegistroDeVendas
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double valorVenda { get; set; }
        public StatusDeVenda Status { get; set; }
        public Vendedor Vendedor { get; set; }

        public RegistroDeVendas()
        {
        }

        public RegistroDeVendas(int id, DateTime date, double valorVenda, StatusDeVenda status, Vendedor vendedor)
        {
            Id = id;
            Date = date;
            this.valorVenda = valorVenda;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
