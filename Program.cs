using System;
using System.Collections.Generic;
class Employee{
    public int employeeid;
    public string employeename;
    public int employeesalary;

    public Employee(int empid, string empname, int empsal) {
        employeeid = empid;
        employeename = empname;
        employeesalary = empsal;
    }

    public override string ToString() {
        return $"Id: {employeeid}, Name: {employeename}, Salary : {employeesalary}";
    }

}

class Department{
    public int departementid;
    public string departementname;

    public Department(int depid, string depname) {
        departementid = depid;
        departementname = depname;
    }

    public override string ToString() {
        return $"Id: {departementid}, Department Name: {departementname}";
    }

}

class Company{
    private List<Employee> employees;
    private List<Department> departments;

    public Company() {
        employees = new List<Employee>();

        departments = new List<Department>();
    }

    public void AddEmployee(Employee employee) {
        employees.Add(employee);
    }

    public void DisplayEmployee() {
        foreach (var emp in employees) {
            Console.WriteLine(emp);
        }
    }

    public void AddDepartment(Department department) {
        departments.Add(department);
    }

    public void DisplayDepartment() {
        foreach (var dep in departments) {
            Console.WriteLine(dep);
        }
    }

    public void AddSalary(){
        int totalsalary = 0;
        foreach (var emp in employees){
            totalsalary += emp.employeesalary;
        } 
        Console.WriteLine("The total salary is: " + totalsalary) ;
    }


}

class Program {
    static void Main(string[] args) {
        Company company = new Company();

        for (int a=0; a<8; a++){
        Console.WriteLine("Select options from menu:");
        Console.WriteLine(@"
        1. Add Employee
        2. Display Employee
        3. Add Department
        4. Display Department
        5. Add Salary
        6. Exit");
        Console.WriteLine("Enter your option:");
        int num = Convert.ToInt32(Console.ReadLine());

        if(num == 1){
            Console.WriteLine("Enter your limit");
            int lim = Convert.ToInt32(Console.ReadLine());
            for(int x=0; x < lim; x++){
                Console.WriteLine("Enter your Employee ID");
                int empid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your employee name:");
                string empname = Console.ReadLine();
                Console.WriteLine("enter your salary:");
                int salary = Convert.ToInt32(Console.ReadLine());
                company.AddEmployee(new Employee(empid, empname, salary));
            }
        } else if(num==2){
            company.DisplayEmployee();
        } else if(num == 3){
            Console.WriteLine("Enter your limit");
            int lim = Convert.ToInt32(Console.ReadLine());
            for(int x=0; x < lim; x++){
                Console.WriteLine("Enter your department ID");
                int depid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your department name:");
                string depname = Console.ReadLine();
                company.AddDepartment(new Department(depid, depname));
            }
    } else if(num == 4){
        company.DisplayDepartment();
    } else if(num==5){
        company.AddSalary();
    } else if(num ==6){
        Console.WriteLine("Enter any key to exit");
        Console.ReadKey();
    }

    }
}
}