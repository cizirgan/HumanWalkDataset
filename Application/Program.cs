using System;
using System.Collections.Generic;
using System.Linq;
using FileHelpers;

namespace MehmetTFM
{
    class Program
    {
        static void Main(string[] args)
        {
            int howManyImages = 20000;
            var rightImages = GenerateRight(howManyImages);
            var leftImages = GenerateLeft(howManyImages);
            var upImages = GenerateUp(howManyImages);
            var downImages = GenerateDown(howManyImages);



            var allOfThem = new List<Image>();
            // allOfThem.AddRange(rightImages);
            // allOfThem.AddRange(leftImages);
            allOfThem.AddRange(upImages);
            allOfThem.AddRange(downImages);

            //  rightImages.AddRange(leftImages);
            upImages.AddRange(downImages);


            var engine = new FileHelperEngine<ImageRL>();
            engine.HeaderText = engine.GetFileHeader();

            System.Console.WriteLine(rightImages.Count());
            var train = rightImages.GetRange(0, 16000);

            System.Console.WriteLine(rightImages.Count());
            var test = rightImages.GetRange(16000, 4000);

            engine.WriteFile("RL_TRAIN.csv", train.ToArray());
            engine.WriteFile("RL_TRAIN_RESPONSE.csv", train.ToArray());

            engine.WriteFile("RL_TEST.csv", test.ToArray());
            engine.WriteFile("RL_TEST_RESPONSE.csv", test.ToArray());



            System.Console.WriteLine(leftImages.Count());
            var leftTrain = leftImages.GetRange(0, 16000);

            System.Console.WriteLine(leftImages.Count());
            var leftTest = leftImages.GetRange(16000, 4000);

            engine.WriteFile("LR_TRAIN.csv", leftTrain.ToArray());
            engine.WriteFile("LR_TRAIN_RESPONSE.csv", leftTrain.ToArray());

            engine.WriteFile("LR_TEST.csv", leftTest.ToArray());
            engine.WriteFile("LR_TEST_RESPONSE.csv", leftTest.ToArray());


            /*  var engine2 = new FileHelperEngine<Image>();
              engine2.HeaderText = engine.GetFileHeader();
              var arrayOfLeftImages = upImages.ToArray();
              var yValues = arrayOfLeftImages.Select(p => new Image()
              {
                  y1 = p.y1,
                  y2 = p.y2,
                  y3 = p.y3,
                  y4 = p.y4
              }
              );
              engine2.WriteFile("UD.csv", yValues);



              var engine3 = new FileHelperEngine<Image>();
              engine3.HeaderText = engine.GetFileHeader();
              var allImages = allOfThem.ToArray();

              engine3.WriteFile("All.csv", allImages);*/

        }

        public static List<ImageRL> GenerateRight(int howManyImages)
        {
            var imageList = new List<ImageRL>();

            for (int i = 0; i < howManyImages; i++)
            {

                var y1 = GetRandomNumber(0, 1);
                y1 = 0;
         
                /* var x2 = GetRandomNumber(0.1, 0.33);
                 var x3 = GetRandomNumber(x2 + 0.1, 0.66);
                 var x4 = GetRandomNumber(x3 + 0.1, 1);*/

                /*var x2 = GetRandomNumber(0.1, 0.2);
                var x3 = GetRandomNumber(x2 + 0.1, 0.6);
                var x4 = GetRandomNumber(x3 + 0.1, 0.8);
                var x5 = GetRandomNumber(x1/104 + 0.1, 1);*/

                var x1 = 0;
                var x2 = GetRandomNumber(0.01, 0.1);
                var x3 = GetRandomNumber(x2 + 0.01, 0.2);
                var x4 = GetRandomNumber(x3 + 0.01, 0.3);
                var x5 = GetRandomNumber(x4 + 0.01, 0.4);
                var x6 = GetRandomNumber(x5 + 0.01, 0.5);
                var x7 = GetRandomNumber(x6 + 0.01, 0.6);
                var x8 = GetRandomNumber(x7 + 0.01, 0.7);
                var x9 = GetRandomNumber(x8 + 0.01, 0.8);
                var x10 = GetRandomNumber(x9 + 0.01, 0.9);

                var image = new ImageRL();
                image.x1 = x1;
                image.x2 = x2;
                image.x3 = x3;
                image.x4 = x4;
                image.x5 = x5;
                image.x6 = x6;
                image.x7 = x7;
                image.x8 = x8;
                image.x9 = x9;
                image.x10 = x10;
                imageList.Add(image);
            }
            return imageList;
        }

        public static List<ImageRL> GenerateLeft(int howManyImages)
        {
            var imageList = new List<ImageRL>();
            for (int i = 0; i < howManyImages; i++)
            {

                var y1 = GetRandomNumber(0, 1);

                var x1 = 1;
                var x2 = GetRandomNumber(0.9, 0.99);
                var x3 = GetRandomNumber(0.8, x2 - 0.01);
                var x4 = GetRandomNumber(0.7, x3 - 0.01);
                var x5 = GetRandomNumber(0.6, x4 - 0.01);
                var x6 = GetRandomNumber(0.5, x5 - 0.01);
                var x7 = GetRandomNumber(0.4, x6 - 0.01);
                var x8 = GetRandomNumber(0.3, x7 - 0.01);
                var x9 = GetRandomNumber(0.2, x8 - 0.01);
                var x10 = GetRandomNumber(0, x9 - 0.01);

                var image = new ImageRL();
                image.x1 = x1;
                image.x2 = x2;
                image.x3 = x3;
                image.x4 = x4;
                image.x5 = x5;
                image.x6 = x6;
                image.x7 = x7;
                image.x8 = x8;
                image.x9 = x9;
                image.x10 = x10;

                imageList.Add(image);
            }
            return imageList;
        }

        public static List<Image> GenerateUp(int howManyImages)
        {
            var imageList = new List<Image>();
            for (int i = 0; i < howManyImages; i++)
            {

                var x1 = GetRandomNumber(0, 1);
                var y1 = 0;
                var y2 = GetRandomNumber(0.1, 0.33);
                var y3 = GetRandomNumber(y2 + 0.1, 0.66);
                var y4 = GetRandomNumber(y3 + 0.1, 1);


                //   System.Console.WriteLine($"x1: {x1} y1:{y1} y2:{y2} y3:{y3} y4:{y4}");

                var image = new Image();
                image.x1 = x1;
                image.y1 = y1;
                image.x2 = x1;
                image.y2 = y2;
                image.x3 = x1;
                image.y3 = y3;
                image.x4 = x1;
                image.y4 = y4;
                imageList.Add(image);
            }
            return imageList;
        }

        public static List<Image> GenerateDown(int howManyImages)
        {
            var imageList = new List<Image>();
            for (int i = 0; i < howManyImages; i++)
            {

                var x1 = GetRandomNumber(0, 1);
                var y1 = 1;
                var y2 = GetRandomNumber(0.66, 0.99);
                var y3 = GetRandomNumber(0.33, y2 - 0.1);
                var y4 = GetRandomNumber(0, y3 - 0.1);

                //  System.Console.WriteLine($"x1: {x1} y1:{y1} y2:{y2} y3:{y3} y4:{y4}");


                var image = new Image();
                image.x1 = x1;
                image.y1 = y1;
                image.x2 = x1;
                image.y2 = y2;
                image.x3 = x1;
                image.y3 = y3;
                image.x4 = x1;
                image.y4 = y4;
                imageList.Add(image);
            }
            return imageList;
        }

        public static double GetRandomNumber(double minimum, double maximum)
        {
            Random random = new Random();

            var ok = Math.Round(random.NextDouble() * (maximum - minimum) + minimum, 2);
            return ok;
        }
    }
}
