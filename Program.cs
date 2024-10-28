using System.Text;
using ConsoleApp2;
using ConsoleApp2.Math;

public class Person
{
    public string FirstName;
    public string LastName;
    public void Introduce()
    {
        Console.WriteLine("My Name is "+FirstName+ " "+LastName);
    }
}

public enum ShippingMethod{
    Regular=1,
    Registered=2,
    Express=3
}

public class Person1
{
    public int Age;
}

//............................................................Main class
class MainProgram
{
    static void Main(string[] args)
    {
        var john = new Person();
        john.FirstName = "john";
        john.LastName = "smith";
        john.Introduce();
        Calculator calculator = new Calculator();
        var result = calculator.Add(1, 2);
        Console.WriteLine(result);
        //  ...............................................String
        var names = new String[3];
        names[0] = john.FirstName;
        names[1] = john.LastName;
        names[2] = "jiyjo";
        Console.WriteLine(names[1]);


        var num3 = new String[3];
        num3[0] = "10";
        num3[1] = "20";
        num3[2] = "30";
        Console.WriteLine(num3[1]);


        var boolArray = new bool[3];
        boolArray[0] = true;
        Console.WriteLine(boolArray[0]);


        var myFullName = string.Format("MY name is {0} {1}", john.FirstName, john.LastName);
        var names3 = new String[3] { "eenee", "meenee", "weene" };
        var formattedNames = string.Join(", ", names3);
        var text = @"hi john 
Look into the following paths
c:\folder1\file1
c:\folder2\file2";
        Console.WriteLine(text);
        //.................................................Enum


        /////////find id with name
        var method = ShippingMethod.Express;
        Console.WriteLine((int)method);

        //////////find name with id

        var methodId = 3;
        Console.WriteLine((ShippingMethod)methodId);

        Console.WriteLine(method.ToString());

        ////////casting string to enum
        var methodName = "Express";
        var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);

        /////////////////////////////////////////////////reference types

        var a = 9;
        var b = a;
        b++;
        Console.WriteLine(String.Format("a :{0} , b :{1}", a, b));

        var array1 = new int[3] { 1, 2, 3 };
        var array2 = array1;
        array2[0] = 11;
        Console.WriteLine(String.Format("array1 : {0}, array2 {1}", array1[0], array2[0]));

        var number = 1;
        Increment(number);
        Console.WriteLine(number);


        var person1 = new Person1() { Age = 20 };
        MakeOld(person1);
        Console.WriteLine(person1.Age);

        //////////////////////////////////////////////// if else 

        int hour = 10;
        if (hour > 0 && hour <= 12)
        {
            Console.WriteLine("good morning");
        }
        else if (hour > 12 && hour <= 18)
        {
            Console.WriteLine("good evening");
        }
        else
        {
            Console.WriteLine("good night");
        }
        /////////////////////////if else using condition
        bool isTrue = false;
        float price = (isTrue) ? 12.40f : 0.00f;
        Console.WriteLine(price);

        ///////////////////////////switch case

        var season1 = Season.Autumn;
        switch (season1)
        {
            case Season.Autumn:
                Console.WriteLine("Season is autumn");
                break;
            case Season.Summer:
                Console.WriteLine("season is summer");
                break;
            ///// other cases
            default:
                Console.WriteLine("season is not given");
                break;
        }

        ////////////////////////////////////////// for loop

        for (var i = 10; i >= 1; i--)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }

        ////////////////////// foreach loop
        String name = john.FirstName;
        for (var i = 0; i < name.Length; i++)
        {
            Console.WriteLine(name[i]);
        }
        foreach (var c in name)
        {
            Console.WriteLine(c);
        }
        var numbers = new int[] { 1, 2, 3, 4, 5, 6 };
        foreach (var i in numbers)
        { Console.WriteLine(i); }

        ////////////////////////////// while loop 

        while (true)
        {
            Console.WriteLine("enter your name : ");
            var input = Console.ReadLine();
            if (!String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine(input);
                continue;
            }
            break;
        }

        ////////////////////////////////////// random class

        var random = new Random();
        var buffer = new char[10];
        for (var i = 0; i < 10; i++)

            buffer[i] = (char)('a' + random.Next(0, 26));
        var password = new string(buffer);
        Console.WriteLine(password);

        /////////////////////////////////////arrays


        var nums = new[] { 9, 3, 6, 0, 4, 7, 2 };
        //length
        Console.WriteLine("Length : " + nums.Length);
        //index
        Console.WriteLine("index of 2 :" + Array.IndexOf(nums, 2));
        ///////clear 
        Array.Clear(nums, 0, 2);
        Console.WriteLine("effect of clear from index 0 to length 2");
        foreach (var i in nums)
        {
            Console.WriteLine(i);
        }
        ///copy
        int[] another = new int[3];
        Array.Copy(nums, another, 3);
        Console.WriteLine("effect of copy from nums to another for 3 elements");
        foreach (var i in another)
        {
            Console.WriteLine(i);
        }
        /////sort
        Console.WriteLine("effect of sort in nums");
        Array.Sort(nums);
        foreach (var i in nums)
        {
            Console.WriteLine(i);
        }
        // reverse
        Console.WriteLine("effect of reverse");
        Array.Reverse(nums);
        foreach (var i in nums)
        {
            Console.WriteLine(i);
        }

        //////////////////////////////////List

        Console.WriteLine("list");

        var list = new List<int>() { 1, 2, 3, 4, 5 };
        list.Add(1);
        list.AddRange(new int[3] { 1, 2, 3 });
        foreach (var i in list)
        { Console.WriteLine(i); }
        Console.WriteLine("\nindex of 3 : " + list.IndexOf(3));
        Console.WriteLine("\n last index of 3 : " + list.LastIndexOf(3));
        Console.WriteLine("\n count : " + list.Count());
        for (var i = 0; i < list.Count; i++)
        {
            if (list[i] == 1)
                list.Remove(list[i]);

        }
        foreach (var number4 in list)
            Console.WriteLine(number4);
        list.Clear();
        Console.WriteLine("\ncount after clearing : " + list.Count);

        /////////////////////////// date time
        var date = new DateTime(1990, 01, 01);
        var now = DateTime.Now;
        var today = DateTime.Today;
        Console.WriteLine("hour : " + now.Hour);
        Console.WriteLine("minute : " + now.Minute);
        var tommorrow = now.AddDays(1);
        Console.WriteLine(now.ToLongDateString());
        Console.WriteLine(now.ToShortDateString());
        Console.WriteLine(now.ToLongTimeString());
        Console.WriteLine(now.ToShortTimeString());
        Console.WriteLine(now.ToString());


        ///////////////////////////////////////// time span
        var timeSpan = new TimeSpan(0, 0, 1);
        var timeSpan1 = TimeSpan.FromHours(1);

        var startTime = DateTime.Now;
        var endTime = DateTime.Now.AddMinutes(3);
        var duration = endTime - startTime;
        Console.WriteLine("Duration : " + duration);
        Console.WriteLine("minute  : " + timeSpan.Minutes);
        Console.WriteLine("totalMinutes : " + timeSpan.TotalMinutes);
        ////////add
        Console.WriteLine("add example : " + timeSpan.Add(TimeSpan.FromMinutes(8)));
        Console.WriteLine("subtract example : " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));
        ////ToString
        Console.WriteLine("ToString example : " + timeSpan.ToString());
        //////parse 
        Console.WriteLine("Parse example : " + TimeSpan.Parse("01:10:08"));

        /////////////////////////////////////////////////////////////////////////////////////////STRING METHODS

        var fullname = "john doe ";
        Console.WriteLine("Trim : '{0}'", fullname.Trim());
        Console.WriteLine("ToUpper : '{0}'", fullname.Trim().ToUpper());

        var index = fullname.IndexOf(' ');
        var firstname = fullname.Substring(0, index);
        var lastname = fullname.Substring(index + 1);
        Console.WriteLine("First name : " + firstname);
        Console.WriteLine("Last name : " + lastname);
        //////////

        var names2 = fullname.Split(' ');
        Console.WriteLine("First name : " + names2[0]);
        Console.WriteLine("Last name : " + names2[1]);
        Console.WriteLine(fullname.Replace("john1", "doe1"));
        Console.WriteLine(fullname.Replace('o', 'O'));
        Console.WriteLine(fullname.Replace(' ', '/'));

        if (String.IsNullOrWhiteSpace(" "))
        {
            Console.WriteLine("invalid");
        }
        var str = "24";
        var age = Convert.ToByte(str);
        Console.WriteLine("age is : " + age);

        float price1 = 29.77f;
        Console.WriteLine(price1.ToString("C1"));//convert to currency using C

        var sentence = "this is a really really really really long and long and long and illogical sentence ";
        var summary = SummerizeText(sentence, 23);
        Console.WriteLine(summary);
    }



    static string SummerizeText(string sentence, int maxLength = 10)
    {
        if (sentence.Length < maxLength)
            return sentence;
        var words = sentence.Split(' ');
        var totalCharacters = 0;
        var summaryWords = new List<string>();
        foreach (var word in words)
        {
            summaryWords.Add(word);
            totalCharacters += word.Length + 1;
            if (totalCharacters > maxLength)
            {
                break;
            }

        }
        return String.Join(" ", summaryWords) + "...";

        ///////////////////////////////////////////////////////string builder

        var builder = new StringBuilder();
        builder.Append('-', 10);
        builder.AppendLine();
        builder.Append("Header");
        builder.AppendLine();
        builder.Append('>', 10);
        Console.WriteLine(builder);
        builder.Replace('-', '+')
                .Remove(0, 10)
                .Insert(0, new string('-', 10));
        Console.WriteLine(builder);
        Console.WriteLine("first char : " + builder[0]);

    }

    public static void Increment(int number)
    {
        number += 10;
    }
    public static void MakeOld(Person1 person1)
    {
        person1.Age += 10;

    }

}