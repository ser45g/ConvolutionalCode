using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvolutionalCode
{
    public static class Extensions
    {
        public static void AppendText(this RichTextBox textBox, string text, Color color, Font? font = null)
        {
            textBox.SelectionStart = textBox.TextLength;
            textBox.SelectionLength = 0;
            textBox.SelectionColor = color;
            if (font != null)
            {
                textBox.SelectionFont = font;
            }
            textBox.AppendText(text);
            textBox.SelectionColor = textBox.ForeColor;
            textBox.SelectionFont = new Font(textBox.Font, FontStyle.Regular);
        }

        public static byte[] FromBinaryString(this string s)
        {
            int count = s.Length / 8;
            var b = new byte[count];
            for (int i = 0; i < count; i++)
                b[i] = Convert.ToByte(s.Substring(i * 8, 8), 2);

            return b;
        }

        public static string ToBinaryString(this byte[] bytes)
        {
            var s = new StringBuilder();
            foreach (byte b in bytes)
            {
                string temp = Convert.ToString(b, 2);
                string a = new string('0', 8 - temp.Length);
                string res32 = a + temp;
                s.Append(res32);

            }

            return s.ToString();
        }
        public static string ToBinaryString(this bool[] bytes)
        {
            var s = new StringBuilder();
            foreach (bool b in bytes)
            {
                string temp = b ? "1" : "0";
                //string a = new string('0', 8 - temp.Length);
                //string res32 = a + temp;
                s.Append(temp);

            }

            return s.ToString();
        }
        public static bool[] ToBoolArrayString(this string binaryString)
        {
            bool[] array = new bool[binaryString.Length];
            for (int i = 0; i < binaryString.Length; i++)
            {
                array[i] = binaryString[i]=='0'?false:true;
            }

            return array;
        }
        public static string ReplaceAt(this string input, int index, char newChar)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input");
            }
            char[] chars = input.ToCharArray();
            chars[index] = newChar;
            return new string(chars);
        }
        public static string ByteArrayToString(this byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }
    }
}
