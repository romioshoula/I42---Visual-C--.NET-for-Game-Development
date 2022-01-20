using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_ExaminationSystem_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable for type selection of examination (Final / Practice)
            int TypeOfExam = 1;

            //Welcoming and selection choice
            Console.Write("Welcome to my exam system :), Please Enter 1 to take the Final Exam, or 2 to take the Practice Exam: ");

            //if statement here -> reminder to implement the if statement at line 60
            TypeOfExam = int.Parse(Console.ReadLine());

            //checking input from user
            while (TypeOfExam < 1 || TypeOfExam > 2)    //(TypeOfExam!=1 || TypeOfExam!=2)
            {
                Console.Write("Kindly enter either 1 for Final Exam, or 2 for Practice Exam: ");
                TypeOfExam = int.Parse(Console.ReadLine());
            }

            //Confirmation
            if (TypeOfExam == 1)
            {
                Console.Write("You have selected: Final Exam: (press enter to confirm)");
                Console.ReadLine();
            }
            else
            {
                Console.Write("You have selected: Practice Exam: (press enter to confirm)");
                Console.ReadLine();
            }

            //Declaring exam subject
            Subject subject = new Subject("Object-Oriented Data Structures in C++ (Coursera)");

            //Declaring all questions and their respective data (Question Body, Answers, marks, etc. )
            Question q1 = new ChooseOne("Choose 1: One of these statements below is true and the other two are false. Which one is true ? ", new string[3] { "Every variable in C++ has to be associated with a specific type.", "A Boolean variable can only be assigned a value from this set of three reserved words: { true, false, undefined}.", "Every function in C++ must return a value." }, 5, 0);
            Question q2 = new ChooseOne("Choose 1: According to the C++ standard, what is the name of the function that is the starting point for a program? ", new string[4] { "start()", "init()", "begin()", "main()" }, 5, 3);
            Question q3 = new ChooseAll("Select all of the following that are true?", new string[4] { "C++ allows a member variable to be declared in a user-defined class with an unknown type that can by defined when an object of that class is created.", "C++ allows a variable to be declared in a user-defined function with an unknown type that can be defined when the function is called.", "C++ allows a local variable to be declared in main() with an unknown type that can be defined when the program is executed.", "C++ allows a variable to be declared in a user-defined member function of a user-defined class that can be defined when the function is called." }, 3, new int[3] {0,1,3});
            Question q4 = new ChooseAll("Select all of the following that will not generate an error at compile time?", new string[4] { "std::vector v;", "std::vector<double> v;", "std::vector<char[256]> v;", "std::vector<std::vector<int>> v;" }, 3, new int[3] { 1, 2, 3 });
            Question q5 = new TrueFalse("True/False: C++ allows a member variable to be declared in a user-defined class with an unknown type that can by defined when an object of that class is created?", 7, 0);
            Question q6 = new TrueFalse("True/False: C++ allows a variable to be declared in a user-defined function with an unknown type that can be defined when the function is called?", 7, 0);
            Question q7 = new TrueFalse("True/False: C++ allows a local variable to be declared in main() with an unknown type that can be defined when the program is executed?", 7, 1);
            Question q8 = new TrueFalse("True/False: C++ allows a variable to be declared in a user-defined member function of a user-defined class that can be defined when the function is called?", 7,0);
            Question q9 = new ChooseOne("Choose 1: Which one of the following properly declares the class RubikCube derived from the base class Cube?", new string[4] { "class Cube : public RubikCube {...};", "class RubikCube : public Cube {...};", "class RubikCube(Cube) {...};", "class Cube(RubikCube) {...};" }, 5, 1);
            Question q10 = new ChooseOne("Choose 1: C++ is ...?", new string[3] { "... a great language for programming data structures.", "... the greatest language for programming data structures ever!", "... meh." }, 5, 0);

            //Saving questions to external file
            QuestionList questions = new QuestionList("Questions_Print.txt");

            //Adding all questions
            questions.Add(q1);
            questions.Add(q2);
            questions.Add(q3);
            questions.Add(q4);
            questions.Add(q5);
            questions.Add(q6);
            questions.Add(q7);
            questions.Add(q8);
            questions.Add(q9);
            questions.Add(q10);

            //saving date
            DateTime date = DateTime.Now; //this is a dynamic datetime (realtime of excecution)
            //DateTime date = new DateTime(2021, 12, 31); // this is a static datetime (fixed)

            //If statement to exceute either FinalExam (Only Shows The Question and Answers)
            //<========================>//or PracticeExam (Shows the right answer after finishing taking the Exam)

            if (TypeOfExam == 1)    //FinalExam (Only Shows The Question and Answers)
            {
                Exam ex1 = new FinalExam(date, subject, questions);
                ex1.printExam();
            }
            else                    //PracticeExam (Shows the right answer after finishing taking the Exam)
            {
                Exam ex2 = new PracticeExam(date, subject, questions);
                ex2.printExam();
            }

            //removed this implementation

            //Exam ex1 = new FinalExam(date, subject, questions);
            //ex1.printExam();
            //Exam ex2 = new PracticeExam(date, subject, questions);
            //ex2.printExam();

            //Waiting enter from user to close the program
            Console.Write("Exam Finished? ");
            Console.ReadLine();
        }
    }
}
