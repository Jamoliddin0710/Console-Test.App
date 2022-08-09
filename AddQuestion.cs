using System.Collections;
public class AddQuestion
{
    
       public static void QuestionsAdd(ref  string[][] quiz, ref int start, ref int end)
        {
            char letter = 'A';
            for (var i = start; i < end;  i++)
            {
                int j = 0;
                Console.WriteLine($"Savolni kiritng :");
                quiz[i] = new string[6];
                quiz[i][j++%6] = Console.ReadLine()!;
    
                Console.WriteLine($"T j indeksini kirting :");
                quiz[i][j++%6] = Console.ReadLine()!;
                Console.WriteLine($"Variantlarni kiriting");
                
                for (var k = 0; k < 4; k++)
                {
                  Console.Write($"{letter++} )");
                  if(letter == 'E')
                  letter = 'A';
                    quiz[i][j++%6] = Console.ReadLine()!;
                }
            }
         
            start = end;
            end = quiz.Length;
        }
    }
   
   

