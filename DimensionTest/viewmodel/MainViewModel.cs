using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DimensionTest.viewmodel
{
    class MainViewModel : NotifyPropertyChanged
    {
        private string _CurentText;
        /// <summary>
        /// адрес организации.
        /// </summary>
        public string CurentText
        {
            get { return _CurentText; }
            set { _CurentText = value; RaisePropertyChanged(() => CurentText); }
        }

        private List<Propertie> _properties;
        /// <summary>
        /// Контейнер метаданных, описывающих запрос и ответ.
        /// </summary>
        public List<Propertie> properties
        {
            get { return _properties; }
            set { _properties = value; RaisePropertyChanged(() => properties); }
        }

        public T Execute<T>(RestRequest request) where T : new()
        {
            var restClient = new RestClient();
            restClient.BaseUrl = new System.Uri("https://search-maps.yandex.ru/v1");
            var response = restClient.Execute<T>(request);

            if (response.ErrorException != null)
            {
                const string message = "Error retrieving response.  Check inner details for more info.";
                var twilioException = new ApplicationException(message, response.ErrorException);
                throw twilioException;
            }
            return response.Data;
        }

        public void GetProperty()
        {            
            var request = new RestRequest();
            request.AddParameter("apikey", "9fdb782f-bb69-46d6-9f09-a142afedb3a9");
            request.AddParameter("text", "бауманская");
            request.AddParameter("lang", "ru_RU");
            request.AddParameter("type", "biz");
            request.RootElement = "features.properties";
            var restClient = new RestClient();
            restClient.BaseUrl = new System.Uri("https://search-maps.yandex.ru/v1");
            var response = restClient.Execute(request);
            if (response.ErrorException != null)
            {
                const string message = "Error retrieving response.  Check inner details for more info.";
                var twilioException = new ApplicationException(message, response.ErrorException);
                throw twilioException;
            }
            List<string> namecompany = ((JArray)JObject.Parse(response.Content)["features"]).Select(c => c["properties"]["CompanyMetaData"]["name"].ToString()).ToList();

        }

    }
}
