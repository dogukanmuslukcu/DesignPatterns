using BuilderPattern;
using System.Net.Http.Headers;
using System.Text;

var sb = new StringBuilder();

sb.Append("Doğukan");
sb.Append("Muslukçu");

var fullName = sb.ToString();
Console.WriteLine(fullName);


var eb = new EndPointBuilder("localhost");
eb  
    .Append("api")
    .Append("user")
    .AppendParam("id", "1");

Console.WriteLine(eb.Build());


var empBuilder = new EmployeeBuilder();
var employee = empBuilder
    .SetFullName("Doğukan Muslukçu")
    .SetUserName("DoğukanM")
    .SetEmailAddress("d@muslukcu")
    .BuildEmployee();

Console.WriteLine(employee.FirstName);


IEmployeeBuilderMethot2 employeeBuilder = new InternalEmployeeBuilder();
employeeBuilder
    .SetFullName("Doğukan Muslukçu");

var emp = employeeBuilder.BuildEmployee();

Console.WriteLine(emp.FirstName);
    