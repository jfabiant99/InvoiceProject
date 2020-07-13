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
            Mapper.CreateMap<EResponse<Product>, EResponse<Product_Response>>();
            Mapper.CreateMap<EResponse<Product_Response>, EResponse<Product>>();
            Mapper.CreateMap<EResponse<Product_Request>, EResponse<Product>>();

            Mapper.CreateMap<EResponse<User>, EResponse<Customer_Response>>();
            Mapper.CreateMap<EResponse<Customer_Response>, EResponse<User>>();
            Mapper.CreateMap<EResponse<Customer_Request>, EResponse<User>>();

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
