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


        [Get($"/lol/summoner/v4/summoners/by-name/{summonerName}?api_key={Secret.ApyKey}")]
        Task<Summoner> GetSummonerAsync(string summonerName);
    }
}
