using Android.Util;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
            Result.Text = $"Clicked {count} time";
		else
            Result.Text = $"Clicked {count} times";


        SemanticScreenReader.Announce(Result.Text);
	}

	private void OnIncremant(object sender, EventArgs e) {

		count--;
		if (count == 10)
            Result.Text = $"Clicked {count} time";
		else
            Result.Text = $"Clicked {count} time";

		SemanticScreenReader.Announce(Result.Text);

    }
}

