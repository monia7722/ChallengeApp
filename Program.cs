using ChallengeApp;

Employee employee1 = new Employee("Anna", "Wiosna", 23);
Employee employee2 = new Employee("Malwina", "Lato", 25);
Employee employee3 = new Employee("Julia", "Jesień", 27);

employee1.AddScore(4);
employee1.AddScore(5);
employee1.AddScore(7);
employee1.AddScore(2);
employee1.AddScore(4);

employee2.AddScore(2);
employee2.AddScore(4);
employee2.AddScore(6);
employee2.AddScore(8);
employee2.AddScore(4);

employee3.AddScore(1);
employee3.AddScore(3);
employee3.AddScore(2);
employee3.AddScore(8);
employee3.AddScore(3);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};
int maxResult = -1;
Employee employeeWithMaxResult = null;
foreach (var employee in employees)
{
    if(employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employeeWithMaxResult = employee;
    }
}
Console.WriteLine("Pracownikiem z największą liczbą punktów jest " + employeeWithMaxResult.name + employeeWithMaxResult.surname + ", wiek " + employeeWithMaxResult.age + " z wynikiem " + employeeWithMaxResult.Result);