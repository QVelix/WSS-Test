using Microsoft.AspNetCore.Mvc;
using WSSTest.Models;

namespace WSSTest.Controllers;

[ApiController]
[Route("[controller]")]
public class UnitController : ControllerBase
{
	private readonly ILogger<UnitController> _logger;
	//Теже преработки, что и в CompanyController и DepartmentController
	//TODO:Заменить логгер на контекст
	public UnitController(ILogger<UnitController> logger)
	{
		_logger = logger;
	}

	//TODO: На весь контроллер! Все методы должны возвращать VIEW
	//TODO: Все методы должны быть асинхронны т.е. напримере ниже: public Task<IActionResult> Get(){return View(context.Unit.ToList())}
	[HttpGet]
	public IEnumerable<Unit> Get()
	{
		/*
		 * TODO: Заменить код ниже на работающий с базой данных, который получит список отделов
		 */
		return new List<Unit>();
	}

	[HttpGet("{id}")]
	public Unit Get(long id)
	{
		/*
		 * TODO: Заменить код ниже на работающий с базой данных, который получит отдел по id. Что-то типа context.Company.Select(company=>company.id==id)
		 */
		return new Unit();
	}

	[HttpPost]
	public void Add(Unit u)
	{
		/*
		 * TODO: Заменить код ниже на работающий с базой данных, который добавит отдел. Что-то типа context.Company.Add(u)
		 */
	}

	[HttpPut("{id}")]
	public Unit Edit(Unit u)
	{
		/*
		 * TODO: Заменить код ниже на работающий с базой данных, который изменит отдел. Что-то типа var c = context.Entry(u).State=EntityState.Modified
		 */
		return u;
	}
}