using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.Helpers
{
    public class FileHelper
    {
        private static string currentDirectory = Environment.CurrentDirectory + @"\wwwroot";
        private static string path = @"\images\";

        public static IResult Add(IFormFile file)
        {
            if (file.Length > 0)
            {
                var name = Guid.NewGuid().ToString();
                var extension = Path.GetExtension(file.FileName);
                using (FileStream stream = File.Create(currentDirectory + path + name + extension))
                {
                    file.CopyTo(stream);
                    stream.Flush();
                }
                return new SuccessResult(name + extension);
            }
            return new ErrorResult("olmadı ");

        }
        public static IResult Delete(string file)
        {
            File.Delete(currentDirectory + path + file);
            return new SuccessResult();
        }
        public static IResult Update(IFormFile file, string imagePath)
        {
            if (file.Length > 0)
            {
                var name = Guid.NewGuid().ToString();
                var extension = Path.GetExtension(file.FileName);
                FileHelper.Delete(imagePath);
                FileHelper.Add(file);
                return new SuccessResult(name + extension);
            }
            return new ErrorResult();

        }
    }
}
