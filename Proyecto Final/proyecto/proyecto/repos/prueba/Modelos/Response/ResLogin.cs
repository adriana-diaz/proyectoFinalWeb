using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba.Modelos.Response
{
    public class ResLogin : ResBase
    {
        public long? sesion_id { get; set; }
        public long? id_usuario { get; set; }
    }
}
