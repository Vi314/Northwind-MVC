using Microsoft.AspNetCore.DataProtection;
using MVC_Odev.Models;

namespace MVC_Odev.Repository
{
    public class Repository
    {
        public static void SepetOlustur()
        {
            SepetProduct sepetUrun = new SepetProduct();
            foreach (Product product in Data.Database.products)
            {
                sepetUrun.Id = product.Id;
                sepetUrun.Name = product.ProductName;
                sepetUrun.Price = product.UnitPrice;
                sepetUrun.Amount = 0;
                Data.Database.sepet.Add(sepetUrun);
                sepetUrun = new SepetProduct();
            }
        }
    }
}
