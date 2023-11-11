using AAJGen;
using System;
using System.Text;
using System.Windows.Forms;

namespace appFelxMax.appClass.clsProgOptions
{
    class clsGenerate
    {

        public void fnGenerateCode(TextBox textBox)
        {
            var chars = "123456789";
            var stringChars = new char[16];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            var finalString = new String(stringChars);
            textBox.Text = finalString.Trim();
        }


    }
}
