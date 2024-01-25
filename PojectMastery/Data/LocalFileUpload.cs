using PojectMastery.Interfaces;

namespace PojectMastery.Data;

public class LocalFileUpload : IFileUpload
{
    private string outputPath { get; }
    public LocalFileUpload(string outputPath)
    {
        this.outputPath = outputPath;
    }
    public string Save(IFormFile formFile)
    {
        var fileInfo = new FileInfo(formFile.FileName);
        var fileName = Guid.NewGuid() + fileInfo.Extension;
        var fileNameWithOutputPath = Path.Combine(outputPath, fileName);

        using var stream = new FileStream(fileNameWithOutputPath, FileMode.Create);
        formFile.CopyTo(stream);

        return fileNameWithOutputPath;
    }
}