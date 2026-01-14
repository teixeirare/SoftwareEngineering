public class Member
{

    public string Name { get; set; } //Create 3 Member objects with different membership levels,Auto-property for Name:
    private int age;// 2. Full property for Age with simple logic
    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 0)
                age = value;
            else age = 0;
        }
    }
    public static int TotalMembers { get; set; } = 0;// 3. Static auto-property for TotalMembers:
    public string MembershipLevel { get; private set; } //5.MembershipLevel auto-property with private setter
    public Member(string name, int age, string membershipLevel)
    {
        this.Name = name;
        this.MembershipLevel = membershipLevel;
        this.Age = age;

        this.booksBorrowed = 0;
        TotalMembers++;
    }
    private static int totalBooksBorrowed;// 4. Static full property with logic for TotalBooksBorrowed:
    public static int TotalBooksBorrowed
    {
        get { return totalBooksBorrowed; }
        set
        {
            if (value >= 0)
                totalBooksBorrowed = value;
            else
                totalBooksBorrowed = 0;
        }
    }

    private int booksBorrowed;// 6. Private instance attribute booksBorrowed
    public int GetBooksBorrowed()
    { return booksBorrowed; }

    private static int standardLimit = 3;// 7. Private static attributes for max borrow limits
    private static int premiumLimit = 5;
    private static int vipLimit = 10;
    private int GetMaxBorrowLimit()
    {
        if (MembershipLevel == "Standard")
            return standardLimit;
        else if (MembershipLevel == "Premium")
            return premiumLimit;
        else if (MembershipLevel == "VIP")
            return vipLimit;
        else
            return 0;
    }

    public void BorrowBook()
    {
        int MaxBorrowed = GetMaxBorrowLimit();
        if (booksBorrowed < MaxBorrowed)
        {
            booksBorrowed++;
            TotalBooksBorrowed++;
        }
        else
        {
            Console.WriteLine($"{Name} has reached their borrowing limit. ");
        }
    }
    public void ReturnBook()
    {
        if (booksBorrowed > 0)
        {
            booksBorrowed--;
            TotalBooksBorrowed--;
        }
        else if (totalBooksBorrowed == 0)
        {
            Console.WriteLine($"{Name} has returned all their books.");
        }
    }

}
public class Program
{
    public static void Main(string[] args)
    {
        Member Alice = new Member("Alice", 25, "Standard");
        Member Bob = new Member("Bob", 30, "Premium");
        Member Charlie = new Member("Charlie", 40, "VIP");

        for (int i = 0; i < 3; i++)
            Alice.BorrowBook();

        for (int i = 0; i < 5; i++)
            Bob.BorrowBook();

        for (int i = 0; i < 10; i++)
            Charlie.BorrowBook();

        Console.WriteLine($"Alice,Age:{Alice.Age},Level:{Alice.MembershipLevel},book borrowed:{Alice.GetBooksBorrowed()}");
        Console.WriteLine($"Bob,Age:{Bob.Age},Level:{Bob.MembershipLevel},book borrowed:{Bob.GetBooksBorrowed()}");
        Console.WriteLine($"Charlie,Age:{Charlie.Age},Level:{Charlie.MembershipLevel},book borrowed:{Charlie.GetBooksBorrowed()}");

        Console.WriteLine($"Total Members:{Member.TotalMembers}");
        Console.WriteLine($"Total book borrowed:{Member.TotalBooksBorrowed}");

        for (int i = 0; i < 3; i++)
            Alice.ReturnBook();

        for (int i = 0; i < 5; i++)
            Bob.ReturnBook();

        for (int i = 0; i < 10; i++)
            Charlie.ReturnBook();

        Console.WriteLine($"Alice,Age:{Alice.Age},Level:{Alice.MembershipLevel},book borrowed:{Alice.GetBooksBorrowed()}");
        Console.WriteLine($"Bob,Age:{Bob.Age},Level:{Bob.MembershipLevel},book borrowed:{Bob.GetBooksBorrowed()}");
        Console.WriteLine($"Charlie,Age:{Charlie.Age},Level:{Charlie.MembershipLevel},book borrowed:{Charlie.GetBooksBorrowed()}");

        Console.WriteLine($"Total Members:{Member.TotalMembers}");
        Console.WriteLine($"Total book borrowed:{Member.TotalBooksBorrowed}");


    }
}






