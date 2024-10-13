//using System.Net;
//using System.Net.Sockets;
//using System.Text;

//Console.WriteLine("Server");
//var endPoint = new IPEndPoint(IPAddress.Parse("10.1.18.1"), 27001);
//var server = new UdpClient(endPoint);

//var remoteEp = new IPEndPoint(IPAddress.Any, 0); // mene mesaj gonderen adam uchun

//while (true)
//{
//    var bytes = server.Receive(ref remoteEp);
//    var str = Encoding.UTF8.GetString(bytes);
//    Console.WriteLine($"{remoteEp}: {str}");
//}
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.IO;

Console.WriteLine("Server");
var endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 27001);
var server = new UdpClient(endPoint);

var remoteEp = new IPEndPoint(IPAddress.Any, 0); 



var bytes = server.Receive(ref remoteEp); 


var outputPath = @"C:\Users\Aliye_du26\Desktop\New folder\ReceivedImage.png";
File.WriteAllBytes(outputPath, bytes);

Console.WriteLine("Image received ");
