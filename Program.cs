using System;

public class Program
{

    public static void Main()
    {
        int[] input = new int[3];
        int count = 0;

        input[0] = int.Parse(Console.ReadLine());
        input[1] = int.Parse(Console.ReadLine());
        input[2] = int.Parse(Console.ReadLine());

        int num = input[0] * input[1] * input[2];

        char[] pieceNum = num.ToString().ToCharArray();

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < pieceNum.Length; j++)
            {
                //int는 안되고 string 으로 하니 출력값이 잘나온다 왜...
                //if (pieceNum[j] == i) {
                if (pieceNum[j].ToString() == i.ToString())
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            count = 0;
        }



    }
}