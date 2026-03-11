
using System.Windows.Forms.DataVisualization.Charting;

namespace SentenceStatistics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtInputSentence.Text = Properties.Settings.Default.inputSentence;
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
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Dictionary<string, double> letterPercentage = Logic.CalcLetterPercentage(txtInputSentence.Text);
            pieChart.Series["chartSeries"].Points.DataBindXY(letterPercentage.Keys, letterPercentage.Values);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.inputSentence = txtInputSentence.Text;
            Properties.Settings.Default.Save();
        }
    }

    public class Logic
    {
        public static Dictionary<string, double> CalcLetterPercentage(string inputString)
        {
            Dictionary<string, double> dictionary = new();
            foreach (var c in inputString.ToLower())
            {
                if (dictionary.ContainsKey(c.ToString()) && Char.IsLetter(c))
                    dictionary[c.ToString()]++;
                else if (Char.IsLetter(c))
                    dictionary[c.ToString()] = 1;
            }

            var total = dictionary.Values.Sum();
            foreach (var key in dictionary.Keys)
            {
                dictionary[key] = Math.Round(dictionary[key] / total * 100, 2);
            }

            //var outputMsg = "";
            //foreach (var pair in dictionary)
            //    outputMsg += $"{pair.Key} = {(float)pair.Value / totalLetter * 100:F2}%\n";

            return dictionary;
        }
    }
}
