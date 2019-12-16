using System;

public class Program
{
    private static Computer _computer;
    public static void Main()
    {
        _computer = new Computer();
        _computer.HardDrive();
        _computer.Ram();
        _computer.MotherBoarding();
        _computer.PowerSupply();
        _computer.Calculate();
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

