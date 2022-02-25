namespace CriaDao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_Head.Text = "";
            textBox_parameter.Text = "";
            string[]coluns = textBoxColuns.Text.Split(new Char[] {',', '.', '-', '\n', '\t' });
            
                foreach (string col in coluns)
            {
                col.Replace(" ", "");
                textBox_parameter.Text = textBox_parameter.Text + "cmd.Parameters.AddWithValue(\"@" + col + "\", " + col + ");\n";
                textBox_Head.Text = textBox_Head.Text + "string " + col + ", ";
            }
                
            
        } 
    }
}