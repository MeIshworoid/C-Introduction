internal class Program
{
    private static void Main()
    {
        //private int _age = 0;
        Console.WriteLine("Hello, World!");

        Console.WriteLine("What is your name?");

        //string userName = Console.ReadLine();
        string password = "123";

        //Console.WriteLine("Hello" + userName); // output: Hellousername??
        //Console.WriteLine("Hello {0} {1}",userName,password);
        //Console.WriteLine($"Hello {userName} {password}");




        // output: Hellousername??

        // static --> same memory address shared on life cycle of application

        //Person person = new Person();

        //int phoneNumber = 0; // variable--> camalCase

        //Console.WriteLine(PhoneNumber);
        //PersonNumber // method, Classes, Properties --> PascalCase 

        int i = 0;
        int b = 1;
        Console.WriteLine(int.MinValue);
        Console.WriteLine(int.MaxValue);

        //@ verbatim literal
        string path = @"E:\\live Wallpaper";
        string name = string.Empty;

        Console.WriteLine(path);
        Console.WriteLine("E:\\\"live Wallpaper");

        //opertor
        // 1. Arthimetic: +,-,*,%
        // 2. Logical: >,<,<=,>=,!=,==
        // 3. Assignment: =;
        // 4. Ternery: (condition)?true:false
        // 5. bitwise &&,||
        var temp = 5;
        //temp++;
        var c = temp++; //
        //temp = temp + 1;
        var temp1 = 5;
        var d = ++temp1;
        Console.WriteLine(c);
        Console.WriteLine(d);
        Console.WriteLine(temp);
        Console.WriteLine(temp1);

        bool value = false;

        if (!value)
        {
            string r = "2";
            Console.WriteLine("Hello");
        }

        //implicit --> auto rw explicit --> user
        Console.WriteLine("Enter your age:");
        int age = int.Parse(Console.ReadLine());
        //int result = 0;
        bool isConvertible = int.TryParse(Console.ReadLine(), out int result);
        //int age1 = Convert.;
        // casting ()
        //int value1 = 1;
        //byte g = (byte)value1;

        //Non Primitive Data type
        //string[] same = new string[]
        //{
        //    "Ram" ,"Hari"
        //}; //
        //string[] same2 = new string[3];
        //same2[0] = "Ram";
        //same2[1] = "Hari";
        //same2[2] = "";

        //int[,] array = new int[2, 2]
        //{
        //    { 1,2 }, { 2,3 }
        //};

        //Console.WriteLine(same2[0])
        //Console.WriteLine(array[])

        //Enum --> special datatype


        MessageCategory con = MessageCategory.SuccessMessage;
        if (MessageCategory.SuccessMessage == con)
        {
            Console.WriteLine("This is success message.");
        }
        else if (MessageCategory.ErrorMessage == con)
        {
            Console.WriteLine("This is errormessage");
        }

        //NUllable data types
        //C# data types value type rw reference type

        int? number = null;
        bool? areYouteneger = null;
        //firename:
        //lastname:
        //are you tenegar:null
        

        //Console.WriteLine("Are you teneger?");
        //bool areYouteneger1 = Convert.ToBoolean(Console.ReadLine());

        //areYouteneger = areYouteneger1;
        if (areYouteneger ==true)
        {
            Console.WriteLine("User give some value... ");
        }
        else if(areYouteneger==false)
        {
            Console.WriteLine("User give some value...");
        }
        else
        {
            Console.WriteLine("User didn't give the value...");
        }

        //null coalasing operator ??
        
        int? noofGame = null;
        int gameOnSale;

        //if (noofGame == null)
        //{
        //    gameOnSale = default;
        //}
        //else
        //{
        //    gameOnSale = noofGame;
        //}

        gameOnSale = noofGame ?? default;

        Console.WriteLine(gameOnSale);

    }

    enum MessageCategory
    {
        SuccessMessage,
        ErrorMessage,
        Warning
    } //declaration
}






