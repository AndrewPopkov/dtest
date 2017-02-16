using DimensionTest.viewmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DimensionTest
{

    public class RootObject : NotifyPropertyChanged
    {
        public class Feature : NotifyPropertyChanged
        {
            public class Properties : NotifyPropertyChanged
            {
                public class CompanyMetaData : NotifyPropertyChanged
                {
                    public class Category : NotifyPropertyChanged
                    {
                        public string @class { get; set; }
                        public string name { get; set { RaisePropertyChanged(() => name); } }
                        public List<List<int>> nameHighlight { get; set; }
                    }

                    public class Phone : NotifyPropertyChanged
                    {
                        public string type { get; set; }
                        public string formatted { get; set; }
                        public string country { get; set; }
                        public string prefix { get; set; }
                        public string number { get; set; }
                        public string info { get; set; }
                    }

                    public class Hours : NotifyPropertyChanged
                    {
                        public class Availability : NotifyPropertyChanged
                        {

                            public class Interval : NotifyPropertyChanged
                            {
                                public string from { get; set; }
                                public string to { get; set; }
                            }

                            public bool Everyday { get; set; }
                            public bool TwentyFourHours { get; set; }
                            public List<Interval> Intervals { get; set; }
                        }

                        public List<Availability> Availabilities { get; set; }
                        public string text { get; set; }
                        public int tzOffset { get; set; }
                    }

                    public class Geo : NotifyPropertyChanged
                    {
                        public string precision { get; set; }
                    }

                    public class Feature : NotifyPropertyChanged
                    {


                        public class Value : NotifyPropertyChanged
                        {
                            public string id { get; set; }
                            public string value { get; set; }
                        }


                        public string id { get; set; }
                        public string type { get; set; }
                        public string name { get; set; }
                        public List<Value> values { get; set; }
                        public object value { get; set; }
                    }


                    public class Snippet : NotifyPropertyChanged
                    {
                        public List<string> FeatureSet { get; set; }
                    }

                    public class Link : NotifyPropertyChanged
                    {
                        public string type { get; set; }
                        public string aref { get; set; }
                        public string href { get; set; }
                    }

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
                public CompanyMetaData CompanyMetaData { get; set; }
                public string description { get; set; }
                public string name { get; set; }
                public List<List<double>> boundedBy { get; set; }
                public List<string> attributions { get; set; }
            }

            public class Geometry : NotifyPropertyChanged
            {
                public string type { get; set; }
                public List<double> coordinates { get; set; }
            }

            public string type { get; set; }
            public Properties properties { get; set; }
            public Geometry geometry { get; set; }
        }
        public string type { get; set; }

        public class Properties : NotifyPropertyChanged
        {
            public class Attribution : NotifyPropertyChanged
            {
                public class Sources : NotifyPropertyChanged
                {
                    public class Twitter : NotifyPropertyChanged
                    {
                        public class Author : NotifyPropertyChanged
                        {
                            public string name { get; set; }
                            public string uri { get; set; }
                        }
                        public string id { get; set; }
                        public Author author { get; set; }
                    }

                    public class Yandex : NotifyPropertyChanged
                    {
                        public class Author : NotifyPropertyChanged
                        {
                            public string name { get; set; }
                            public string uri { get; set; }
                        }
                        public string id { get; set; }
                        public Author author { get; set; }
                    }
                    public Twitter twitter { get; set; }
                    public Yandex yandex { get; set; }
                }
                public Sources Sources { get; set; }
            }
            public class ResponseMetaData : NotifyPropertyChanged
            {
                public class SearchRequest : NotifyPropertyChanged
                {
                    public string request { get; set; }
                    public int results { get; set; }
                    public int skip { get; set; }
                    public List<List<double>> boundedBy { get; set; }
                }
                public class SearchResponse : NotifyPropertyChanged
                {
                    public class Sort : NotifyPropertyChanged
                    {
                        public string type { get; set; }
                    }

                    public class Point : NotifyPropertyChanged
                    {
                        public string type { get; set; }
                        public List<double> coordinates { get; set; }
                    }
                    public int found { get; set; }
                    public Sort Sort { get; set; }
                    public Point Point { get; set; }
                    public List<List<double>> boundedBy { get; set; }
                    public string display { get; set; }
                }
                public SearchRequest SearchRequest { get; set; }
                public SearchResponse SearchResponse { get; set; }
            }
            public Attribution Attribution { get; set; }
            public ResponseMetaData ResponseMetaData { get; set; }
        }
        public List<Feature> features { get; set; }

    }

}
