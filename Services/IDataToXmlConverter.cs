namespace WSSTest.Services;

public interface IDataToXmlConverter
{
	string ExportXML(DbContext context);

	void ImportXML(string UserXml, DbContext context);
}