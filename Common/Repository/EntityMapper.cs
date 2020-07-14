using Common.HttpHelpers;
using Domain;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Response;
using Models.Request;

namespace Common.Repository
{
    public class EntityMapper<TSource, TDestination> where TSource : class where TDestination : class
    {

        public EntityMapper()
        {
            Mapper.CreateMap<EResponseBase<Product>, EResponseBase<Product_Response>>();
            Mapper.CreateMap<EResponseBase<Product_Response>, EResponseBase<Product>>();
            Mapper.CreateMap<EResponseBase<Product_Request>, EResponseBase<Product>>();

            Mapper.CreateMap<EResponseBase<User>, EResponseBase<Customer_Response>>();
            Mapper.CreateMap<EResponseBase<Customer_Response>, EResponseBase<User>>();
            Mapper.CreateMap<EResponseBase<Customer_Request>, EResponseBase<User>>();

            Mapper.CreateMap<Invoice, SalesInvoce_Response>();
            Mapper.CreateMap<SalesInvoce_Response, Invoice>();
            Mapper.CreateMap<SalesInvoce_Request, Invoice>();

            Mapper.CreateMap<Detail, SalesInvoceDetail_Response>();
            Mapper.CreateMap<SalesInvoceDetail_Response, Detail>();
            Mapper.CreateMap<SalesInvoceDetail_Request, Detail>();

         //   Mapper.CreateMap<Seller, Seller_Response>();
         //   Mapper.CreateMap<Seller_Response, Seller>();
         //   Mapper.CreateMap<Seller_Request, Seller>();

        }

        public TDestination Translate(TSource obj)
        {
            return Mapper.Map<TDestination>(obj);
        }

    }
}
