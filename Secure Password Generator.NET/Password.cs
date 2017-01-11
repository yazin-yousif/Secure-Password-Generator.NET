using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secure_Password_Generator
{
    /*
     * This class contains contains all variables and methods required to generate a password
     * */
    class Password
    {

        /*
         * Variable declarations
         */
        private int length = 0;
        private bool includeNumbers = false;
        private bool includeSymbols = false;

        private Letters letters;
        private Random rnd = new Random();

        private char[] arrayLetters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        private char[] arraySymbols = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~".ToCharArray();
        private char[] arrayNumbers = "0123456789".ToCharArray();


        public Password(int length, Letters letters, bool numbers, bool symbols)
        {
            this.length = length;
            this.letters = letters;
            this.includeNumbers = numbers;
            this.includeSymbols = symbols;

        }

        /*
         * This method is responsible for streamlining the password generation process.
         * When all sub-methods have been executed, generate() returns the generated password.
         * */
        public string generate()
        {
            String password = "";

            if (letters.doInclude())
            {
                password = generateLetters(includeSymbols || includeNumbers);
            }

            if (includeNumbers)
            {
                password = generateNumbers(password, includeSymbols);
            }

            if (includeSymbols)
            {
                password = generateSymbols(password);
            }

            return new string(password.OrderBy(r => rnd.Next()).ToArray());

        }

        /*
         * This method handles generating the 'letters' portion of the password
         * */
        private string generateLetters(bool partial)
        {
            String password = "";

            for (int i = 0; i < length; i++)
            {
                password += arrayLetters[rnd.Next(0, arrayLetters.Length)];

                if (partial)
                {
                    i++;
                }

            }

            if (letters.setUpper())
            {
                return password.ToUpper();
            }

            if (letters.setLower())
            {
                return password.ToLower();
            }

            return handleMixCase(password);
        }

        /*
         * This helper method handles the mixed case option.
         * */
        private string handleMixCase(String password)
        {
            String newPassword = "";

            bool upper = false;

            bool lower = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (i % 2 != 0)
                {
                    newPassword += password[i].ToString().ToUpper();
                    upper = true;
                }
                else
                {
                    newPassword += password[i].ToString();
                    lower = true;
                }
            }

            if (!upper || !lower)
            {
                handleMixCase(password);
            }

            return newPassword;

        }

        /*
        * This method handles the 'numbers' portion of the password
        * */
        private string generateNumbers(string password, bool symbols)
        {
            int passwordLength = password.Length;

            for (int i = 0; i < (length - passwordLength); i++)
            {
                password += arrayNumbers[rnd.Next(0, arrayNumbers.Length)];

                if (symbols)
                {
                    i = i + 1;
                }
            }

            return password;

        }

        /*
        * This method handles the 'symbols' portion of the password
        * */
        private string generateSymbols(string password)
        {
            int passwordLength = password.Length;

            for (int i = 0; i < (length - passwordLength); i++)
            {
                password += arraySymbols[rnd.Next(0, arraySymbols.Length)];
            }

            return password;

        }

    }
}
