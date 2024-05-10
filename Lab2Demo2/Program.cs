/* Trong C#, từ khóa var được sử dụng để khai báo biến mà không cần phải chỉ định rõ kiểu dữ liệu của biến đó. 
 * Kiểu dữ liệu của biến sẽ được xác định dựa trên giá trị mà nó được gán trong quá trình khởi tạo
 * 
 * Từ khóa var thường được sử dụng để viết mã ngắn gọn và dễ đọc hơn, 
 * đặc biệt khi kiểu dữ liệu của biến là rõ ràng từ giá trị khởi tạo.
 * */

using System;

class Program
{
    static void Main()
    {
        var name = "John";
        var age = 30;
        var isStudent = true;

        Console.WriteLine($"Name: {name}, Age: {age}, Is Student: {isStudent}");

        var numbers = new int[] { 1, 2, 3, 4, 5 };
        foreach (var number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}