using System;

namespace Csharp_basics2 {
    class Program {

        //static void SayHi() {
        //    Console.WriteLine("hi!");
        //}

        //static string SayHi() {
        //    return "hi!";
        //}
        static string SayHi() => "hi!";
        static void Main() {

            //int[] scores = new int[3];
            //scores[0] = 10;
            //scores[1] = 30;
            //scores[2] = 20;
            //int[] scores = new int[] { 10, 20, 30 };
            //int[] scores = { 10, 20, 30 };
            //var scores = new[] { 10, 20, 30 };
            //Console.WriteLine(scores[1]);
            //SayHi();
            Console.WriteLine(SayHi());
        }
    }
}
