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
        public Product_Response_v1 Get(int id)
        {
            Product product = service.GetById(id);
            Product_Response_v1 response = new Product_Response_v1();
            response.ProductID = product.ProductID;
            response.ProductName = product.ProductName;
            response.Price = product.Price;
            response.Stock = product.Stock;
            return response;
        }
        public void Post([FromBody] Product_Request_v1 request)
        {
            Product product = new Product();
            product.ProductName = request.ProductName;
            product.Price = request.Price;
            product.Stock = request.Stock;
            product.CreatedBy = request.CreatedBy;
            service.Insert(product);
        }

        [HttpPost]
        public void Update([FromBody] Product request)
        {
            service.Update(request, request.ProductID);
        }
        [HttpPost]
        public void Delete([FromBody] Product request)
        {
            service.Delete(request.ProductID);
        }


    }
}
