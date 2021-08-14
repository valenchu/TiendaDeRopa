using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeRopa.Model
{
    class Vendedor
    {
        //AtributosMiembros
        private String nombre = "Valentín";
        private String apellido = "Cassino";
        private long codigoVendedor = 2908199236618123;
        //Constructor LLeno y  Vacio
        public Vendedor()
        {
        }

        public Vendedor(string nombre, string apellido, long codigoVendedor)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.codigoVendedor = codigoVendedor;
        }
        //MetodosGetterAndSettersPropiedades para C#
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public long CodigoVendedor { get => codigoVendedor; set => codigoVendedor = value; }

        public override string ToString()
        {
            return $"Nombre: {nombre} // Apellido: {apellido} // Codigo: {codigoVendedor}";
        }
    }

}
