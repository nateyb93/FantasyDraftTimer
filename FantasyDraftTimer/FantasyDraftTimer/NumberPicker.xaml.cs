using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace FantasyDraftTimer
{
    public enum Size
    {
        Small,
        Normal,
        Large,
        XLarge,
        XXLarge,
        XXXLarge
    }

    public sealed partial class NumberPicker : UserControl
    {
        public int Min { get; set; }
        public int Max { get; set; }

        private Size _size;
        /// <summary>
        /// Gets or sets the size of the appearance of the control
        /// </summary>
        public Size Size
        {
            get
            {
                return _size;
            }
            set
            {
                _size = value;
                _adjustSize();
            }
        }
        
        /// <summary>
        /// Currently selected value of the number picker
        /// </summary>
        public int Value { get; set; }

        private bool _showDigits;
        public bool ShowDigits
        {
            get
            {
                return _showDigits;
            }
            set
            {
                _showDigits = value;
                _setValueText();
            }
        }

        public NumberPicker()
        {
            this.InitializeComponent();

            Value = Min;
        }

        /// <summary>
        /// Increments the value
        /// </summary>
        private void _goUp()
        {
            Value++;
            if (Value > Max)
            {
                Value = Max;
            }

            _setValueText();
        }

        /// <summary>
        /// Decrements the value
        /// </summary>
        private void _goDown()
        {
            Value--;
            if (Value < Min)
            {
                Value = Min;
            }

            _setValueText();
        }


        /// <summary>
        /// Adjusts the size of the appearance of the control
        /// </summary>
        private void _adjustSize()
        {
            switch (_size)
            {
                case Size.Small:
                    _setFont(16);
                    break;
                case Size.Normal:
                    _setFont(24);
                    break;
                case Size.Large:
                    _setFont(36);
                    break;
                case Size.XLarge:
                    _setFont(48);
                    break;
                case Size.XXLarge:
                    _setFont(72);
                    break;
                case Size.XXXLarge:
                    _setFont(108);
                    break;
            }
        }

        /// <summary>
        /// Sets the font size for the control
        /// </summary>
        /// <param name="fontSize"></param>
        private void _setFont(int fontSize)
        {
            UpButton.FontSize = fontSize / 2;
            ValueText.FontSize = fontSize;
            ValueText.Width = 1.75 * fontSize;
            DownButton.FontSize = fontSize / 2;
        }

        private void _setValueText()
        {
            if (_showDigits)
                ValueText.Text = Value.ToString("00");
            else
                ValueText.Text = Value.ToString();
        }

        private void UpButton_Click(object sender, RoutedEventArgs e)
        {
            _goUp();
        }

        private void DownButton_Click(object sender, RoutedEventArgs e)
        {
            _goDown();
        }


        private void ValueText_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int value = int.Parse(ValueText.Text);
                Value = value;
            }
            catch (Exception ex)
            {

            }
        }
    }
}
