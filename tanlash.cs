public class tanlash
{
    public void tanlang (){

    string[][] quiz = new string[100][];

quiz[0] = new string[6]{"4 + 2 = ?", "3", "5", "6", "2", "8"};
quiz[1] = new string[6]{"4 * 2 = ?", "2", "8", "18", "22", "0"};
quiz[2] = new string[6]{"4 / 2 = ?", "5", "145", "652", "9", "2"};
quiz[4] = new string[6]{"4 - 2 = ?", "2", "0", "652", "9", "4"};
    
Console.WriteLine($"1. Testni boshlash");
Console.WriteLine($"2. Savol qo'shish");
Console.WriteLine($"3. Ma'lumot");
Console.WriteLine($"4. Statistika ");
int n = int.Parse(Console.ReadLine()!);
 switch(n)
 {
    case 1: Testniboshlash.print(ref quiz); break;
    case 2: int start = 5;
int end = int.Parse(Console.ReadLine()!);
 AddQuestion.QuestionsAdd(ref quiz, ref start, ref end); break;
 
    case 3: Testniboshlash.print(ref quiz); break;
    case 4: Testniboshlash.print(ref quiz); break;
 };

    } 
}