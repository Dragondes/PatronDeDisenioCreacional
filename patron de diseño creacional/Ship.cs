using System;
namespace patron_de_diseño_creacional
{
    public class Ship : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine(" the deliver was sended by ship");
        }
    }

}