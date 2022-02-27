namespace CriaDao
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxColuns = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_Head = new System.Windows.Forms.TextBox();
            this.textBox_parameter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_cmd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Update = new System.Windows.Forms.TextBox();
            this.textBox_Insert = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_table = new System.Windows.Forms.TextBox();
            this.Reader = new System.Windows.Forms.Label();
            this.textBox_reader = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxColuns
            // 
            this.textBoxColuns.Location = new System.Drawing.Point(12, 27);
            this.textBoxColuns.Multiline = true;
            this.textBoxColuns.Name = "textBoxColuns";
            this.textBoxColuns.Size = new System.Drawing.Size(202, 318);
            this.textBoxColuns.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Colunas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Criar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_Head
            // 
            this.textBox_Head.Location = new System.Drawing.Point(12, 427);
            this.textBox_Head.Name = "textBox_Head";
            this.textBox_Head.Size = new System.Drawing.Size(1061, 23);
            this.textBox_Head.TabIndex = 3;
            // 
            // textBox_parameter
            // 
            this.textBox_parameter.Location = new System.Drawing.Point(220, 27);
            this.textBox_parameter.Multiline = true;
            this.textBox_parameter.Name = "textBox_parameter";
            this.textBox_parameter.Size = new System.Drawing.Size(391, 372);
            this.textBox_parameter.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Head";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Parameter";
            // 
            // textBox_cmd
            // 
            this.textBox_cmd.Location = new System.Drawing.Point(107, 351);
            this.textBox_cmd.Name = "textBox_cmd";
            this.textBox_cmd.Size = new System.Drawing.Size(107, 23);
            this.textBox_cmd.TabIndex = 7;
            this.textBox_cmd.Text = "cmd";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sqlcommand";
            // 
            // textBox_Update
            // 
            this.textBox_Update.Location = new System.Drawing.Point(617, 27);
            this.textBox_Update.Multiline = true;
            this.textBox_Update.Name = "textBox_Update";
            this.textBox_Update.Size = new System.Drawing.Size(225, 372);
            this.textBox_Update.TabIndex = 9;
            // 
            // textBox_Insert
            // 
            this.textBox_Insert.Location = new System.Drawing.Point(848, 27);
            this.textBox_Insert.Multiline = true;
            this.textBox_Insert.Name = "textBox_Insert";
            this.textBox_Insert.Size = new System.Drawing.Size(225, 372);
            this.textBox_Insert.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(617, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Update";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(849, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Insert";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Table";
            // 
            // textBox_table
            // 
            this.textBox_table.Location = new System.Drawing.Point(107, 376);
            this.textBox_table.Name = "textBox_table";
            this.textBox_table.Size = new System.Drawing.Size(107, 23);
            this.textBox_table.TabIndex = 13;
            // 
            // Reader
            // 
            this.Reader.AutoSize = true;
            this.Reader.Location = new System.Drawing.Point(1080, 9);
            this.Reader.Name = "Reader";
            this.Reader.Size = new System.Drawing.Size(43, 15);
            this.Reader.TabIndex = 16;
            this.Reader.Text = "Reader";
            // 
            // textBox_reader
            // 
            this.textBox_reader.Location = new System.Drawing.Point(1079, 27);
            this.textBox_reader.Multiline = true;
            this.textBox_reader.Name = "textBox_reader";
            this.textBox_reader.Size = new System.Drawing.Size(225, 372);
            this.textBox_reader.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 453);
            this.Controls.Add(this.Reader);
            this.Controls.Add(this.textBox_reader);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_table);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Insert);
            this.Controls.Add(this.textBox_Update);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_cmd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_parameter);
            this.Controls.Add(this.textBox_Head);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxColuns);
            this.Name = "Form1";
            this.Text = "Cria Dao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxColuns;
        private Label label1;
        private Button button1;
        private TextBox textBox_Head;
        private TextBox textBox_parameter;
        private Label label2;
        private Label label3;
        private TextBox textBox_cmd;
        private Label label4;
        private TextBox textBox_Update;
        private TextBox textBox_Insert;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox_table;
        private Label Reader;
        private TextBox textBox_reader;
    }
}