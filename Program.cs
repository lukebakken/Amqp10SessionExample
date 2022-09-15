using Amqp;

namespace Amqp10SessionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var address = new Address($"amqp://myusername:{Uri.EscapeDataString("mypassword")}@myhost.com:5672");
            var con = new Connection(address);
            var session1 = new Session(con);
            var session2 = new Session(con);
            var session3 = new Session(con);
            Console.ReadKey();
        }
    }
}
