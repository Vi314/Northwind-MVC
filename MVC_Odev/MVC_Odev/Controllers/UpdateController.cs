using Microsoft.AspNetCore.Mvc;
using MVC_Odev.Models;

namespace MVC_Odev.Controllers
{
    public class UpdateController:Controller
    {
        public IActionResult UpdateOrder(int id)
        {
            Order updated = new Order();
            foreach (Order order in Data.Database.orders)
            {
                if (order.Id == id)
                {
                    updated = order;
                    break;
                }
            }
            return View(updated);   
        }
        [HttpPost]
        public IActionResult UpdateOrder(Order order)
        {
            foreach (Order item in Data.Database.orders)
            {
                if (item.Id == order.Id)
                {
                    item.OrderDate = order.OrderDate;
                    item.ShipAdress = order.ShipAdress;
                    item.Freight = order.Freight;
                    item.CustomerID = order.CustomerID;
                    item.ShipVia = order.ShipVia;
                    break;
                }
            }
            return Redirect("/home/orders");
        }

        public IActionResult UpdateEmployee(int id)
        {
            Employee updated = new Employee();
            foreach (Employee item in Data.Database.employees)
            {
                if (item.Id == id)
                {
                    updated = item;
                    break;
                }
            }
            return View(updated);
        }
        [HttpPost]
        public IActionResult UpdateEmployee(Employee employee)
        {
            foreach (Employee item in Data.Database.employees)
            {
                if (item.Id == employee.Id)
                {
                    item.EmployeeFirstName = employee.EmployeeFirstName;
                    item.EmployeeLastName = employee.EmployeeLastName;
                    item.EmployeeTitle = employee.EmployeeTitle;
                    item.EmployeePhone = employee.EmployeePhone;
                    break;
                }
            }
            return Redirect("/home/employee");
        }

        public IActionResult UpdateCustomer(string id)
        {
            Customer updated = new Customer();
            foreach (Customer item in Data.Database.customers)
            {
                if (item.Id == id)
                {
                    updated = item;
                    break;
                }
            }
            return View(updated);
        }
        [HttpPost]
        public IActionResult UpdateCustomer(Customer customer)
        {
            foreach (Customer item in Data.Database.customers)
            {
                if (item.Id == customer.Id)
                {
                    item.CustomerName = customer.CustomerName;
                    item.CustomerTitle = customer.CustomerTitle;
                    item.CustomerPhone = customer.CustomerPhone;
                    break;
                }
            }
            return Redirect("/home/customers");
        }
        public IActionResult UpdateProduct(int id)
        {
            Product updated = new Product();
            foreach (Product product in Data.Database.products)
            {
                if (product.Id == id)
                {
                    updated = product;
                    break;
                }
            }
            return View(updated);
        }
        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {
            foreach (Product item in Data.Database.products)
            {
                if (item.Id == product.Id)
                {
                    item.ProductName = product.ProductName;
                    item.UnitPrice = product.UnitPrice;
                    item.UnitsInStock = product.UnitsInStock;
                    break;
                }
            }
            return Redirect("/home/products");
        }
    }
}
