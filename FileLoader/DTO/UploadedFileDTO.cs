namespace FileLoader.DTO
{
    public class UploadedFileDTO
    {
        public UploadedFileDTO(string fileName, bool isLoaded)
        {
            this.fileName = fileName;
            this.isLoaded = isLoaded;
        }
        public string fileName { get; set; }
        public bool isLoaded { get; set; }
    }
}
