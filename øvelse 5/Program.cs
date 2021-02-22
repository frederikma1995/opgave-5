using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace øvelse_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "";
            Console.WriteLine("create new password");
            password = Console.ReadLine();

            bool hasNum = false;
            bool hasLet = false;

            bool hasSpec = false;
            char currentCharacter;

            for (int i = 0; i < password.Length; i++)
            {
                currentCharacter = password[i];
                if (char.IsDigit(currentCharacter))
                {
                    hasNum = true;
                    ;
                }
                else if (char.IsLetter(currentCharacter))
                {
                    hasLet = true;

                }
                else if (!char.IsLetterOrDigit(currentCharacter))
                {
                    hasSpec = true;

                }
            }
            validate(hasLet,hasNum,hasSpec,password);
        }

        static public void validate(bool hasLet, bool hasNum, bool hasSpec, string password)
        {
            if (hasLet == true && hasNum == true && hasSpec == true && password.Length >= 8)
            {
                Console.WriteLine("The password '{0}' is a very strong password.", password);
            }
            else if (hasLet == true && hasNum == true && hasSpec == false && password.Length >= 8)
            {
                Console.WriteLine(" The password '{0}' is a strong password.", password);
            }
            else if (hasLet == true && hasNum == false && hasSpec == false && password.Length < 8)
            {
                Console.WriteLine(" The password '{0}' is a weak password.", password);
            }
            else if (hasLet == false && hasNum == true && hasSpec == false && password.Length < 8)
            {
                Console.WriteLine("The password '{0}' is a very weak password.", password);
            }
            else
            { Console.WriteLine("sorry password does not fit the requirements"); }
            Console.ReadLine();
        }
    }
}
