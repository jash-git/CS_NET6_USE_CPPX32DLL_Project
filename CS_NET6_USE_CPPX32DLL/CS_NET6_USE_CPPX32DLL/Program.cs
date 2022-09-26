using System.Runtime.InteropServices;

public class Program
{
    ///*
    [DllImport("./CB_BaseLib.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Add")]
    static extern double Add(double a, double b);
    //*/
    /*
    //這個DLL有相依其他DLL(MSVCR100D.dll)
    [DllImport("./c_MathFuncsDll.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Add")]
    static extern double Add(double a, double b);
    [DllImport("./c_MathFuncsDll.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Subtract")]
    static extern double Subtract(double a, double b);
    [DllImport("./c_MathFuncsDll.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Multiply")]
    static extern double Multiply(double a, double b);
    [DllImport("./c_MathFuncsDll.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Divide")]
    static extern double Divide(double a, double b);
    //*/
    static void Pause()
    {
        Console.Write("Press any key to continue . . . ");
        Console.ReadKey(true);
    }
    static void Main()
    {
        double d1 = 5.0d;
        double d2 = 20.0d;
        double d3 = 0.0;
        d3 = Add(d1, d2);
        Console.WriteLine("HELLO WORD");
        Console.WriteLine("d1=" + d1);
        Console.WriteLine("d2=" + d2);
        Console.WriteLine("d3=" + d3);
        Pause();
    }
}
