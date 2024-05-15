using Microsoft.AspNetCore.Mvc;
using WSSTest.Models;
using WSSTest.Services;

namespace WSSTest.Controllers;

[ApiController]
[Route("[controller]")]
public class XmlCoverterController : ControllerBase
{
	private readonly ILogger<XmlCoverterController> _logger;
	private readonly IDataToXmlConverter _dataToXmlConverter = new DataToXmlConverter();
	private readonly DbContext _context;

	//TODO:Заменить логгер на контекст
	public XmlCoverterController(ILogger<XmlCoverterController> logger)
	{
		_logger = logger;
	}

	//TODO: На весь контроллер! Все методы должны возвращать VIEW
	//TODO: Все методы должны быть асинхронны
	[HttpGet]
	public string ExportData()
	{
		return _dataToXmlConverter.ExportXML(_context);
	}

	[HttpPost]
	public void ImportData(string UserXml)
	{
		_dataToXmlConverter.ImportXML(UserXml, _context);
	}
}