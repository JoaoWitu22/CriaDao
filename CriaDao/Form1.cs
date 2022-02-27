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
            string cmd = textBox_cmd.Text;
            textBox_Head.Text = "";
            textBox_parameter.Text = "";
            string[] coluns = textBoxColuns.Text.Split(new Char[] { ',', '.', '-', '\n', '\t' });
            string update = "UPDATE " + textBox_table.Text + " SET ";
            string insert = "INSERT INTO " + textBox_table.Text + " (";
            string values = "";
            string colun = "";
            foreach (string colr in coluns)
            {
                var col = colr.Replace(" ", "").Replace("[", "").Replace("]", "").Replace("\n", "");
                textBox_parameter.Text = textBox_parameter.Text + cmd + ".Parameters.AddWithValue(\"@" + col + "\", " + col + ");\n";
                textBox_Head.Text = textBox_Head.Text + "string " + col + ", ";
                update += col + " = @" + col + ",\n";
                values += "@" + col + ", ";
                colun += col + ", ";
            }
            update += " WHERE xxxxxxxxxxxx";
            insert += colun + ") VALUES (" + values + ")";
            textBox_Update.Text = update;
            textBox_Insert.Text = insert;
        }
    }
}

