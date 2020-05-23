using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialProgra10.Modelos
{
    public class Gastos : Shape
    {
        public double Gasto { get; set; }
        public double Luz { get; set; }
        public double Internet { get; set; }
        public double Telefono { get; set; }
        public override double Porcentaje()
        {
            return (Gasto + Luz + Internet + Telefono) * 0.5;
        }

        public override double Publicar()
        {
            throw new NotImplementedException();
        }
    }
}
