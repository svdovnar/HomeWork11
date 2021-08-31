using System;
using ClassLibrary;

namespace ConsoleAp
{
    class Program
    {
        static void Main(string[] args)
        {
            NewsProvider provider = new NewsProvider();
            
            Client client = new Client();

            client.SubscribeOnNews(InfoCategories.Humor, provider);
            provider.SubscribeNews(InfoCategories.Humor);

            client.SubscribeOnNews(InfoCategories.News, provider);
            provider.SubscribeNews(InfoCategories.News);
            
            
            Console.ReadKey();
        }
    }
}
