using System;

namespace MVC_Odev.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShipVia { get; set; }
        public decimal Freight { get; set; }
        public string ShipAdress { get; set; }

    }
}
