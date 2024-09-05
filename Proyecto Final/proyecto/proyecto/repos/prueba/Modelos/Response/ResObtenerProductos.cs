using prueba.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba.Modelos.Response
{
    public class ResObtenerProductos : ResBase
    {
        public List<Producto.ConsultarTodos> listaDePublicaciones = new List<Producto.ConsultarTodos>();
    }
}
