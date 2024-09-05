using prueba.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba.Modelos.Response
{
    public class ResObtenerTarjetas : ResBase
    {
        public List<Tarjetas.consultaTarjeta> listaDeconsultas = new List<Tarjetas.consultaTarjeta>();
    }
}
