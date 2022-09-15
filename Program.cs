using Amqp;

var address = new Address($"amqp://guest:guest@localhost:5672");
var con = new Connection(address);
var session1 = new Session(con);
var session2 = new Session(con);
var session3 = new Session(con);
Console.ReadKey();
