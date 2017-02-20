using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DimensionTest.viewmodel
{
    class texboxDescriptionViewModel:NotifyPropertyChanged
    {
        private string _WatermarkText;
        /// <summary>
        /// Подсказка.
        /// </summary>
        public string WatermarkText
        {
            get { return _WatermarkText; }
            set
            {
                _WatermarkText = value;
                RaisePropertyChanged(() => WatermarkText);
            }
        }

        private string _TextDescription;
        /// <summary>
        /// Текст.
        /// </summary>
        public string TextDescription
        {
            get { return _TextDescription; }
            set
            {
                _TextDescription = value;
                RaisePropertyChanged(() => TextDescription);
            }
        }

        private SimpleCommand _Commandtexbox;
        /// <summary>
        /// Команда на запрос поиска
        /// </summary>
        public SimpleCommand Commandtexbox
        {
            get { return _Commandtexbox; }
            set
            {
                _Commandtexbox = value;
                RaisePropertyChanged(() => Commandtexbox);
            }
        }

   

    }
}
