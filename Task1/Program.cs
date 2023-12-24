 // Задайте двумерный массив символов (тип char [,]). 
 //Создать строку из символов этого массива
// a b c => “abcdef”
// d e f

char[,] elements = new char[,]{{'a','b','c'},{'d','e','f'}};

string str = "";
string GetStringFrom2DArrayChar()
{
    string result="";
    {
        for(int i=0; i < elements.GetLength(0); i++)
        {
            for(int j=0; j < elements.GetLength(1); j++ )
            {
                result+= elements[i,j];
            }
        }
        return result;
    }
}
str= GetStringFrom2DArrayChar();
Console.WriteLine(str);




