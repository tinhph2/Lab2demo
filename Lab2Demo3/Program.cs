/* Trong C#, từ khóa dynamic được sử dụng để xác định một biến mà kiểu dữ 
 * liệu của nó được xác định vào thời điểm thực thi, 
 * chứ không phải tại thời điểm biên dịch.
 * 
 * Biến dynamic cho phép chúng ta làm việc với các loại dữ liệu không xác định tại thời điểm biên dịch, 
 * giúp tăng tính linh hoạt trong việc lập trình. Tuy nhiên, cần lưu ý rằng việc sử dụng dynamic có thể 
 * ảnh hưởng đến hiệu suất và tính ổn định của ứng dụng trong một số trường hợp.*/

using System;

class Program
{
    static void Main()
    {
        dynamic dynamicVariable = 10; // Khai báo biến dynamic và gán giá trị là 10
        Console.WriteLine($"Kiểu dữ liệu của dynamicVariable: {dynamicVariable.GetType()}");

        dynamicVariable = "Hello, dynamic!"; // Thay đổi giá trị của biến dynamic thành một chuỗi
        Console.WriteLine($"Kiểu dữ liệu của dynamicVariable sau khi thay đổi: {dynamicVariable.GetType()}");

        dynamic dynamicObject = new { Name = "Alice", Age = 25 }; // Khởi tạo một dynamic object
        Console.WriteLine("Thông tin: Name - " + dynamicObject.Name + ", Age - " + dynamicObject.Age);

        dynamic result = AddDynamic(5, 3);
        Console.WriteLine($"Kết quả của phép cộng: {result}");
    }

    static dynamic AddDynamic(dynamic a, dynamic b)
    {
        return a + b;
    }
}