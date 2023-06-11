using System;
using System.Collections.Generic;
using System.Text;
using Capa_LogicaNegocio_02;
using Capa_Entidades;

namespace Capa_Presentacion_01
{
    internal class Configuracion
    {
        public static string getConnectionString
        {
            get
            {
                return Properties.Settings.Default.ConnectionString;
            }
        }
    }
}
