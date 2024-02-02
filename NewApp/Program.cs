using NewApp.Models;
public class Program
{
    private static void Main(string[] args)
    {
        //Khoi tao 2 doi tuong thu class Person
        Person ps1 = new Person();
        Person ps2 = new Person();
        //Gán giá trị cho thuộc tính đối tượng ps1
        ps1.FullName = "Nguyen Van A";
        ps1.Address = "Ha Noi";
        ps1.Age = 18;
        //Gán giá trị cho thuộc tính đối tượng ps2
        ps2.FullName = "Nguyễn Van B";
        ps2.Address = "Phu Tho";
        ps2.Age = 19;
        //Gọi phương thức hiển thị thông tin 
        ps1.Display();
        ps2.Display();
    }
}
