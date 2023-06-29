using System;

namespace csharp.ru {
public class Program {

public static void Main(string[] args) {
    //Console.WriteLine("Колчество чисел больше 0 : " + method1());
    method2();
}

public static int method1() {
    List<Int32> list = new List<Int32>();

    for(int i = 0; i < 10; i++) {
        Console.WriteLine("Введите число: ");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a > 0) {list.Add(a);}
    }

    return list.Count;
}

public static void method2() {
    Console.WriteLine("Введите число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число: ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число: ");
    int c = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число: ");
    int d = Convert.ToInt32(Console.ReadLine());

    if (a != c) {
        int f = (d-b)/(a-c);
        int g = a*f + b;
        
        Console.WriteLine(f + " " + g);
    }
    else Console.WriteLine("Прямые параллельны");
}


}
}
