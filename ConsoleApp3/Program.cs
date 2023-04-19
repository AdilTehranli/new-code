

//using System;

//Console.WriteLine("Birinci ededi daxil edin:");
//int n = int.Parse(Console.ReadLine());
//Console.WriteLine("Ikinci ededi daxil edin:");
//int m = int.Parse(Console.ReadLine());
//int sum = 0;


//while (n <= m)
//{
    
//    if (n % 2 != 0)
//    {
//        sum += n;
        
//    }
//    n++;
    
//}
//Console.WriteLine("Cem : " + sum);


//#region fesillerin tapilmasi
//int monthIndex =int.Parse(Console.ReadLine());
//string result = monthIndex switch
//{
//    >=0 and <=2 or 12 => "Winter",
//    >=4 and  <= 6 =>"spring",
//    >= 8 and <= 10 =>"summer",
//    >=12 and <= 14 => "autumn",
//};
//Console.WriteLine(result);
//#endregion

//#region qisa yolla arrayin icindekileri ekrana yazdirma
//int[] arr = { 1, 39, 5, 3, 2 };
//foreach (int item in arr)
//{
//    Console.WriteLine(item);
//}
//#endregion 


//int DayIndex = 0;
//string result = DayIndex switch
//{
//    >= 0 and <= 4 => "weekday",
//    _ => "weekend"
//};
//Console.WriteLine(result);
