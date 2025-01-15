namespace BMI_Calculator
{
    public partial class Form1 : Form
    {
        float result;
        String language = "english";

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            result = (float)Math.Round(float.Parse(textBoxWeight.Text) / MathF.Pow(float.Parse(textBoxHeight.Text), 2), 2);
            textBoxBMIValue.Text = result.ToString();
            textBoxBMIValue.Enabled = true;
            textBoxClassification.Enabled = true;

            if(result < 17)
            {
                textBoxClassification.Text = "Very underweight";
                if (language == "portuguese")
                    textBoxClassification.Text = "Muito abaixo do peso";
            }
            else if (result < 18.4)
            {
                textBoxClassification.Text = "Underweight";
                if (language == "portuguese")
                    textBoxClassification.Text = "abaixo do peso";
            }
            else if (result < 24.9)
            {
                textBoxClassification.Text = "Normal weight";
                if (language == "portuguese")
                    textBoxClassification.Text = "Peso normal";
            }
            else if (result < 29.9)
            {
                textBoxClassification.Text = "Overweight";
                if (language == "portuguese")
                    textBoxClassification.Text = "Sobre peso";
            }
            else if (result < 34.9)
            {
                textBoxClassification.Text = "Obesity - class I";
                if (language == "portuguese")
                    textBoxClassification.Text = "Obesidade - classe I";
            }
            else if (result < 39.9)
            {
                textBoxClassification.Text = "Obesity - class II";
                if (language == "portuguese")
                    textBoxClassification.Text = "Obesidade - classe II";
            }
            else if (result >= 40)
            {
                textBoxClassification.Text = "Obesity - class III";
                if (language == "portuguese")
                    textBoxClassification.Text = "Obesidade - classe III";
            }
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            textBoxHeight.Text = "";
            textBoxWeight.Text = "";
            textBoxBMIValue.Text = "";
            textBoxClassification.Text = "";
            textBoxBMIValue.Enabled = false;
            textBoxClassification.Enabled = false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButtonEnglish_CheckedChanged(object sender, EventArgs e)
        {
            language = "english";
            Text = "BMI Calculator";
            labelBMI.Text = "Body Mass Index";
            labelHeight.Text = "Enter Height";
            labelTypeHeight.Text = "metter";
            labelWeight.Text = "Enter Weight";
            labelTypeWeight.Text = "kilogram";
            labelBMIValue.Text = "BMI Value";
            labelClassification.Text = "Classification";
            buttonCheck.Text = "Check BMI";
            buttonClean.Text = "Clean";
            buttonExit.Text = "Exit";
        }

        private void radioButtonPortugues_CheckedChanged(object sender, EventArgs e)
        {
            language = "portuguese";
            Text = "Calculadora IMC";
            labelBMI.Text = "Índice de Massa Corporal";
            labelHeight.Text = "Digite a altura";
            labelTypeHeight.Text = "m, cm";
            labelWeight.Text = "Digite o peso";
            labelTypeWeight.Text = "kg";
            labelBMIValue.Text = "Valor IMC";
            labelClassification.Text = "Classificação";
            buttonCheck.Text = "Checar IMC";
            buttonClean.Text = "Limpar";
            buttonExit.Text = "Sair";
        }
    }
}
