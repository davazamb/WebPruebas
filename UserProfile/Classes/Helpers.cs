using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserProfile.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace UserProfile.Classes
{
    public class Helpers
    {
        //private static ApplicationDbContext User = new ApplicationDbContext(); 
        //public FileContentResult UserPhotos()
        //{
        //    if (User.Identity.IsAuthenticated)
        //    {
        //        String userId = User.Identity.GetUserId();
        //        // to get the user details to load user Image
        //        var bdUsers = HttpContext.GetOwinContext().Get<ApplicationDbContext>();
        //        var userImage = bdUsers.Users.Where(x => x.Id == userId).FirstOrDefault();

        //        if (userImage != null)
        //        {
        //            string fileName = HttpContext.Server.MapPath(@"~/Images/no-image.png");

        //            byte[] imageData = null;
        //            FileInfo fileInfo = new FileInfo(fileName);
        //            long imageFileLength = fileInfo.Length;
        //            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
        //            BinaryReader br = new BinaryReader(fs);
        //            imageData = br.ReadBytes((int)imageFileLength);

        //            return File(imageData, "image/png");

        //        }


        //        return new FileContentResult(userImage.UserPhoto, "image/jpeg");
        //    }
        //    else
        //    {
        //        string fileName = HttpContext.Server.MapPath(@"~/Images/no-image.png");

        //        byte[] imageData = null;
        //        FileInfo fileInfo = new FileInfo(fileName);
        //        long imageFileLength = fileInfo.Length;
        //        FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
        //        BinaryReader br = new BinaryReader(fs);
        //        imageData = br.ReadBytes((int)imageFileLength);
        //        return File(imageData, "image/png");

        //    }
        //}

    }
}