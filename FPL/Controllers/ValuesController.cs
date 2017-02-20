using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization.Formatters.Binary;
using System.Web.Http;
using FPL.Models;

namespace FPL.Controllers
{
    //[RoutePrefix("api/fpl")]
    public class ValuesController : ApiController
    {
        // GET api/values/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        [HttpGet, Route("getPlayer")]
        public async void GetPlayer([FromBody] string options)
        {
            var webClient = new WebClient();

            var data =
                await webClient.DownloadDataTaskAsync(new Uri("https://fantasy.premierleague.com/drf/bootstrap-static"));


            BinaryFormatter bf = new BinaryFormatter();
            var players  = new List<Player>();
            MemoryStream ms = new MemoryStream(data);
            var t = bf.Deserialize(ms) as Players;
            

            var playersData = System.Web.Helpers.Json.Encode(data);

            webClient.DownloadDataCompleted += PlayersLoadCompleted;
            webClient.DownloadDataAsync(new Uri("https://fantasy.premierleague.com/drf/bootstrap-static"));
            //return options;
            
        }


        static void PlayersLoadCompleted(object sender, DownloadDataCompletedEventArgs e)
        {
            byte[] rawData = e.Result;

        }
    }
}
