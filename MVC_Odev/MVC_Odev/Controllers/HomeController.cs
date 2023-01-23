using Microsoft.AspNetCore.Mvc;
using MVC_Odev.Models;
using System;
    
namespace MVC_Odev.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int id)
        {
            foreach (var product in Data.Database.sepet)
            {
                if (id == product.Id)
                {
                    product.Amount += 1;
                    break;
                }
            }
            return View();
        }

        public IActionResult Products(int id)
        {
            foreach (Product product in Data.Database.products)
            {
                if (product.Id == id)
                {
                    Data.Database.products.Remove(product);
                    break;
                }
            }
            ViewBag.Products = Data.Database.products;
            return View();
        }

        public IActionResult ProductCreate()
        {
            return View();
        }

        [HttpPost]  
        public IActionResult ProductCreate(Product product)
        {
            product.Id = Data.Database.products.Count + 1;
            Data.Database.products.Add(product);  
            return View();
        }

        public IActionResult Customers(string id)
        {
            foreach (Customer customer in Data.Database.customers)
            {
                if (customer.Id == id)
                {
                    Data.Database.customers.Remove(customer);
                    break;
                }
            }
            ViewBag.Customer = Data.Database.customers;
            return View();
        }
        public IActionResult CustomerCreate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CustomerCreate(Customer customer)
        {
            Data.Database.customers.Add(customer);
            return View();
        }

        public IActionResult Orders(int id)
        {
            foreach (Order order in Data.Database.orders)
            {
                if (order.Id == id)
                {
                    Data.Database.orders.Remove(order);
                    break;
                }
            }
            ViewBag.Orders = Data.Database.orders;
            return View();
        }

        public IActionResult Employee(int id)
        {
            foreach (Employee employee in Data.Database.employees)
            {
                if (employee.Id == id)
                {
                    Data.Database.employees.Remove(employee);
                    break;
                }
            }
            ViewBag.Employee = Data.Database.employees;
            return View();
        }

        public IActionResult EmployeeCreate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EmployeeCreate(Employee employee)
        {
            employee.Id = Data.Database.employees.Count + 1;
            Data.Database.employees.Add(employee);
            return View();
        }

        public IActionResult Sepet()
        {
            ViewBag.Sepet = Data.Database.sepet;
            return View();
        }

        [HttpPost]
        public IActionResult Sepet(Order order)
        {
            order.Id = Data.Database.orders.Count + 1;
            order.OrderDate = DateTime.Now;
            Data.Database.orders.Add(order);
            foreach (var item in Data.Database.sepet)
            {
                item.Amount = 0;
            }
            return View();
        }

    }
}
