using System;
using System.Collections.Generic;
using System.Text;

namespace patron_de_diseño_creacional
{
    public class ConcreteTransportFactory :TransportFactory
    {
        public override ITransport GetTransport(string Transport)
        {
            switch (Transport)
            {
                case "Trunk":
                    return new Trunk();                 
                case "Ship":
                    return new Ship();                    
                default:
                    throw new Exception(string.Format($"Transport '{Transport}' cannot be created"));                   
            }
        }
    }
}