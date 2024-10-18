using ExperimentalShell.Models;
using System.Diagnostics;
using ZXing.Net.Maui.Controls;
using ZXing.Net.Maui;

namespace ExperimentalShell.Views.Cats;

public partial class CatsView : ContentPage
{
    public CatsView()
    {
        InitializeComponent();

        cameraBarcodeReaderView.Options = new BarcodeReaderOptions
        {
            Formats = BarcodeFormats.OneDimensional | BarcodeFormats.TwoDimensional ,
            AutoRotate = true,
            Multiple = true
        };
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
      
    }
    protected void BarcodesDetected(object sender, BarcodeDetectionEventArgs e)
    {
        var result = e.Results?.FirstOrDefault();
        if (result is null) return;

        Dispatcher.DispatchAsync(async () =>
        {
            await DisplayAlert("Barcode detected", result.Value, "OK");
        });

    }
}