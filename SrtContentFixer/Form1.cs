namespace SrtContentFixer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "fileName.txt");
        }
        public static void GetFiles()
        {
            var currentDirectory = Directory.GetCurrentDirectory();

            // files list from the root directory and prints it
            var files = Directory.GetFiles(currentDirectory);
            Console.WriteLine(String.Join(Environment.NewLine, files));
        }
    }
}