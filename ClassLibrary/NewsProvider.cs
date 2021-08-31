using System;

namespace ClassLibrary
{
    public class NewsProvider
    {
        public delegate void SubscribeTo();

        public event SubscribeTo SubscribedNews;

        public event SubscribeTo SubscribedSport;

        public event SubscribeTo SubscribedWeather;

        public event SubscribeTo SubscribedIncidents;

        public event SubscribeTo SubscribedHumor;
        
        public void SubscribeNews(InfoCategories category)
        {
            switch (category)
            {
                case InfoCategories.News:
                    if (SubscribedNews != null)
                        SubscribedNews();
                    break;
                case InfoCategories.Sport:
                    if (SubscribedSport != null)
                        SubscribedSport();
                    break;
                case InfoCategories.Weather:
                    if (SubscribedWeather != null)
                        SubscribedWeather();
                    break;
                case InfoCategories.Incidents:
                    if (SubscribedIncidents != null)
                        SubscribedIncidents();
                    break;
                case InfoCategories.Humor:
                    if (SubscribedHumor != null)
                        SubscribedHumor();
                    break;
                default:
                    break;
            }
        }
    }
    
}
