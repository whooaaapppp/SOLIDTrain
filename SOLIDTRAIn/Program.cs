using System;
using System.Linq;
using System.Reflection;

public class Program
{
    private static Computer _computer;
    public static void Main()
    {
        _computer = new Computer();

        //invoking all functions via reflections
        //runAllFunctions(_computer);
        _computer.HardDrive();
        _computer.Ram();
        _computer.MotherBoarding();
        _computer.PowerSupply();
        _computer.Calculate();
    }

    //reflections are slow... https://docs.microsoft.com/en-us/archive/msdn-magazine/2005/july/using-net-avoid-common-performance-pitfalls-for-speedier-apps
    public static void runAllFunctions(Computer computer)
    {
        // https://docs.microsoft.com/en-us/dotnet/api/system.reflection.methodbase.invoke?view=netcore-3.1 
        _computer = computer;
        var methods = _computer.GetType().GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
        foreach (var method in methods)
        {
            method.Invoke(_computer, new object[] { });
        }
    }
}


public interface IMotherBoard
{
    void MotherBoarding();
}

public interface ICpu
{
    void Calculate();
}

public interface IRam
{
    void Ram();
}

public interface IHardDrive
{
    void HardDrive();
}

public interface IPowerSupply
{
    void PowerSupply();
}


public interface IComputer : IHardDrive, IPowerSupply, IRam, IMotherBoard, ICpu
{
    //premade interface wrapping other interfaces
}

public class Computer : IHardDrive, IPowerSupply, IRam, IMotherBoard, ICpu
{
    
    public Computer()
    {
        //to do
    }

    public void Calculate()
    {
        //execute the interface contract
        Console.WriteLine("Calculating");
    }

    public void HardDrive()
    {
        //execute the interface contract
        Console.WriteLine("Writing Data");
    }

    public void MotherBoarding()
    {
        //execute the interface contract
        Console.WriteLine("Connecting everything");
    }

    public void PowerSupply()
    {
        //execute the interface contract
        Console.WriteLine("Producing Power");
    }

    public void Ram()
    {
        //execute the interface contract
        Console.WriteLine("Storing Data");
    }

    
}

