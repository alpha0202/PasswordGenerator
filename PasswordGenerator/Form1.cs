namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        Random _ramdom = new Random();
        static string upperCaseList = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
        static string lowerList = "abcdefghijklmnñopqrstuvwxyz";
        static string numberList = "0123456789";
        static string symbolList = "!¡@#$%&/*+()[]{}=<>,;:.~^";

        string allCharsList = string.Empty;
        public Form1()
        {
            InitializeComponent();
            txtLength.Text = "20";
        }


        private void BuildCharsList()
        {
            allCharsList =string.Empty;
            txtPassResult.Text = string.Empty;

            if (chkIncludeUpper.Checked)
                allCharsList += upperCaseList;
            if (chkIncludeLower.Checked)
                allCharsList += lowerList;
            if (chkIncludeNumers.Checked)
                allCharsList += numberList;
            if (chkSymbols.Enabled)
                allCharsList += symbolList;

            if (string.IsNullOrEmpty(allCharsList))
                allCharsList = string.Concat(upperCaseList, lowerList, numberList, symbolList);
        }


        private string GeneratePassword(int length)
        {

            string newPassword = string.Empty;

            if (length < 6)
                throw new Exception("A strong password needs more than 6 characters");

            for (int i = 0; i < length; i++)
            {
                newPassword += GetRandomChar();
            }
            return newPassword;
        }

        private string GetRandomChar()
        {
            return allCharsList.ToCharArray()[(int)Math.Floor(_ramdom.NextDouble() * allCharsList.Length)].ToString();
        }


        private void btnGenerate_Click(object sender, EventArgs e)
        {
            BuildCharsList();

            txtPassResult.Text = GeneratePassword(int.Parse(txtLength.Text));

        }
    }
}