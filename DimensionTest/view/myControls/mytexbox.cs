using DimensionTest.viewmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace DimensionTest.view.myControls
{
    /// <summary>
    /// Логика взаимодействия для mytexbox.xaml
    /// </summary>
    public partial class mytexbox : TextBox
    {
        //public mytexbox()
        //{
        //    InitializeComponent();

        //}

        /// <summary>
        /// Initializes a new instance of the <see cref="mytexbox"/> class with default watermark text.
        /// </summary>
        public mytexbox()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="mytexbox"/> class.
        /// </summary>
        /// <param name="watermark">The watermark to show when value is <c>null</c> or empty.</param>
        public mytexbox(string watermark)
        {
            WatermarkText = watermark;
        }
        //#region Text
        //public string Text
        //{
        //    get { return (string)GetValue(TextProperty); }
        //    set { SetValue(TextProperty, value); }
        //}

        //public static readonly DependencyProperty
        //    TextProperty = DependencyProperty.Register
        //    ("Text",
        //    typeof(string),
        //    typeof(mytexbox),
        //    new FrameworkPropertyMetadata(
        //    string.Empty,
        //    new PropertyChangedCallback(OnTextChanged))
        //    );

        //public static void OnTextChanged(DependencyObject o, DependencyPropertyChangedEventArgs e)
        //{
        //    var obj = o as mytexbox;
        //    if (e.NewValue != null)
        //    {

        //    }
        //}
        //#endregion

        #region Command
        public Command Command
        {
            get { return (Command)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        public static readonly DependencyProperty
            CommandProperty = DependencyProperty.Register
            ("Command",
            typeof(Command),
            typeof(mytexbox),
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
