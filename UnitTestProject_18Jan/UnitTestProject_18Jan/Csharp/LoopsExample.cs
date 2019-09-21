using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
    [TestFixture]
    public class LoopsExample
    {
        [Test]
        public void LoopExampleTest()
        {
        //Example of if statement
        Console.WriteLine("Example of if statement");
        int score = 40;
        if ((score >= 0) && (score < 40))
            Console.WriteLine("Failed Test");
        else if ((score >= 40) && (score <= 100))
            Console.WriteLine("Passed Test");
        else
            Console.WriteLine("Invalid Score");
        Console.WriteLine("Example of for loop & continue statement");
        int sum = 0;
        for(int i=1;i <= 10; i++)
        {
            if (i == 5)
                continue;
            Console.WriteLine("value of i = " + i);
            sum = sum + i;
            
        }

        Console.WriteLine("sum of 1 to 10 : " + sum);
        Console.WriteLine("Example of while loop & break statement");
        int j = 10;
        sum = 0;
        while (j > 0)
        {
            Console.WriteLine("value of j = " + j);
            sum = sum + j;
            j = j - 1;
            if (j == 5)
                break;
        }
        Console.WriteLine("Sum of 1 to 10 :" + sum);
        }
    }

