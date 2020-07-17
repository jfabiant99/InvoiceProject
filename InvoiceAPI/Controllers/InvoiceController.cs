using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Domain;
using InvoiceAPI.Models.Response;
using InvoiceAPI.Models.Request;
using System.Web.Http.Cors;

namespace InvoiceAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class InvoiceController : ApiController
    {
        private InvoiceService service = new InvoiceService();
        public List<Invoice_Response_v1> Get()
        {
           
            //Mapper
            var response = (from c in service.Get()
                            select
                            new Invoice_Response_v1
                            {
                                InvoiceID= c.InvoiceID,
                                Date = c.Date,
                                InvoiceNumber = c.InvoiceNumber,
                                Details=c.Details
                            }).ToList();
            return response;
        }
        public Invoice_Response_v1 Get(int id)
        {
            Invoice invoice = service.GetById(id);
            Invoice_Response_v1 response = new Invoice_Response_v1();
            response.InvoiceID =invoice.InvoiceID;
            response.Date = invoice.Date;
            response.InvoiceNumber = invoice.InvoiceNumber;
            response.Details = invoice.Details;
         
            return response;
        }
        public void Post([FromBody] Invoice_Request_v1 request)
        {
            Invoice invoice = new Invoice();
            invoice.Date = request.Date;
            invoice.InvoiceNumber = request.InvoiceNumber;
            
            service.Insert(invoice);
        }
        [HttpPost]
        public void Update([FromBody] Invoice request)
        {
            service.Update(request, request.InvoiceID);
        }
        [HttpPost]
        public void Delete([FromBody] Invoice request)
        {
            service.Delete(request.InvoiceID);
        }
    }
}
