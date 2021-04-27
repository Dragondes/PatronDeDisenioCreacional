using System;
using System.Collections.Generic;
using System.Text;

namespace patron_de_diseño_creacional
{
    public abstract class TransportFactory
    {
        public abstract ITransport GetTransport(string Transport);

    }
}