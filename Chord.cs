using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A05_Chord
{
  /// <summary>
  /// Provides all the chord properties
  /// </summary>
  class Chord
  {
    public string name { get; }
    public string textFile { get; }
    public string audioFile { get; }

    public Chord(string n, string t, string a)
    {
      name = n;
      textFile = t;
      audioFile = a;
    }
  }
}
