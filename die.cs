using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoDiceGame
{
    public class Die
    {
        private int _sides;
        private int _roll;
        private Random _generator;
        private ConsoleColor _color;

        public Die()
        { 
            _generator = new Random();
            _sides = 6;
            _roll = _generator.Next(1, _sides + 1);
            _color = ConsoleColor.White;
        
        
        }
        //public Die (int sides)
        //{
        //    _generator = new Random(sides);
        //    _sides = sides;
        //    _roll = _generator.Next(1, sides+1);
        //}
        //accesor props
        public int Roll 
        { 
            get { return _roll; } 
            //set { _roll = value; }
        }

        public override string ToString()
        {
            return _roll.ToString();
        }

        public void RollDie()
        {
            _roll = _generator.Next(1 , _sides + 1);
        }
        
        public ConsoleColor _Color
        { 
            get { return _color; } 
            set { _color = value; }
        }
        public void ColoredDie()
        {
            
            if (Roll == 1)
            {
                _color = ConsoleColor.Red;
            }
            else if (Roll == 2)
            {
                _color= ConsoleColor.Green;
            }
            else if (Roll == 3)
            {
                _color = ConsoleColor.Blue;      
            }
            else if (_roll == 4)
            {
                _color = ConsoleColor.Yellow;
            }
            else if (_roll == 5)
            {
                _color = ConsoleColor.Magenta;
            }
            else if (_roll == 6)
            {
                _color = ConsoleColor.Cyan;
            }
            else
            {
                _color = ConsoleColor.White;
            }
            Console.ForegroundColor = _color;
        }
        public void DrawRoll()
        {
            ConsoleColor currentForecolor = Console.ForegroundColor;
            currentForecolor = ConsoleColor.White;

            if (Roll == 1)
            {
                //Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("-----");
                Console.WriteLine("|   |");
                Console.WriteLine("| 0 |");
                Console.WriteLine("|   |");
                Console.WriteLine("-----");
                //Console.ForegroundColor = ConsoleColor.White;
            }
            else if(Roll == 2)
            {
                //Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("-----");
                Console.WriteLine("|0  |");
                Console.WriteLine("|   |");
                Console.WriteLine("|  0|");
                Console.WriteLine("-----");
                //Console.ForegroundColor = ConsoleColor.White;
            }
            else if (Roll == 3)
            {
                //Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("-----");
                Console.WriteLine("|0  |");
                Console.WriteLine("| 0 |");
                Console.WriteLine("|  0|");
                Console.WriteLine("-----");
                //Console.ForegroundColor = ConsoleColor.White;
            }
            else if (Roll == 4)
            {
                //Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("-----");
                Console.WriteLine("|0 0|");
                Console.WriteLine("|   |");
                Console.WriteLine("|0 0|");
                Console.WriteLine("-----");
                //Console.ForegroundColor = ConsoleColor.White;
            }
            else if (Roll == 5)
            {
                //Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("-----");
                Console.WriteLine("|0 0|");
                Console.WriteLine("| 0 |");
                Console.WriteLine("|0 0|");
                Console.WriteLine("-----");
                //Console.ForegroundColor = ConsoleColor.White;
            }
            else if (Roll == 6)
            {
               // Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("-----");
                Console.WriteLine("|0 0|");
                Console.WriteLine("|0 0|");
                Console.WriteLine("|0 0|");
                Console.WriteLine("-----");
                //Console.ForegroundColor = ConsoleColor.White;
            }
            Console.ForegroundColor = currentForecolor;
        }

    }
}
