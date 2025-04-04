using COMP003B.Assignment3.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment3.Controllers
{
	public class EventController : Controller
	{
		[HttpGet("event/register/{eventCode}")]
		public IActionResult Register(string eventCode)
		{
			var model = new EventRegistration
			{
				EventCode = eventCode
			};
			return View(model);
		}
		[HttpGet]
		public IActionResult Register()
		{
			return View(new EventRegistration());
		}
		[HttpPost]
		public IActionResult Register(EventRegistration model)
		{
			if (ModelState.IsValid)
			{
				return RedirectToAction("Success", model);
			}
			return View(model);
		}
		public IActionResult Success(EventRegistration model)
		{
			return View(model);
		}
	}
}