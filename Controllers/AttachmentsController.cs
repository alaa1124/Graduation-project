using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI.WebControls;

namespace GradProjectAPI.Controllers
{
    public class AttachmentsController : ApiController
    {
        [HttpPost]
        public void UploadAttachment(byte[] image, string FileName, string Extention)
        {
            UploadAttachment(image, FileName, Extention);
        }

        [HttpGet]
        public List<ListItem> DownloadAttachment(string TalbCode)
        {
            return DownloadAttachment(TalbCode);
        }
    }
}