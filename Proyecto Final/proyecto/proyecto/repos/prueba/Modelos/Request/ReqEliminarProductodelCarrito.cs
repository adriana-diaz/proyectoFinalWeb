using prueba.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba.Modelos.Request
{
    public class ReqEliminarProductodelCarrito
    {
        public Carrito.EliminarC carrito { get; set; }
    }
}