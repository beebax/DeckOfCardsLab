using System;
using Newtonsoft.Json;
using System.Net;
using DeckOfCardsLab.Models;

namespace DeckOfCardsLab.Models
{
    public class DeckOfCardsDAL
    {
        public DeckOfCardsModel GetCards()
        {
            //Setup
            string url = $"https://deckofcardsapi.com/api/deck/new/draw/?count=5";

            //Request
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Convert it to JSON
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            //Convert to C#
            DeckOfCardsModel deckOfCards = JsonConvert.DeserializeObject<DeckOfCardsModel>(JSON);
            return deckOfCards;

        }
    }
}

