public class Member
{
    // ============================
    // 1. Public Auto-property for Name
    // TODO: Implement a public property to store the member's name
    // Instructions:
    // - This property should allow reading and writing the member's name outside of the class
    // - Demonstrates auto-properties in C#
    public string Name { get; set; }

    // ============================
    // 2. Full property for Age with simple logic
    private int age;
    public int Age
    {
        get { return age; }
        set
        {
            // TODO: Implement logic to prevent negative ages
            // Instructions:
            // - If the provided age is less than 0, set the member's age to 0
            // - Otherwise, store the provided value
            // - Demonstrates a full property with a backing field and setter logic
            if ( value < 0)
            {
                age = 0;
            }
            else
            {
                age = value;
            }
        }
    }

    // ============================
    // 3. Static auto-property for TotalMembers
    // TODO: Implement a public static auto-property to track total members
    // Instructions:
    // - Increment this property by 1 in the constructor every time a new Member is created
    // - Demonstrates static auto-properties and class-level data
    public static int TotalMembers { get; set; } = 0;

    // ============================
    // 4. Static full property with logic for TotalBooksBorrowed
    private static int totalBooksBorrowed;
    public static int TotalBooksBorrowed
    {
        get { return totalBooksBorrowed; }
        set
        {
            // TODO: Implement logic to prevent negative total books borrowed
            // Instructions:
            // - If the value is less than 0, set it to 0
            // - Otherwise, store the provided value
            // - Demonstrates static full properties with validation logic
            if(value < 0)
            {
                totalBooksBorrowed = 0;
            }
            else
            {
                totalBooksBorrowed = value;
            }
        }
    }

    // ============================
    // 5. MembershipLevel auto-property with private setter
    // TODO: Implement a public property for MembershipLevel with a private setter
    // Instructions:
    // - This property should be readable publicly but only writable inside the class
    // - Demonstrates controlled access to a property
    public string MembershipLevel { get; private set; }


    // ============================
    // 6. Private instance attribute booksBorrowed
    // TODO: Create a private field to track the number of books a member has borrowed
    // Instructions:
    // - Demonstrates encapsulation of instance data
    private int booksBorrowed;

    // ============================
    // 7. Private static attributes for max borrow limits
    // TODO: Create private static fields to define the maximum number of books that can be borrowed
    // Instructions:
    // - Define one field for Standard members with a limit of 3 books
    // - Define one field for Premium members with a limit of 5 books
    // - Define one field for VIP members with a limit of 10 books
    // - Use private and static so these values are shared across all members and cannot be changed from outside
    // - Demonstrates using class-level variables to enforce business rules
    private static int standardLimit = 3;
    private static int premiumLimit = 5;
    private static int vipLimit = 10;


    // ============================
    // Constructor
    public Member(string name, int age, string level)
    {
        // TODO: Initialize Name, Age, and MembershipLevel
        // Instructions:
        // - Store the provided name in the Name property
        // - Store the provided age in the Age property (it will correct negative ages)
        // - Store the provided membership level in the MembershipLevel property
        // - Initialize the number of books borrowed to 0
        // - Increment TotalMembers by 1
        // - Demonstrates constructor usage and interaction with static and instance data
        Name = name;
        Age = age;
        MembershipLevel = level;
        booksBorrowed = 0;
        TotalMembers++;
    }

    // ============================
    // Private method to get max borrow limit for this member
    // TODO: Implement a private method to return the max number of books allowed
    private int GetMaxBorrowLimit()
    {
        // Instructions:
        // - Check the MembershipLevel property
        // - Return the corresponding maximum from the static max borrow limits defined earlier
        // - If the membership level is unknown, return 0
        // - Demonstrates encapsulation of business logic and use of static fields
        //return 0; // placeholder
        if(MembershipLevel == "Standard")
        {
            return standardLimit;
        }
        else if(MembershipLevel == "Premium")
        {
            return premiumLimit;
        }
        else if(MembershipLevel == "VIP")
        {
            return vipLimit;
        }
        else
        {
            return 0;
        }
    }

    // ============================
    // Borrow book method
    // TODO: Implement BorrowBook()
    public void BorrowBook()
    {
        // Instructions:
        // - Call the method that returns the max books allowed
        // - Compare the current booksBorrowed with the maximum
        // - If the member is below the limit:
        //    - Increment booksBorrowed and TotalBooksBorrowed
        // - If the member has reached the limit:
        //    - Print a message: "<Name> has reached their borrowing limit.", where <Name> is the member's name property
        // - Demonstrates using private methods, instance and static data together, with user feedback
        
        if(booksBorrowed < GetMaxBorrowLimit())
        {
            booksBorrowed++;
            TotalBooksBorrowed++;
        }
        else
        {
            Console.WriteLine($"{Name} has reached their borrowing limit.");
        }
    }

    // ============================
    // Return book method
    // TODO: Implement ReturnBook()
    public void ReturnBook()
    {
        // Instructions:
        // - If the member has borrowed any books:
        //    - Decrement booksBorrowed and TotalBooksBorrowed
        // - If the member has returned all books:
        //    - Print a message: "<Name> has returned all their books.", where <Name> is the member's name property
        // - Demonstrates safe decrement of instance and static attributes with user feedback
        if(booksBorrowed > 0)
        {
            booksBorrowed--;
            TotalBooksBorrowed--;
        }
        else
        {
            Console.WriteLine($"{Name} has returned all their books.");
        }
    }

    // ============================
    // Getter for private booksBorrowed
    // TODO: Implement a public method to return the number of books borrowed
    public int GetBooksBorrowed()
    {
        // Instructions:
        // - Demonstrates encapsulation and controlled access to a private data attribute
        //return 0; // placeholder
        return booksBorrowed;
        
    }
}