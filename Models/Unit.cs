namespace WSSTest.Models;

//Это модель отдела
public class Unit
{
	public long Id { get; set; }

	public string Name
	{
		get { return Name + " " + Id.ToString(); }
		set { Name = value; }
	}
	public Department Department { get; set; }
}