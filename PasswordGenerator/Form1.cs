namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        Random _ramdom = new Random();
        static readonly string upperCaseList = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
        static readonly string lowerList = "abcdefghijklmnñopqrstuvwxyz";
        static readonly string numberList = "0123456789";
        static readonly string symbolList = "!¡@#$%&/*+()[]{}=<>,;:.~^";

        string allCharsList = string.Empty;
        public Form1()
        {
            InitializeComponent();
            txtLength.Text = "20";
        }

        //iniciando con la verificación de los check si son habilitados, de lo contrario se crea un password por defecto con todas las opciones.
        private void BuildCharsList()
        {
            allCharsList = string.Empty;
            txtPassResult.Text = string.Empty;

            if (chkIncludeUpper.Checked)
                allCharsList += upperCaseList;
            if (chkIncludeLower.Checked)
                allCharsList += lowerList;
            if (chkIncludeNumbers.Checked)
                allCharsList += numberList;
            if (chkSymbols.Checked)
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


            try
            {
                BuildCharsList();

                txtPassResult.Text = GeneratePassword(int.Parse(txtLength.Text));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Information");
            }


        }

        //controlar la entrada de solo números en txtLength
        private void txtLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}