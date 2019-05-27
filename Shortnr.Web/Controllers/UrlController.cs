using Shortnr.Web.Business;
using Shortnr.Web.Entities;
using Shortnr.Web.Models;
using Shortnr.Web.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Shortnr.Web.Controllers
{
	public class UrlController : Controller
	{
		private IUrlManager _urlManager;
	    private LogU log = new LogU(typeof(UrlController));

        public UrlController(IUrlManager urlManager)
		{
			this._urlManager = urlManager;
        }

		[HttpGet]
		public ActionResult Index()
		{

            Url url = new Url();
			return View(url);
		}

		public async Task<ActionResult> Index(Url url)
		{
			if (ModelState.IsValid)
			{
			    log.Info("Request.UserHostAddress=>"+ Request.UserHostAddress);
                ShortUrl shortUrl = await this._urlManager.ShortenUrl(url.LongURL, Request.UserHostAddress, url.CustomSegment);
				url.ShortURL = string.Format("{0}://{1}{2}{3}", Request.Url.Scheme, Request.Url.Authority, Url.Content("~"), shortUrl.Segment);
			}
			return View(url);
		}

		public async Task<ActionResult> Click(string segment)
		{
			string referer = Request.UrlReferrer != null ? Request.UrlReferrer.ToString() : string.Empty;
			Stat stat = await this._urlManager.Click(segment, referer, Request.UserHostAddress);
			return this.RedirectPermanent(stat.ShortUrl.LongUrl);
		}
	}
}