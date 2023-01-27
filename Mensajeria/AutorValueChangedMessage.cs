
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRevista.Mensajeria
{
    class AutorValueChangedMessage : ValueChangedMessage<Autor>
    {
        public NuevaPersonaValueChangedMessage(Autor a) : base(a) { }
    }
}
