using Microsoft.AspNetCore.Mvc;
using WSSTest.Models;

namespace WSSTest.Controllers;

[ApiController]
[Route("[controller]")]
public class CompanyController : ControllerBase
{
	private readonly ILogger<CompanyController> _logger;

	//TODO:Заменить логгер на контекст
	public CompanyController(ILogger<CompanyController> logger)
	{
		_logger = logger;
	}

	//TODO: На весь контроллер! Все методы должны возвращать VIEW
	[HttpGet]
	public IEnumerable<Company> Get()
	{
		/*
		 * TODO: Заменить код ниже на работающий с базой данных, который получит список компаний
		 */
		return new List<Company>();
	}

	[HttpGet("{id}")]
	public Company Get(long id)
	{
		/*
		 * TODO: Заменить код ниже на работающий с базой данных, который получит компанию по id. Что-то типа context.Company.Select(company=>company.id==id)
		 */
		return new Company();
	}

	[HttpPost]
	public void Add(Company c)
	{
		/*
		 * TODO: Заменить код ниже на работающий с базой данных, который добавит компанию. Что-то типа context.Company.Add(c)
		 */
	}

	[HttpPut("{id}")]
	public Company Edit(Company c)
	{
		/*
		 * TODO: Заменить код ниже на работающий с базой данных, который изменит компанию. Что-то типа var c = context.Entry(c).State=EntityState.Modified
		 */
		return c;
	}
}