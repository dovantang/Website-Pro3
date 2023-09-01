using Microsoft.AspNetCore.Mvc;
using QRCoder;
using System.Drawing;
using System.Drawing.Imaging;

namespace NetCore_MVC.Controllers
{
    public class BaseController : Controller
    {
       
        [HttpPost, Route("login-user")]
        public IActionResult Login(string Username, string Password)
        {
            if (ModelState.IsValid)
            {
                //var check = db.MMCVUsers.FirstOrDefault(x => x.Username == Username
                //&& x.Password == Password);
                //if (check != null)
                //{
                //    return RedirectToAction("Index", "Home");
                //}
            }
            return RedirectToAction("Index", "Login");
        }

        public string CreateQRCode(string value)
        {
            QRCodeGenerator QrGenerator = new QRCodeGenerator();
            QRCodeData QrCodeInfo = QrGenerator.CreateQrCode(value, QRCodeGenerator.ECCLevel.Q);
            QRCode QrCode = new QRCode(QrCodeInfo);
            Bitmap QrBitmap = QrCode.GetGraphic(60);
            byte[] BitmapArray = QrBitmap.BitmapToByteArray();
            string QrUri = string.Format("data:image/png;base64,{0}", Convert.ToBase64String(BitmapArray));
            return QrUri;
        }
    }
    //Extension method to convert Bitmap to Byte Array
    public static class BitmapExtension
    {
        public static byte[] BitmapToByteArray(this Bitmap bitmap)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                bitmap.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }
    }
}
