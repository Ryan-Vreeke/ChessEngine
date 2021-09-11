using System;

namespace ChessEngine
{
    class Class
    {
        static void Main(string[] args)
        {
            UInt64 bitBoard = 0;



            Util.SetBit(ref bitBoard, 2);
            Console.WriteLine(bitBoard);
            
           
            Console.WriteLine(Util.GetBit(ref bitBoard, 2));

        }
    }
}
