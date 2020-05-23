using ParcialProgra10.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialProgra10.Clases
{
    public class CalculoGastos
    {
        public double Porcentaje(Shape[] shapes)
        {
            double porcentarje = 0.5;
            try
            {
                foreach (var shape in shapes)
                {
                    porcentarje = +shape.Porcentaje();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return porcentarje;
        }

        public double Publicar(Shape[] shapes)
        {
            double porcentarje = 0.10;
            try
            {
                foreach (var shape in shapes)
                {
                    porcentarje = +shape.Porcentaje();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return porcentarje;
        }
    }
}
