using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GradProjectAPI.Models
{
    public class Attachments : System.Web.UI.Page
    {
        public void UploadAttachment(byte[] image, string FileName, string Extention)
        {
            File.WriteAllBytes(Server.MapPath("~/Images/" + FileName + "." + Extention), image);
        }

        public List<ListItem> DownloadAttachment(string TalbCode)
        {
            string FileName;
            List<ListItem> files = new List<ListItem>();
            string[] path = Directory.GetFiles(Server.MapPath("~/Images/"));
            foreach (string pathItem in path)
            {
                FileName = Path.GetFileName(pathItem);
                if (FileName.Split('_')[0] == TalbCode)
                {
                    files.Add(new ListItem(FileName.Split('_')[1].Split('.')[0], "~/Images/" + FileName));
                }
            }
            return files;
        }

        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

        public void CompressImage(string Path, string DestPath, long Quality)
        {
            using (Bitmap bmp1 = new Bitmap(Path))
            {
                ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);

                System.Drawing.Imaging.Encoder QualityEncoder = System.Drawing.Imaging.Encoder.Quality;

                EncoderParameters myEncoderParameters = new EncoderParameters(1);

                EncoderParameter myEncoderParameter = new EncoderParameter(QualityEncoder, Quality);

                myEncoderParameters.Param[0] = myEncoderParameter;

                bmp1.Save(DestPath, jpgEncoder, myEncoderParameters);
            }
        }
    }
}