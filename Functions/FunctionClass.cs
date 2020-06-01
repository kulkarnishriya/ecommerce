#r "Newtonsoft.Json"

using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;
using System.Drawing.Common;
using System.Drawing.Imaging;
using Microsoft.Azure.Storage;
using System.Drawing;
using Microsoft.Azure.Storage.Blob;

public static async Task<HttpResponseMessage> Run(HttpRequest req, ILogger log)
{
    log.LogInformation("C# HTTP trigger function processed a request.");

    string name = req.Query["name"];

    string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
    dynamic data = JsonConvert.DeserializeObject(requestBody);
    name = name ?? data.path;

    Image img = Image.FromFile(name);
    byte[] arr;
    using (MemoryStream ms = new MemoryStream())
    {
        img.Save(ms, System.Drawing.Common.ImageFormat.Jpeg);
        arr = ms.GetBuffer();
    
        string storageConnectionString = System.Environment.GetEnvironmentVariable("StorageConnection");
        CloudStorageAccount storageAccount;
    if (CloudStorageAccount.TryParse(storageConnectionString, out storageAccount))
    {
    // Create the CloudBlobClient that represents the Blob storage endpoint for the storage account.
    CloudBlobClient cloudBlobClient = storageAccount.CreateCloudBlobClient();
    
    CloudBlobContainer cloudBlobContainer = cloudBlobClient.GetContainerReference("ContainerName");
    await cloudBlobContainer.CreateIfNotExistsAsync();
    
    CloudBlockBlob cloudBlockBlob = cloudBlobContainer.GetBlockBlobReference("Image1.jpeg");
    cloudBlockBlob.Properties.ContentType = "image\\jpeg";
    
    ms.Seek(0, SeekOrigin.Begin);
    cloudBlockBlob.UploadFromStream(ms);
    }
    }
    
    
    return name == null
    ? req.CreateResponse(HttpStatusCode.BadRequest, "Please pass a Path  in the request body")
    : req.CreateResponse(HttpStatusCode.OK, "Uploaded to Storage Blob" );
    
}
