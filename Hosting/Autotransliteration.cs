using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hosting
{
    class Autotransliteration
    {
        public static string Convert(string input)
        {

            int len = input.Length;
            input = input + " ";
            string output = String.Empty;
            for (int i = 0; i < len; i++)
            {

                if ((input[i] == 'y') & (((input[i + 1] == 'u') | (input[i + 1] == 'U')) | (input[i + 1] == 'a') | (input[i + 1] == 'A')))
                {
                    switch (input[i + 1])
                    {
                        case 'u': output += 'ю'; i += 1; ; break;
                        case 'a': output += 'я'; i += 1; break;
                    }

                }
                else
                {

                    if ((input[i + 1] != 'h') & (input[i + 1] != 'H'))
                    {
                        switch (input[i])
                        {
                            case ' ': output += ' '; break;
                            case 'а': output += 'a'; break;
                            case 'б': output += 'b'; break;
                            case 'в': output += 'v'; break;
                            case 'г': output += 'g'; break;
                            case 'д': output += 'd'; break;
                            case 'е': output += 'e'; break;
                            case 'ж': output += 'j'; break;
                            case 'з': output += 'z'; break;
                            case 'и': output += 'i'; break;
                            case 'к': output += 'k'; break;
                            case 'л': output += 'l'; break;
                            case 'м': output += 'm'; break;
                            case 'н': output += 'n'; break;
                            case 'о': output += 'o'; break;
                            case 'п': output += 'p'; break;
                            case 'р': output += 'r'; break;
                            case 'с': output += 's'; break;
                            case 'т': output += 't'; break;
                            case 'у': output += 'u'; break;
                            case 'ф': output += 'f'; break;
                            case 'х': output += 'h'; break;
                            case 'ц': output += 'c'; break;
                            case 'ч': output += "ch"; break;
                            case 'ш': output += "sh"; break;
                            case 'щ': output += "shh"; break;
                            case 'э': output += "eh"; break;
                            case 'ю': output += "yu"; break;
                            case 'я': output += "ya"; break;

                            case 'А': output += 'A'; break;
                            case 'Б': output += 'B'; break;
                            case 'В': output += 'V'; break;
                            case 'Г': output += 'G'; break;
                            case 'Д': output += 'D'; break;
                            case 'Е': output += 'E'; break;
                            case 'Ж': output += 'J'; break;
                            case 'З': output += 'Z'; break;
                            case 'И': output += 'I'; break;
                            case 'К': output += 'K'; break;
                            case 'Л': output += 'L'; break;
                            case 'М': output += 'M'; break;
                            case 'Н': output += 'N'; break;
                            case 'О': output += 'O'; break;
                            case 'П': output += 'P'; break;
                            case 'Р': output += 'R'; break;
                            case 'С': output += 'S'; break;
                            case 'Т': output += 'T'; break;
                            case 'У': output += 'Y'; break;
                            case 'Ф': output += 'F'; break;
                            case 'Х': output += 'H'; break;
                            case 'Ц': output += 'C'; break;
                            case 'Ч': output += "CH"; break;
                            case 'Ш': output += "SH"; break;
                            case 'Щ': output += "SHH"; break;
                            case 'Э': output += "EH"; break;
                            case 'Ю': output += "YU"; break;
                            case 'Я': output += "YA"; break;

                            case 'a': output += 'а'; break;
                            case 'b': output += 'б'; break;
                            case 'v': output += 'в'; break;
                            case 'g': output += 'г'; break;
                            case 'd': output += 'д'; break;
                            case 'e': output += 'е'; break;
                            case 'j': output += 'ж'; break;
                            case 'z': output += 'з'; break;
                            case 'i': output += 'и'; break;
                            case 'k': output += 'к'; break;
                            case 'l': output += 'л'; break;
                            case 'm': output += 'м'; break;
                            case 'n': output += 'н'; break;
                            case 'o': output += 'о'; break;
                            case 'p': output += 'п'; break;
                            case 'r': output += 'р'; break;
                            case 's': output += 'с'; break;
                            case 't': output += 'т'; break;
                            case 'u': output += 'у'; break;
                            case 'f': output += 'ф'; break;
                            case 'h': output += 'х'; break;
                            case 'c': output += 'ц'; break;
                            // case "ch": output +='ч' ; break;       
                            // case "sh": output +='ш' ; break;       
                            //  case "shh": output +='щ' ; break;      
                            //  case "eh": output +='э' ; break;       
                            //  case "yu": output +='ю' ; break;       
                            // case "ya": output +='я' ; break;       

                            case 'A': output += 'А'; break;
                            case 'B': output += 'Б'; break;
                            case 'V': output += 'В'; break;
                            case 'G': output += 'Г'; break;
                            case 'D': output += 'Д'; break;
                            case 'E': output += 'Е'; break;
                            case 'J': output += 'Ж'; break;
                            case 'Z': output += 'З'; break;
                            case 'I': output += 'И'; break;
                            case 'K': output += 'К'; break;
                            case 'L': output += 'Л'; break;
                            case 'M': output += 'М'; break;
                            case 'N': output += 'Н'; break;
                            case 'O': output += 'О'; break;
                            case 'P': output += 'П'; break;
                            case 'R': output += 'Р'; break;
                            case 'S': output += 'С'; break;
                            case 'T': output += 'Т'; break;
                            case 'Y': output += 'У'; break;
                            case 'F': output += 'Ф'; break;
                            case 'H': output += 'Х'; break;
                            case 'C': output += 'Ц'; break;
                            //  case "CH": output +='Ч' ; break;       
                            //  case "SH": output +='Ш' ; break;       
                            //  case "SHH": output +='Щ' ; break;      
                            //  case "EH": output +='Э' ; break;       
                            //   case "YU": output +='Ю' ; break;       
                            //  case "YA": output +='Я' ; break;       
                            case '1': output += '1'; break;
                            case '2': output += '2'; break;
                            case '3': output += '3'; break;
                            case '4': output += '4'; break;
                            case '5': output += '5'; break;
                            case '6': output += '6'; break;
                            case '7': output += '7'; break;
                            case '8': output += '8'; break;
                            case '9': output += '9'; break;
                            case '0': output += '0'; break;
                            case '_': output += '_'; break;
                            case ':': output += ':'; break;
                            case ';': output += ';'; break;
                            case '*': output += '*'; break;
                            case '-': output += '-'; break;
                            case '+': output += '+'; break;
                            case '=': output += '='; break;
                            case '<': output += '<'; break;
                            case '>': output += '>'; break;
                            case '?': output += '?'; break;
                            case '!': output += '!'; break;
                        }
                    }
                    else
                    {
                        if ((input[i + 2] != 'h') & (input[i + 2] != 'H'))
                        {
                            switch (input[i])
                            {
                                case 'c': output += 'ч'; i += 1; break;
                                case 's': output += 'ш'; i += 1; break;
                                case 'e': output += 'э'; i += 1; break;
                                case 'C': output += 'Ч'; i += 1; break;
                                case 'S': output += 'Ш'; i += 1; break;
                                case 'E': output += 'Э'; i += 1; break;

                            }
                        }
                        else
                        {
                            switch (input[i])
                            {

                                case 's': output += 'щ'; i += 2; break;
                                case 'S': output += 'Щ'; i += 2; break;

                            }
                        }
                    }
                }
            }


            return output;
        }
    }
}
