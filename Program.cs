

using Advanced.FirstAssignment;

Boek boek = new Boek();
Boek boek2 = new Boek();

boek.Lees(boek, 1, "naam1", "Uitgever1", 10);
boek2.Lees(boek2, 1, "naam2", "Uitgever2", 10);


Console.WriteLine(boek.ToString());
Console.WriteLine(boek2.ToString());