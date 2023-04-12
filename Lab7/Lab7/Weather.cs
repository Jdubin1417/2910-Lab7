using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Weather
{
    // represent my JSON keys
    public string type { get; set; } 
    public string title { get; set; } 
    public string updated { get; set; }
    
    public override string ToString()
    {
        string weatherString =
        $"Type: {type}\n" +
        $"Title: {title}\n" +
        $"Updated: {updated}\n";
        return weatherString;
    }
}
