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

namespace T5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : UserControl
    {
        private bool Loaded = false;
        private ShipMissionData shipMissionData;
        private ShipHullData shipHullData;

        public MainWindow()
        {
            this.InitializeComponent();
            shipMissionData = new ShipMissionData();
            shipHullData = new ShipHullData();
            LoadData();
        }

        private void LoadData()
        {
            // Load Combo box details
            MissionServiceCbx.DataContext = shipMissionData.GetChildren("", "", "", "");
        }



        private void MissionTab_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void MissionServiceCbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MissionActivityCbx.DataContext = shipMissionData.GetChildren(MissionServiceCbx.SelectedValue.ToString(), "", "", "");
        }

        private void MissionActivityCbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }



    }
}
