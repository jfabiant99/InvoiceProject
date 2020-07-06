using AutoMapper;
using Domain;
using InvoiceAPI.Models.Request;
using InvoiceAPI.Models.Response;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace InvoiceAPI.Controllers
{
    public class ProductController : ApiController
    {
        private ProductService service = new ProductService();

        public List<Product_Response_v1> Get()
        {
            //Mapper
            //Transforma un objeto de un tipo (Product) a otro tipo (ProductResponse)
            var response = (from c in service.Get()
                            select
                            new Product_Response_v1
                            {
                                ProductID = c.ProductID,
                                ProductName = c.ProductName,
                                Price = c.Price,
                                Stock = c.Stock
                            }).ToList();
            return response;
        }

        public void Post([FromBody] Product_Request_v1 request)
        {
            //Ingreso un objeto de tipo Product_Request_v1
            //TRANSFORMAR
            //Necesito un objeto de tipo Product
            Product product = new Product();
            product.ProductName = request.ProductName;
            product.Price = request.Price;
            product.Stock = request.Stock;
            service.Insert(product);
        }

    }
}
