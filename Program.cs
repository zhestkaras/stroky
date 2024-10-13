//14
//Console.WriteLine("vvedite stroky");
//string input = Console.ReadLine();
//int max = 0;
//int cur = 0;    
//foreach (char c in input)
//{
//    if (char.IsDigit(c))
//    {
//        cur++;
//        if (cur > max)
//        {
//            max = cur;
//        }
//    }
//    else
//    {
//        cur = 0;
//    }
//}
//Console.WriteLine("dlina"+ max);

//15
//Console.WriteLine("vvedite stroky");
//string input = Console.ReadLine();
//if ( input.EndsWith(":") )
//{
//    input = input.Substring(0, input.Length - 1);
//}
//string[] words = input.Split(';');
//    int count =  0;
//foreach ( string word in words )
//{
//    string trim = word.Trim();
//    if ( trim.Length > 0 && trim.EndsWith("a", StringComparison.OrdinalIgnoreCase))
//    {
//        count++;
//    }
//}
//Console.WriteLine("kol-vo slov"+count);

//16
//Console.WriteLine("vvedite stroky");
//string input = Console.ReadLine();
//string[] words = input.Split(new char[] { ' ', ',','.',';',':','!','?'}, StringSplitOptions.RemoveEmptyEntries);
//Console.WriteLine("slova na k");
//bool found = false; 
//foreach ( string word in words)
//{
//    if (word.IndexOf('k', StringComparison.OrdinalIgnoreCase) >= 0)
//    {
//        Console.WriteLine(word);
//        found = true;   
//    }
//}
//if (!found)
//{
//    Console.WriteLine("slov net");
//}

//17
//Console.WriteLine("vvedite stroky");
//string input = Console.ReadLine();
//string[] words = input.Split(new char[] { ' ', ',', '.', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
//Console.WriteLine("slova nachin i zakan");
//bool found = false;
//foreach (string word in words)
//{
//   if ( word.Length > 0)
//    {
//        if (char.ToLower(word[0]) == char.ToLower(word[word.Length - 1]))
//        {
//            Console.WriteLine(word);
//            found = true;
//        }
        
//    }
//}
//if (!found)
//{
//    Console.WriteLine("slov net");
//}

