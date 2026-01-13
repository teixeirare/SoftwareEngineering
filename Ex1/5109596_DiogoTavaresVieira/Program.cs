public class Program
{
    public static void Main(string[] args)
    {
        // TODO: Create 3 Member objects with different membership levels
        // Instructions:
        // - Instantiate one "Standard", one "Premium", one "VIP" member
        // - make up your own names and ages for the members you create
        // - Demonstrates object creation and constructor usage


        // TODO: Call BorrowBook() multiple times for each member
        // Instructions:
        // - Test borrowing to the maximum allowed for each membership level
        // - Ensure the message prints when the limit is reached
        // - Demonstrates instance vs static data and conditional logic


        // TODO: Print out each member's name, age, membership level, and books borrowed
        // Instructions:
        // - Use properties and the method for borrowed books
        // - Demonstrates reading instance and property data


        // TODO: Print TotalMembers and TotalBooksBorrowed
        // Instructions:
        // - Use static properties
        // - Demonstrates reading class-level data


        // TODO: Call ReturnBook() multiple times for all members
        // Instructions:
        // - Return all books for all members
        // - Ensure the message prints when all books are returned
        // - Demonstrates safe decrement of instance and static fields


        // TODO: Print out each member's name, age, membership level, and books borrowed
        // Instructions:
        // - Use properties and the method for borrowed books
        // - Demonstrates reading instance and property data


        // TODO: Print TotalMembers and TotalBooksBorrowed
        // Instructions:
        // - Use static properties
        // - Demonstrates reading class-level data

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


        Member m1 = new Member("Alice", 25, "Standard");
        Member m2 = new Member("Bob", 33, "Premium");
        Member m3 = new Member("Charlie", 40, "VIP");

        // Borrow books to the maximum allowed
        for (int i = 0; i < 4; i++) m1.BorrowBook();   // Standard limit = 3
        for (int i = 0; i < 6; i++) m2.BorrowBook();   // Premium limit = 5
        for (int i = 0; i < 11; i++) m3.BorrowBook();

        // Print member info after borrowing
        Console.WriteLine($"{m1.Name}, Age: {m1.Age}, Level: {m1.MembershipLevel}, Books Borrowed: {m1.GetBooksBorrowed()}");
        Console.WriteLine($"{m2.Name}, Age: {m2.Age}, Level: {m2.MembershipLevel}, Books Borrowed: {m2.GetBooksBorrowed()}");
        Console.WriteLine($"{m3.Name}, Age: {m3.Age}, Level: {m3.MembershipLevel}, Books Borrowed: {m3.GetBooksBorrowed()}");

        // Print static totals
        Console.WriteLine($"Total Members: {Member.TotalMembers}");
        Console.WriteLine($"Total Books Borrowed: {Member.TotalBooksBorrowed}");

        // Return all books
        for (int i = 0; i < 4; i++) m1.ReturnBook();
        for (int i = 0; i < 6; i++) m2.ReturnBook();
        for (int i = 0; i < 11; i++) m3.ReturnBook();

        // Print member info after returning
        Console.WriteLine($"{m1.Name}, Age: {m1.Age}, Level: {m1.MembershipLevel}, Books Borrowed: {m1.GetBooksBorrowed()}");
        Console.WriteLine($"{m2.Name}, Age: {m2.Age}, Level: {m2.MembershipLevel}, Books Borrowed: {m2.GetBooksBorrowed()}");
        Console.WriteLine($"{m3.Name}, Age: {m3.Age}, Level: {m3.MembershipLevel}, Books Borrowed: {m3.GetBooksBorrowed()}");

        // Print static totals again
        Console.WriteLine($"Total Members: {Member.TotalMembers}");
        Console.WriteLine($"Total Books Borrowed: {Member.TotalBooksBorrowed}");
    }
}
