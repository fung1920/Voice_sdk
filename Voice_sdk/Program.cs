using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Voice_sdk;
//using voice_recognition.cs.VoiceRecognition.cs;

class Program {
        static void Main(string[] args) {

            string[] wstr = new string[] {"select", "selecting", "selecting mode", "rank", "ranking", "ranking mode", "swap forward", 
                "swap back", "reset", "restart", "cat", "kitty", "aeroplane", "plane", "dog", "puppy", "donut", "Eiffel Tower", "tower", 
                "Tom Mason", "Taylor Swift", "T-shirt", "tennis racket", "apple", "eyeglasses", "hourglass", "Moon", "sun", "revolver", 
                "gun", "hamburger", "pumpkin", "ladder", "skull", "car", "I MuSe"};
            int cnt;
            cnt = wstr.Length;    // To find the length of wstr[]
                        
            // To print out the commands
            Console.WriteLine("Selecting Mode Command: {0}, {1}, {2}", wstr[0], wstr[1], wstr[2]);
            Console.WriteLine("Ranking Mode Command: {0}, {1}, {2}", wstr[3], wstr[4], wstr[5]);
            Console.WriteLine("Swapping Mode Command: {0}, {1}", wstr[6], wstr[7]);
            Console.WriteLine("Reset Mode Command: {0}, {1} \n", wstr[8], wstr[9]);

            // To print out the 20 categories, each category has 25 images
            Console.WriteLine("Category: ");
            for (int i = 10; i < cnt-1; i++)
            {
                Console.Write("{0}, ",wstr[i]);
            }
            Console.WriteLine("{0}\n", wstr[cnt-1]);

            // To do the voice setting
            Voice pipeline=new Voice();
            Console.WriteLine("Please speak a command word or a name of categories.\n\n");
            
            // To set the command words
            pipeline.SetVoiceCommands(wstr);

            // To enable 
            pipeline.EnableVoiceRecognition(0);
            
            if (!pipeline.Init())
            {
                Console.WriteLine("cannot initialized");
                return;
            }

            while (true)
            {
                if (!pipeline.AcquireFrame(true))
                {
                    Console.WriteLine("Failed to initialize or stream data");
                    break;
                }
                pipeline.ReleaseFrame();               
            }
            pipeline.Close();
            pipeline.Dispose();
        }
}
