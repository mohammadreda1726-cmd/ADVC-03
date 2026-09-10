using Microsoft.VisualBasic;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ADVC_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region Exercise 1: Student Grade Manager
            //// Create a program that manages student grades using One Of Collections
            ////1.Create a Collection with these grades: 85, 92, 78, 95, 88, 70, 100, 65
            //List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };
            ////2.Print the collection, Count, first and last grade
            //Console.WriteLine("Grades:");
            //foreach(int grade in grades)
            //{
            //    Console.WriteLine(grade);
            //}  
            //Console.WriteLine("Count: " + grades.Count);
            //Console.WriteLine("first grade: " + grades[0]);
            //Console.WriteLine("last grade: " + grades[grades.Count - 1]);
            ////3.Sort the grades ascending, then print
            //grades.Sort();
            //Console.WriteLine("Grades (sorted):");
            //foreach(int grade in grades)
            //{
            //    Console.WriteLine(grade);
            //}
            ////4.Get the first grade above 90
            //foreach (int grade in grades)
            //{ if (grade > 90)
            //    Console.WriteLine("\nFirst grade above 90: " + grade); break; 
            //}
            ////5.Get all grades below 75(failing grades)
            //Console.WriteLine("\nFailing grades:");
            //foreach (int grade in grades) 
            //{ if (grade < 75)
            //     Console.Write(grade + " "); 
            //}
            //Console.WriteLine();
            ////6.Remove all failing grades(below 75)
            //for (int i = grades.Count - 1; i >= 0; i--)
            //{
            //    if (grades[i] < 75) 
            //        grades.RemoveAt(i);
            //}
            //Console.WriteLine("\nGrades after removing failing grades:");
            //foreach (int grade in grades)
            // Console.Write(grade + " "); 
            //Console.WriteLine();

            ////7.Check if any grade equals 100
            //bool has100 = false;
            //foreach (int grade in grades)
            //{ if (grade == 100) 
            //     has100 = true; break;  
            //}
            //Console.WriteLine("\nAny grade equals 100? " + has100);

            ////8.Create a List<string> where each grade becomes "Grade: X"
            //List<string> gradeMessages = new List<string>();
            //foreach (int grade in grades) 
            //{ 
            //    gradeMessages.Add("Grade: " + grade); 
            //}
            //Console.WriteLine("\nGrade messages:");
            //foreach (string message in gradeMessages)
            //{
            //    Console.WriteLine(message);
            //}

            //#endregion


            //#region Exercise 2: Leaderboard
            ////Create a leaderboard that automatically sorts players by score.
            //// key = score
            //// value = player name
            //Dictionary<int, string> leaderboard = new Dictionary<int, string>();
            ////1.Add: 500 = "Ahmed", 200 = "Sara", 800 = "Ali", 350 = "Mona"
            //leaderboard.Add(500, "Ahmed");
            //leaderboard.Add(200, "Sara");
            //leaderboard.Add(800, "Ali");
            //leaderboard.Add(350, "Mona");

            ////2.Print all entries(they should be sorted by score automatically)
            //List<int> scores = new List<int>(leaderboard.keys);
            //scores.Sort();
            //Console.WriteLine("Leaderboard :");

            //foreach (int score in scores)
            //    Console.WriteLine(score + " = " + leaderboard[score]);

            ////3.Access the first key and first value
            //int firstKey = scores[0];
            //string firstValue = leaderboard[firstKey];

            //Console.WriteLine("\nFirst Key: " + firstKey);
            //Console.WriteLine("First Value: " + firstValue);

            ////4.Check if score 500 exists
            //if (leaderboard.ContainsKey(500)) 
            //{ 
            //    Console.WriteLine("\nScore 500 exists");
            //} 
            //else
            //{
            //    Console.WriteLine("\nScore 500 does not exist");
            //}
            ////5.Safely get the player with score 999
            //string playerName;

            //if (leaderboard.TryGetValue(999, out playerName))
            //{
            //    Console.WriteLine("\nPlayer with score 999: " + playerName);
            //}
            //else
            //{
            //    Console.WriteLine("\nNo player with score 999");
            //}

            ////6.Remove the player with score 200 and print the updated list
            //leaderboard.Remove(200);

            //Console.WriteLine("\nLeaderboard after removing score 200:"); 
            //scores = new List<int>(leaderboard.Keys);
            //scores.Sort(); 
            //foreach (int score in scores) 
            //{
            //    Console.WriteLine(score + " = " + leaderboard[score]);
            //}

            //#endregion


            #region Exercise 3: Phone Book
            //Build a phone book application.
            //1.Create a Collection with 4 contacts(name → phone number)

            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            phoneBook.Add("Ahmed", "01012345678");
            phoneBook.Add("Sara", "01123456789");
            phoneBook.Add("Ali", "01234567890");
            phoneBook.Add("Mona", "01512345678");
            //2.Add a new contact using [] syntax (add or update)

            phoneBook["Omar"] = "01098765432";
            //3.Try adding a duplicate using .Add() — catch the exception and print the error

            try
            { 
                phoneBook.Add("Ahmed", "01111111111"); 
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message); 
            }
            //4.Try adding a duplicate using .TryAdd() — print whether it succeeded

            bool result = phoneBook.TryAdd("Ahmed", "01222222222");
            Console.WriteLine("TryAdd succeeded: " + result);
            //5.Search for a contact that doesn’t exist

            if (phoneBook.ContainsKey("Youssef")) 
            { 
                Console.WriteLine("Youssef is found");
            } 
            else
            { 
                Console.WriteLine("Youssef is not found");
            }
            //6.Get a contact with a fallback of "Not Found"

            string phone;
            if (phoneBook.TryGetValue("Youssef", out phone))
            {
                Console.WriteLine("Phone: " + phone);
            }
            else
            { 
                Console.WriteLine("Phone: Not Found");
            }
            //7.Print all Keys on one line, then all Values on another line

            Console.WriteLine("\nKeys:");
            foreach (string name in phoneBook.Keys) 
            {
                Console.Write(name + " ");
            }
            Console.WriteLine(); 
            // Print all Values on another line

            Console.WriteLine("Values:"); 
            foreach (string number in phoneBook.Values)
            { 
                Console.Write(number + " "); 
            } 
            Console.WriteLine();

            #endregion
        }
    }
}