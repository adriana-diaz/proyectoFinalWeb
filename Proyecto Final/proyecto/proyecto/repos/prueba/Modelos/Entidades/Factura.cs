﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace prueba.Modelos.Entidades
{
    public class Factura
    {
        public class Consultar
        {
            public int id_usuario { get; set; }
            public int id_tarjeta { get; set; }
            public int id_factura { get; set; }
            public DateTime fecha { get; set; }
            public string nombre_usuario { get; set; }
            public string cedula { get; set; }
            public string nombre_producto { get; set; }
            public int precio_producto { get; set; }
            public int cantidad { get; set; }
            public int subtotal { get; set; }
            public int monto_total { get; set; }
        }
    }
}
