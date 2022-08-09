

public class Testniboshlash
{
    


public static void print (ref string[][] quiz )
{
   char jav = 'A';
for (int i = 0; i <= quiz.Length ; i++)
{
    if (quiz[i] == null)
        break;

    for (int j = 0; j < quiz[i].Length; j++)
    {
        if (j == 0) Console.WriteLine("Savol = " + quiz[i][j]);
        else if(j != 1) Console.WriteLine($"{jav++}. {quiz[i][j]}");
    }
    
    Console.Write("Javob : ");
    var input = Console.ReadLine();

    string javob = "Notogri";
    if (input == (int.Parse(quiz[i][1]) - 1).ToString()) javob = "Togri";

    Console.WriteLine($"{javob}\n Keyingi savolga enter bosing");
    Console.ReadKey();
}
}

}