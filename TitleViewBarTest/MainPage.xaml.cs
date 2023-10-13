namespace TitleViewBarTest;

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
		{ 
			CounterBtn.Text = $"Clicked {count} time";
			LblCounter.Text =$"{count} ";
        }
        else
		{
            CounterBtn.Text = $"Clicked {count} times";
            LblCounter.Text = $"{count}";
        }
			

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

