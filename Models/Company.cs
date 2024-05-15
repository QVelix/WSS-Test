namespace WSSTest.Models;

public class Company
{
	public long Id { get; set; }
	public string Name
	{
		get { return Name + " " + Id.ToString(); }
		set { Name = value; }
	}
}