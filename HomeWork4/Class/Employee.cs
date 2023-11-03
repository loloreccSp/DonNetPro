namespace HomeWork4
{
    public class Employee : SalaryEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Employee(int id, string name, string surname, string phone, string email, int salary) : base(salary)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Phone = phone;
            Email = email;
            Salary = salary;
        }


        public void InfoEmployee() => Console.WriteLine($"Employe id: {Id}; " +
            $"Employee: {Name} {Surname}; " +
            $"Phone: {Phone}; " +
            $"Email: {Email}; " +
            $"Sal: {Salary}grn");
    }



    public class SalaryEmployee
    {
        public int Salary { get; set; }

        public SalaryEmployee(int salary)
        {
            Salary = salary;
        }
        public static SalaryEmployee operator +(SalaryEmployee salary, SalaryEmployee salaryAdd)
        => new (salary.Salary + salaryAdd.Salary);

        public static SalaryEmployee operator -(SalaryEmployee salary, SalaryEmployee salaryAdd)
        => new (salary.Salary - salaryAdd.Salary);


        public static bool operator ==(SalaryEmployee salary, SalaryEmployee salaryequals)
        => salary.Salary == salaryequals.Salary;
        public static bool operator !=(SalaryEmployee salary, SalaryEmployee salaryequals)
        => salary.Salary != salaryequals.Salary;


        public static bool operator >(SalaryEmployee salary, SalaryEmployee salaryequals)
        => salary.Salary > salaryequals.Salary;
        public static bool operator <(SalaryEmployee salary, SalaryEmployee salaryequals)
        => salary.Salary < salaryequals.Salary;
    };
}
