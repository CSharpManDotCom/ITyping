namespace ITyping;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	public MainWindow()
	{
		InitializeComponent();
	}

	protected override void OnPreviewKeyDown(KeyEventArgs e)
	{
		switch(e.Key)
		{
			case Key.Back:
				inputText.Text = inputText.Text.Substring(0, inputText.Text.Length - 1);
				
				break;

			case Key.Q:
				inputText.Text = inputText.Text + "q";
				break;
		}
		base.OnPreviewKeyDown(e);
	}

	protected override void OnPreviewKeyUp(KeyEventArgs e)
	{
		switch(e.Key)
		{
			case Key.Q:
				
			break;
		}

		base.OnPreviewKeyUp(e);
	}
}
