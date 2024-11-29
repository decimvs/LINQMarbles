using LinqMarbles.Client.Models;
using MudBlazor;

namespace LinqMarbles.Client.Helpers
{
    public class ColorsHelper
    {
        public static string GetRandomColor(GlobalObject global)
        {
            Span<string> darkColors = [ Colors.Red.Darken2, Colors.Pink.Darken2, Colors.Purple.Darken2,
                Colors.DeepPurple.Darken2, Colors.Indigo.Darken2, Colors.Blue.Darken2, Colors.LightBlue.Darken2,
                Colors.Cyan.Darken2, Colors.Teal.Darken2, Colors.Green.Darken2, Colors.LightGreen.Darken2,
                Colors.Lime.Darken2, Colors.Yellow.Darken2, Colors.Amber.Darken2, Colors.Orange.Darken2,
                Colors.DeepOrange.Darken2, Colors.Brown.Darken2, Colors.BlueGray.Darken2];

            Span<string> lightColors  = [ Colors.Red.Lighten3, Colors.Pink.Lighten3, Colors.Purple.Lighten3,
                Colors.DeepPurple.Lighten3, Colors.Indigo.Lighten3, Colors.Blue.Lighten3, Colors.LightBlue.Lighten3,
                Colors.Cyan.Lighten3, Colors.Teal.Lighten3, Colors.Green.Lighten3, Colors.LightGreen.Lighten3,
                Colors.Lime.Lighten3, Colors.Yellow.Lighten3, Colors.Amber.Lighten3, Colors.Orange.Lighten3,
                Colors.DeepOrange.Lighten3, Colors.Brown.Lighten3, Colors.BlueGray.Lighten3];

            var randomIndex = Random.Shared.Next(lightColors.Length);
            
            if (global != null && global.IsDarkMode)
            {
                return darkColors[randomIndex];
            }
            else
            {
                return lightColors[randomIndex];
            }
        }
    }
}
