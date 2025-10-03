using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Security.Cryptography;



namespace AplicacaoAPI
{
  public class StatusPK
    {
      static public string Id { get; set; }
        static public string HP { get; set; }
        static public string ATK { get; set; }
        static public string DEF { get; set; }
        static public string SPATK { get; set; }
        static public string SPDEF { get; set; }
        static public string SPE { get; set; }

       
    }
}
