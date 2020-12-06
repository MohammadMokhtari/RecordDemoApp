using System;

Record1 r1 = new("Mohammad", "Mokhtari");
Record1 r2 = new("Mohammad", "Mokhtari");
Record1 r3 = new("Goli", "Abediani");

Class1 c1 = new("Mohammad", "Mokhtari");
Class1 c2 = new("Mohammad", "Mokhtari");
Class1 c3 = new("Goli", "Abediani");

Console.WriteLine("Record :");
Console.WriteLine($"Equals {Equals(r1, r2)}");
Console.WriteLine($"Equlas {r1 == r2}");
Console.WriteLine($"Equlas {r1.Equals(r2)}");
Console.WriteLine($"GetHashCode{c1.GetHashCode()}");
Console.WriteLine($"GetHashCode{c2.GetHashCode()}");
Console.WriteLine($"GetHashCode{c3.GetHashCode()}");
Console.WriteLine(r3);
Console.WriteLine(r3.SeyHello());

Console.WriteLine();
Console.WriteLine("**************************");
Console.WriteLine();

Console.WriteLine("Class");
Console.WriteLine($"Equals {Equals(c1, c2)}");
Console.WriteLine($"Equlas {c1 == c2}");
Console.WriteLine($"Equlas {c1.Equals(c2)}");
Console.WriteLine($"GetHashCode {c1.GetHashCode()}");
Console.WriteLine($"GetHashCode {c2.GetHashCode()}");
Console.WriteLine($"GetHashCode {c3.GetHashCode()}");
Console.WriteLine(c3);

Console.WriteLine("---------------------------------------------");
Console.WriteLine();

var (fn, ln) = r3;
Console.WriteLine(fn);

(string cfn, string cln) = c2;
Console.WriteLine(cfn);




public record Record2(int Id, string FirstName, string LastName);


public record Record1(string FirstName, string LastName)
{
    public string FirstName { get; init; } = FirstName;

    private string _lastname = LastName;

    public string LastName
    {
        get { return _lastname.Substring(0, 2); }
        init { _lastname = value; }
    }
    public string FullName => $"{FirstName} {LastName}";


    public string SeyHello()
    {
        return $"Hello {FirstName}";
    }
}


public class Class1 : BaseClass
{
    public Class1(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string FirstName { get; init; }

    public string LastName { get; init; }

    public void Deconstruct(out string fName, out string lName)
    {
        fName = FirstName;
        lName = LastName;
    }
}

public class BaseClass
{
    public int Id { get; init; }
    public readonly string Hashcode;
}


