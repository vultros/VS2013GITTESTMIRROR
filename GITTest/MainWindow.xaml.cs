﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GITTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GITTestLib.GITTestLibClass testClass;

        public MainWindow()
        {
            InitializeComponent();
            testClass = new GITTestLib.GITTestLibClass();
            testClass.Init();
            // Comment added in vasgit project
            // Commet added on github project
        }
    }
}
