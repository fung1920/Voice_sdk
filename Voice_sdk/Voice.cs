﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Voice_sdk;

namespace Voice_sdk
{
    class Voice : UtilMPipeline
    {
        protected int nframes;
        protected bool device_lost;

        public Voice()
            : base()
        {
            EnableVoiceRecognition();
            nframes = 0;
            device_lost = false;
        }
        public override bool OnDisconnect()
        {
            if (!device_lost) Console.WriteLine("Device disconnected");
            device_lost = true;
            return base.OnDisconnect();
        }

            public override void OnReconnect()
            {
                Console.WriteLine("Device reconnected");
                device_lost = false;
            }


            public override void OnRecognized(ref PXCMVoiceRecognition.Recognition data)
            {
                string str;
                str = data.dictation;
                Console.WriteLine("Recognized<{0}>", str);


                // Command words
                if (str.CompareTo("swap forward") == 0)
                    Console.WriteLine("The previous image is shown!\n");
                else if (str.CompareTo("swap backward") == 0 || str.CompareTo("swap back") == 0)
                    Console.WriteLine("The next image is shown!\n");
                else if (str.CompareTo("rank") == 0 || str.CompareTo("ranking") == 0 || str.CompareTo("ranking mode") == 0)
                    Console.WriteLine("Ranking Mode is on!\n");
                else if (str.CompareTo("select") == 0 || str.CompareTo("selecting") == 0 || str.CompareTo("selecting mode") == 0)
                    Console.WriteLine("The image is selected!\n");

                // Category
                else if (str.CompareTo("cat") == 0 || str.CompareTo("kitty") == 0)
                    Console.WriteLine("Images from 1 to 25 are shown!\n");
                else if (str.CompareTo("aeroplane") == 0 || str.CompareTo("plane") == 0)
                    Console.WriteLine("Images from 26 to 50 are shown!\n");
                else if (str.CompareTo("dog") == 0 || str.CompareTo("puppy") == 0)
                    Console.WriteLine("Images from 51 to 75 are shown!\n");
                else if (str.CompareTo("donut") == 0)
                    Console.WriteLine("Images from 76 to 100 are shown!\n");
                else if (str.CompareTo("Eiffel Tower") == 0 || str.CompareTo("tower") == 0)
                    Console.WriteLine("Images from 101 to 125 are shown!\n");
                else if (str.CompareTo("Tom Mason") == 0)
                    Console.WriteLine("Images from 126 to 150 are shown!\n");
                else if (str.CompareTo("Taylor Swift") == 0)
                    Console.WriteLine("Images from 151 to 175 are shown!\n");
                else if (str.CompareTo("T-shirt") == 0)
                    Console.WriteLine("Images from 176 to 200 are shown!\n");
                else if (str.CompareTo("tennis racket") == 0)
                    Console.WriteLine("Images from 201 to 225 are shown!\n");
                else if (str.CompareTo("apple") == 0)
                    Console.WriteLine("Images from 226 to 250 are shown!\n");
                else if (str.CompareTo("eyeglasses") == 0)
                    Console.WriteLine("Images from 251 to 275 are shown!\n");
                else if (str.CompareTo("hourglass") == 0)
                    Console.WriteLine("Images from 276 to 300 are shown!\n");
                else if (str.CompareTo("Moon") == 0)
                    Console.WriteLine("Images from 301 to 325 are shown!\n");
                else if (str.CompareTo("sun") == 0)
                    Console.WriteLine("Images from 326 to 350 are shown!\n");
                else if (str.CompareTo("revolver") == 0 || str.CompareTo("gun") == 0)
                    Console.WriteLine("Images from 351 to 375 are shown!\n");
                else if (str.CompareTo("hamburger") == 0)
                    Console.WriteLine("Images from 376 to 400 are shown!\n");
                else if (str.CompareTo("pumpkin") == 0)
                    Console.WriteLine("Images from 401 to 425 are shown!\n");
                else if (str.CompareTo("ladder") == 0)
                    Console.WriteLine("Images from 426 to 450 are shown!\n");
                else if (str.CompareTo("skull") == 0)
                    Console.WriteLine("Images from 451 to 475 are shown!\n");
                else if (str.CompareTo("car") == 0)
                    Console.WriteLine("Images from 476 to 500 are shown!\n");
                else if (str.CompareTo("I MuSe") == 0)
                    Console.WriteLine("Voice Command!\n");
                else
                    Console.WriteLine("Please speak a command word or a name of categories.\n");
            }
        };
    
}
