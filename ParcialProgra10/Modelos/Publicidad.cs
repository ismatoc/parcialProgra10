using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialProgra10.Modelos
{
    class Publicidad : Shape
    {
        public double Postear { get; set; }
        public double Redes { get; set; }
        public double Prensa { get; set; }
        public double Pancartas { get; set; }
        public override double Porcentaje()
        {
            throw new NotImplementedException();
        }

        public override double Publicar()
        {
            return (Postear + Redes + Prensa + Pancartas) * 0.10;
        }
    }
}
