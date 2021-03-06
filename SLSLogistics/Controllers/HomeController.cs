﻿using System.Web.Mvc;
using SLSLogistics.Models;

namespace SLSLogistics.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View(GetBreadcrumbModel("Hem"));
		}

		public ActionResult Contact()
		{
			return View(GetBreadcrumbModel("Kontakt"));
		}

		public ActionResult News()
		{
			return View(GetBreadcrumbModel("Nyheter"));
		}

		public ActionResult Transports()
		{
			return View(GetBreadcrumbModel("Transporter"));
		}

		public ActionResult Policy()
		{
			return View(GetBreadcrumbModel("Vår Policy"));
		}

		public ActionResult About()
		{
			return View(GetBreadcrumbModel("Om SLS"));
		}

		public ActionResult Warehouse()
		{
			return View(GetBreadcrumbModel("Lager"));
		}
		private BreadcrumbModel GetBreadcrumbModel(string displayName)
		{
			return new BreadcrumbModel(displayName);
		}

		
	}
}