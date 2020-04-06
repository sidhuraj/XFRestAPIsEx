using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RestAPIEx
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            getMoviesList();
        }

        private async void getMoviesList()
        {

            //call the rest APi
            HttpClient objHttpClient = new HttpClient();
            var data =await objHttpClient.GetStringAsync("https://api.androidhive.info/json/movies.json");

            //parse the json data
            var moviesData = JsonConvert.DeserializeObject<List<Movie>>(data.ToString()); // or (data); if u use obj symbol "{" then JsonConvert.DesrializeObject(objMovie)//

            lbxMoviesList.ItemsSource = moviesData;

            lbxMoviesList.ItemSelected += LbxMoviesList_ItemSelected;

        }

        private void LbxMoviesList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var movieItem = e.SelectedItem as Movie;

           
        }
    }
}

//note:These  process only supports below android 8 //
// If some times does not comes the  output region is above android 9: process is --go to--solution explor--android--properties--AndroidManifest.xm-- <application android:label="RestAPIEx.Android" android:usesCleartextTraffic="true"/>