using static System.Console;

namespace Chap03_Interfaces
{
    public class Document : IStorable
    {
        public void Read(string filename) =>
            WriteLine($"Reading {filename} into this document");

        public void Write(string filename) =>
            WriteLine($"Writing {filename} to disk...");
    }

    public class Audio : IStorable
    {
        public void Read(string filename) =>
            WriteLine($"Reading {filename} into this audio");

        public void Write(string filename) =>
            WriteLine($"Writing {filename} to disk...");
    }
}