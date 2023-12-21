Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<Customer>();
for (int i = 0; i < numberOfRecords; i++)
{
	// In this loop, populate the object's properties using Console.ReadLine()
	var customer = new Customer();

	Console.WriteLine("Enter the value for " + "First Name");
	customer.FirstName = Console.ReadLine();

	Console.WriteLine("Enter the value for " + "Last Name");
	customer.LastName = Console.ReadLine();

	Console.WriteLine("Enter the value for " + "City");
	customer.City = Console.ReadLine();

	Console.WriteLine("Enter the value for " + "Age");
	customer.Age = Console.ReadLine();

	recordList.Add(customer);
}

foreach (Customer record in recordList)
{
	Console.WriteLine(record.ToString());
}

public class Customer
{
	private string firstName;
	public string FirstName { get { return firstName; } set {  firstName = value; } }

	private string lastName;
	public string LastName { get { return lastName; } set { lastName = value; } }
	
	private string city;
	public string City { get { return city; } set { city = value; } }
	
	private string age;
	public string Age { get { return age; } set { age = value; } }

	public override string ToString()
	{
		return string.Join("; ",
		  $"First Name = {FirstName}",
		  $"Last Name = {LastName}",
		  $"City = {City}",
		  $"Age = {Age}"
		);
	}
}

// Print out the list of records using Console.WriteLine()