using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.CoreLayer.Services.FileManager
{
    public interface IFileManager
    {

        void DeleteFile(string fileName, string path);
        string SaveFileAndReturnName(IFormFile file, string savePath);
        string SaveImageAndReturnImageName(IFormFile file, string savePath);
    }
}
