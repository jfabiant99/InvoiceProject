using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infraestructure;
using Domain;
using System.Data.Entity.Validation;

namespace Service
{
    public class ProductService
    {
        public List<Product> Get()
        {
            List<Product> products = null;
            using (var context = new InvoiceContext())
            {

                products = context.Products.Where(p => p.Enable == true).ToList();

            }
            return products;
        }

        public Product GetById(int ID)
        {
            Product product = null;

            using (var context = new InvoiceContext())
            {
                product = context.Products.Where(p => p.Enable == true).FirstOrDefault();
            }

            return product;
        }

        public void Insert(Product product)
        {
            using (var context = new InvoiceContext())
            {
                product.Enable = true;
                product.CreatedOn = DateTime.Now;
                product.ModifiedOn = DateTime.Now;

                context.Products.Add(product);
                context.SaveChanges();
            }
        }

        public void Update (Product product, int id)
        {
            using (var context = new InvoiceContext())
            {
                var productNew = context.Products.Find(id);
                productNew.ProductName = product.ProductName == null ? productNew.ProductName : product.ProductName;
                productNew.Price = product.Price == 0 ? productNew.Price : product.Price;
                productNew.Stock = product.Stock == 0 ? productNew.Stock : product.Stock;
                productNew.ModifiedOn = DateTime.Now;

                context.SaveChanges();
            }
        }

        public void Delete (int id)
        {
            using (var context = new InvoiceContext())
            {
                var product = context.Products.Find(id);
                product.Enable = false;
                context.SaveChanges();

            }
        }

    }
}
