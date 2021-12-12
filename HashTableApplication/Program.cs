using HashTableApplication;
Console.WriteLine("Hello World!WELCOME TO HASHTABLE");
Console.WriteLine("Hash table demo"); //() []
MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
hash.Add("0", "To be or not to be");
hash.Add("0", "To be or not to be");
hash.frequencyOfWords("0");
hash.Add("1", "be");
hash.Add("2", "not");
hash.Add("3", "or");
hash.Add("4", "not");
hash.Add("5", "be");
string hash5 = hash.Get("5");
Console.WriteLine("Fifth index value="+hash5);

string hash2 = hash.Get("2");
Console.WriteLine("Fifth index value="+hash2);
