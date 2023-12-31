1- 
static void Main(string[] args)
{            
	DateTime today = DateTime.Now;
	Console.WriteLine("Today = " + DateTime.Now);
	TimeSpan duration = new TimeSpan(40, 0, 0, 0);
	DateTime answer = today.Add(duration);
	Console.WriteLine("{0:dddd}", answer);

	Console.Read();
}

2-
using System;

namespace exercises
{
   class Program
    {       
        static void Main(string[] args)
        {
            Console.WriteLine(test("Hello", "Hi"));
            Console.WriteLine(test("Python", "PHP"));
            Console.WriteLine(test("JS", "JS"));
            Console.WriteLine(test("Csharp", ""));
            Console.ReadLine();
        }

		public static string test(string s1, string s2)
        {
            string lastChars = String.Empty;

            if (s1.Length > 0)
            {
                lastChars += s1.Substring(0, 1);
            }
            else
            {
                lastChars += "#";
            }

            if (s2.Length > 0)
            {
                lastChars += s2.Substring(s2.Length - 1);
            }
            else
            {
                lastChars += "#";
            }

            return lastChars;
        }
   }
}

3-       
static void Main()
{
	int[] n1 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };        
	
	var nQuery =
		from VrNum in n1
		where (VrNum % 2) == 0
		select VrNum;

	foreach (int VrNum in nQuery)
	{
		Console.Write("{0} ", VrNum);
	}        
}

4-
static void Main(string[] args)
{
	int[] n1 = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };         

	var nQuery =
		from VrNum in n1
		where VrNum > 0
		where VrNum < 12
		select VrNum;

	foreach (int num in nQuery)
	{
		Console.Write("{0} ", num);
	}             
}

5-     
static void Main(string[] args)
{
	var arr1 = new[] { 3, 9, 2, 8, 6, 5 };
				 
	var sqNo = from int Number in arr1
			let SqrNo = Number * Number
			where SqrNo > 20
			select new { Number, SqrNo };

	foreach (var num in sqNo)
	{
		Console.WriteLine("{0} ", num);
	}             
}

6-
static void Main(string[] args)
{
	int[] arr1 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
				 
	var n = from Num in arr1
			group Num by Num into y
			select y;
	 
	Console.WriteLine("The number and the Frequency are :");
	foreach (var arrNo in n)  
	{  
	  Console.WriteLine("Number " + arrNo.Key + " appears " + arrNo.Count() + " times");
	} 
}

7-
static void Main(string[] args)
{
	string str = "apple";
				 
	var chars = from c in str
			group c by c into y
			select y;
	 
	Console.WriteLine("The frequency of the characters are :");
	foreach (var c in chars)  
	{  
	  Console.WriteLine("Character " + c.Key + ": " + c.Count() + " times");  
	} 
}

8-
static void Main(string[] args)
{
	string[] weekDays = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
	
	var days = from day in weekDays
			   select day;
	 
	foreach (var day in days)  
	{  
	  Console.WriteLine(day);  
	} 
}

9-      
static void Main(string[] args)
{
	int[] nums = new int[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };    
	
	var n = from x in nums
			group x by x into y
			select y;             
	
	foreach (var arrEle in n)  
	{  
	  Console.WriteLine(arrEle.Key + "\t" + arrEle.Sum() + "\t" + arrEle.Count());
	} 
}
 
10-     
static void Main(string[] args)
{
	string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

	Console.WriteLine("Input starting character for the string :") ;
	string startChar = Console.ReadLine();

	Console.WriteLine("Input ending character for the string :");
	string endChar = Console.ReadLine();

	var citiesq = from city in cities
				  where city.StartsWith(startChar)
				  where city.EndsWith(endChar)
				  select city;

	foreach ( var c in citiesq )
	{
		Console.WriteLine("The city starting with {0} and ending with {1} is {2}", startChar, endChar, c);
	}
}

11-
static void Main(string[] args)
{
	List<int> numList = new List<int> { 55, 200, 740, 76, 230, 482, 95 }; 
	var nums = numList.FindAll(x => x > 80);
	
	Console.WriteLine("The members of the list are :");
	foreach(int num in nums)
	{
		Console.WriteLine(num);
	}
	
	Console.ReadLine();
}

12-
static void Main(string[] args)
{
	int record = 2;
	List<int> numList = new List<int> { 5, 7, 13, 24, 6, 9, 8, 7 };
	
	numList.Sort();
	numList.Reverse();
			   
	Console.WriteLine("The top {0} records from the list are : ", record);
	foreach(int num in numList.Take(record))
	{
		Console.WriteLine(num);
	}
	
	Console.ReadLine();
}

13-       
static void Main(string[] args)
{
	string str = "this IS a STRING with UPPER text";
	
	var upWord =  str.Split(' ')
				.Where(x => String.Equals(x, x.ToUpper(),
				StringComparison.Ordinal));         
			   
	Console.WriteLine("The UPPER CASE words are :");
	foreach(string w in upWord)
	{
		Console.WriteLine(w);
	}            
}

14-
static void Main(string[] args)
{
	string[] strArr = { "cat", "dog", "rat" };            
	var str =  String.Join(", ", strArr);             
	Console.WriteLine(str);                 
}

15-
using System;
using System.Collections.Generic;
using System.Linq;

namespace exercises
{
	public class Students  
    {  
        public string StuName { get; set; }  
        public int GrPoint { get; set; }  
        public int StuId { get; set; }  
  
        public List<Students> GtStuRec()  
        {  
            List<Students> stulist = new List<Students>();  
            stulist.Add(new Students { StuId = 1, StuName = "Joseph ", GrPoint = 800 });  
            stulist.Add(new Students { StuId = 2, StuName = "Alex", GrPoint = 458 });  
            stulist.Add(new Students { StuId = 3, StuName = "Harris", GrPoint = 900 });  
            stulist.Add(new Students { StuId = 4, StuName = "Taylor", GrPoint = 900 });  
            stulist.Add(new Students { StuId = 5, StuName = "Smith", GrPoint = 458 });  
            stulist.Add(new Students { StuId = 6, StuName = "Natasa", GrPoint = 700 });  
            stulist.Add(new Students { StuId = 7, StuName = "David", GrPoint = 750 });  
            stulist.Add(new Students { StuId = 8, StuName = "Harry", GrPoint = 700 });  
            stulist.Add(new Students { StuId = 9, StuName = "Nicolash", GrPoint = 597 });  
            stulist.Add(new Students { StuId = 10, StuName = "Jenny", GrPoint = 750 });  
            return stulist;  
        }  
    }  
    
    class Program
    {       
      static void Main(string[] args)
      {
      	int grade = 2;
      	
        Students std = new Students();
        var stulist = std.GtStuRec();
        
        var students = (from stuMast in stulist  
                 group stuMast by stuMast.GrPoint into g  
                 orderby g.Key descending   
                 select new  
                     {  
                         StuRecord = g.ToList()                                      
                     }).ToList();
                     
        var gradeStudents = students[grade].StuRecord;
        
        foreach(var st in gradeStudents) {                    
        	Console.WriteLine(" Id : {0},  Name : {1},  achieved Grade Point : {2}",st.StuId, st.StuName, st.GrPoint); 
        }
      }
    }
}

16-      
static void Main(string[] args)
{
	string[] files = { "aaa.frx", "bbb.TXT", "xyz.dbf", "abc.pdf", "aaaa.PDF", "xyz.frt", "abc.xml", "ccc.txt", "zzz.txt" };        

	var filegr = from file in files  
			 group file by Path.GetExtension(file).TrimStart('.').ToLower() into g  
			 select g;
				 
	foreach(var file in filegr) {                    
		Console.WriteLine(file.Count() + " File(s) with " + file.Key + " Extension"); 
	}
}

17-      
static void Main(string[] args)
{
	string[] files = { "aaa.frx", "bbb.TXT", "xyz.dbf", "abc.pdf", "aaaa.PDF", "xyz.frt", "abc.xml", "ccc.txt", "zzz.txt" };        

	var fGrp = files.Select(file => Path.GetExtension(file).TrimStart('.').ToLower())
				 .GroupBy(z => z,(e, ctr) =>new
												 {
													Extension = e,
													Count = ctr.Count()
												  });

	foreach (var m in fGrp) {
		Console.WriteLine("{0} File(s) with {1} Extension ",m.Count, m.Extension);
	}        
} 

18-     
static void Main(string[] args)
{
	List<string> listOfString = new List<string>();  
		listOfString.Add("m");  
		listOfString.Add("n");  
		listOfString.Add("o");  
		listOfString.Add("p");  
		listOfString.Add("q");        
	
	var _result1 = from y in listOfString  
	select y; 
	
	foreach(var tchar in _result1)  
	{  
		Console.WriteLine("Char: {0} ", tchar);  
	} 
   
	string newstr =  listOfString.FirstOrDefault(en => en == "o");  
	listOfString.Remove(newstr);  

	var _result = from z in listOfString  
	select z;  

	Console.WriteLine("\nNach dem Entfernen:");
	foreach(var rChar in _result)  
	{  
		Console.WriteLine("Char: {0} ", rChar);  
	}   
}

19-       
static void Main(string[] args)
{
	int minLength = 2;
	string[] strArr = { "this", "is", "a", "string" };  

	var result = from str in strArr 
	  where str.Length >= minLength
	  orderby str
	  select str; 

	foreach(var str in result)  
	{  
	  Console.WriteLine("Item: {0} ", str);  
	}             
}
 
20-       
static void Main(string[] args)
{
	char[] charset1 = { 'X', 'Y', 'Z' };
	int[] numset1 = { 1, 2, 3, 4 };

	var cartesianProduct = from letterList in charset1
						   from numberList in numset1
						   select new { letterList, numberList };

	Console.Write("The cartesian product are : \n");
	foreach (var productItem in cartesianProduct)
	{
	  Console.WriteLine(productItem);
	}        
}

21-      
static void Main(string[] args)
{
	char[] charset = { 'X', 'Y', 'Z' };
	int[] numset = { 1, 2, 3, 4 };
	string[] colorset = { "Green", "Orange" };

	var cartesianProduct = from letter in charset
							from number in numset
							from color in colorset
							select new { letter, number, color };

	Console.Write("The cartesian product are : \n");
	foreach (var productItem in cartesianProduct)
	{
	  Console.WriteLine(productItem);
	}        
}

22-       
static void Main(string[] args)
{
	List<Item_mast> itemlist = new List<Item_mast>
	{  
	   new Item_mast { ItemId = 1, ItemDes = "Biscuit  " }, 
	   new Item_mast { ItemId = 2, ItemDes = "Chocolate" }, 
	   new Item_mast { ItemId = 3, ItemDes = "Butter   " },  
	   new Item_mast { ItemId = 4, ItemDes = "Brade    " },  
	   new Item_mast { ItemId = 5, ItemDes = "Honey    " }  
	}; 
	  
	List<Purchase> purchlist = new List<Purchase>
	{  
	   new Purchase { InvNo=100, ItemId = 3,  PurQty = 800 }, 
	   new Purchase { InvNo=101, ItemId = 2,  PurQty = 650 }, 
	   new Purchase { InvNo=102, ItemId = 3,  PurQty = 900 },  
	   new Purchase { InvNo=103, ItemId = 4,  PurQty = 700 },
	   new Purchase { InvNo=104, ItemId = 3,  PurQty = 900 },  
	   new Purchase { InvNo=105, ItemId = 4,  PurQty = 650 },  		   
	   new Purchase { InvNo=106, ItemId = 1,  PurQty = 458 }  
	}; 
		
	var cartesianProduct = from item in itemlist
							from purch in purchlist
							where item.ItemId == purch.ItemId
							select new { item.ItemId, item.ItemDes, purch.PurQty };         

	Console.Write("The cartesian product are : \n");
	foreach (var productItem in cartesianProduct)
	{
	  Console.WriteLine(productItem);
	} 
}    
    
public class Item_mast
{
	public int ItemId { get; set; }
	public string ItemDes { get; set; }
}

public class Purchase
{
	public int InvNo { get; set; }
	public int ItemId { get; set; }
	public int PurQty { get; set; }
}

23-       
static void Main(string[] args)
{
	List<Item_mast> itemlist = new List<Item_mast>
	{  
	   new Item_mast { ItemId = 1, ItemDes = "Biscuit  " }, 
	   new Item_mast { ItemId = 2, ItemDes = "Chocolate" }, 
	   new Item_mast { ItemId = 3, ItemDes = "Butter   " },  
	   new Item_mast { ItemId = 4, ItemDes = "Brade    " },  
	   new Item_mast { ItemId = 5, ItemDes = "Honey    " }  
	}; 
	  
	List<Purchase> purchlist = new List<Purchase>
	{  
	   new Purchase { InvNo=100, ItemId = 3,  PurQty = 800 }, 
	   new Purchase { InvNo=101, ItemId = 2,  PurQty = 650 }, 
	   new Purchase { InvNo=102, ItemId = 3,  PurQty = 900 },  
	   new Purchase { InvNo=103, ItemId = 4,  PurQty = 700 },
	   new Purchase { InvNo=104, ItemId = 3,  PurQty = 900 },  
	   new Purchase { InvNo=105, ItemId = 4,  PurQty = 650 },  		   
	   new Purchase { InvNo=106, ItemId = 1,  PurQty = 458 }  
	}; 
		
	var innerJoin = from item in itemlist
		join purch in purchlist on item.ItemId equals purch.ItemId  
		select new  
		{  
			itid = item.ItemId,  
			itdes = item.ItemDes,  
			prqty = purch.PurQty  
		};  

	foreach (var item in innerJoin)
	{
	  Console.WriteLine("ID: {0}, Description: {1}, Menge: {2} ", item.itid, item.itdes, item.prqty);
	} 
}    
    
public class Item_mast
{
	public int ItemId { get; set; }
	public string ItemDes { get; set; }
}

public class Purchase
{
	public int InvNo { get; set; }
	public int ItemId { get; set; }
	public int PurQty { get; set; }
}

24-      
static void Main(string[] args)
{
	List<Item_mast> itemlist = new List<Item_mast>
	{  
		new Item_mast { ItemId = 1, ItemDes = "Biscuit  " }, 
		new Item_mast { ItemId = 2, ItemDes = "Chocolate" }, 
		new Item_mast { ItemId = 3, ItemDes = "Butter   " },  
		new Item_mast { ItemId = 4, ItemDes = "Brade    " },  
		new Item_mast { ItemId = 5, ItemDes = "Honey    " }  
	}; 
	  
	List<Purchase> purchlist = new List<Purchase>
	{  
		new Purchase { InvNo=100, ItemId = 3,  PurQty = 800 }, 
		new Purchase { InvNo=101, ItemId = 2,  PurQty = 650 }, 
		new Purchase { InvNo=102, ItemId = 3,  PurQty = 900 },  
		new Purchase { InvNo=103, ItemId = 4,  PurQty = 700 },
		new Purchase { InvNo=104, ItemId = 3,  PurQty = 900 },  
		new Purchase { InvNo=105, ItemId = 4,  PurQty = 650 },  		   
		new Purchase { InvNo=106, ItemId = 1,  PurQty = 458 }  
	}; 
		
	var leftOuterJoin = from itm in itemlist
						join prch in purchlist on itm.ItemId equals prch.ItemId	into g
						from p in g.DefaultIfEmpty(new Purchase())
						select new
						{
							itid = itm.ItemId,
							itdes = itm.ItemDes,
							prqty = p.PurQty
						};

	foreach (var item in leftOuterJoin)
	{
	  Console.WriteLine("ID: {0}, Description: {1}, Menge: {2} ", item.itid, item.itdes, item.prqty);
	} 
}

25-      
static void Main(string[] args)
{
	List<Item_mast> itemlist = new List<Item_mast>
	{  
		new Item_mast { ItemId = 1, ItemDes = "Biscuit  " }, 
		new Item_mast { ItemId = 2, ItemDes = "Chocolate" }, 
		new Item_mast { ItemId = 3, ItemDes = "Butter   " },  
		new Item_mast { ItemId = 4, ItemDes = "Brade    " },  
		new Item_mast { ItemId = 5, ItemDes = "Honey    " }  
	}; 
	  
	List<Purchase> purchlist = new List<Purchase>
	{  
		new Purchase { InvNo=100, ItemId = 3,  PurQty = 800 }, 
		new Purchase { InvNo=101, ItemId = 2,  PurQty = 650 }, 
		new Purchase { InvNo=102, ItemId = 3,  PurQty = 900 },  
		new Purchase { InvNo=103, ItemId = 4,  PurQty = 700 },
		new Purchase { InvNo=104, ItemId = 3,  PurQty = 900 },  
		new Purchase { InvNo=105, ItemId = 4,  PurQty = 650 },  		   
		new Purchase { InvNo=106, ItemId = 1,  PurQty = 458 }       
	}; 
		
	var rightOuterJoin = from p in purchlist
						join i in itemlist on p.ItemId equals i.ItemId	into g
						from b in g.DefaultIfEmpty(new Item_mast())
						select new
						{
							itid = p.ItemId,
							itdes = b.ItemDes,
							prqty = p.PurQty
						};

	foreach (var item in rightOuterJoin)
	{
	  Console.WriteLine("ID: {0}, Description: {1}, Menge: {2} ", item.itid, item.itdes, item.prqty);
	} 
}    
    
public class Item_mast
{
	public int ItemId { get; set; }
	public string ItemDes { get; set; }
}

public class Purchase
{
	public int InvNo { get; set; }
	public int ItemId { get; set; }
	public int PurQty { get; set; }
}

26-      
static void Main(string[] args)
{
	string[] cities = { "CALIFORNIA", "PARIS", "NEW DELHI", "LONDON", "ABU DHABI", "ZURICH", "NAIROBI",  "AMSTERDAM", "ROME"};

	IEnumerable<string> orderedCities =
		cities.OrderBy(str => str.Length)
						.ThenBy(str => str);
	 
	foreach (var city in orderedCities)
	{
	  Console.WriteLine(city);
	} 
} 

27-      
static void Main(string[] args)
{
	string[] cities = { "CALIFORNIA", "PARIS", "NEW DELHI", "LONDON", "ABU DHABI", "ZURICH", "NAIROBI", "AMSTERDAM", "ROME"};

	var cityGrs = from city in cities
				   group city by city.Length into c
				   select c;       
	 
	foreach (var cg in cityGrs)
	{
	  Console.WriteLine("\n");
	  foreach(var c in cg) {
		Console.Write(c + " , ");
	  }          
	} 
} 

28-       
static void Main(string[] args)
{
	string[] cities = { "CALIFORNIA", "PARIS", "NEW DELHI", "LONDON", "ABU DHABI", "ZURICH", "NAIROBI", "AMSTERDAM", "ROME"};        
				   
	var citySplit = from i in Enumerable.Range(0, cities.Length)
								group cities[i] by i / 3;
								
	foreach (var cg in citySplit)
	{
		Console.WriteLine("\n");
		foreach(var c in cg) {
		Console.Write(c + " , ");
	  }  
	}		
} 

29-       
static void Main(string[] args)
{
	var itemlist = (from c in Item_Mast.GetItemMast()
				select c.ItemDes)
				.Distinct()
				.OrderBy(x => x);
								
	foreach (var item in itemlist)
	{
		Console.WriteLine(item);        
	}		
}    
class Item_Mast
{
	public int 	ItemId { get; set; }
	public string ItemDes { get; set; }

	public static List<Item_Mast> GetItemMast()
	{
	  List<Item_Mast> itemlist = new List<Item_Mast>();
	  itemlist.Add(new Item_Mast() { ItemId = 1, ItemDes = "Biscuit  " });
	  itemlist.Add(new Item_Mast() { ItemId = 2, ItemDes = "Honey    " });
	  itemlist.Add(new Item_Mast() { ItemId = 3, ItemDes = "Butter   " });
	  itemlist.Add(new Item_Mast() { ItemId = 4, ItemDes = "Brade    " });
	  itemlist.Add(new Item_Mast() { ItemId = 5, ItemDes = "Honey    " });
	  itemlist.Add(new Item_Mast() { ItemId = 6, ItemDes = "Biscuit  " });
	  return itemlist;
	}
}

30-       
static void Main(string[] args)
{
	Console.WriteLine("#f08080" + "->" + test("#f08080"));
	Console.WriteLine("#EFFA07A" + "->" + test("#EFFA07A"));
	Console.WriteLine("#E9967A" + "->" + test("#E9967A"));
	Console.WriteLine("#CD5C5C" + "->" + test("#CD5C5C"));       	
}

public static bool test(string hc)
{
	return Regex.IsMatch(hc, @"[#][0-9A-Fa-f]{6}\b");
}

31-      
static void Main(string[] args)
{
	Console.WriteLine("CPP Exercises." + "->" + test("CPP Exercises."));
	Console.WriteLine("C# syntax is highly expressive, yet it is also simple and easy to learn." + "->" + test("C# syntax is highly expressive, yet it is also simple and easy to learn."));
	Console.WriteLine("C# is an elegant and type-safe object-oriented language" + "->" + test("C# is an elegant and type-safe object-oriented language"));              	
}

public static double test(string text)
{
	string new_text = Regex.Replace(text, "[^A-Za-z ]", "");
	double average_len = new_text.Split(' ').Select(x => x.Length).Average();
	return Math.Round(average_len, 2);
}

32-       
static void Main(string[] args)
{
	Console.WriteLine("amamd" + "->" + test("amamd"));
	Console.WriteLine("pamamd" + "->" + test("pamamd"));        
	Console.WriteLine("ferre" + "->" + test("ferre"));       
}

public static bool test(string text)
{
	bool result = Regex.Replace(string.Concat(text.OrderBy(x => x)),@"([a-z])\1{1}",string.Empty).Length <= 1;
	return result;
}

33-       
static void Main(string[] args)
{
	Console.WriteLine("Suuu#21g" + " -> " + test("Suuu#21g"));
	Console.WriteLine("W#1g@" + " -> " + test("W#1g@"));
	Console.WriteLine("a&&g@" + " -> " + test("a&&g@"));
	Console.WriteLine("sdsd723#$Amid" + " -> " + test("sdsd723#$Amid"));
	Console.WriteLine("sdsd723#$Amidkiouy" + " -> " + test("sdsd723#$Amidkiouy"));
}

public static bool test(string text)
{
	return text.Length >= 7 && text.Length <= 16 
		&& Regex.IsMatch(text, @"[a-z]") 
		&& Regex.IsMatch(text, @"[A-Z]")
		&& Regex.IsMatch(text, @"[0-9]")
		&& Regex.IsMatch(text, @"[!@#$%^]")
		&& !Regex.IsMatch(text, @"[^\dA-Za-z!@#$%^]");
} 

34-       
static void Main(string[] args)
{
	Console.WriteLine("AACC, PPRR" + " -> " + test("AACC", "PPRR"));
	Console.WriteLine("FFGG, ADAD" + " -> " + test("FFGG", "ADAD"));
}

public static bool test(string text1, string text2)
{
	for (int i = 0; i < text1.Length; i++)
	{
		if (text1.IndexOf(text1.Substring(i, 1), i + 1) != text2.IndexOf(text2.Substring(i, 1), i + 1))
			return false;
	}
   return true;
}

35-       
static void Main(string[] args)
{
	Regex rx = new Regex(@"\b(?<word>[a-zA-Z#]+)\s+(\k<word>)\b",
	  RegexOptions.Compiled | RegexOptions.IgnoreCase);
	  
	MatchCollection matches = rx.Matches("C# C# syntax is highly expressive, yet it is is also simple and easy to to learn learn.");

	foreach (Match match in matches)
	{
		GroupCollection groups = match.Groups;
		Console.WriteLine("'{0}' repeated at positions {1} and {2}",
						  groups["word"].Value,
						  groups[0].Index,
						  groups[1].Index);
	}        
}  

36-      
static void Main(string[] args)
{
	Console.WriteLine("AA@%^&CC -> " + test("AA@%^&CC"));
	Console.WriteLine("Python -> " + test("Python"));
	Console.WriteLine("w3resource.com -> " + test("w3resource.com"));
}

public static string test(string text)
{
	return Regex.Replace(text, @"[^A-Za-z0-9\s_-]", "");
} 

37-      
static void Main(string[] args)
{
	Console.WriteLine("C# Exercises -> " + test("C# Exercises"));
	Console.WriteLine("Python Exercises -> " + test("Python Exercises"));
	Console.WriteLine("Tutorial on c# -> " + test("Tutorial on c#"));
}

public static string test(string text)
{
	if(Regex.IsMatch(text, Regex.Escape("C#"), RegexOptions.IgnoreCase))
	{
		return "C# document found.";
	} else
	{
		return "Sorry no C# document!";
	}      	
}

38-
static void Main(string[] args)
{
	Console.Write("Input a character: ");
	char ch = (char)Console.Read();
	if (Char.IsLetter(ch))
	{
		if (Char.IsUpper(ch))
		{
			Console.WriteLine("uppercase");
		}
		else
		{
			Console.WriteLine("lowercase");
		}
	}
	else
	{
		Console.WriteLine("not an alphabetic character");
	}

	Console.Read();
}

39-
static void Main(string[] args)
{
	Console.Write("Enter a number: ");
	int number = Convert.ToInt32(Console.ReadLine());
	int dividers = 0;

	for (int i = 1;  i <= number; i++)
	{
		if(number % i == 0)
		{
			dividers++;
		}
	}

	if(dividers == 2) 
	{ 
		Console.WriteLine("prime number"); 
	} 
	else 
	{
		Console.WriteLine("no prime number");
	}

	Console.Read();
}

40-
static void Main(string[] args)
{
	int int1 = Int32.MaxValue;
	int int2 = Int32.MaxValue;
	long longResult = Math.BigMul(int1, int2);
	Console.WriteLine("{0} * {1} = {2}", int1, int2, longResult);
	
	Console.Read();
}

41-
delegate double Measure(double radius);

static void Main(string[] args)
{           
	Measure[] Calc = new Measure[3];

	Circle circ = new Circle();
	Calc[0] = new Measure(circ.Diameter);            
	Calc[1] = new Measure(circ.Circumference);            
	Calc[2] = new Measure(circ.Area);

	double radius = 10;
	double diameter = Calc[0](radius);
	double circumference = Calc[1](radius);
	double area = Calc[2](radius);

	Console.WriteLine("Diameter:      {0}", diameter);
	Console.WriteLine("Circumference: {0}", circumference);
	Console.WriteLine("Area:          {0}", area);

	Console.Read();
}

42-
delegate void dele(int a, int b);
static void Main(string[] args)
{
	dele del = new dele(Oper.Add);
	del += new dele(Oper.Sub);
	del(4, 2);
	del -= new dele(Oper.Sub);
	del(1, 9);

	Console.Read();
}

43-
static void Main(string[] args)
{
	int[] a = { 3, 0, 2, 5, -1, 4, 1 };

	foreach (int i in a)
	{
		Console.Write(i + ", ");
	}

	Console.WriteLine("");

	for (int i = 0; i < a.Length - 1; i++)
	{
		for (int j = 0; j < a.Length - 1; j++)
		{
			if (a[j] > a[j + 1])
			{
				int temp = a[j];
				a[j] = a[j + 1];
				a[j + 1] = temp;
            }
		}                
	}

	foreach (int i in a)
	{
		Console.Write(i + ", ");
	}

	Console.Read();
}

44-
static void Main(string[] args)
{
	Console.WriteLine(isPalindrome(123456));
	Console.WriteLine(isPalindrome(16461));
	Console.WriteLine(isPalindrome(-121));

	Console.Read();
}

public static bool isPalindrome(int a)
{
	if (a < 0) { return false; }
	if (a < 10) { return true; }

	var temp = a;
	var b = 0;
	var digit = 0;
	while (temp != 0)
	{
		digit = temp % 10;
		b = b * 10 + digit;
		temp /= 10;
	}
	return a == b;
}

45-
public class PriceChangedEventArgs : EventArgs
{
	public readonly double LastPrice, NewPrice;

	public PriceChangedEventArgs (double lastPrice, double newPrice)
	{
		LastPrice = lastPrice;
		NewPrice = newPrice;
	}
}

public class Stock
{
	double price;          

	public event EventHandler<PriceChangedEventArgs> PriceChanged;
	protected virtual void OnPriceChanged (PriceChangedEventArgs e) => PriceChanged?.Invoke (this, e);

	public double Price
	{
		get 
		{ 
			return price;
		}
		set
		{
			if (price == value) return;
			OnPriceChanged(new PriceChangedEventArgs(price, value));
			price = value;
		}
	}
}

46-
public static IEnumerable<int> EvenSequence(int firstNumber, int lastNumber)
{
	for (int number = firstNumber; number <= lastNumber; number++)
	{
		if (number % 2 == 0)
		{
			yield return number;
		}
	}
}

47-
using (var enumerator = "Mona".GetEnumerator())
{
	while (enumerator.MoveNext())
	{
		var element = enumerator.Current;
		Console.WriteLine(element);
	}
}

48- The code should be added outside the Program class!
public static class MyCircleExtension
{
	public static double Area(this Circle c, double Radius)
	{
		const double PI = 3.14159;
		return Radius * Radius * PI;
	}
}

49-
static void Main(string[] args)
{
	int? x = 5;
	int? y = 10;	

	bool b = (x.HasValue && y.HasValue) ? (x.Value < y.Value) : false;
	Console.WriteLine("b = {0}", b);

	Console.Read();
}

50-
static IEnumerable<int> EvenNumbersOnly (IEnumerable<int> Sequence) 
{
	foreach (int x in Sequence)
	{
		if ((x % 2) == 0)
		{ 
			yield return x;
		}
	}
}
		
static void Main(string[] args)
{
	foreach (int n in Numbers())
	{
		Console.Write(n + " ");
	}

	Console.WriteLine("\n");

	foreach (int n in EvenNumbersOnly(Numbers()))
	{
		Console.Write(n + " ");
	}

	Console.Read();
}

51-
class Person
{
	... 
	
	// Copy constructor.
	//public Person(Person previousPerson)
	//{
	//    Name = previousPerson.Name;
	//    Age = previousPerson.Age;
	//}

	// Alternate copy constructor calls the instance constructor.
	public Person(Person previousPerson)
		: this(previousPerson.Name, previousPerson.Age)
	{
	}
		
	...	
}

static void Main(string[] args)
{
	Person person1 = new Person("George", 40);
	Person person2 = new Person(person1);
	
	person1.Age = 39;
	person2.Age = 41;            
	person2.Name = "Charles";
	
	Console.WriteLine(person1.Details());
	Console.WriteLine(person2.Details());
	
	Console.Read();
}

52-
public class Adult : Person
{
	private static int minimumAge;

	public Adult(string firstName, string lastName) : base(firstName, lastName)
	{ }

	static Adult()
	{
		minimumAge = 18;
	}            
}

static void Main(string[] args)
{
	Adult a = new Adult("Mona", "Stamm");
	
	Console.Read();
}

53-
static void Main(string[] args)
{
	int[] nrs = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

	foreach (int n in nrs.Take(5..))
	{
		Console.Write(n + " ");
	}

	Console.WriteLine("\n");

	foreach (int n in nrs.Take(..5))
	{
		Console.Write(n + " ");
	}

	Console.WriteLine("\n");

	foreach (int n in nrs.Take(2..4))
	{
		Console.Write(n + " ");
	}

	Console.WriteLine("\n");

	Console.Read();
}

54-
Console.WriteLine(nrs.First()); // 10
Console.WriteLine(nrs.Last());  // 6
Console.WriteLine(nrs.ElementAt(2)); // 8
Console.WriteLine(nrs.First(n => n % 2 == 1)); // 9
Console.WriteLine(nrs.Count()); // 5
Console.WriteLine(nrs.Min());   // 6
Console.WriteLine(nrs.Max());   // 10
Console.WriteLine(nrs.Average());   // 8
Console.WriteLine(nrs.Count(n => n % 2 == 0)); // 3
Console.WriteLine(nrs.Max(n => n + 5)); // 15
Console.WriteLine(nrs.Min(n => n + 4)); // 10
Console.WriteLine(nrs.Average(n => n + 2)); // 10
Console.WriteLine(nrs.Contains(7)); // True
Console.WriteLine(nrs.Any(n => n % 2 == 0)); // True
Console.WriteLine(nrs.All(n => n % 2 == 0)); // False

55-
static void Main(string[] args)
{
	string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };

	var namesQuery = from n in names
					 where n.Length == names.Min(n2 => n2.Length)
					 select n;

	foreach ( var name in namesQuery )
	{
		Console.WriteLine( name );
	}

	Console.Read();
}

56-
static void Main(string[] args)
{
	string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };

	var namesQuery = from n in names
					 let vowelless = Regex.Replace(n, "[aeiou]", "")
					 where vowelless.Length > 2
					 orderby vowelless
					 select n + " - " + vowelless;

	foreach ( var name in namesQuery )
	{
		Console.WriteLine( name );
	}

	Console.Read();
}

57-
async static Task AsyncGo()
{
	Console.WriteLine("Start");
	await AsyncPrintAnswerToLife();
	Console.WriteLine("End");
}

async static Task AsyncPrintAnswerToLife()
{
	int answer = await AsyncGetAnswerToLife();
	Console.WriteLine(answer);
}

async static Task<int> AsyncGetAnswerToLife()
{
	await Task.Delay(10000);
	int answer = 21 * 2;
	return answer;
}

58-
static void Main(string[] args)
{
	Task task = AsyncGo();
	var awaiter = task.GetAwaiter();
	awaiter.OnCompleted(() => {
		Console.WriteLine("My code after completion of AsyncGo()");
	});            

	Console.Read();
}

59-
async static void Test()
{
	for (int i = 0; i < 10;  i++)
	{
		await AsyncGo();
		Console.WriteLine(i);
	}
}

60-
static void Main(string[] args)
{
	Task<int> task = ComplexCalculationAsyn();
	var awaiter = task.GetAwaiter();
	awaiter.OnCompleted(() => {
		int result = awaiter.GetResult();
		Console.WriteLine("Result after calculation = {0}", result);
	});
				
	Console.Read();
}

61-
async static void Test()
{
	await Task.WhenAll(ComplexCalculationAsyn(), ComplexCalculationAsyn2());
	Console.WriteLine("All tasks finished");

	await Task.WhenAny(ComplexCalculationAsyn(), ComplexCalculationAsyn2());
	Console.WriteLine("Any task finished");
}

62-
static async IAsyncEnumerable<int> RangeAsync (int start, int end, int delay)
{
	for(int i = start; i <= end; i++)
	{
		await Task.Delay (delay);
		yield return i;
	}

}

async static void Test()
{
	await foreach(var number in RangeAsync(9, 25, 1000))
	{
		Console.WriteLine(number);
	}
}

static void Main(string[] args)
{
	Test();

	Console.Read();
}

63-
public class Panda
{
	public string Name;
	public static int Population;
	public Panda(string n) 
	{
		Name = n;
		Population = Population + 1;
	}
} 

64-
public string CreateHeader()
{
	var properties = _type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

	var bob = new StringBuilder();
	foreach (var property in properties)
	{
		bob.Append(property.Name).Append(",");
	}

	return bob.ToString()[..^1];
}

65-
public string CreateRow(T item)
{
	var properties = _type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

	var bob = new StringBuilder();
	foreach (var property in properties)
	{
		bob.Append(CreateItem((dynamic)property.GetValue(item))).Append(",");
	}

	return bob.ToString()[..^1];
}

private string CreateItem(object item) { return item.ToString(); }
private string CreateItem(DateTime item) { return item.ToShortDateString(); }

66-
[Fact]
public void LoadBands_ValidCall()
{
	using(var mock = AutoMock.GetLoose())
	{
		mock.Mock<IRepository>()
			.Setup(r => r.GetBands("select * from Person"))
			.Returns(new List<Band>
			{
				new Band { Name = "Farhad Darya", BestSong = "Kabul Jan" },
				new Band { Name = "Ahmad Zaher", BestSong = "Laili Laili" }
			});

		var cls = mock.Create<BandController>();
		var actual = cls.LoadBands();		

		List<Band> expected = new List<Band>();
		expected.Add(new Band
		{
			Name = "Farhad Darya",
			BestSong = "Kabul Jan"
		});
		expected.Add(new Band
		{
			Name = "Ahmad Zaher",
			BestSong = "Laili Laili"
		});
		
		Assert.NotNull(actual);
		Assert.Equal(expected.Count, actual.Count);

		for(int i = 0; i < expected.Count; i++)
		{
			Assert.Equal(expected[i].Name, actual[i].Name);
			Assert.Equal(expected[i].BestSong, actual[i].BestSong);
		}
	}
}

67-
[Fact]
public void SaveData_ValidCall()
{
	using (var mock = AutoMock.GetLoose())
	{
		Band band = new Band { Name = "Sarban", BestSong = "Ay Shakhe Gul" };
		string sql = "insert into Person ...";
		mock.Mock<IRepository>()
			.Setup(r => r.SaveBand(band, sql));                   

		var cls = mock.Create<BandController>();
		cls.SaveData(band);

		mock.Mock<IRepository>()
			.Verify(x => x.SaveBand(band, sql), Times.Exactly(1));
	}
}

68-
static void Main(string[] args)
{
	int[,] matrix = new int[3, 3];
	
	for(int i = 0; i < matrix.GetLength(0); i++)
	{
		for(int j = 0; j < matrix.GetLength(1); j++)
		{
			matrix[i, j] = i * 3 + j;
		}
	}

	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			Console.Write($"{matrix[i, j]}  ");
		}
		Console.WriteLine("\n");
	}
	
	Console.Read();
}

69-
static void Main(string[] args)
{
	int[][] matrix = new int[3][];

	for (int i = 0; i < matrix.Length; i++)
	{
		if(i == 2)
		{
			matrix[i] = new int[6];
		}
		else
		{
			matrix[i] = new int[3];
		}
		
		for (int j = 0; j < matrix[i].Length; j++)
		{
			matrix[i][j] = i * 3 + j;
		}
	}

	for (int i = 0; i < matrix.Length; i++)
	{                
		for (int j = 0; j < matrix[i].Length; j++)
		{
			Console.Write($"{matrix[i][j]}  ");
		}
		Console.WriteLine("\n");
	}
	
	Console.Read();
}

70-
static void AppendText(StringBuilder sb) 
{
	sb.Append("Test");
	sb = null;
}

static void AppendText(ref StringBuilder sb)
{
	sb.Append("Test");
	sb = null;
}

71-
public class PeopleContext : DbContext
{
	public PeopleContext(DbContextOptions options) : base(options) {}

	public DbSet<Book> Books { get; set; }
}
	
public class Book
{
	public int BookId { get; set; }
	public string Title { get; set; }
	public string Description { get; set; }
	public DateTime PublishedOn { get; set; }
	public string Publisher { get; set; }
	public decimal Price { get; set; }
	public string ImageUrl { get; set; }
	public bool SoftDeleted { get; set; }
}

72-
migrationBuilder.CreateTable(
	name: "Books",
	columns: table => new
	{
		BookId = table.Column<int>(type: "int", nullable: false)
			.Annotation("SqlServer:Identity", "1, 1"),
		Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
		Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
		PublishedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
		Publisher = table.Column<string>(type: "nvarchar(max)", nullable: false),
		Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
		ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
		SoftDeleted = table.Column<bool>(type: "bit", nullable: false)
	},
	constraints: table =>
	{
		table.PrimaryKey("PK_Books", x => x.BookId);
	});
	
73-
public void OnGet()
{
	var bookToAdd = new Book
	{
		Title = "Entity Framework Core IN ACTION",
		Description = ".NET Entity Framework advanced book",
		PublishedOn = new DateTime(2020, 1, 1),
		Publisher = "Jon P. Smith",
		Price = 55,
		ImageUrl = "www.manning.com",
		SoftDeleted = false
	};

	_db.Add(bookToAdd);
	_db.SaveChanges();
}

public class PeopleContext : DbContext
{
	public PeopleContext(DbContextOptions options) : base(options) {}	
	public DbSet<Book> Books { get; set;}	
}

public class Book
{
	public int BookId { get; set; }
	public string Title { get; set; }
	public string Description { get; set; }
	public DateTime PublishedOn { get; set; }
	public string Publisher { get; set; }
	public decimal Price { get; set; }
	public string ImageUrl { get; set; }
	public bool SoftDeleted { get; set; }
}

74- 
exec sp_executesql N'SET IMPLICIT_TRANSACTIONS OFF; 
SET NOCOUNT ON;
INSERT INTO [Books] ([Description], [ImageUrl], [Price], [PublishedOn], [Publisher], [SoftDeleted], [Title])  
OUTPUT INSERTED.[BookId]
VALUES (@p0, @p1, @p2, @p3, @p4, @p5, @p6);',
N'@p0 nvarchar(4000),
@p1 nvarchar(4000),
@p2 decimal(18,2),
@p3 datetime2(7),
@p4 nvarchar(4000),
@p5 bit,
@p6 nvarchar(4000)',
@p0=N'An advanced book about EF Core',
@p1=N'www.image.de/image',
@p2=66.00,
@p3='2022-01-01 00:00:00',
@p4=N'John P.Smith',
@p5=0,
@p6=N'Entity Framework Core IN ACTION'

75-
public class PeopleContext : DbContext
{
	public PeopleContext(DbContextOptions options) : base(options) {}

	public DbSet<Book> Books { get; set; }
	public DbSet<PriceOffer> PriceOffers { get; set; }
}
	
public class PriceOffer
{
	public int PriceOfferId { get; set; }
	public decimal NewPrice { get; set; }
	public string PromotionalText { get; set; }
	
	//relationships
	public int BookId { get; set; }
}

public class Book
{
	public int BookId { get; set; }
	public string Title { get; set; }
	public string Description { get; set; }
	public DateTime PublishedOn { get; set; }
	public string Publisher { get; set; }
	public decimal Price { get; set; }
	public string ImageUrl { get; set; }
	public bool SoftDeleted { get; set; }
	
	//relationships
	public PriceOffer Promotion { get; set; }       
}

76-
modelBuilder.Entity("EFDataAccessLibrary.Models.PriceOffer", b =>
{
	b.HasOne("EFDataAccessLibrary.Models.Book", null)
		.WithOne("Promotion")
		.HasForeignKey("EFDataAccessLibrary.Models.PriceOffer", "BookId")
		.OnDelete(DeleteBehavior.Cascade)
		.IsRequired();
});

modelBuilder.Entity("EFDataAccessLibrary.Models.Book", b =>
{
	b.Navigation("Promotion")
		.IsRequired();
});

77-
public void OnGet()
{
	var book = _db.Books
		.First(p => p.Promotion == null);

	book.Promotion = new PriceOffer
	{
		NewPrice = book.Price / 2,
		PromotionalText = "Half price today!"
	};

	_db.SaveChanges();
}

78-
SELECT TOP(1) [b].[BookId], [b].[Description], [b].[ImageUrl], [b].[Price],
[b].[PublishedOn], [b].[Publisher], [b].[SoftDeleted], [b].[Title]  
FROM [Books] AS [b]  
LEFT JOIN [PricesOffers] AS [p] ON [b].[BookId] = [p].[BookId]  
WHERE [p].[PriceOfferId] IS NULL

exec sp_executesql 
N'SET IMPLICIT_TRANSACTIONS OFF;  SET NOCOUNT ON;  
INSERT INTO [PricesOffers] (NewPrice, PromotionalText)  
OUTPUT INSERTED.[PriceOfferId]  
VALUES (@p0, @p1, @p2);  ',
N'@p0 int,@p1 decimal(18,2),@p2 nvarchar(4000)',
@p0=4,@p1=33.00,@p2=N'Half price today 14:50!'

79-
public void OnGet()
{
	var book = _db.Books
		.Include(p => p.Promotion)
		.First(p => p.Promotion != null);

	book.Promotion = new PriceOffer
	{
		NewPrice = book.Price / 2,
		PromotionalText = "Half price today!"
	};

	_db.SaveChanges();
}

80-
SELECT TOP(1) [b].[BookId], [b].[Description], [b].[ImageUrl], [b].[Price], 
[b].[PublishedOn], [b].[Publisher], [b].[SoftDeleted], [b].[Title], 
[p].[PriceOfferId], [p].[BookId], [p].[NewPrice], [p].[PromotionalText]  
FROM [Books] AS [b]
LEFT JOIN [PricesOffers] AS [p] ON [b].[BookId] = [p].[BookId]  
WHERE [p].[PriceOfferId] IS NOT NULL

exec sp_executesql 
N'SET NOCOUNT ON;  
DELETE FROM [PricesOffers]  OUTPUT 1  WHERE [PriceOfferId] = @p0;
INSERT INTO [PricesOffers] ([BookId], [NewPrice], [PromotionalText])  
OUTPUT INSERTED.[PriceOfferId]  
VALUES (@p1, @p2, @p3);  ',
N'@p0 int,@p1 int,@p2 decimal(18,2),@p3 nvarchar(4000)',
@p0=4,@p1=1,@p2=33.00,@p3=N'Half price today 14:50!'

81-
public class PeopleContext : DbContext
{
	public PeopleContext(DbContextOptions options) : base(options) {}
	public DbSet<Book> Books { get; set; }        
}

public class Book
{
	public int BookId { get; set; }
	public string Title { get; set; }
	public string Description { get; set; }
	public DateTime PublishedOn { get; set; }
	public string Publisher { get; set; }
	public decimal Price { get; set; }
	public string ImageUrl { get; set; }
	public bool SoftDeleted { get; set; }
	
	public ICollection<Review> Reviews { get; set; }
}

public class Review
{
	public int ReviewId { get; set; }
	public string VoterName { get; set; }
	public int NumStars { get; set; }
	public string Comment { get; set; }

	//-----------------------------------------
	//Relationships
	public int BookId { get; set; }
}

modelBuilder.Entity("EFDataAccessLibrary.Models.Review", b =>
{
	b.HasOne("EFDataAccessLibrary.Models.Book", null)
		.WithMany("Reviews")
		.HasForeignKey("BookId")
		.OnDelete(DeleteBehavior.Cascade)
		.IsRequired();
});

modelBuilder.Entity("EFDataAccessLibrary.Models.Book", b =>
{
	b.Navigation("Reviews");
});

82-
public void OnGet()
{	
	var bookToAdd = new Book
	{
		Title = "Test Book",                
		Description = "This is only a test book",
		PublishedOn = DateTime.Today,
		Publisher = "Dr. Testmann",
		ImageUrl = "www.test.de",
		Reviews = new List<Review>
		{
			new Review
			{
				NumStars = 5,
				Comment = "Great test book!",
				VoterName = "Mr U Test"
			}
		}
	};

	_db.Add(bookToAdd);
	_db.SaveChanges();
}

83-
public class PeopleContext : DbContext
{
	public PeopleContext(DbContextOptions options) : base(options) {}

	public DbSet<Book> Books { get; set; }
	public DbSet<Author> Authors { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<BookAuthor>()
			.HasKey(x => new { x.BookId, x.AuthorId });
	}		
}

public class Book
{
	public int BookId { get; set; }
	public string Title { get; set; }
	public string Description { get; set; }
	public DateTime PublishedOn { get; set; }
	public string Publisher { get; set; }
	public decimal Price { get; set; }
	public string ImageUrl { get; set; }
	public bool SoftDeleted { get; set; }

	public ICollection<BookAuthor> AuthorsLink { get; set; }
}

public class Author
{
	public int AuthorId { get; set; }
	public string Name { get; set; }        

	public ICollection<BookAuthor> BooksLink { get; set; }
}

public class BookAuthor
{
	public int BookId { get; set; }
	public int AuthorId { get; set; }        
	
	public Book Book { get; set; }
	public Author Author { get; set; }
}

84-
modelBuilder.Entity("EFDataAccessLibrary.Models.BookAuthor", b =>
{
	b.HasOne("EFDataAccessLibrary.Models.Author", "Author")
		.WithMany("BooksLink")
		.HasForeignKey("AuthorId")
		.OnDelete(DeleteBehavior.Cascade)
		.IsRequired();

	b.HasOne("EFDataAccessLibrary.Models.Book", "Book")
		.WithMany("AuthorsLink")
		.HasForeignKey("BookId")
		.OnDelete(DeleteBehavior.Cascade)
		.IsRequired();

	b.Navigation("Author");

	b.Navigation("Book");
});

modelBuilder.Entity("EFDataAccessLibrary.Models.Author", b =>
{
	b.Navigation("BooksLink");
});

modelBuilder.Entity("EFDataAccessLibrary.Models.Book", b =>
{
	b.Navigation("AuthorsLink");
});

85-
public class PeopleContext : DbContext
{
	public PeopleContext(DbContextOptions options) : base(options) {}
	
	public DbSet<Book> Books { get; set; }
	public DbSet<Tag> Tags { get; set; }	
}

public class Book
{
	public int BookId { get; set; }
	public string Title { get; set; }	
	public string Description { get; set; }
	public DateTime PublishedOn { get; set; }
	public string Publisher { get; set; }	
	public decimal Price { get; set; }	
	public string ImageUrl { get; set; }
	public bool SoftDeleted { get; set; }
	
	public ICollection<Tag> Tags { get; set; }
}

public class Tag
{
	public string TagId { get; set; }

	public ICollection<Book> Books { get; set; }
}

86-
public void OnGet()
{
	var firstBook = _db.Books
		.Include(book => book.Reviews)
		.FirstOrDefault();
}
		
SELECT [t].[BookId], [t].[Description], [t].[ImageUrl], [t].[Price], [t].[PublishedOn], 
[t].[Publisher], [t].[SoftDeleted], [t].[Title], 
[r].[ReviewId], [r].[BookId], [r].[Comment], [r].[NumStars], [r].[VoterName]  
FROM ( SELECT TOP(1) [b].[BookId], [b].[Description], [b].[ImageUrl], [b].[Price], [b].[PublishedOn], 
[b].[Publisher], [b].[SoftDeleted], [b].[Title]  
FROM [Books] AS [b] ) AS [t]  
LEFT JOIN [Review] AS [r] ON [t].[BookId] = [r].[BookId]  
ORDER BY [t].[BookId]

87-
public void OnGet()
{
	var firstBook = _db.Books.First();
	var reviews = _db.Entry(firstBook)
		.Collection(book => book.Reviews)
		.Query().Count();
}
		
SELECT TOP(1) [b].[BookId], [b].[Description], [b].[ImageUrl], [b].[Price], [b].[PublishedOn], 
[b].[Publisher], [b].[SoftDeleted], [b].[Title]  
FROM [Books] AS [b]

exec sp_executesql N'SELECT COUNT(*)  FROM [Review] AS [r]  
WHERE [r].[BookId] = @__p_0',N'@__p_0 int',@__p_0=1

88-
public void OnGet()
{
	var firstBook = _db.Books.First();
	_db.Entry(firstBook)
		.Collection(book => book.Reviews).Load();
}

SELECT TOP(1) [b].[BookId], [b].[Description], [b].[ImageUrl], [b].[Price], [b].[PublishedOn], 
[b].[Publisher], [b].[SoftDeleted], [b].[Title]  
FROM [Books] AS [b]

exec sp_executesql N'SELECT [r].[ReviewId], [r].[BookId], [r].[Comment], [r].[NumStars], [r].[VoterName]  
FROM [Review] AS [r]  
WHERE [r].[BookId] = @__p_0',N'@__p_0 int',@__p_0=1

89-
public void OnGet()
{
	var firstBook = _db.Books.First();
	var starRatings = _db.Entry(firstBook)
		.Collection(book => book.Reviews)
		.Query().Select(review => review.NumStars)
		.ToList();
}

SELECT TOP(1) [b].[BookId], [b].[Description], [b].[ImageUrl], [b].[Price], [b].[PublishedOn], 
[b].[Publisher], [b].[SoftDeleted], [b].[Title]  
FROM [Books] AS [b]

exec sp_executesql N'SELECT [r].[NumStars]  
FROM [Review] AS [r]  WHERE [r].[BookId] = @__p_0',N'@__p_0 int',@__p_0=1

90-
public void OnGet()
{
	var books = _db.Books
		.Select(book => new
		{
			book.Title,
			book.Price,
			NumReviews = book.Reviews.Count,

		}).ToList();            
}

SELECT [b].[Title], [b].[Price], 
( SELECT COUNT(*)      
  FROM [Review] AS [r]
  WHERE [b].[BookId] = [r].[BookId]) AS [NumReviews]  
FROM [Books] AS [b]

91-
public void OnGet()
{
	var book = _db.Books
		.Include(p => p.Promotion)
		.Include(p => p.Reviews)
		.Single(p => p.Description == "EF Core"); 
	
	_db.Books.Remove(book);
	_db.SaveChanges();
}

92-
public void OnGet()
{
	var book = _db.Books
		.Include(book => book.AuthorsLink
			.OrderBy(bookAuthor => bookAuthor.AuthorId))
			.ThenInclude(bookAuthor => bookAuthor.Author)
		.Single(book => book.Title == "Achtsamkeit");
}

93-
public void OnGet()
{
	var book = _db.Books.Single(book => book.Title == "Achtsamkeit");

	_db.Entry(book)
		.Collection(book => book.AuthorsLink).Load();

	foreach( var authorLink in book.AuthorsLink)
	{
		_db.Entry(authorLink)
			.Reference(bookAuthor => bookAuthor.Author).Load();
	}                
}

94-
public void OnGet()
{
	var book = _db.Books
		.Select(book => new
		{
			book.BookId,
			book.Title,
			AuthorsString = string.Join(", ", 
							book.AuthorsLink
							.Select(ba => ba.Author.Name))

		}
		).Single(book => book.Title == "Achtsamkeit");             
}

95-
SELECT [t].[BookId], [t].[Title], [t0].[Name], [t0].[BookId], [t0].[AuthorId], [t0].[AuthorId0]  
FROM ( SELECT TOP(2) [b].[BookId], [b].[Title] FROM [Books] AS [b] WHERE [b].[Title] = N'Achtsamkeit'  ) AS [t]  
LEFT JOIN ( SELECT [a].[Name], [b0].[BookId], [b0].[AuthorId], [a].[AuthorId] AS [AuthorId0]      
	FROM [BookAuthor] AS [b0]
	INNER JOIN [Authors] AS [a] ON [b0].[AuthorId] = [a].[AuthorId]  ) 
	AS [t0] ON [t].[BookId] = [t0].[BookId] 
ORDER BY [t].[BookId], [t0].[BookId], [t0].[AuthorId]

96-
public void OnGet()
{
	var books = _db.Books
		.AsNoTracking()
		.MapBookToDto();

	foreach(var dto in books)
	{
		...
	}
}
		
public static class MyExtension
{
	public static IQueryable<BookListDto> MapBookToDto(this IQueryable<Book> books)
	{
		return books.Select(book => new BookListDto
		{
			BookId = book.BookId,
			Title = book.Title,
			Price = book.Price,
			ActualPrice = book.Promotion == null ? book.Price : book.Promotion.NewPrice,
			Authors = string.Join(", ", book.AuthorsLink.Select(ba => ba.Author.Name)),
			ReviewsCount = book.Reviews.Count,
			ReviewsAverageVotes = book.Reviews
								.Select(review => (double?) review.NumStars).Average(),
			TagStrings = book.Tags.Select(x => x.TagId).ToArray(),
		});
	}
}

97-
public void OnGet()
{
	var books = _db.Books
		.AsNoTracking()
		.MapBookToDto()
		.OrderBooksBy(OrderByOptions.ByPriceHighestFirst);

	foreach(var dto in books)
	{
		// ...
	}
}
		
public static IQueryable<BookListDto> OrderBooksBy(this IQueryable<BookListDto> books, 
                                                            OrderByOptions orderByOptions)
{
	switch (orderByOptions)
	{
		case OrderByOptions.SimpleOrder:
			return books.OrderByDescending(x => x.BookId);
		case OrderByOptions.ByVotes:
			return books.OrderByDescending(x => x.ReviewsAverageVotes);
		case OrderByOptions.ByPriceLowestFirst:
			return books.OrderBy(x => x.ActualPrice);
		case OrderByOptions.ByPriceHighestFirst:
			return books.OrderByDescending(x => x.ActualPrice);
		default:
			throw new ArgumentOutOfRangeException(nameof(orderByOptions), 
													orderByOptions, null);
	}           
}

98-
public void OnGet()
{
	var books = _db.Books
		.AsNoTracking()
		.MapBookToDto()
		.OrderBooksBy(OrderByOptions.ByPriceHighestFirst)
		.FilterBooksBy(BooksFilterBy.ByTags, ".NET");

	foreach (var dto in books)
	{
		// ...
	}
}
		
public static IQueryable<BookListDto> FilterBooksBy(this IQueryable<BookListDto> books,
                                                            BooksFilterBy filterBy,
                                                            string filterValue)
{
	if(string.IsNullOrEmpty(filterValue))
		return books;

	switch (filterBy)
	{
		case BooksFilterBy.NoFilter:
			return books;
		case BooksFilterBy.ByVotes:
			var filterVote = int.Parse(filterValue);
			return books.Where(x => x.ReviewsAverageVotes > filterVote);
		case BooksFilterBy.ByTags:
			return books.Where(x => x.TagStrings.Any(y => y == filterValue));                        
		default:
			throw new ArgumentOutOfRangeException(nameof(filterBy), filterBy, null);
	}            
}

99-
public void OnGet()
{
	var foundAuthor = _db.Authors
		.SingleOrDefault(author => author.Name == "Eckert Tolle");
	if (foundAuthor == null)
	{
		throw new Exception("Author not found");
	}

	var book = new Book
	{
		Title = "Test Book",
		PublishedOn = DateTime.Today,
		Description = "",
		Publisher = "",
		Price = 0,
		ImageUrl = ""
	};

	book.AuthorsLink = new List<BookAuthor>
	{
		new BookAuthor
		{
			Book = book,
			Author = foundAuthor
		}
	};

	_db.Add(book);
	_db.SaveChanges();
}

100-
public ChangePubDateDto GetOriginal(int id)
{
	return _db.Books
		.Select(p => new ChangePubDateDto
		{
			BookId = p.BookId,
			Title = p.Title,
			PublishedOn = p.PublishedOn
		})
		.Single(k => k.BookId == id);
}

public Book UpdateBook(ChangePubDateDto dto)
{
	var book = _db.Books.SingleOrDefault(x => x.BookId == dto.BookId);
	if(book == null)
	{
		throw new ArgumentException("Book not found");
	}
	book.PublishedOn = DateTime.Today;
	_db.SaveChanges();
	return book;
}

101-
public string GetModifiedAuthor()
{
	var author = _db.Books
		.AsNoTracking()
		.Where(p => p.Title == "Achtsamkeit")
		.Select(p => p.AuthorsLink.First().Author)
		.Single();
	author.Name = "New Author Name";
	return JsonConvert.SerializeObject(author);
}

public void UpdateAuthor(string authorJson)
{
	var author = JsonConvert.DeserializeObject<Author>(authorJson);

	_db.Authors.Update(author);
	_db.SaveChanges();
}

102-
public PriceOffer GetOriginal(int id)
{
	var book = _db.Books
		.Include(b => b.Promotion)
		.Single(b => b.BookId == id);

	return book?.Promotion ?? new PriceOffer()
	{
		BookId = id,
		NewPrice = book.Price,
		PromotionalText = ""
	};
}

public Book AddUpdatePriceOffer(PriceOffer promotion)
{
	var book = _db.Books
		.Include(b => b.Promotion)
		.Single(b => b.BookId == promotion.BookId);

	if(book.Promotion == null)
	{
		book.Promotion = promotion;
	}
	else
	{
		book.Promotion.NewPrice = promotion.NewPrice;
		book.Promotion.PromotionalText = promotion.PromotionalText + " changed!";
	}

	_db.SaveChanges();
	return book;
}

103-
public void OnGet()
{
	var book = _db.Books
		.First(b => b.Promotion == null);

	_db.Add(new PriceOffer {
		BookId = book.BookId,
		NewPrice = book.Price / 2,
		PromotionalText = "Half price today!"
	});

	_db.SaveChanges();
}

104-
public void OnGet()
{
	var book = _db.Books
		.Include(b => b.Reviews)
		.First();

	book.Reviews.Add(new Review
	{
		VoterName = "Unit Test",
		NumStars = 5,
		Comment = "Great book!"
	});

	_db.SaveChanges();
}

105-
public void OnGet()
{
	var book = _db.Books
		.Include(b => b.Reviews)
		.Single(b => b.BookId == 1);

	book.Reviews = new List<Review>
	{
		new Review
		{
			VoterName = "Mona",
			NumStars = 3,
			Comment = "The book is ok"
		}
	};

	_db.SaveChanges();
}

106-
public Review GetBlankReview(int id, out string title)
{
	title = _db.Books
		.Where(b => b.BookId == id)
		.Select(b => b.Title)
		.Single();

	return new Review
	{
		BookId = id
	};
}

public Book AddReviewToBook(Review review)
{
	var book = _db.Books
		.Include(b => b.Reviews)
		.Single(b => b.BookId == review.BookId);

	review.VoterName = "Geeti";
	review.NumStars = 1;
	review.Comment = "The book is not good";

	book.Reviews.Add(review);
	_db.SaveChanges();
	return book;
}

107-
public void OnGet()
{
	var book = _db.Books
		.Include(b => b.AuthorsLink)
		.Single(b => b.Title == "Neuanfang");

	var existingAuthor = _db.Authors
		.Single(b => b.Name == "Ajan Chah");

	book.AuthorsLink.Add(new BookAuthor 
	{
		Book = book,
		Author = existingAuthor
	});

	_db.SaveChanges();
}

108-
public void OnGet()
{
	var book = _db.Books
		.Include(b => b.Tags)
		.Single(b => b.Title == "Neuanfang");

	var existingTag = _db.Tags
		.Single(t => t.TagId == "Roman");

	book.Tags.Add(existingTag);
	_db.SaveChanges();
}

109-
public void OnGet()
{
	int reviewToChangeId = 7;
	int newBookId = 5;
	var reviewToChange = _db.Find<Review>(reviewToChangeId);
	reviewToChange.BookId = newBookId;
	_db.SaveChanges();
}

110-
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
	...

	modelBuilder.Entity<Book>()
		.HasQueryFilter(p => !p.SoftDeleted);
}