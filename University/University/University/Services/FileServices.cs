using University.Dto;
using University.Models;


namespace University.Services
{
    public class FileServices
    {
        private readonly IHostEnvironment _webHost;

        public FileServices
            (
                IHostEnvironment webHost
            )
        {
            _webHost = webHost;
        }


        public void FilesToApi(CourseDto dto, Course domain)
        {
            //tingimus, kui File ei ole null v]i on vähemalt rohkem, kui 0 faili
            if (dto.Files != null && dto.Files.Count > 0)
            {
                if (!Directory.Exists(_webHost.ContentRootPath + "\\wwwroot\\multipleFileUpload\\"))
                {
                    Directory.CreateDirectory(_webHost.ContentRootPath + "\\wwwroot\\multipleFileUpload\\");
                }

                foreach (var file in dto.Files)
                {
                    string uploadsFolder = Path.Combine(_webHost.ContentRootPath, "wwwroot", "multipleFileUpload");
                    string uniqueFileName = Guid.NewGuid().ToString() + " - " + file.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(fileStream);

                        FileToApi path = new FileToApi
                        {
                            Id = Guid.NewGuid(),
                            ExistingFilePath = uniqueFileName,
                            CourseId = domain.CourseId
                        };

                        //_context.FileToApis.Add(path);
                    }
                }
            }    
        }
    }
}
