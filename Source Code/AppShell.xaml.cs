﻿namespace WellnessApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Studying), typeof(Studying));
        }
    }
}
