namespace Exercise_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = new string('-' , 20+50+65+10);
            Console.WriteLine($"{"Type" , -10}{"Byte(s) of memory" , -20}{"Min" , 50}{"Max" , 65}");
            Console.WriteLine(line);
            Console.WriteLine($"{"sbyte" , -10}{sizeof(sbyte) , -20}{sbyte.MinValue,50}{sbyte.MaxValue,65}");
            Console.WriteLine($"{"byte" , -10}{sizeof(byte) ,-20}{byte.MinValue,50}{byte.MaxValue,65}");
            Console.WriteLine($"{"short",-10}{sizeof(short),-20}{short.MinValue,50}{short.MaxValue,65}");
            Console.WriteLine($"{"ushort",-10}{sizeof(ushort),-20}{ushort.MinValue,50}{ushort.MaxValue,65}");
            Console.WriteLine($"{"int",-10}{sizeof(int),-20}{int.MinValue,50}{int.MaxValue,65}");
            Console.WriteLine($"{"uint",-10}{sizeof(uint),-20}{uint.MinValue,50}{uint.MaxValue,65}");
            Console.WriteLine($"{"long",-10}{sizeof(long),-20}{long.MinValue,50}{long.MaxValue,65}");
            Console.WriteLine($"{"ulong",-10}{sizeof(ulong),-20}{ulong.MinValue,50}{ulong.MaxValue,65}");
            unsafe 
            {
                Console.WriteLine($"{"Int128",-10}{sizeof(Int128),-20}{Int128.MinValue,50}{Int128.MaxValue,65}");
                Console.WriteLine($"{"UInt128",-10}{sizeof(UInt128),-20}{UInt128.MinValue,50}{UInt128.MaxValue,65}");
                Console.WriteLine($"{"Half",-10}{sizeof(Half),-20}{Half.MinValue,50}{Half.MaxValue,65}");
            }
            Console.WriteLine($"{"float",-10}{sizeof(float),-20}{float.MinValue,50}{float.MaxValue,65}");
            Console.WriteLine($"{"double",-10}{sizeof(double),-20}{double.MinValue,50}{double.MaxValue,65}");
            Console.WriteLine($"{"decimal",-10}{sizeof(decimal),-20}{decimal.MinValue,50}{decimal.MaxValue,65}");
        }
    }
}
