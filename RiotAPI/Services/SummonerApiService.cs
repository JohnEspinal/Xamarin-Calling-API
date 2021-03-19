using Newtonsoft.Json;
using RiotAPI.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace RiotAPI.Services
{
    public class SummonerApiService : ISummonerApiService
    {
        public async Task<Summoner> GetSummonerAsync(string summonerName)
        {
            Summoner summ = null;

            HttpClient client = new HttpClient();

            var formattedSummonerName = summonerName.Replace(" ", "%20");

            var urlString = $"https://la1.api.riotgames.com/lol/summoner/v4/summoners/by-name/{formattedSummonerName}?api_key=RGAPI-8214dfc1-21a7-4243-a92c-4f8cc83e714a";



            var response = await client.GetAsync(urlString);

            if (response.IsSuccessStatusCode)
            {
                summ = JsonConvert.DeserializeObject<Summoner>( await response.Content.ReadAsStringAsync());
            }

            return summ;
        }
    }
}
