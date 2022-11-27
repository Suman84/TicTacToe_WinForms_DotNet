using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTicTacToe
{
    public class Board
    {
        public string[] data { get; set; } = { "", "", "", "", "", "", "", "", "", ""};


        public void setBoard(string[] newData)
        {
            data = newData;
        }
    }
}
