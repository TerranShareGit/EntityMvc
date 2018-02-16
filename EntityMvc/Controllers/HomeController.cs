using AnyEntityClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace EntityMvc.Controllers
{
    public class HomeController : Controller
    {
        private WebApiHelper webApiHelper = new WebApiHelper();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public async Task<ActionResult> GetAllEntities()
        {
            AnyEntity[] entities = await webApiHelper.GetAllEntitiesAsync();
            return Json(entities, JsonRequestBehavior.AllowGet);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<Uri> Create(AnyEntity entity)
        {
            entity.Id = "0"; //Реализовано инкрементом
            var uri = await webApiHelper.CreateAnyEntityAsync(entity);
            return uri; //В релизе, конечно, что-то осмысленное
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<HttpStatusCode> Delete(string id)
        {
            var statusCode = await webApiHelper.DeleteAnyEntityAsync(id);
            return statusCode; //В релизе, конечно, что-то осмысленное
        }
    }
}