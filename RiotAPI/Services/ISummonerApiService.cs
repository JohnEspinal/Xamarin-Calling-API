using RiotAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RiotAPI.Services
{
    public interface ISummonerApiService
    {
        Task<Summoner> GetSummonerAsync(string summonerName);
    }
}
