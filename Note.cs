using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyzeAudio
{
    public class Note
    {
        public string Name { get; }
        public string Symbol { get; }
        public int Octave { get; }
        public double Frequency { get; }

        public Note(string name, string symbol, int octave, double frequency)
        {
            Name = name;
            Symbol = symbol;
            Octave = octave;
            Frequency = frequency;
        }
    }
}
