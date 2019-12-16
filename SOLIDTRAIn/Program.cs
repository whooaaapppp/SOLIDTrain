using System;

public class Program
{
    private static Computer _computer;
    public static void Main()
    {
        _computer = new Computer();
        _computer.Test();
    }
}


public interface MotherBoard
{
    void MotherBoarding(string[] item);
}

public interface Cpu
{
    void Calculate(string[] item);
}

public interface Ram
{
    void Ram(string[] item);
}

public interface HardDrive
{
    void HardDrive(string[] item);
}

public interface PowerSupply
{
    void PowerSupply(string[] item);
}



public class Computer
{
    private MotherBoard _mb;
    private Cpu _cpu;
    private Ram _ram;
    private HardDrive _hd;
    private PowerSupply _ps;
    public Computer()
    {
        _mb = new MotherBoard();
        _cpu = new Cpu();
        _ram = new Ram();
        _hd = new HardDrive();
        _ps = new PowerSupply();
    }

    public void Test()
    {
        Console.WriteLine(_mb.Motherboarding());
        Console.WriteLine(_cpu.Calculate());
        Console.WriteLine(_ram.StoringData());
        Console.WriteLine(_hd.WritingData());
        Console.WriteLine(_ps.ProducePower());
    }
}

internal class PowerSupply
{
    public string ProducePower()
    {
        return "Producing Power";
    }
}

internal class HardDrive
{
    public string WritingData()
    {
        return "Writing Data";
    }
}

internal class Ram
{
    public string StoringData()
    {
        return "Storing Data";
    }
}

internal class Cpu
{
    public string Calculate()
    {
        return "Calculating";
    }
}

internal class MotherBoard
{
    public string Motherboarding()
    {
        return "Connecting everything";
    }
}
