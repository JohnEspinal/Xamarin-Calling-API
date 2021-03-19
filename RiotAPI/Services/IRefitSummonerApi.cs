using Refit;
using RiotAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RiotAPI.Services
{
    public interface IRefitSummonerApi
    {


        [Get("/lol/summoner/v4/summoners/by-name/{summonerName}?api_key=RGAPI-8214dfc1-21a7-4243-a92c-4f8cc83e714a")]
        Task<Summoner> GetSummonerAsync(string summonerName);
    }
}
