/*Trong C#, "implicitly" thường được sử dụng để chỉ việc chuyển đổi dữ liệu từ kiểu dữ liệu này sang kiểu dữ liệu khác
  mà không cần khai báo hoặc định rõ kiểu chuyển đổi.*/

using System;

class Program
{
    static void Main()
    {
        float integerValue = 10;
        double doubleValue = integerValue; // Chuyển đổi ngầm định từ int sang double

        Console.WriteLine("Giá trị int: " + integerValue);
        Console.WriteLine("Giá trị double sau khi chuyển đổi từ int: " + doubleValue);
    }
}