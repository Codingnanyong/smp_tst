using autobat.model.Files; 

Batch bat = new Batch();

bat.Name = "test";

bat.SetFullName();

Console.Write(bat.FullName);