using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Collections;

namespace Common.HttpHelpers
{
    public class ApiUrl
    {


        public static string Url(int model)
        {
            string url = BaseUrl() + modelUrl(model);
            return url;
        }

        public static string BaseUrl()
        {
            string url = ConfigurationManager.AppSettings["Url"];
            string port = ConfigurationManager.AppSettings["Port"];
            string api = ConfigurationManager.AppSettings["Api"];
            string baseUrl = url + port + api;

            return baseUrl;
        }

        public static string modelUrl(int model)
        {
            string modelUrl = "";
            switch (model)
            {
                case (int)Numerable.User:
                    modelUrl = ConfigurationManager.AppSettings["User"];
                    break;
                case (int)Numerable.Product:
                    modelUrl = ConfigurationManager.AppSettings["Product"];
                    break;
                case (int)Numerable.Invoice:
                    modelUrl = ConfigurationManager.AppSettings["Invoice"];
                    break;
                case (int)Numerable.Detail:
                    modelUrl = ConfigurationManager.AppSettings["Detail"];
                    break;
                default:
                    break;
            }

            return modelUrl;
        }


    }
}
