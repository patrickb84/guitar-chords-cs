using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A05_Chord
{
  class DrawStaffs
  {
    private static int left = 5; //TODO
    private static int top = 5;    //TODO

    /// <summary>
    /// Draws a blank Tablature staff
    /// </summary>
    public static void Tabstaff()
    {
      for (int i = 0; i < 6/*numstrings*/; i++)
      {
        Console.SetCursorPosition(left, top);
        for (int j = 0; j < 8/*nummeasures*/; j++)
        {
          Console.Write("|---------");
        }
        Console.Write("|");
        top++;
      }
      Console.WriteLine();
    }

    /// <summary>
    /// Draws a blank fretboard
    /// </summary>
    public static void Fretboard()
    {
      for (int i = 0; i < 6; i++)
      {
        int width = 13;
        Console.SetCursorPosition(left, top + 5);
        Console.Write("||");
        for (int j = 0; j < 12; j++)
        {
          for (int k = 0; k < width; k++)
          {
            Console.Write("-");
          }
          Console.Write("|");
          width--;
        }
        Console.WriteLine();
        top++;
      }
      Console.WriteLine();
    }
  }
}
