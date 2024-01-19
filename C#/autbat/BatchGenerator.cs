using autbat.Model;

namespace autbat
{
    public class BatchGenerator
    {
        public void CreateBatch(BatchModel batch){
            string file = batch.FileName + "." + batch.BatchType.ToString();
            string path = Path.Combine(Environment.CurrentDirectory,file);

            try{
                File.WriteAllText(path,batch.Command);
            }
            catch{
                Console.WriteLine("Error");
            }
        }

        public void WriteBatch(BatchModel batch){
            string file = batch.FileName + "." + batch.BatchType.ToString();
            string path = Path.Combine(Environment.CurrentDirectory,file);

            try{
                File.AppendAllText(path,batch.Command);
            } 
            catch{
                Console.WriteLine("Error");
            }

        }
        public void AdminRun(BatchModel batch){
            string file = batch.FileName + "." + batch.BatchType.ToString();
            string path = Path.Combine(Environment.CurrentDirectory,file);

            try{
                var startInfo = new System.Diagnostics.ProcessStartInfo{
                    FileName = path,
                    Verb = "runas",
                    UseShellExecute = true
                };
            } 
            catch{
                Console.WriteLine("Error");
            }
        }

        public void Run(BatchModel batch){
            string file = batch.FileName + "." + batch.BatchType.ToString();
            string path = System.IO.Path.Combine(Environment.CurrentDirectory, file);

            try{
                var startInfo = new System.Diagnostics.ProcessStartInfo{
                    FileName = path,
                    UseShellExecute = true
                };
            } 
            catch{
                Console.WriteLine("Error");
            }
        }

        public void DeleteBatch(BatchModel batch){
            string file = batch.FileName + "." + batch.BatchType.ToString();
            string path = Path.Combine(Environment.CurrentDirectory,file);

            try{
                File.Delete(path);
            } 
            catch{
                Console.WriteLine("Error");
            }
        }
    }
}