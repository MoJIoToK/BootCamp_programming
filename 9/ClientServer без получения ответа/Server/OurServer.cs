using System.Net.Sockets;
using System.Net;
using System.Text;

namespace Server
{
    class OurServer
    {
        TcpListener server;

        public OurServer()
        {
            server = new TcpListener(IPAddress.Parse("127.0.0.1"), 5555);//слушаем адрес и порт
            server.Start();

            LoopClients();  
        }

        void LoopClients() //функция для того чтобы постоянно ловить клиента
        {
            while (true)
            {
                TcpClient client = server.AcceptTcpClient();/*как только происходит подключение клиента, его сразу
                                                            начинают обрабатывать (создают на сервере) на сервере*/

                Thread thread = new Thread(() => HandleClient(client));//обработка нескольки клиентов сразу. Многопоточно
                thread.Start();
            }
        }

        void HandleClient(TcpClient client)
        {
            StreamReader sReader = new StreamReader(client.GetStream(), Encoding.UTF8);//получаем поток от клиента
            
            while (true)
            {
                string message = sReader.ReadLine();
                Console.WriteLine($"Клиент написал - {message}");
            }
        }
    }
}