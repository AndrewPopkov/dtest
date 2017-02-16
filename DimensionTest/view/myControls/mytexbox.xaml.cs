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
    /// Логика взаимодействия для mytexbox.xaml
    /// </summary>
    public partial class mytexbox : UserControl
    {
        private mytexboxViewModel viewmodel;
        public mytexbox()
        {
            InitializeComponent();
            viewmodel=new mytexboxViewModel();
            this.datatext.GotFocus+= new RoutedEventHandler((o, e) =>
            {

            });
            this.DataContext = viewmodel;

        }
        #region Text
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly DependencyProperty
            TextProperty = DependencyProperty.Register
            ("Text",
            typeof(string),
            typeof(mytexbox),
            new FrameworkPropertyMetadata(
            string.Empty,
            new PropertyChangedCallback(OnTextChanged))
            );

        public static void OnTextChanged(DependencyObject o, DependencyPropertyChangedEventArgs e)
        {
            var obj = o as mytexbox;
            if (e.NewValue != null)
            {

            }
        }
        #endregion

        #region Command
        public string Command
        {
            get { return (string)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        public static readonly DependencyProperty
            CommandProperty = DependencyProperty.Register
            ("Command",
            typeof(string),
            typeof(ICommand),
            new FrameworkPropertyMetadata(null, OnCommandChanged)
            );

        public static void OnCommandChanged(DependencyObject o, DependencyPropertyChangedEventArgs e)
        {
            var obj = o as mytexbox;
            if (e.NewValue != null)
            {

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
            typeof(mytexbox),
            new FrameworkPropertyMetadata(string.Empty, OnWatermarkTextChanged)
            );

        public static void OnWatermarkTextChanged(DependencyObject o, DependencyPropertyChangedEventArgs e)
        {
            var obj = o as mytexbox;
            if (e.NewValue != null)
            {

            }
        }
        #endregion
    }
}
