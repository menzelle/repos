using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Get_Snap_Me_Images.Models;
using Microsoft.Azure.Storage;
using Microsoft.Azure.Storage.Blob;
using System.IO;
using GetSnapMeImages.Models;

namespace Get_Snap_Me_Images.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ShowImage()
        {
            string _imageName = Request.Form["ImageSource"]; 

           string ms = await DownloadImageStream(_imageName);

            ShowImageViewModel viewModel = new ShowImageViewModel
            {
                OutputImage = ms
            };
            return View(viewModel);
        }

        public async Task<string> DownloadImageStream(string imageName)
        {

            //based on current environment get blob connection string and container name via startup         
            string connectionString = Startup.BlobConnectionString;
            string containerString = Startup.BlobContainerString;

            string ms = "";

            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(connectionString);

            //createCloudBlobClient. This class provides a point of access to the Azure Blob service
            CloudBlobClient cloudBlobClient = storageAccount.CreateCloudBlobClient();

            //create or get the container named userimages from Azure
            CloudBlobContainer _userImagesContainer = cloudBlobClient.GetContainerReference(containerString);

            //get the blob by name
            CloudBlockBlob blockBlob = _userImagesContainer.GetBlockBlobReference(imageName);

            try
            {
                using (var stream = new MemoryStream())
                {
                    await blockBlob.DownloadToStreamAsync(stream);
                    stream.Position = 0;
                    byte[] content = stream.ToArray();

                    ms = Convert.ToBase64String(content);
                }
            }
            catch (StorageException ex)
            {


                imageName = "NoUserImageFound.png";
                blockBlob = _userImagesContainer.GetBlockBlobReference(imageName);
                using (var stream = new MemoryStream())
                {
                    await blockBlob.DownloadToStreamAsync(stream);
                    stream.Position = 0;
                    byte[] content = stream.ToArray();

                    ms = Convert.ToBase64String(content);
                }

            }
            return ms;
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
