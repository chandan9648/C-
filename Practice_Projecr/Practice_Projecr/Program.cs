//int[,] marks = new int[2,2];
//for(int i = 0; i < 2; i++)
//{
//    for(int j = 0; j < 2; j++)
//    {
//        Console.WriteLine("Enter mark of students");
//        marks[i,j] = Convert.ToInt32(Console.ReadLine());

//    }
//}
//for(int i = 0; i<marks.Length; i++)
//{
//    for (int j = 0; j < 2; j++)
//    {
//        Console.WriteLine(marks[i, j]);
//    }
//}
//foreach(int i in marks)
//{
//    Console.WriteLine(i);
//}


//multi dimension array.... 


//String
//find vowel and consonent in string

String s3 = "concept";
char[] arr = s3.ToCharArray();
int v = 0;
int c = 0;
foreach(char ch in arr)
{
    switch (ch)
    {
        case 'a':
        case 'e':
        case 'i':
        case 'o':
        case 'u':
            v++;
            break;
            default:
            c++;
            break;
    }
}
Console.WriteLine("Total vowel is {0} and consonent is {1}", v, c);