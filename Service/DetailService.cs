using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infraestructure;
using Domain;

namespace Service
{
    public class DetailService
    {
        public List<Detail> Get()
        {
            List<Detail> details = null;
            using ( var context = new InvoiceContext())
            {
                details = context.Details.ToList();

            }
            return details;

        }
        public Detail GetById(int ID)
        {
            Detail detail = null;
            using (var context =new InvoiceContext())
            {
                detail = context.Details.Where(d => d.DetailID == ID).FirstOrDefault();

            }
            return detail;
        }
        public void Insert(Detail detail)
        {
            using (var context = new InvoiceContext())
            {
         // Falta insertar la cantidad de los productos yel precio total 
            
                context.Details.Add(detail);
                context.SaveChanges();
            }
        }
        public void Update(Detail detail, int id)
        {
            using (var context = new InvoiceContext())
            {
                var detailNew = context.Details.Find(id);
                detailNew.Quantity = detail.Quantity == 0 ? detailNew.Quantity : detail.Quantity;
                detailNew.Price = detail.Price == 0 ? detailNew.Price : detail.Price;
                detailNew.ProductID = detail.ProductID == 0 ? detailNew.ProductID : detail.ProductID;
                detailNew.InvoiceID = detail.InvoiceID == 0 ? detailNew.InvoiceID : detail.InvoiceID;
                detailNew.Seller = detail.Seller == null ? detailNew.Seller : detail.Seller;


                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = new InvoiceContext())
            {
                var detail = context.Details.Find(id);
                context.Details.Remove(detail);
                context.SaveChanges();

            }
        }

    }
}