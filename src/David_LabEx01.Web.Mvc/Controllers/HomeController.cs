using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using David_LabEx01.Controllers;

namespace David_LabEx01.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : David_LabEx01ControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
