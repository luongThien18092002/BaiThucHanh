namespace NewApp.Models
{
    public class Employee
    {
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        //Nhập thông tin 
        public void EnterData()
        {
            System.Console.Write(" EmployeeCode = ");
            EmployeeCode = Console.ReadLine();
            System.Console.Write("EmployeeName = ");
            EmployeeName = Console.ReadLine();
            System.Console.Write("Age = ");
            Age = Convert.ToInt16(Console.ReadLine());
        }
        //Hiển thị thông tin
        public void Display(){
            System.Console.WriteLine(" {0} - {1} - {2}",EmployeeCode ,EmployeeName , Age);
        }
    }
}