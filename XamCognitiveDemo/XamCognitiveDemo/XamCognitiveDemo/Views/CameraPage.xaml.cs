﻿using Xamarin.Forms;
using XamCognitiveDemo.Services;
using XamCognitiveDemo.ViewModels;

namespace XamCognitiveDemo.Views
{
    public partial class CameraPage : ContentPage
    {
        public VideoAnalysisViewModel ViewModel => ViewModelLocator.VideoAnalysisViewModel;

        public CameraPage()
        {
            InitializeComponent();
            this.BindingContext = ViewModel;
        }
    }
}
