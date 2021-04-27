using System;
namespace patron_de_diseño_creacional
{
    public class Trunk : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine(" the deliver was sended by Trunk");
        }
    }

}