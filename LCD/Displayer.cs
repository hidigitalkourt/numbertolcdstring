using System;
using System.Collections.Generic;
using System.Linq;

namespace LCD
{
    public class Displayer
    {   
        private Dictionary<int,string[]> LCDLookUp = new Dictionary<int, string[]>{
            {0, new string[]{"._.","|.|","|_|"}},
            {1, new string[]{"...","..|","..|"}},
            {2, new string[]{"._.","._|","|_."}},
            {3, new string[]{"._.","._|","._|"}},
            {4, new string[]{"...","|_|","..|"}},
            {5, new string[]{"._.","|_.","._|"}},
            {6, new string[]{"._.","|_.","|_|"}},
            {7, new string[]{"._.","..|","..|"}},
            {8, new string[]{"._.","|_|","|_|"}},
            {9, new string[]{"._.","|_|","..|"}}
        };

      

        public string[] GetLCD(int number)
        {
            return LCDLookUp[number];
 
        }
    }
}
