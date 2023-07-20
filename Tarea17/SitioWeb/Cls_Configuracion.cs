using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration; //Para utilizar ConfigurationManager

namespace SitioWeb
{
    public static class Cls_Configuracion
    {
        public static string getConnectionString
        {
            get
            {
                return ConfigurationManager.AppSettings["ConnectionString"];
            }
        }
    }
}