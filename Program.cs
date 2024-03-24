using System;

namespace ArithmeticQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            bool rerun = true;

            while (rerun)
            {
                Random random = new Random();
                int totalQuestions = random.Next(5, 15);
                int correctAnswers = 0;

                Console.WriteLine("Arithmetic Quiz\n");

                for (int i = 1; i <= totalQuestions; i++)
                {
                    int num1 = random.Next(1, 100); 
                    int num2 = random.Next(1, 100);
                    char[] operators = { '+', '-', '*', '/' };
                    char op = operators[random.Next(operators.Length)];

                    Console.Write($"Question {i}: What is {num1} {op} {num2}? : ");
                    double userAnswer = double.Parse(Console.ReadLine());

                    double correctAnswer;
                    switch (op)
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
                            correctAnswer = (double)num1 / num2;
                            break;
                        default:
                            correctAnswer = 0;
                            break;
                    }

                    if (userAnswer == correctAnswer)
                    {
                        Console.WriteLine("Correct!\n");
                        correctAnswers++;
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect! The correct answer is {correctAnswer}.\n");
                    }
                }

                double percentageCorrect = (double)correctAnswers / totalQuestions * 100;

                Console.WriteLine("Results:");
                Console.WriteLine($"Total Correct Answers: {correctAnswers}");
                Console.WriteLine($"Percentage of Correct Answers: {percentageCorrect}%");

                Console.WriteLine("\nDo you want to run the program again? (y/n)");
                char choice = char.ToLower(Console.ReadKey().KeyChar);
                if (choice != 'y')
                    rerun = false;

                Console.WriteLine("\n\n");
            }
        }
    }
}
