using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Windows.Input;

namespace DimensionTest.viewmodel
{
    class MainViewModel : NotifyPropertyChanged
    {
        public MainViewModel()
        {
            setupCommands();
        }
        private string _CurentText;
        /// <summary>
        /// адрес организации.
        /// </summary>
        public string CurentText
        {
            get { return _CurentText; }
            set
            {
                _CurentText = value;
                updateCommandsState();
                RaisePropertyChanged(() => CurentText);
            }
        }

        private ResponseClass _result;
        /// <summary>
        /// Класс списка полученных фирм.
        /// </summary>
        public ResponseClass result
        {
            get { return _result; }
            set
            {
                _result = value;
                RaisePropertyChanged(() => result);
            }
        }

        private SimpleCommand _RequestCommand;
        /// <summary>
        /// Команда на запрос списка компаний
        /// </summary>
        public SimpleCommand RequestCommand
        {
            get { return _RequestCommand; }
            set
            {
                _RequestCommand = value;
                RaisePropertyChanged(() => RequestCommand);
            }
        }


        /// <summary>
        /// Создать команды.
        /// </summary>
        public void setupCommands()
        {
            this.RequestCommand = new SimpleCommand(
                p =>
                {
                    result = new ResponseClass(GetListCompany());
                   // this.createNewRate();
                },
                p =>
                {
                    return true;
                   // return CurentText != null ? true : false;
                });
        }

        /// <summary>
        /// Обновить состояние команд.
        /// </summary>
        public void updateCommandsState()
        {
            this.RequestCommand.Update();
        }


        public List<string> GetListCompany()
        {
            var request = new RestRequest();
            request.AddParameter("apikey", "9fdb782f-bb69-46d6-9f09-a142afedb3a9");
            request.AddParameter("text", CurentText);
            request.AddParameter("lang", "ru_RU");
            request.AddParameter("type", "biz");
            var restClient = new RestClient();
            restClient.BaseUrl = new System.Uri("https://search-maps.yandex.ru/v1");
            var response = restClient.Execute(request);
            if (response.ErrorException != null)
            {
                const string message = "Error retrieving response.  Check inner details for more info.";
                var twilioException = new ApplicationException(message, response.ErrorException);
                throw twilioException;
            }
            List<string> ListNameCompany = ((JArray)JObject.Parse(response.Content)["features"]).Select(c => c["properties"]["CompanyMetaData"]["name"].ToString()).ToList();
            return ListNameCompany;
        }

    }
}
