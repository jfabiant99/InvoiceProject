using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infraestructure;
using Domain;

namespace Service
{
    public class ProductService
    {
        public List<Product> Get()
        {
            List<Product> products = null;
            using (var context = new InvoiceContext())
            {

                products = context.Products.ToList();

            }
            return products;
        }

        public Product GetById(int ID)
        {
            Product product = null;

            using (var context = new InvoiceContext())
            {
                product = context.Products.Find(ID);
            }

            return product;
        }

        public void Insert(Product product)
        {
            using (var context = new InvoiceContext())
            {
                product.Enable = true;
                product.CreatedOn = DateTime.Today;
                product.ModifiedOn = DateTime.Today;
                product.CreatedBy = "Admin";
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

                context.SaveChanges();
            }
        }

        public void Delete (int id)
        {
            using (var context = new InvoiceContext())
            {
                var product = context.Products.Find(id);
                context.Products.Remove(product);
                context.SaveChanges();

            }
        }

    }
}
