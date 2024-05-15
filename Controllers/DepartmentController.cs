using Microsoft.AspNetCore.Mvc;
using WSSTest.Models;

namespace WSSTest.Controllers;

[ApiController]
[Route("[controller]")]
public class DepartmentController : ControllerBase
{
	private readonly ILogger<DepartmentController> _logger;
	//Теже переработки, что и в companycontroller
	//TODO:Заменить логгер на контекст
	public DepartmentController(ILogger<DepartmentController> logger)
	{
		_logger = logger;
	}

	//TODO: На весь контроллер! Все методы должны возвращать VIEW
	//TODO: Все методы должны быть асинхронны т.е. напримере ниже: public Task<IActionResult> Get(){return View(context.Department.ToList())}
	[HttpGet]
	public IEnumerable<Department> Get()
	{
		/*
		 * TODO: Заменить код ниже на работающий с базой данных, который получит список департаментов
		 */
		return new List<Department>();
	}

	[HttpGet("{id}")]
	public Department Get(long id)
	{
		/*
		 * TODO: Заменить код ниже на работающий с базой данных, который получит департамент по id. Что-то типа context.Department.Select(company=>company.id==id)
		 */
		return new Department();
	}

	[HttpPost]
	public void Add(Department d)
	{
		/*
		 * TODO: Заменить код ниже на работающий с базой данных, который добавит департамент. Что-то типа context.Company.Add(d)
		 */
	}

	[HttpPut("{id}")]
	public Department Edit(Department d)
	{
		/*
		 * TODO: Заменить код ниже на работающий с базой данных, который изменит департамент. Что-то типа var c = context.Entry(d).State=EntityState.Modified
		 */
		return d;
	}
}