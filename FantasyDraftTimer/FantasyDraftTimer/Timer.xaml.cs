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
    public sealed partial class Timer : UserControl
    {
        private int _timeLeft;

        public int MaxTime { get; set; }

        private DispatcherTimer _timer;

        public MainPage MainPage { get; set; }

        private Size _size;
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

        public Timer()
        {
            this.InitializeComponent();

            Loaded += Timer_Loaded;
        }

        void Timer_Loaded(object sender, RoutedEventArgs e)
        {
            _timeLeft = MaxTime;
            _updateText();
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(1);
            _timer.Tick += _timer_Tick;
        }

        private void _timer_Tick(object sender, object e)
        {
            _timeLeft--;
            if (_timeLeft == 0)
            {
                StopTimer();
                return;
            }

            _updateText();
        }

        public void StopTimer()
        {
            _timer.Stop();
            _timeLeft = MaxTime;
            //PLAY SOUND
        }

        public void StartTimer()
        {
            _timer.Start();
        }

        private void _updateText()
        {
            int seconds = _timeLeft % 60;
            int minutes = _timeLeft / 60;

            SecondsText.Text = seconds.ToString("00");
            MinutesText.Text = minutes.ToString();
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
            MinutesText.FontSize = fontSize;
            Colon.FontSize = fontSize;
            SecondsText.FontSize = fontSize;
        }
    }
}
