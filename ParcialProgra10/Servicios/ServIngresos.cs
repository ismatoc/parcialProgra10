using ParcialProgra10.Clases;
using ParcialProgra10.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialProgra10.Servicios
{
    class ServIngresos : IControlApp<Ingresos>
    {
        private readonly List<Ingresos> _ingresos;
        public ServIngresos()
        {
            _ingresos = new List<Ingresos>();
        }

        public void AgregarIngresos(Ingresos ingresos) => _ingresos.Add(ingresos);

        public override string ToString() =>
            string.Join(Environment.NewLine, _ingresos.Select(x => $"Empresa: {x.empresaDonacion}, Producto: {x.producto}, Cantidad: {x.cantidad}"));
        
    }
}
