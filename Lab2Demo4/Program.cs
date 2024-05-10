/*
 * Trong C#, nullable type là kiểu dữ liệu cho phép biến của bạn có thể lưu trữ giá trị null 
 * ngoài giá trị dữ liệu thực sự của kiểu dữ liệu đó. 
 * Điều này rất hữu ích khi bạn muốn biết biến đó chưa được khởi tạo hoặc có giá trị thực sự hay không.
 * 
 * Sử dụng nullable type giúp xử lý việc biến có thể không chứa giá trị dữ liệu và giúp tránh việc nhầm lẫn 
 * giữa giá trị thực sự và giá trị không xác định.
 */

using System;

class Program
{
    static void Main()
    {
        int? nullableInt = null; // Khai báo một biến kiểu int có thể là null
        double? nullableDouble = 3.14;

        Console.WriteLine("Giá trị của nullableInt: " + nullableInt);
        Console.WriteLine("Giá trị của nullableDouble: " + nullableDouble);

        // Sử dụng toán tử null-coalescing để xác định giá trị mặc định nếu biến là null
        int actualInt = nullableInt ?? 0;
        double actualDouble = nullableDouble ?? 0.0;

        Console.WriteLine("Giá trị thực tế của actualInt: " + actualInt);
        Console.WriteLine("Giá trị thực tế của actualDouble: " + actualDouble);
    }
}