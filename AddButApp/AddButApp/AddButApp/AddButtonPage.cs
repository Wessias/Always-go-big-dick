using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AddButApp
{
	public class AddButtonPage : ContentPage
	{
		public AddButtonPage ()
		{
            Grid grid = new Grid();
            Title = "Label Grid Demo - C#";
            int columnsNum = 6;
            int rowsNum = 6;

            for (int x = 0; x < columnsNum; x++)
            {
                for (int y = 0; y < rowsNum; y++)
                {
                    // Insert button into grid  
                    Button b = new Button() { HorizontalOptions = LayoutOptions.Fill, VerticalOptions = LayoutOptions.Fill ,Text = x + ":" +y };
                    grid.Children.Add(b, x, y);
                }
            }
            Content = grid;
        }
	}
}