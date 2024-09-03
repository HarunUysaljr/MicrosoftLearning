/*

Gereksinimler:

Veriler:
Her öğrencinin sınav ve ek görev puanlarını içeren diziler.
Öğrenci adları dizisi.

Görevler:
Her öğrencinin sınav puanları ve ek görev puanlarını kullanarak final notunu hesaplamak.
Ek görev puanlarını final notuna etki edecek şekilde değerlendirmek.
Harf notlarını ve ek görev puanlarının etkisini belirlemek.
Not raporunu ekrana yazdırmak.
*/

/*
Detaylar:
Sınav Puanları: Her öğrenci için 5 sınav puanı.
Ek Görev Puanları: Her öğrenci için 4 ek görev puanı.
Sınav Puanları: Final notunun hesaplanmasında anahtar rol oynar.
Ek Görev Puanları: Final notuna %15 oranında katkıda bulunur.
*/

int examAssignments = 5; // sınav ödevlerinin sayısı

string[] studentNames = new string[] { "John", "Mia", "Ethan", "Olivia" };

int[] johnExamScores = new int[] { 82, 90, 76, 88, 91 };
int[] miaExamScores = new int[] { 78, 84, 89, 90, 87 };
int[] ethanExamScores = new int[] { 95, 92, 88, 85, 91 };
int[] oliviaExamScores = new int[] { 80, 82, 86, 89, 84 };

int[] johnExtraCredits = new int[] { 9, 10, 8, 11 };
int[] miaExtraCredits = new int[] { 10, 12, 9, 11 };
int[] ethanExtraCredits = new int[] { 11, 10, 10, 12 };
int[] oliviaExtraCredits = new int[] { 8, 9, 7, 10 };

// Display header row for scores/grades
Console.Clear();
Console.WriteLine("Student\t\tGrade\tLetter Grade\n");


foreach (string name in studentNames)
{
    int[] studentExamScores = new int[examAssignments];
    int[] studentExtraCredits = new int[4];

    if (name == "John")
    {
        studentExamScores = johnExamScores;
        studentExtraCredits = johnExtraCredits;
    }
    else if (name == "Mia")
    {
        studentExamScores = miaExamScores;
        studentExtraCredits = miaExtraCredits;
    }
    else if (name == "Ethan")
    {
        studentExamScores = ethanExamScores;
        studentExtraCredits = ethanExtraCredits;
    }
    else if (name == "Olivia")
    {
        studentExamScores = oliviaExamScores;
        studentExtraCredits = oliviaExtraCredits;
    }
               // Sınav puanlarının toplamını hesaplayın
            int sumExamScores = studentExamScores.Sum();

            // Ek görev puanlarının sınav puanlarına etkisini hesaplayın
            decimal extraCreditImpact = studentExtraCredits.Sum() * 0.15m;

            // Final puanını hesaplayın
            decimal finalScore = sumExamScores + extraCreditImpact;

            // Harf notunu hesaplayın
            string letterGrade = "";

            if (finalScore >= 97)
                letterGrade = "A+";
            else if (finalScore >= 93)
                letterGrade = "A";
            else if (finalScore >= 90)
                letterGrade = "A-";
            else if (finalScore >= 87)
                letterGrade = "B+";
            else if (finalScore >= 83)
                letterGrade = "B";
            else if (finalScore >= 80)
                letterGrade = "B-";
            else if (finalScore >= 77)
                letterGrade = "C+";
            else if (finalScore >= 73)
                letterGrade = "C";
            else if (finalScore >= 70)
                letterGrade = "C-";
            else if (finalScore >= 67)
                letterGrade = "D+";
            else if (finalScore >= 63)
                letterGrade = "D";
            else if (finalScore >= 60)
                letterGrade = "D-";
            else
                letterGrade = "F";

            // Sonuçları yazdırın
            Console.WriteLine($"{name}\t\t{finalScore:F1}\t{letterGrade}");
    }

        // Uygulamanın bitişi
        Console.WriteLine("\n\rPress the Enter key to continue");
        Console.ReadLine();

        //test