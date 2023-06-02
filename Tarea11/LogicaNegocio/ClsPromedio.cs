using System;
using System.Collections.Generic;
using System.Text;

namespace LógicaNegocio
{
    public class ClsPromedio
    {
        #region Atributos
        private string condición;
        private string color;
        private double promedio;
        #endregion

        #region Propiedades
        public string Condición { get => condición; set => condición = value; }
        public string Color { get => color; set => color = value; }
        public double Promedio { get => promedio; set => promedio = value; }
        #endregion

        #region Constructores
        public ClsPromedio() {}
        #endregion

        public void CalcularPromedio(double sumaNotas, int cantidadNotas)
        {
            promedio = sumaNotas / cantidadNotas;
        }

        public void CalcularCondición()
        {
            if (promedio >= 70)
            {                
                condición = "APROBADO";
                color = "Verde";
            }
            else
            {
                condición = "REPROBADO";
                color = "Rojo";
            }
        }
    }
}
