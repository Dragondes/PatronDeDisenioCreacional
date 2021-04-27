using System;

namespace patron_de_diseño_creacional
{
    class Program
    {
         static void Main(string[] args)
        {
            TransportFactory factory = new ConcreteTransportFactory();

            ITransport trunk = factory.GetTransport("Trunk");
            trunk.Deliver();

            ITransport ship = factory.GetTransport("Ship");
            ship.Deliver();
        

        }
    }
}
