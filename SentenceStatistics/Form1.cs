namespace SentenceStatistics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcPercentage_Click(object sender, EventArgs e)
        {
            string inputSentence;
            try
            {
                inputSentence = txtInputSentence.Text;
                if (string.IsNullOrEmpty(inputSentence))
                    throw new FormatException("Поле не должно быть пустым");
            } 
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(inputSentence);
        }
    }

    public class Logic
    {
        public static string CalcPercentage(string inputString)
        {
            Dictionary<char, int> dictionary = new();
            foreach (var c in inputString.ToLower())
            {
                if (dictionary.ContainsKey(c) && Char.IsLetter(c))
                    dictionary[c]++;
                else if (Char.IsLetter(c))
                    dictionary[c] = 1;
            }

            var totalLetter = dictionary.Values.Sum();

            var outputMsg = "";
            foreach (var pair in dictionary)
                outputMsg += $"{pair.Key} = {(float)pair.Value / totalLetter * 100:F2}%\n";

            return outputMsg;
        }
    }
}
