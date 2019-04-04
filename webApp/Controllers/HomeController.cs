using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webApp.Models;

namespace webApp.Controllers
{
	public class HomeController : Controller
	{

		private UserContext db;
		public HomeController(UserContext context)
		{
			db = context;
		}

		public async Task<IActionResult> Index()
		{
			return View(await db.Users.ToListAsync());
		}

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Create(User user)
		{
			db.Users.Add(user);
			await db.SaveChangesAsync();
			return RedirectToAction("Index");
		}

		

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}

		public async Task<IActionResult> Edit(int? id)
		{
			if (id != null)
			{
				User User = await db.Users.FirstOrDefaultAsync(p => p.Id == id);
				if (User != null)
					return View(User);
			}
			return NotFound();
		}

		public async Task<IActionResult> Details(int? id)
		{
			if (id != null)
			{
				User user = await db.Users.FirstOrDefaultAsync(p => p.Id == id);
				if (user != null)
					return View(user);
			}
			return NotFound();
		}

		[HttpPost]
		public async Task<IActionResult> Edit(User User)
		{
			db.Users.Update(User);
			await db.SaveChangesAsync();
			return RedirectToAction("Index");
		}
	}
}
