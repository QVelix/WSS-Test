namespace WSSTest.Models;

public class Department
{
	public long Id { get; set; }
	public string Name { get; set; }
	public Company Company { get; set; }
}