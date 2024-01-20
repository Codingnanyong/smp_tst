using autobat.model;

namespace autobat.model.Files
{
    public class Batch : BaseModel{
       public string Name { get;  set; } = string.Empty;
        public FileType FileType { get;  set; } = FileType.bat;
        
        public string Command { get;  set; } = string.Empty;

        public string FullName {get; set;} = string.Empty;

        public void SetFullName(){
            this.FullName = this.Name + "." + this.FileType.ToString();
        }
    }
}