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

Console.WriteLine(bat.FileName.ToString()+"."+bat.BatchType.ToString());

static string GetFileName(){
    Console.Write("What's File Name : ");
    return Console.ReadLine()!;
}