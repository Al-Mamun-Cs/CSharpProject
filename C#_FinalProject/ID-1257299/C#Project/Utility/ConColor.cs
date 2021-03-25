using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConPJ1.Utility
{
    public enum MessageType { Success, Warning, Error, LightText }
    public class ConColor
    {
        public void WriteMessage(string message, MessageType mtype)
        {
            switch (mtype)
            {
                case MessageType.Success:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.BackgroundColor = ConsoleColor.White;
                    break;
                case MessageType.Warning:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case MessageType.Error:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    break;
                case MessageType.LightText:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
                default:
                    break;

            }
            Console.Write(message);
            Console.ResetColor();
        }
    }
}
