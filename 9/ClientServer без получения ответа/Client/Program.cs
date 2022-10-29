namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Это наш клиент");
            OurClient ourClient = new OurClient();/* создаем нового клиента, создается конструктор. 
                                                    Вызывается функция из OurClient.cs, строка 10*/
        }
    }
}