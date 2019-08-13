using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A05_Chord
{
  class Program
  {
    public static List<Chord> chords = new List<Chord>()
        {
          new Chord("G", "g.txt", "g.wav"),
          new Chord("C", "c.txt", "c.wav"),
          new Chord("D", "d.txt", "d.wav"),
          new Chord("A", "a.txt", "a.wav"),
          new Chord("Am", "am.txt", "am.wav"),
          new Chord("Em", "em.txt", "em.wav"),
          new Chord("Dm", "dm.txt", "dm.wav"),
          new Chord("G7", "g7.txt", "g7.wav"),
          new Chord("C7", "c7.txt", "c7.wav"),
          new Chord("E7", "e7.txt", "e7.wav"),
          new Chord("A7", "a7.txt", "a7.wav"),
          new Chord("D7", "d7.txt", "d7.wav"),
          new Chord("Fmaj7", "fmaj7.txt", "fmaj7.wav")
        };

    static void Main(string[] args)
    {
      //Draw the screen
      Console.SetCursorPosition(15, 1);
      Console.WriteLine("GUITAR MAESTRO: You Guitar Chord Companion\n");
      IEnumerable<string> s =
        from c in chords
        select c.name;
      Console.SetCursorPosition(5, Console.WindowHeight - 2);
      Console.WriteLine(string.Join(" ", s));

      DrawStaffs.Tabstaff();
      DrawStaffs.Fretboard();

      //Take in user input in a loop
      string input;
      do
      {
        Console.SetCursorPosition(5, 25);
        Console.Write("Choose a chord from the list to view: ");

        input = Console.ReadLine();
        string fileName = string.Join(
          "",
          from c in chords
          where c.name.Equals(input)
          select c.textFile
        );

        FileIO file = new FileIO();
        file.DrawChord(fileName);

        FileIO.measureTop = 5;
        FileIO.measureLeft += 10;
      }
      while (input != "q"); //TODO: to upper case
    }
  }
}
