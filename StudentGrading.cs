// setting up students + their scores
decimal[] Barbara = {89, 94, 29, 96, 90};
decimal[] Josef = {84, 90, 69, 66, 91};
decimal[] Nicolas = {89, 74, 59, 95, 91};
decimal[] Sophie = {89, 84, 49, 94, 91};

//creating overall studentsArray to use in outer for-loop
decimal[][] students = {Barbara, Josef, Nicolas, Sophie};

//starting for-loop
foreach (var student in students) {
    decimal totalOfGrades = 0;
    for(int i = 0; i < student.Length; i++) {
        totalOfGrades += student[i];
    }

    decimal interimFinalScore = totalOfGrades / 5; 
    decimal extraCredit = interimFinalScore / 10;
    decimal finalNumericGrade = interimFinalScore + extraCredit;

    //adding extra credit to the array 
    student.Add(extraCredit);

    //printing out the results:
    Console.WriteLine($"{students[student]} has scored an average of: {interimFinalScore}");
    Console.WriteLine($"The extra credit {students[student]} received is: {extraCredit}.");
    Console.WriteLine($"This sums up to a final score of: {finalNumericGrade}");
}





