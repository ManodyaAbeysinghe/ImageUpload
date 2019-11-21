using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UploadImageInDatabase.Models;

namespace UploadImageInDatabase.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            MVCImageDBEntities db = new MVCImageDBEntities();

            return View();
        }

        //public JsonResult ImageUpload(ImageViewModel model)
        //{
        //    MVCImageDBEntities db = new MVCImageDBEntities();
        //    int imgId = 0;
        //    var file = model.ImageFile;
        //        byte[] Imagebyte = null;
        //    if (file != null)
        //    {
        //        file.SaveAs(Server.MapPath("/UploadImage" + file.FileName));
        //    }
        //}


    }
}