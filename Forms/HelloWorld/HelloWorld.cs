using System;
using System.Windows.Forms;
using System.Drawing;

public class HelloWorld : Form 
{

	public static void Main()
	{
		Application.Run(new HelloWorld());
	}

	public HelloWorld()	
	{
		Button b = new Button();
		b.Text = "Click me";
		b.Click += new EventHandler (Button_Click);
		Controls.Add(b);
	}

	private void Button_Click(object sender, EventArgs e)
	{
		MessageBox.Show("Button Clicked");
	}
	
}
