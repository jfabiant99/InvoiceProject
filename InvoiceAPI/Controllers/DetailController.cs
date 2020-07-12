using Domain;
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
    public class DetailController : ApiController
    {
        private DetailService service = new DetailService();

        public List<Detail_Response_v1>Get()
        {
            var reponse = (from c in service.Get()
                          select
                          new Detail_Response_v1
                          {
                              DetailID = c.DetailID,
                              Quantity = c.Quantity,
                              Prize = c.Prize,
                              Product = c.Product,
                              Invoice = c.Invoice
                          }).ToList();
            return reponse;
        }
        public Detail_Response_v1 Get(int id)
        {
            Detail detail=service.GetById(id);
            Detail_Response_v1 response = new Detail_Response_v1();
            response.DetailID = detail.DetailID;
            response.Quantity = detail.Quantity;
            response.Prize = detail.Prize;
            response.Product = detail.Product;
            response.Invoice = detail.Invoice;

            return response; 
        }
        public void Post([FromBody] Detail_Response_v1 request)
        {
            Detail detail = new Detail();
            detail.Quantity = request.Quantity;
            detail.Prize = request.Prize;
            
            service.Insert(detail);
        }

        [HttpPost]
        public void Update([FromBody] Detail request)
        {
            service.Update(request, request.DetailID);
        }
        [HttpPost]
        public void Delete([FromBody] Detail request)
        {
            service.Delete(request.DetailID);
        }


    }
}
