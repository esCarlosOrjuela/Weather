﻿namespace src;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new MVVM.Views.MainView();
    }
}

