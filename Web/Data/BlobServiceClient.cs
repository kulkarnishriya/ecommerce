using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Web.Models;
using System.Net.Http;
using Web.Models;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace Web.Data
{
    public class BlobServiceClient
    {
        private HttpClient _httpClient = new HttpClient();

        [BindProperty]
        public List<string> ImageList { get; private set; }

        public async Task GetBlobFiles()
        {
            var imagesUrl = Constants.blobApiUrl;

            string imagesJson = await _httpClient.GetStringAsync(imagesUrl);

            IEnumerable<string> imagesList = JsonConvert.DeserializeObject<IEnumerable<string>>(imagesJson);

            this.ImageList = imagesList.ToList<string>();
        }

        public async Task<string> UploadToBlob(IFormFile Upload)
        {
            string response = null;
            if (Upload != null && Upload.Length > 0)
            {
                var imagesUrl = Constants.blobApiUrl;

                using (var image = new StreamContent(Upload.OpenReadStream()))
                {
                    image.Headers.ContentType = new MediaTypeHeaderValue(Upload.ContentType);
                    HttpClientHandler clientHandler = new HttpClientHandler();
                    clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
                    using (var client = new HttpClient(clientHandler))
                    {
                        client.DefaultRequestHeaders.Add("Name", Upload.FileName);
                        var res = await client.PostAsync(imagesUrl, image);
                        response = res.Content.ReadAsStringAsync().Result;
                    }
                }
            }
            return response;
        }
 
    }
}