using DimensionTest.viewmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DimensionTest.view.myControls
{
    /// <summary>
    /// Логика взаимодействия для texboxDescription.xaml
    /// </summary>
    public partial class texboxDescription : UserControl
    {
        private texboxDescriptionViewModel viewmodel;
        public texboxDescription()
        {
            InitializeComponent();
            viewmodel = new texboxDescriptionViewModel();
            this.tbx1.DataContext = viewmodel;
            this.viewmodel.PropertyChanged += (o, e) =>
                {
                    if (e.PropertyName == "TextDescription")
                    {
                        if (this.viewmodel.TextDescription != null)
                        {
                            this.TextDescription = this.viewmodel.TextDescription;
                        }
                    }

                };
        }

        public void ClearText(object sender, RoutedEventArgs e)
        {
            this.tbx1.Text = string.Empty;
        }

        #region TextDescription
        public string TextDescription
        {
            get { return (string)GetValue(TextDescriptionProperty); }
            set { SetValue(TextDescriptionProperty, value); }
        }

        public static readonly DependencyProperty
            TextDescriptionProperty = DependencyProperty.Register
            ("TextDescription",
            typeof(string),
            typeof(texboxDescription),
            new FrameworkPropertyMetadata(
            string.Empty,
            new PropertyChangedCallback(OnTextDescriptionChanged))
            );

        public static void OnTextDescriptionChanged(DependencyObject o, DependencyPropertyChangedEventArgs e)
        {
            var obj = o as texboxDescription;
            if (e.NewValue != null)
            {
                obj.tbx1.Text = (string)e.NewValue;
            }
        }
        #endregion


        #region Command
        public ICommand Commandtexbox
        {
            get { return (SimpleCommand)GetValue(CommandtexboxProperty); }
            set { SetValue(CommandtexboxProperty, value); }
        }

        public static readonly DependencyProperty
            CommandtexboxProperty = DependencyProperty.Register
            ("Commandtexbox",
            typeof(ICommand),
            typeof(texboxDescription),
            new FrameworkPropertyMetadata(null, OnCommandtexboxPropertyChanged)
            );

        public static void OnCommandtexboxPropertyChanged(DependencyObject o, DependencyPropertyChangedEventArgs e)
        {
            var obj = o as texboxDescription;
            if (e.NewValue != null)
            {
                obj.viewmodel.Commandtexbox  = (SimpleCommand)e.NewValue;
            }
        }
        #endregion


        #region WatermarkText
        public string WatermarkText
        {
            get { return (string)GetValue(WatermarkTextProperty); }
            set { SetValue(WatermarkTextProperty, value); }
        }

        public static readonly DependencyProperty
            WatermarkTextProperty = DependencyProperty.Register
            ("WatermarkText",
            typeof(string),
            typeof(texboxDescription),
            new FrameworkPropertyMetadata(string.Empty, OnWatermarkTextChanged)
            );

        public static void OnWatermarkTextChanged(DependencyObject o, DependencyPropertyChangedEventArgs e)
        {
            var obj = o as texboxDescription;
            if (e.NewValue != null)
            {
                obj.viewmodel.WatermarkText = (string)e.NewValue;
            }
        }
        #endregion
    }
}
