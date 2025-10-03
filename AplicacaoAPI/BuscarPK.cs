using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace AplicacaoAPI
{
    public class BuscarPK
    {
        public static void BuscaPK(string NomePk)
        {
            try
            {
                string url = $"https://pokeapi.co/api/v2/pokemon/{NomePk}";
                using (WebClient client = new WebClient())
                {

                    //INTEGRAR
                    string json = client.DownloadString(url);
                    JObject pokemonData = JObject.Parse(json);

                    //ID
                    StatusPK.Id = (pokemonData["id"]).ToString();

                    //STATS
                    StatusPK.HP = (pokemonData["stats"][0]["base_stat"]).ToString();
                    StatusPK.ATK = (pokemonData["stats"][1]["base_stat"]).ToString();
                    StatusPK.DEF = (pokemonData["stats"][2]["base_stat"]).ToString();
                    StatusPK.SPATK = (pokemonData["stats"][3]["base_stat"]).ToString();
                    StatusPK.SPDEF = (pokemonData["stats"][4]["base_stat"]).ToString();
                    StatusPK.SPE = (pokemonData["stats"][5]["base_stat"]).ToString();

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "ERRO na integração"); }
        }
    }
}
