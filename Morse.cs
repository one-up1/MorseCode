using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCode
{
    public class Morse
    {
        private static readonly Dictionary<char, string> codes = new Dictionary<char, string>();
        private static readonly Dictionary<string, char> chars = new Dictionary<string, char>();

        static Morse()
        {
            codes.Add('A', "· —");
            codes.Add('B', "— · · ·");
            codes.Add('C', "— · — ·");
            codes.Add('D', "— · ·");
            codes.Add('E', "·");
            codes.Add('F', "· · — ·");
            codes.Add('G', "— — ·");
            codes.Add('H', "· · · ·");
            codes.Add('I', "· ·");
            codes.Add('J', "· — — —");
            codes.Add('K', "— · —");
            codes.Add('L', "· — · ·");
            codes.Add('M', "— —");
            codes.Add('N', "— ·");
            codes.Add('O', "— — —");
            codes.Add('P', "· — — ·");
            codes.Add('Q', "— — · —");
            codes.Add('R', "· — ·");
            codes.Add('S', "· · ·");
            codes.Add('T', "—");
            codes.Add('U', "· · —");
            codes.Add('V', "· · · —");
            codes.Add('W', "· — —");
            codes.Add('X', "— · · —");
            codes.Add('Y', "— · — —");
            codes.Add('Z', "— — · ·");
            codes.Add('0', "— — — — —");
            codes.Add('1', "· — — — —");
            codes.Add('2', "· · — — —");
            codes.Add('3', "· · · — —");
            codes.Add('4', "· · · · —");
            codes.Add('5', "· · · · ·");
            codes.Add('6', "— · · · ·");
            codes.Add('7', "— — · · ·");
            codes.Add('8', "— — — · ·");
            codes.Add('9', "— — — — ·");
            codes.Add('.', "· — · — · —");
            codes.Add(',', "— — · · — —");
            codes.Add('?', "· · — — · ·");
            codes.Add('!', "— · — · — —");
            codes.Add('-', "— · · · · —");
            codes.Add('/', "— · · — ·");
            codes.Add(':', "— — — · · ·");
            codes.Add('\'', "· — — — — ·");
            codes.Add(')', "— · — — · —");
            codes.Add(';', "— · — · —");
            codes.Add('(', "— · — — ·");
            codes.Add('=', "— · · · —");
            codes.Add('@', "· — — · — ·");
            codes.Add('&', "· – · · ·");

            chars.Add("· —", 'A');
            chars.Add("— · · ·", 'B');
            chars.Add("— · — ·", 'C');
            chars.Add("— · ·", 'D');
            chars.Add("·", 'E');
            chars.Add("· · — ·", 'F');
            chars.Add("— — ·", 'G');
            chars.Add("· · · ·", 'H');
            chars.Add("· ·", 'I');
            chars.Add("· — — —", 'J');
            chars.Add("— · —", 'K');
            chars.Add("· — · ·", 'L');
            chars.Add("— —", 'M');
            chars.Add("— ·", 'N');
            chars.Add("— — —", 'O');
            chars.Add("· — — ·", 'P');
            chars.Add("— — · —", 'Q');
            chars.Add("· — ·", 'R');
            chars.Add("· · ·", 'S');
            chars.Add("—", 'T');
            chars.Add("· · —", 'U');
            chars.Add("· · · —", 'V');
            chars.Add("· — —", 'W');
            chars.Add("— · · —", 'X');
            chars.Add("— · — —", 'Y');
            chars.Add("— — · ·", 'Z');
            chars.Add("— — — — —", '0');
            chars.Add("· — — — —", '1');
            chars.Add("· · — — —", '2');
            chars.Add("· · · — —", '3');
            chars.Add("· · · · —", '4');
            chars.Add("· · · · ·", '5');
            chars.Add("— · · · ·", '6');
            chars.Add("— — · · ·", '7');
            chars.Add("— — — · ·", '8');
            chars.Add("— — — — ·", '9');
            chars.Add("· — · — · —", '.');
            chars.Add("— — · · — —", ',');
            chars.Add("· · — — · ·", '?');
            chars.Add("— · — · — —", '!');
            chars.Add("— · · · · —", '-');
            chars.Add("— · · — ·", '/');
            chars.Add("— — — · · ·", ':');
            chars.Add("· — — — — ·", '\'');
            chars.Add("— · — — · —", ')');
            chars.Add("— · — · —", ';');
            chars.Add("— · — — ·", '(');
            chars.Add("— · · · —", '=');
            chars.Add("· — — · — ·", '@');
            chars.Add("· – · · ·", '&');
        }

        public static void t()
        {foreach (char c in codes.Keys)
            {
                Console.WriteLine("chars.Add(\"" + codes[c] + "\", '" + c + "');");
            }
        }
    }
}
