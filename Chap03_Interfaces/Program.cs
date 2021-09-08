using System;

namespace Chap03_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IStorable document = new Document();
            document.Read("myfile");

            ReadStorable(document);

            IStorable audio = new Audio();
            ReadStorable(audio);
        }

        static void ReadStorable(IStorable storable)
            => storable.Read("test");
    }
}
