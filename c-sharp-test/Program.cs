﻿using System;
using System.Linq;

namespace c_sharp_test
{
    public class main
    {

        static void Main(string[] args)
        {
            Car car = new Car();

            car.brand = "Porche";
            car.model = "Camera S";
            car.color = "Black";

            Console.WriteLine("The car details: " + "\n Brand: " + car.brand + "\n Model: " + car.model + "\n Color: " + car.color);

            string[] arr1 = { "maki", "nigiri", "sahimi" };
            string[] arr2 = { "salad", "stick", "maki" };

            var arr3 = arr1.Intersect(arr2);
            var last = arr2.Last();
            foreach (var i in arr3)
            {
                Console.WriteLine("\n" + i + " " + last);
            }

            int[] sample = new int[10];
            int j;

            for (j = 0; j < 10; j++)
            {
                sample[j] = j;
            }

            for (j = 0; j < 10; j++)
            {
                Console.WriteLine("\n[Sample " + j + " ]: " + sample[j]);
            }

            int[] nums = new int[5];
            double avg = 0;

            nums[0] = 15;
            nums[1] = 29;
            nums[2] = 37;
            nums[3] = 43;
            nums[4] = 55;

            for (int k = 0; k < 5; k++)
            {
                avg = avg + nums[k];
            }
            avg = avg / 5;
            Console.WriteLine("\n" + avg);

            int[] calAverage = { 12, 56, 79, 95, 54 };
            int avg2 = 0;

            for (int m = 0; m < 5; m++)
            {
                avg2 = avg2 + calAverage[m];
            }
            avg2 = avg2 / 5;
            Console.WriteLine("\n" + avg2);

            Hill hill = new Hill();

            hill.name = "Green Hill";
            hill.color = "Green";

            Console.WriteLine("The hill name is " + hill.name + " and the color is " + hill.color);


            Drive drive = new Drive();

            // drive.distance = 200;
            // drive.time = 5;
            int calSpeed = drive.speed(200, 5);
            Console.WriteLine(calSpeed);


            string loopName = "Hello World";

            for (int i = 0; i <loopName.Length; i++)
            {
                Console.WriteLine(loopName[i]);
            }


            Logic logic = new Logic();

            for (int i = 0; i <10; i++)
            {
                if (logic.isPrime(i) == true) {
                    Console.WriteLine(i + " is a prime number.");
                } else Console.WriteLine(i + " is not a prime number.");
            }




            Console.Read();


        }
    }
}
