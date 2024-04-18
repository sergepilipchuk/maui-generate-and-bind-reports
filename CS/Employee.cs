namespace maui_generate_and_bind_reports;

public class Employee
{
    public string Name { get; set; }
    public string Position { get; set; }
}

public class EmployeeDataSource
{
    private List<Employee> employees;

    public EmployeeDataSource()
    {
        employees = new List<Employee>()
        {
            new Employee() {
                Name = "Ana Trujillo",
                Position = "CEO"
            },
            new Employee() {
                Name = "Andrew Fuller",
                Position = "Vice President, Sales"
            },
            new Employee() {
                Name = "Nancy Davolio",
                Position = "Accountant"
            },
            new Employee() {
                Name = "Maria Anders",
                Position = "Accountant"
            },
            new Employee() {
                Name = "Antonio Moreno",
                Position = "Sales Representative"
            },
            new Employee() {
                Name = "Thomas Hardy",
                Position = "Sales Representative"
            },
            new Employee() {
                Name = "Christina Berglund",
                Position = "Order Administrator"
            },
            new Employee() {
                Name = "Frédérique Citeaux",
                Position = "Marketing Manager"
            },
            new Employee() {
                Name = "Hanna Moos",
                Position = "Sales Representative"
            }
        };
    }
    public IEnumerable<Employee> Employees
    {
        get => employees;
    }
}
