using HashTableApplication;
Console.WriteLine("Hello World!WELCOME TO HASHTABLE");
Console.WriteLine("Hash table demo"); //() []
MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
hash.Add("0", "To be or not to be");
hash.Add("0", "To be or not to be");
hash.frequencyOfWords("0");
hash.Add("1", "A random paragraph can also be an excellent way for a writer to tackle writers' block. Writing block can often happen due to being stuck with a current project that the writer is trying to complete. By inserting a completely random paragraph from which to begin, it can take down some of the issues that may have been causing the writers' block in the first place.");
hash.frequencyOfWords("1");
hash.Add("1", "be");
hash.Add("2", "not");
hash.Add("3", "or");
hash.Add("4", "not");
hash.Add("5", "be");
string hash5 = hash.Get("5");
Console.WriteLine("Fifth index value="+hash5);

string hash2 = hash.Get("2");
Console.WriteLine("Fifth index value="+hash2);
string paragraph = "A random paragraph can also be an excellent way for a writer to tackle writers' block. Writing block can often happen due to being stuck with a current project that the writer is trying to complete. By inserting a completely random paragraph from which to begin, it can take down some of the issues that may have been causing the writers' block in the first place.";
string[] para = paragraph.Split(',');
MyMapNode<int, string> hash1 = new MyMapNode<int, string>(para.Length);
int key = 0;
foreach (string word in para)
{
    hash1.Add(key, word);
    key++;
}

hash.Remove(hash1, "avoidable");