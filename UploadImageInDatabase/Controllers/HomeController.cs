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
        private string imagebyte;

        public ActionResult Index()
        {
            MVCImageDBEntities db = new MVCImageDBEntities();

            return View();
        }

        public JsonResult ImageUpload(ImageViewModel model)
        {
            MVCImageDBEntities db = new MVCImageDBEntities();
            int imgId = 0;
            var file = model.ImageFile;
            byte[] Imagebyte = null;
            if (file != null)
            {
                file.SaveAs(Server.MapPath("/UploadImage" + file.FileName));
                Binaryreader reader = new Binaryreader(file.InputStream);
                imagebyte = reader.ReadBytes(file.InputStream);
                StoreImage img = new StoreImage();
                img.ImageTitle = file.FileName;
                img.ImageByte = imagebyte;
                img.ImagePath = "/Upload/" + file.FileName;
                db.SaveChanges();
                imgId = img.ImageId;
            }
            return Json(imgId, JsonRequestBehavior.AllowGet);
        }
public ActionResult DisplayingImage(int imgID)
        {
            MVCImageDBEntities db = new MVCImageDBEntities();

            var img = db.StoreImages.SingleOrDefault(x => x.ImageId == imgID);

            return File(img.ImageByte, "image/jpg");
        }

    }
}