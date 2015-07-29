using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace FantasyDraftTimer
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private int _numRounds;
        private int _picksPerRound;
        private int _secsPerRound;

        private int _currentPick;
        private int _currentRound;

        private bool _pickIsIn;

        public MainPage()
        {
            this.InitializeComponent();
            Timer.MainPage = this;
        }

        private void TimerButton_Click(object sender, RoutedEventArgs e)
        {
            Timer.StartTimer();
            //User clicked "SUBMIT"
            if (!_pickIsIn)
            {
                SubmitPick();
            }
            else
            {
                NewPick();
            }
        }

        private void StartDraftClick_Click(object sender, RoutedEventArgs e)
        {
            _startDraft();
        }

        /// <summary>
        /// Handles actions associated with starting a new pick
        /// </summary>
        public void NewPick()
        {
            Timer.StartTimer();
            _pickIsIn = false;
            TimerButton.Content = "SUBMIT";
            TimerButton.Foreground = new SolidColorBrush(Colors.Green);
            _incrementPick();
        }

        /// <summary>
        /// Handles actions associated with submitting a pick
        /// </summary>
        public void SubmitPick()
        {
            Timer.StopTimer();
            _pickIsIn = true;
            TimerButton.Content = "NEXT";
            TimerButton.Foreground = new SolidColorBrush(Colors.Red);
            //PLAY SOUND
        }

        /// <summary>
        /// Increments the value of the current pick
        /// </summary>
        private void _incrementPick()
        {
            _currentPick++;
            if (_currentPick > _picksPerRound)
            {
                _currentRound++;
                _currentPick = 1;
            }

            _updatePickDisplay();
        }

        /// <summary>
        /// Updates the display for the current round/pick values
        /// </summary>
        private void _updatePickDisplay()
        {
            CurrentRoundText.Text = _currentRound.ToString();
            CurrentPickText.Text = _currentPick.ToString();
        }

        /// <summary>
        /// Starts the draft with the settings from the overlay
        /// </summary>
        private void _startDraft()
        {
            _numRounds = RoundsPicker.Value;
            _picksPerRound = PicksPicker.Value;
            _secsPerRound = SecPicker.Value + (60 * MinPicker.Value);

            Timer.MaxTime = _secsPerRound;

            _currentRound = 1;
            _currentPick = 1;
            _pickIsIn = false;

            StartOverlayGrid.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            Timer.StartTimer();
        }
    }
}
