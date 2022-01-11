using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SouthernCabinetry.Controllers
{
    [AllowAnonymous]
    public class CatalogController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult View_SCI_Arts_Crafts_Catalog()
        //{
        //    object file = null;
        //    Response.Headers.Add("Content-Disposition", $"inline; filename=\"{file.Name}\"");
        //    return File(file.CreateReadStream(), "application/pdf", file.Name);
        //}


        public ActionResult SCI_Arts_Crafts_Catalog()
        {
            string filePath = "~/Downloads/Arts_&_Crafts.pdf";
            Response.Headers.Add("Content-Disposition", "inline; filename=Arts_&_Crafts.pdf");
            return File(filePath, "application/pdf");
        }

        public ActionResult SCI_Base_Cabinets_Catalog()
        {
            string filePath = "~/Downloads/Base_Cabinetry.pdf";
            Response.Headers.Add("Content-Disposition", "inline; filename=Base_Cabinet_Catalog.pdf");
            return File(filePath, "application/pdf");
        }
        public ActionResult SCI_Mobile_Cabinet_Catalog()
        {
            string filePath = "~/Downloads/Mobile_Cabinets.pdf";
            Response.Headers.Add("Content-Disposition", "inline; filename=Mobile_Cabinet_Catalog.pdf");
            return File(filePath, "application/pdf");
        }
        public ActionResult SCI_Music_Cabinet_Catalog()
        {
            string filePath = "~/Downloads/Music_Cabinetry.pdf";
            Response.Headers.Add("Content-Disposition", "inline; filename=Music_Cabinet_Catalog.pdf");
            return File(filePath, "application/pdf");
        }
        public ActionResult SCI_Tall_Cabinet_Catalog()
        {
            string filePath = "~/Downloads/Tall_Cabinetry.pdf";
            Response.Headers.Add("Content-Disposition", "inline; filename=Tall_Cabinet_Catalog.pdf");
            return File(filePath, "application/pdf");
        }
        public ActionResult SCI_Wall_Cabinet_Catalog()
        {
            string filePath = "~/Downloads/Wall_Cabinetry.pdf";
            Response.Headers.Add("Content-Disposition", "inline; filename=Wall_Cabinetry_Catalog.pdf");
            return File(filePath, "application/pdf");
        }
        public ActionResult SCI_Wardrobe_Cabinet_Catalog()
        {
            string filePath = "~/Downloads/Wardrobe_Cabinetry.pdf";
            Response.Headers.Add("Content-Disposition", "inline; filename=Wardrobe_Cabinetry_Catalog.pdf");
            return File(filePath, "application/pdf");
        }
        public ActionResult SCI_Casework_Specs()
        {
            string filePath = "~/Downloads/Casework_Specs.pdf";
            Response.Headers.Add("Content-Disposition", "inline; filename=Casework_Specs.pdf");
            return File(filePath, "application/pdf");
        }
        public ActionResult SCI_Catalog_Index()
        {
            string filePath = "~/Downloads/Catalog_Index.pdf";
            Response.Headers.Add("Content-Disposition", "inline; filename=Catalog_Index.pdf");
            return File(filePath, "application/pdf");
        }
    }
}
