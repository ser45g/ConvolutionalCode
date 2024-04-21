using ConvolutionalCodeModel;
using System.Diagnostics.Metrics;
using System.Text;
using System.Windows.Forms;
namespace ConvolutionalCode
{
    public partial class Form1 : Form
    {
        private bool _isBinary;
        public Form1()
        {
            InitializeComponent();
            //toolTip1.SetToolTip(textBox4, "Введите полиномы в 10СС через пробел");
            toolTip1.SetToolTip(label7, "Полиномы играют важнейшую роль в эффективности свёрточного кодирования");

            _isBinary = false;
            button3.Text = "В текстовом виде";
            //Числа в 8СС
            cbAvailablePolynoms.Items.Add("3 7");
            cbAvailablePolynoms.Items.Add("3 5 12");
            cbAvailablePolynoms.Items.Add("7 14");
            cbAvailablePolynoms.Items.Add("7 17");
            this.Text = "Свёрточный код";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files|*.txt|All files|*.*";
            //openFileDialog.InitialDirectory=Directory.GetCurrentDirectory();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var reader = File.OpenText(openFileDialog.FileName))
                {
                    textBox1.Text = reader.ReadToEnd();
                }

            }
        }
        private bool IsBinaryString(string str)
        {
            var ch = str.FirstOrDefault((x) => x != '0' && x != '1');
            return (ch == 0) ? true : false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbAvailablePolynoms.Text))
            {
                MessageBox.Show("Необходимо выбрать полиномы для свёрточного кода", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            richTextBox1.Clear();
            richTextBox2.Clear();
            int[] polynoms = null;
            try
            {
                polynoms = (cbAvailablePolynoms.Text.Split(' ').Where(x => !string.IsNullOrEmpty(x)).Select(x => Convert.ToInt32(x, 8))).ToArray();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            //foreach (int i in polynoms)
            //{
            //    if (i < 0)
            //    {
            //        MessageBox.Show("Полином должен быть больше нуля");
            //        return;
            //    }
            //}

            ConvolutionalCodeModel.Viterbi.Encoder encoder = new ConvolutionalCodeModel.Viterbi.Encoder(polynoms);

            if (!_isBinary)
            {
                textBox3.Text = Encoding.UTF8.GetBytes(textBox1.Text).ToBinaryString();

            }
            else
            {
                if (IsBinaryString(textBox1.Text))
                {
                    textBox3.Text = textBox1.Text;
                }
                else
                {
                    MessageBox.Show("Некоторые символы в строке не соответствуют двоичному виду", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            bool[] ar = textBox3.Text.ToBoolArrayString();
            textBox2.Text = encoder.Encode(ar).ToArray().ToBinaryString();
            var message = textBox2.Text;

            int errorProb = (int)numericUpDown1.Value;
            int errorCount = errorProb * message.Length / 100;

            Random random = new Random();
            List<int> errorIndexec = new List<int>();
            for (int i = 0; i < errorCount; i++)
            {
                int index = 0;
                index = random.Next(1, message.Length);
                bool isInList = errorIndexec.IndexOf(index) != -1;
                if (isInList)
                    continue;

                errorIndexec.Add(index);
                if (message[index] == '0')
                {
                    message = message.ReplaceAt(index, '1');
                }
                else
                {
                    message = message.ReplaceAt(index, '0');
                }
                //message.ReplaceAt(index, message[index] == '0' ? '1' : '0');
            }
            for (int i = 0; i < message.Length; i++)
            {
                bool isInList = errorIndexec.IndexOf(i) != -1;
                if (isInList)
                {
                    richTextBox1.AppendText(message[i].ToString(), Color.Red,
                        new Font(richTextBox1.Font, FontStyle.Underline));
                }
                else
                {
                    richTextBox1.AppendText(message[i].ToString(), Color.Black);

                }

            }

            ConvolutionalCodeModel.Viterbi.Decoder decoder = new ConvolutionalCodeModel.Viterbi.Decoder(polynoms);
            string s = string.Empty;
            string decodedBinString = "";
            if (!_isBinary)
            {
                decodedBinString = Encoding.UTF8.GetString(
                    decoder.Decode(message.ToBoolArrayString()).ToBinaryString().FromBinaryString());

            }
            else
            {
                decodedBinString = decoder.Decode(message.ToBoolArrayString()).ToBinaryString();

            }



            for (int i = 0; i < decodedBinString.Length; i++)
            {


                if (decodedBinString[i] != textBox1.Text[i])
                {
                    richTextBox2.AppendText(decodedBinString[i].ToString(), Color.Red
                        , new Font(richTextBox1.Font, FontStyle.Underline));
                }
                else
                {
                    richTextBox2.AppendText(decodedBinString[i].ToString(), Color.DarkGreen);
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!_isBinary)
            {
                _isBinary = true;
                button3.Text = "В двоичном виде";
            }
            else
            {
                _isBinary = false;
                button3.Text = "В текстовом виде";
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
