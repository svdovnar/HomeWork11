using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Client 
    {
        private void OnNewsSubscribe()
        {
            Console.WriteLine("Nothing interesting happened");
        }
        private void OnSportSubscribe()
        {
            Console.WriteLine("Our hockey s*cks");
        }
        private void OnWeatherSubscribe()
        {
            Console.WriteLine("Autumn");
        }
        private void OnHumorSubscribe()
        {
            Console.WriteLine("Delegates not funny");
        }
        private void OnIncidentsSubscribe()
        {
            Console.WriteLine("Minsk is flooded");
        }
        public void SubscribeOnNews(InfoCategories category, NewsProvider newsProvider)
        {
            switch (category)
            {
                case InfoCategories.News:
                    newsProvider.SubscribedNews += OnNewsSubscribe;
                    break;
                case InfoCategories.Weather:
                    newsProvider.SubscribedWeather += OnSportSubscribe;
                    break;
                case InfoCategories.Sport:
                    newsProvider.SubscribedSport += OnWeatherSubscribe;
                    break;
                case InfoCategories.Humor:
                    newsProvider.SubscribedHumor += OnHumorSubscribe;
                    break;
                case InfoCategories.Incidents:
                    newsProvider.SubscribedIncidents += OnIncidentsSubscribe;
                    break;
            }
        }
    }
}

