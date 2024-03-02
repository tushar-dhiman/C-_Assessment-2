
/*
Write a program and ask the user to enter a few words separated by a space. 
Use the words to create a variable name with PascalCase. 
For example, if the user types: "number of students", display "NumberOfStudents". 
Make sure that the program is not dependent on the input. 
So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
*/



using Problem_1;


class PascalScaleMain
{
    public static void Main(string[] args)
    {

        UserInput userInput = new UserInput();

        PascalScaleFormatter pascalScaleFormatter = new PascalScaleFormatter();

        Console.WriteLine("Enter few words separated by space.");
        string userString = userInput.inputFromUser();

        string pascalScaleConvertedString = pascalScaleFormatter.toPascalScale(userString);
        Console.WriteLine("PascalScale String = " + pascalScaleConvertedString);

    }
}