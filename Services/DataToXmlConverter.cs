using System.Text;
using System.Xml.Serialization;

namespace WSSTest.Services;

public class DataToXmlConverter : IDataToXmlConverter
{
	public string ExportXML(DbContext context)
	{
		//TODO:Привести к рабочему коду
		var allData = context.ToList();
		XmlSerializer serializer = new XmlSerializer(typeof(allData));
		StringWriter stringWriter = new StringWriter();
		
		serializer.Serialize(stringWriter, allData);
		return stringWriter.ToString();
	}

	public void ImportXML(string UserXml, DbContext context)
	{
		//TODO:Привести к рабочему коду
		var allData = context.ToList();
		using (Stream reader = new MemoryStream(Encoding.UTF8.GetBytes(UserXml)))
		{
			XmlSerializer serializer = new XmlSerializer(typeof(allData));
			context.Entry(serializer.Deserialize(reader)).State = EntityState.Modified;
		}
		
	}
}