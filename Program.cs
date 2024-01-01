﻿string [] ShowElemsWhichEqualAndLessThenThree (string [] arr)
{    
    string [] result = new string [arr.Length];

    for (int i = 0; i < arr.Length; i++)
    {
        string str = arr[i];
        int length = str.Length;
        if (length <= 3)
        {
            result[i] = arr[i];            
        }
    }    
   return result;    
}

string [] strArray1 = {"Hello", "2", "world", ":-)"};
string [] strArray2 = {"123", "1567", "-2", "computer science"};
string [] strArray3 = {"Russia", "Denmark", "Kazan", "Nim"};

Console.Clear();
string [] showElemsWhichEqualAndLessThenThree1 = ShowElemsWhichEqualAndLessThenThree (strArray1);
string [] showElemsWhichEqualAndLessThenThree2 = ShowElemsWhichEqualAndLessThenThree (strArray2);
string [] showElemsWhichEqualAndLessThenThree3 = ShowElemsWhichEqualAndLessThenThree (strArray3);
