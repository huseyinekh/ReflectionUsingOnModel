

using OOP.Task_2.Models;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    static void Main()
    {
        Employe t = new Employe();
        //typeof(Employe).GetMethod("Hello").Invoke(t, new[] { "WOLLA" });

        // alternative if you don't know the type of the object:
        t.GetType().GetMethod("setUser").Invoke(t, new[] { "Huseyn","Khidirov" });

    }
}



