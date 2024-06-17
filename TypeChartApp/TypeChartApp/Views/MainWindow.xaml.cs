﻿using System.Windows;
using System.Windows.Input;

namespace TypeChartApp.Views;

/// <summary>
///     Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        this.Topmost = true;
    }
}