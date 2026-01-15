public class Program
{
    public static void Main(string[] args)
    {
        // TODO: Create 3 Member objects with different membership levels
        // Instructions:
        // - Instantiate one "Standard", one "Premium", one "VIP" member
        // - make up your own names and ages for the members you create
        // - Demonstrates object creation and constructor usage
        Member member1 = new Member("Jean", 30, "Standard");
        Member member2 = new Member("Romain", 15, "Premium");
        Member member3 = new Member("Dominic", 26, "VIP");

        
        Console.WriteLine();
        // TODO: Call BorrowBook() multiple times for each member
        // Instructions:
        // - Test borrowing to the maximum allowed for each membership level
        // - Ensure the message prints when the limit is reached
        // - Demonstrates instance vs static data and conditional logic
        for(int i = 0; i < 4; i++)
        {
            member1.BorrowBook();
        }

        for (int i = 0; i < 6; i++)
        {
            member2.BorrowBook();
        }

        for (int i = 0; i < 11; i++)
        {
            member3.BorrowBook();
        }
        Console.WriteLine();

        // TODO: Print out each member's name, age, membership level, and books borrowed
        // Instructions:
        // - Use properties and the method for borrowed books
        // - Demonstrates reading instance and property data
        Console.WriteLine($"{member1.Name}, {member1.Age} years old, {member1.MembershipLevel}, {member1.GetBooksBorrowed()} books");
        Console.WriteLine($"{member2.Name}, {member2.Age} years old, {member2.MembershipLevel}, {member2.GetBooksBorrowed()} books");
        Console.WriteLine($"{member3.Name}, {member3.Age} years old, {member3.MembershipLevel}, {member3.GetBooksBorrowed()} books");
        Console.WriteLine();

        // TODO: Print TotalMembers and TotalBooksBorrowed
        // Instructions:
        // - Use static properties
        // - Demonstrates reading class-level data
        Console.WriteLine($"Total members:{Member.TotalMembers}\n" +
            $"Total books borrowed: {Member.TotalBooksBorrowed}");
        Console.WriteLine();

        // TODO: Call ReturnBook() multiple times for all members
        // Instructions:
        // - Return all books for all members
        // - Ensure the message prints when all books are returned
        // - Demonstrates safe decrement of instance and static fields
        for (int i = 0; i < 4; i++)
        {
            member1.ReturnBook();
        }

        for (int i = 0; i < 6; i++)
        {
            member2.ReturnBook();
        }

        for (int i = 0; i < 11; i++)
        {
            member3.ReturnBook();
        }
        Console.WriteLine();

        // TODO: Print out each member's name, age, membership level, and books borrowed
        // Instructions:
        // - Use properties and the method for borrowed books
        // - Demonstrates reading instance and property data
        Console.WriteLine($"{member1.Name}, {member1.Age} years old, {member1.MembershipLevel}, {member1.GetBooksBorrowed()} books");
        Console.WriteLine($"{member2.Name}, {member2.Age} years old, {member2.MembershipLevel}, {member2.GetBooksBorrowed()} books");
        Console.WriteLine($"{member3.Name}, {member3.Age} years old, {member3.MembershipLevel}, {member3.GetBooksBorrowed()} books");
        Console.WriteLine();

        // TODO: Print TotalMembers and TotalBooksBorrowed
        // Instructions:
        // - Use static properties
        // - Demonstrates reading class-level data
        Console.WriteLine($"Total members:{Member.TotalMembers}\n" +
            $"Total books borrowed: {Member.TotalBooksBorrowed}");
        Console.WriteLine();
        /*
            Instructions for Expected Output:

            If you create the following members:
            - Alice, Age: 25, Membership Level: Standard
            - Bob, Age: 30, Membership Level: Premium
            - Charlie, Age: 40, Membership Level: VIP

            Then the program should produce the following output when borrowing and returning books:

            Alice has reached their borrowing limit.
            Bob has reached their borrowing limit.
            Charlie has reached their borrowing limit.
            Alice, Age: 25, Level: Standard, Books Borrowed: 3
            Bob, Age: 30, Level: Premium, Books Borrowed: 5
            Charlie, Age: 40, Level: VIP, Books Borrowed: 10
            Total Members: 3
            Total Books Borrowed: 18
            Alice has returned all their books.
            Bob has returned all their books.
            Charlie has returned all their books.
            Alice, Age: 25, Level: Standard, Books Borrowed: 0
            Bob, Age: 30, Level: Premium, Books Borrowed: 0
            Charlie, Age: 40, Level: VIP, Books Borrowed: 0
            Total Members: 3
            Total Books Borrowed: 0
        */
    }
}
