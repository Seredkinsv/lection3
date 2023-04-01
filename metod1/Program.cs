// Vid 1 ничего принимает и не возвращают, начинаются с void
//void Method1()

//{
  //  Console.WriteLine("Authtor...");
//}
//Method1();


// Vid2 что то принимают но ничего не возвращают, начинаются с void
//void Method2(string msg)
//{
  //  Console.WriteLine(msg);
//}
//Method2(msg: "text sms");

//void Method21(string msg, int count)
//{
  //  int i = 0;
   // while (i < count)
    //{
    //    Console.WriteLine(msg);
    //    i++;
  //  }
//}
//Method21(msg: "text", count: 4);
//Method21(count: 4, msg: "new text");

//Vid 3 данные что то возвращают, но ничего не принимают

//int Method3()
//{
//    return DateTime.Now.Year;
//}

//int Year = Method3();
//Console.WriteLine(Year);

// Vid4 Методы которые что то принимают и что то возвращают

//string Method4(int count, string c)
//{
  //  int i = 0;
    //string result = String.Empty;

    //while (i < count)
    //{
      //  result = result + c;
        //i++;
          //  }
            //return result;
//}
//string res = Method4(10, "z");
//Console.WriteLine(res);

string Method4(int count, string c)
{
    
    string result = String.Empty;
for( int i = 0; i < count; i++)
       {
        result = result + c;
                    }
            return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);

for (int i= 1; i <= 10; i++)
{
    for (int j= 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
      Console.WriteLine();
}