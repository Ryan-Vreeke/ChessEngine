using System;
using System.Collections.Generic;
using System.Text;

namespace ChessEngine
{
    class Util
    {

        static public void SetBit(ref UInt64 bitboard, UInt16 square)
        {

            bitboard |= (1UL << square);
        }


        static public UInt64 GetBit(ref UInt64 bitboard, UInt16 square)
        {
            return bitboard & 1UL << square;
        }

        static public void PopBit(ref UInt64 bitboard, UInt16 square)
        {
            bitboard &= ~(1UL << square);
        }


    }
}
