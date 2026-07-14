// Import System namespace for fundamental classes and base functionalities
using System;
using System.Collections.Generic;

class Program
{

    static void Main()
    {

        Random rand = new Random();
        char[] myOperators = { '+', '-', '*', '/' };

        // get number of questions
        Console.Write("How many questions do you want?: ");
        int numberOfQuestions = int.Parse(Console.ReadLine() ?? "0"); // convert answer into int
        Console.WriteLine(numberOfQuestions);

        // initialise total score and incorrect answers
        int totalScore = 0;
        List<string> incorrectAnswers = new List<string>();

        for(int i = 0; i < numberOfQuestions; i++)
        {
            int num1 = rand.Next(1,4); // start with smaller ints
            int num2 = rand.Next(1,4);
            char mySign = myOperators[rand.Next(myOperators.Length)];
            int correctAnswer = 0;

            Console.WriteLine($"What is {num1} {mySign} {num2}? ");
            int answer = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine(answer);
            
            // handle float answers by using quotient instead
            if (mySign == '/')
            {
                num2 = rand.Next(1, 5);
                int quotient = rand.Next(1, 5);
                num1 = num2 * quotient;
            }
            else
            {
                num1 = rand.Next(1, 5);
                num2 = rand.Next(1, 5);
            }

            switch (mySign)
            {
                case '+':
                    correctAnswer = num1 + num2;
                    break;

                case '-':
                    correctAnswer = num1 - num2;
                    break;

                case '*':
                    correctAnswer = num1 * num2;
                    break;

                case '/':
                    correctAnswer = num1 / num2;
                    break;
            }

            if (answer == correctAnswer)
            {
                totalScore++;
            }
            else
            {
                incorrectAnswers.Add($"{num1} {mySign} {num2} = {answer} (correct: {correctAnswer})");
            }
        }

        foreach (var item in incorrectAnswers)
        {
            Console.WriteLine(item);
        }
        // generate question
        
        // get user input
        // check correctness
        // update score
        // store incorrect answer
        

        // final score
        // List of incorrect answers
        // percentage(optional)

    }
}
