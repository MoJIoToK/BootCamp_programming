using System.Net.Sockets; //стандартная библиотека дотнета для работы с ТСР
using System.Text;

namespace Client // пространство имен
{
    class OurClient
    {
        private TcpClient client;
        private StreamWriter sWriter;
        public OurClient()
        {
            client = new TcpClient("127.0.0.1", 5555);
            sWriter = new StreamWriter(client.GetStream(), Encoding.UTF8);
            //Необходимо постоянно держать подключение

            HandleCommunication();
        }
        void HandleCommunication()
        {
            while (true)
            {
                Console.Write("> ");
                string message = Console.ReadLine();
                sWriter.WriteLine(message);//сообщение подготовлено для отправки на сервер
                sWriter.Flush();//сообщение отправить немедленно
            }
        }
    }
}