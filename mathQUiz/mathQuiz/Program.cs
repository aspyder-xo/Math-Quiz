// Import System namespace for fundamental classes and base functionalities
// using System;
// using System.Collections.Generic;


class Program
{

    static void Main()
    {

        Random rand = new Random();
        char[] myOperators = { '+', '-', '*', '/' }; 

        // get number of questions
        Console.Write("How many questions do you want?: "); 
        int numberOfQuestions = int.Parse(Console.ReadLine() ?? "0"); 
        Console.WriteLine(numberOfQuestions); 

        // initialise total score and incorrect answers
        int totalScore = 0; 
        List<string> incorrectAnswers = new List<string>(); 

        for(int i = 0; i < numberOfQuestions; i++)
            {
                char mySign = myOperators[rand.Next(myOperators.Length)];
                int num1, num2;

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

                Console.WriteLine($"What is {num1} {mySign} {num2}? ");
                int answer = int.Parse(Console.ReadLine() ?? "0");

                int correctAnswer = 0;

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
                    totalScore++;
                else
                    incorrectAnswers.Add($"{num1} {mySign} {num2} = {answer} (The correct answer is: {correctAnswer})");
            }

        foreach (var item in incorrectAnswers)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine($"Well Done! You got {totalScore} correct");
    }
}


