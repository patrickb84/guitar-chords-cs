using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Media;

namespace A05_Chord
{
    class FileIO
    {
        public static int measureTop = 5;
        public static int measureLeft = 10;

        /// <summary>
        /// Draws a chord shape selected by the user on the tab staff
        /// </summary>
        /// <param name="chord"></param>
        public void DrawChord(string chord)
        {
            DrawStaffs draw = new DrawStaffs();
            try
            {
                using (StreamReader reader = new StreamReader("Resources/" + chord))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.SetCursorPosition(measureLeft, measureTop);
                        Console.WriteLine("{0}", line);
                        measureTop++;
                    }
                    //Console.SetCursorPosition(measureLeft, measureTop);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Plays the sound file associated with the user's chord selection
        /// </summary>
        /// <param name="chords"></param>
        public void PlaySound(string[] chords)
        {
            foreach (string n in chords)
            {
                SoundPlayer player = new SoundPlayer("Resources/" + n);
                player.Play();
            }
        }
    }
}
