﻿/*

Bir okulda öğretmen yardımcısı olduğunuzu ve not verme sürecini otomatikleştirmek için bir uygulama geliştirdiğinizi varsayalım. 
Uygulama, öğrenci adlarını ve notlanmış ödevleri depolamak için dizileri kullanır. 
Uygulama ayrıca her öğrencinin son notunu hesaplamak ve raporlamak için yineleme ve seçim deyimlerinin bir bileşimini uygular. 
Uygulamanız, öğrenci notlarını hesaplarken sınav ödevleri ile ek kredi ödevleri arasında bile ayrım yapıyor. 
Uygulama öğretmenin istediği her şeyi yapsa da yeni özellikler için bir istek aldınız. 
Öğretmen, son sayısal puan ve harf notundan ayrı olarak sınav ve ek kredi ödevi puanlarını göstermek için not verme raporunu güncelleştirmenizi istedi.

Bu modül, Öğrenci Notlama uygulamanıza yeni özellikler eklemeniz için sizi zorlar.

Kısacası öğretmenin güncelleştirilmiş not raporu belirtimini kullanarak şunları yapmanız gerekir:

sınavlar, ek kredi ödevleri ve genel not için ayrı final puanlarını hesaplamak için yineleme ve seçim kodunu güncelleştirin.
not raporunu konsola yazan kodu güncelleştirin.
Bu modülün sonunda, öğrenci notlarını öğretmenin güncelleştirilmiş gereksinimlerine uygun olarak hesaplayıp raporlayabilen, 
Öğrenci Notlama uygulamasının güncelleştirilmiş bir sürümüne sahip olacaksınız

*/

int examAssignments = 5;

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

// display the header row for scores/grades
Console.Clear();
Console.WriteLine("Student\t\tGrade\tLetter Grade\n");

/*
The outer foreach loop is used to:
- iterate through student names 
- assign a student's grades to the studentScores array
- sum assignment scores (inner foreach loop)
- calculate numeric and letter grade
- write the score report information
*/
foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    int sumAssignmentScores = 0;

    decimal currentStudentGrade = 0;

    int gradedAssignments = 0;

    /* 
    the inner foreach loop sums assignment scores
    extra credit assignments are worth 10% of an exam score
    */
    foreach (int score in studentScores)
    {
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
            sumAssignmentScores += score;

        else
            sumAssignmentScores += score / 10;
    }

    currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";

    // Student         Grade
    // Sophia:         92.2    A-
    
    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
}

// required for running in VS Code (keeps the Output windows open to view results)
Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();
