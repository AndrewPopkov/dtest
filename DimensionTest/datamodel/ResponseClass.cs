using DimensionTest.viewmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DimensionTest
{
    /// <summary>
    /// Класс спика фирм.
    /// </summary>
    public class ResponseClass :NotifyPropertyChanged
    {
        
        private List<string> _PartyList;
        /// <summary>
        ///Список организаций
        /// </summary>
        public List<string> PartyList
        {
            get { return _PartyList; }
            set { _PartyList = value; RaisePropertyChanged(() => PartyList); }
        }

        /// <summary>
        /// Конструктор класса <see cref="ResponseClass"/>.
        /// </summary>
        public ResponseClass()
        {
        }

        /// <summary>
        /// Конструктор  копирования класса <see cref="ResponseClass"/>.
        /// </summary>
        /// <param name="obj">Объект, на основе которого инициализируется создаваемый объект.</param>
        public ResponseClass(List<string> obj)
        {
            this.PartyList = new List<string>();
            obj.ForEach(s=>
            {
                this.PartyList.Add(s);
            });
        }
    }

}
