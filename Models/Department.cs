namespace WSSTest.Models;

public class Department
{
	public long Id { get; set; }

	public string Name
	{
		get { return Name + " " + Id.ToString(); }
		set { Name = value; }
	}

	public Company Company { get; set; }
}