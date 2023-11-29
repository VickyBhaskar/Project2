// See https://aka.ms/new-console-template for more information
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "student.txt";

        try
        {
            // Read all lines from the file
            string[] lines = File.ReadAllLines(filePath);

            // Display header
            Console.WriteLine("StudentID\tFirstName\tLastName\tGrade");

            // Display each student's data
            foreach (string line in lines.Skip(1)) // Skip header line
            {
                string[] studentData = line.Split(',');

                // Assuming the order of data in the file is StudentID, FirstName, LastName, Grade
                string studentId = studentData[0];
                string firstName = studentData[1];
                string lastName = studentData[2];
                string grade = studentData[3];

                Console.WriteLine($"{studentId}\t\t{firstName}\t\t{lastName}\t\t{grade}");
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found. Make sure the file exists and try again.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}

