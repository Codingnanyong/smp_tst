namespace autbat.Model
{
    public class BatchModel
    {
        public string FileName { get;  set; } = string.Empty;
        public FileType BatchType { get;  set; } = FileType.bat;
        public string Command { get;  set; } = string.Empty;
    }
}
