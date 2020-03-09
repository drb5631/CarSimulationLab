﻿using System;
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

namespace CarSimulationLab
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string domeLightState = "off";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void DomeButton_Click(object sender, RoutedEventArgs e)
        {

                switch (domeLightState)
                {
                    case "off":
                        domeLightImage.Source = new BitmapImage(new Uri("images/domeLight.jpg", UriKind.Relative));
                        domeLightButton.Background = Brushes.Yellow;
                        domeLightButton.Foreground = Brushes.Black;
                        domeLightButton.Content = "Light On";
                        domeLightState = "on";
                        break;
                    case "on":
                        if (doorOpenButton.IsChecked == true) {
                        domeLightImage.Source = new BitmapImage(new Uri("images/domeLight.jpg", UriKind.Relative));
                        }
                        else
                    {
                        domeLightImage.Source = null;
                    }
                        domeLightButton.Background = Brushes.Blue;
                        domeLightButton.Content = "Light Auto";
                        domeLightState = "auto";
                        break;
                    case "auto":
                        domeLightImage.Source = null;
                        domeLightButton.Background = Brushes.Black;
                        domeLightButton.Foreground = Brushes.White;
                        domeLightButton.Content = "Light Off";
                        domeLightState = "off";
                        break;
                }
        }

        private void BeltButton_Click(object sender, RoutedEventArgs e)
        {

            if ((string) beltButton.Content == "Not Buckled")
            {
                beltButton.Background = Brushes.Green;
                beltButton.Content = "Buckled";
                seatBeltImage.Source = new BitmapImage(new Uri("images/buckled.jpg", UriKind.Relative));
            }
            else
            {
                beltButton.Background = Brushes.Red;
                seatBeltImage.Source = new BitmapImage(new Uri("images/notBuckled.jpg", UriKind.Relative));
                beltButton.Content = "Not Buckled";
            }
        }

        private void DriverSeatButton_Click(object sender, RoutedEventArgs e)
        {
            if ((string) driverSeatButton.Content == "Sit") {
                driverSeatButton.Background = Brushes.Green;
                driverSeatButton.Content = "Driver Seated";
            }
            else
            {
                driverSeatButton.Background = Brushes.Black;
                driverSeatButton.Content = "Sit";
            }
        }

        private void BrakeButton_Click(object sender, RoutedEventArgs e)
        {
            if ((string) brakeButton.Content == "Apply Brake") {
                brakeButton.Background = Brushes.Red;
                brakeButton.Content = "Release Brake";
            }
            else
            {
                brakeButton.Background = Brushes.Black;
                brakeButton.Content = "Apply Brake";
            }
        }

        private void WindowButton_Click(object sender, RoutedEventArgs e)
        {
            if ((string) windowButton.Content == "Window Up")
            {
                windowButton.Background = Brushes.SkyBlue;
                windowButton.Content = "Window Down";
            }
            else
            {
                windowButton.Background = Brushes.Black;
                windowButton.Content = "Window Up";
            }
        }

        private void WipersBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (wipersBox.SelectedItem == wipersOffButton)
            {
                
            }
            else
            {

            }
        }

        private void WipersOnButton_Checked(object sender, RoutedEventArgs e)
        {
            wipersImage.Source = new BitmapImage(new Uri("images/wipersOn.jpg", UriKind.Relative));
        }
    }
}
