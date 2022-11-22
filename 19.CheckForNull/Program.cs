string? text = null;
string name = text ?? "Tom";  // равно Tom, так как text равен null
Console.WriteLine(name);    // Tom

int? id = 200;
int personid = id ?? 1; // равно 200, так как id не равен null
Console.WriteLine(personid);    // 200

string? text2 = null;
text2 ??= "Sam";
// аналогично
// text = text ?? "Sam";
Console.WriteLine(text2);    // Sam

int? id1 = 100;
id1 ??= 1;
// аналогично
//id = id ?? 1;
Console.WriteLine(id1); // 100