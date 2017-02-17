using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimensionTest.viewmodel
{
    public class RootObject
    {
        public bool error_message { get; set; }

        // public List<Dictionary<string, string>> result { get; set; }

        [JsonProperty("result"), JsonConverter(typeof(GetDictionary))]
        public Dictionary<string, string> result { get; set; }

        public int status { get; set; }
        public string url { get; set; }

        public override string ToString()
        {
            return string.Format("error_message: {0}\nresult:\n{1}\nstatus: {2}\nurl: {3}", error_message,
                // string.Join("\n", result.SelectMany(x => x).Select(x => string.Format("{0} - {1}", x.Key, x.Value)))
                string.Join("\n", result.Select(x => string.Format("{0} - [{1}]", x.Key, x.Value)))
                , status, url);
        }
    }
    class GetDictionary : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return typeof(List<Dictionary<string, string>>).IsAssignableFrom(objectType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return serializer.Deserialize<List<Dictionary<string, string>>>(reader)
                .SelectMany(x => x).ToDictionary(x => x.Key, v => v.Value);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

    }
    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
            
    //        var obj = JsonConvert.DeserializeObject<RootObject>(json);
    //        Console.WriteLine(obj);
    //    }

    //}
}
