int? val = null;
IsNull(val);    // null
val = 22;
IsNull(val);    // 22

void IsNull(int? obj)
{
    if (obj == null) Console.WriteLine("null");
    else Console.WriteLine(obj);
}