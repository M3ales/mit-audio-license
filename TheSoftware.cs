/^
 * Provided by claude.ai.
 *
 * Prompt
 * Write a c# script to populate TheSoftware.cs file in the `mit-audio-license` repository that showcases Suno's music generation. This is a parody of a repository so you are free to generate whatever you feel is necessary.
^/

using System;

namespace SunoAudio 
{
    public class TheSoftware
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Suno's Fantabulous Music Generator!");
            
            string[] notes = {"C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B"};
            string[] instruments = {"kazoo", "cowbell", "banjo", "didgeridoo", "theremin", "slide whistle"};
            
            Random rand = new Random();
            
            while(true)
            {
                int bpm = rand.Next(60, 200);
                Console.WriteLine($"Sick beat generated at {bpm} BPM!");
                
                for(int i=0; i<4; i++)
                {
                    int randNoteIndex = rand.Next(notes.Length);
                    int randInstrumentIndex = rand.Next(instruments.Length);
                    
                    string note = notes[randNoteIndex];
                    string instrument = instruments[randInstrumentIndex];
                    
                    Console.WriteLine($"Layering a {note} played on {instrument}");
                }
                
                Console.WriteLine("Dropping the beat in 3...2...1...");
                Console.WriteLine();
                Console.WriteLine("SUNO'S HYPNOTIC GENERATED TUNE PLAYS");
                Console.WriteLine();
                Console.WriteLine("The crowd goes wild! 'Encore! Encore!' they chant.");
                Console.WriteLine();
                
                Console.WriteLine("Generate another masterpiece? (y/n)");
                string input = Console.ReadLine();
                
                if(input.ToLower() != "y")
                {
                    break;  
                }
            }
        }
    }
}
