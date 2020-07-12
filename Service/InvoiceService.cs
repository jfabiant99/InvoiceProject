using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Infraestructure;

namespace Service
{
    public class InvoiceService
    {
        public List<Invoice>Get ()
        {
            List<Invoice> invoices = null;
            using (var context = new InvoiceContext())

            {
                invoices = context.Invoices.ToList();
            }
            return invoices;
        }
        public Invoice GetById(int id)
        {
            Invoice invoice = null;
            using (var context = new InvoiceContext())
            {
                invoice = context.Invoices.Find(id);
            }
            return invoice;
        }

        public void Insert(Invoice invoice)
        {
            using (var context = new InvoiceContext())
            {
                invoice.Date = DateTime.Now;
                context.Invoices.Add(invoice);
                context.SaveChanges();
            }
        }
        public void Update(Invoice invoice, int id)
        {
            using (var context = new InvoiceContext())
            {
                var invoiceNew = context.Invoices.Find(id);
                invoiceNew.Date = invoice.Date == null ? invoice.Date : invoice.Date;
                invoiceNew.InvoiceNumber = invoice.InvoiceNumber == null ? invoice.InvoiceNumber : invoice.InvoiceNumber;

                context.SaveChanges();

            }
        }
         public void Delete(int id)
        {
            using (var context = new InvoiceContext())
            {
                var invoice = context.Invoices.Find(id);
                context.Invoices.Remove(invoice);
                context.SaveChanges();
            }
        }



    }
}
