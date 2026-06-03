using System;

public interface IPrinter
{
    void Print();
}

public interface IScanner
{
    void Scan();
}

public class Printer : IPrinter
{
    public void Print()
    {
        Console.WriteLine("Printing document...");
    }
}

public class Scanner : IScanner
{
    public void Scan()
    {
        Console.WriteLine("Scanning document...");
    }
}

// Combines both functionalities
public class PrintScanner : IPrinter, IScanner
{
    public void Print()
    {
        Console.WriteLine("Printing document...");
    }

    public void Scan()
    {
        Console.WriteLine("Scanning document...");
    }
}

public class TaskManager
{
    public void PrintTask(int taskId, IPrinter printer)
    {
        Console.WriteLine($"Executing Print Task: {taskId}");
        printer.Print();
    }

    public void ScanTask(int taskId, IScanner scanner)
    {
        Console.WriteLine($"Executing Scan Task: {taskId}");
        scanner.Scan();
    }
}

public class Program
{
    public static void Main()
    {
        var printer = new Printer();
        var scanner = new Scanner();
        var printScanner = new PrintScanner();

        var scheduler = new TaskManager();

        scheduler.PrintTask(101, printer);
        scheduler.ScanTask(102, scanner);
        scheduler.PrintTask(103, printScanner);  
        scheduler.ScanTask(104, printScanner);   
    }
}