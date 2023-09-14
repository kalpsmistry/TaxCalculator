using System;
using Microsoft.AspNetCore.Mvc;
using TaxCalculator.Models;
using TaxCalculator.Code;

namespace TaxCalculator.Controllers
{
	public class TaxController : Controller
	{
		public readonly CalculateTax _calculateTax = new CalculateTax();

		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult CalculateIncomeTax(decimal salary)
		{
			if (!ModelState.IsValid)
			{
				ViewBag.NoSalary = "No annual salary provided";
				return View("Index");
			}

			var model = new IncomeTaxModel()
			{
				GrossAnnualSalary = salary
			};

			model = _calculateTax.Calculate(model);
			return View("Index", model);
		}
	}
}