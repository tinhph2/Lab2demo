/* Anonymous type trong C# là một kiểu dữ liệu được tạo ra thông qua new và danh sách các thuộc tính được 
 * khai báo cùng với giá trị của chúng trong dấu ngoặc nhọn {}. 
 * Kiểu dữ liệu này được sử dụng khi cần tạo một đối tượng
 * với các thuộc tính cụ thể nhưng không cần định nghĩa một class hoặc struct tường minh
 * 
 * Anonymous type hữu ích trong các trường hợp mà bạn cần tạo một đối tượng
 * nhưng không cần định nghĩa một class hay struct mới.
 */

using System;

class Program
{
    static void Main()
    {
        var person = new
        {
            Name = "Alice",
            Age = 30,
            Occupation = "Engineer"
        };

        Console.WriteLine($"Person: {person.Name}, Age: {person.Age}, Occupation: {person.Occupation}");
    }
}