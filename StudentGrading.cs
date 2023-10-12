// setting up students + their scores
double[] Barbara = { 89, 94, 49, 96, 90 };
double[] Joszef = { 84, 90, 69, 66, 91 };
double[] Nicolas = { 89, 74, 79, 95, 91 };
double[] Sophie = { 89, 84, 49, 94, 91 };

//creating overall studentsArray to use in outer for-loop
double[][] students = { Barbara, Joszef, Nicolas, Sophie };

//creating array to hold all student names as converting double[] is a bitch
string[] studentNames = {"Barbara", "Joszef", "Nicolas", "Sophie"};


//starting for-loop
for (int i = 0; i < students.Length; i++)
{
    string letterGrade = "";
    double totalOfGrades = 0;
    for (int j = 0; j < students[i].Length; j++)
    {   

        totalOfGrades += students[i][j];
    }

    double interimFinalScore = totalOfGrades / 5;
    double extraCredit = Math.Round(interimFinalScore / 10, 2);
    double finalNumericGrade = Math.Round(interimFinalScore + extraCredit, 2);

    if (finalNumericGrade >= 90) {
        letterGrade = "A";
    } else if (finalNumericGrade >= 80) {
        letterGrade = "B";
    } else if (finalNumericGrade >= 70) {
        letterGrade = "C";
    } else if (finalNumericGrade >= 60) {
        letterGrade = "D";
    } else {
        letterGrade = "F";
    }

    //printing out the results:
    Console.WriteLine($"{studentNames[i]} has scored an average of:\t {interimFinalScore}");
    Console.WriteLine($"The extra credit {studentNames[i]} received is:\t {extraCredit}");
    Console.WriteLine($"This sums up to a final score of:\t {finalNumericGrade}");
    Console.WriteLine($"In letter grades that would be:\t\t {letterGrade}");
    Console.WriteLine();
}





