using DimensionTest.viewmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DimensionTest
{
    public class CompanyMetaData 
    {
        public string id { get; set; }
        public string name { get; set; }
        public List<List<int>> nameHighlight { get; set; }
        public string address { get; set; }
        public List<List<int>> addressHighlight { get; set; }
        public string url { get; set; }
        public List<Category> Categories { get; set; }
        public List<Phone> Phones { get; set; }
        public Hours Hours { get; set; }
        public Geo Geo { get; set; }
        public List<Feature> Features { get; set; }
        public Snippet Snippet { get; set; }
        public List<Link> Links { get; set; }
    }
    public class Category 
    {
        public string @class { get; set; }
        public string name { get; set; }
        public List<List<int>> nameHighlight { get; set; }
    }

    public class Phone 
    {
        public string type { get; set; }
        public string formatted { get; set; }
        public string country { get; set; }
        public string prefix { get; set; }
        public string number { get; set; }
        public string info { get; set; }
    }
    public class Interval 
    {
        public string from { get; set; }
        public string to { get; set; }
    }

    public class Availability 
    {
        public bool Everyday { get; set; }
        public bool TwentyFourHours { get; set; }
        public List<Interval> Intervals { get; set; }
    }

    public class Hours 
    {
        public List<Availability> Availabilities { get; set; }
        public string text { get; set; }
        public int tzOffset { get; set; }
    }

    public class Geo 
    {
        public string precision { get; set; }
    }

    public class Value 
    {
        public string id { get; set; }
        public string value { get; set; }
    }

    public class Feature 
    {
        public string id { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public List<Value> values { get; set; }
        public object value { get; set; }
    }


    public class Snippet 
    {
        public List<string> FeatureSet { get; set; }
    }

    public class Link 
    {
        public string type { get; set; }
        public string aref { get; set; }
        public string href { get; set; }
    }

    public class Propertie : NotifyPropertyChanged
    {
        private CompanyMetaData _CompanyMetaData;
        /// <summary>
        /// Содержит сведения об отдельной организации: адрес, контактную информацию, режим работы, вид деятельности и др.
        /// </summary>
        public CompanyMetaData CompanyMetaData
        {
            get { return _CompanyMetaData; }
            set { _CompanyMetaData = value; RaisePropertyChanged(() => CompanyMetaData); }
        }

        private string _description;
        /// <summary>
        /// Текст, который рекомендуется указывать в качестве подзаголовка при отображении найденной организации.
        /// </summary>
        public string description
        {
            get { return _description; }
            set { _description = value; RaisePropertyChanged(() => description); }
        }

        private string _name;
        /// <summary>
        /// Текст, который рекомендуется указывать в качестве заголовка при отображении найденной организации.
        /// </summary>
        public string name
        {
            get { return _name; }
            set { _name = value; RaisePropertyChanged(() => name); }
        }
        private List<List<double>> _boundedBy;
        /// <summary>
        /// Границы области, в которую входит организация. Содержит координаты левого нижнего и правого верхнего углов области.
        /// Координаты указаны в последовательности «долгота, широта». 
        /// </summary>
        public List<List<double>> boundedBy
        {
            get { return _boundedBy; }
            set { _boundedBy = value; RaisePropertyChanged(() => boundedBy); }
        }
        private List<string> _attributions;
        /// <summary>
        /// Названия поставщика, предоставляющего сведения о данной организации.
        /// </summary>
        public List<string> attributions
        {
            get { return _attributions; }
            set { _attributions = value; RaisePropertyChanged(() => attributions); }
        }
    }

}
