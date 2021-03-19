using Refit;
using RiotAPI.Models;
using RiotAPI.Services;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace RiotAPI.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ICommand GetSummonerCommand { get; }

        public string SummonerName { get; set; }

        ISummonerApiService summonerApiService;

        public Summoner Summoner { get; set; }

        public MainViewModel()
        {
            summonerApiService = new SummonerApiService();
            GetSummonerCommand = new Command(GetSummonerAsync);
        }

        private async void GetSummonerAsync()
        {
            if(Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                var serviceApi = RestService.For<IRefitSummonerApi>("https://la1.api.riotgames.com");
                var summoner = await summonerApiService.GetSummonerAsync(SummonerName);

                Summoner = summoner;
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("No Internet", "It looks like you don't have internet, please connect and try again.", "Ok");
            }
            
        }





        public event PropertyChangedEventHandler PropertyChanged;
    }
}
