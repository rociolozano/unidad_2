using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdvancedCsharp.Models;

namespace AdvancedCsharp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
             return View();
        }
        public String Vista()
        {

            return "Navegar a una URL para mostrar un ejemplo";
            
        }
        public ViewResult AutoProperty()
        {
            //crear un nuevo objeto
            //de la clase producto
            Product myProduct = new Product
            {
                //establece el valor de la propiedad
                ProductID = 12,
                Name = "Kayak",
                Description = "Kiosteca blue",
                category = "SPORTS",
                price = 12.5f
            };

            string salida =
                String.Format("{0}-{1}-{2}-{3}-{4:C0}",
                myProduct.ProductID,
            myProduct.Name,
            myProduct.Description,
            myProduct.category,
            myProduct.price);
            //genera la vista
            return View("Results", (object)salida);
        }

        public ViewResult CreateCollection()
        { 
          //Arreglos de String
            string[] stringArray = { "manzana", "naranja", "lima" };
            //Lista
            List<int> intList = new List<int> { 10, 20, 30, 40 };
            //Diccionario
            Dictionary<string, int> myDict = new Dictionary<string, int>
            {
                {"Manzana", 10},
                {"Naranja", 20},
                {"Lima", 30}

            };
            return View("Results", (object)myDict["Naranja"].ToString());
        }

        public ViewResult UseExtension()
        {
            //Creacion e inicializacion de
            //Shopping cart (carrito de compras)
            ShoppingCart cart = new ShoppingCart
            {
                Products = new List<Product>
                {
                    new Product{Name = "Kayak", price = 3250.0f},
                    new Product{Name = "Lentes", price = 1500.0f},
                    new Product{Name = "Balon Football", price = 50.0f},
                    new Product{Name = "Disco Volador", price = 130.0f},
                }
            };
            //obteniendo el total de la compra
            double total = cart.TotalPrices();

            //rendereando vista
            return View("Results", (object)String.Format("Total: {0:c}", total));
        }
    }
}
