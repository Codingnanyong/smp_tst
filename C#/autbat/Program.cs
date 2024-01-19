using autbat.Model;
using autbat;

OsModel os = new OsModel();

BatchModel bat = new BatchModel();

bat.FileName = GetFileName();

if(os.OsName.IndexOf("unix",StringComparison.OrdinalIgnoreCase)>=0){
    bat.BatchType = FileType.sh;
}
else{
    bat.BatchType = FileType.bat;
}

BatchGenerator generator = new BatchGenerator();

generator.CreateBatch(bat);

static string GetFileName(){
    Console.Write("What's File Name : ");
    return Console.ReadLine()!;
}