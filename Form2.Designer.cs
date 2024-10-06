namespace BUS_ORGANIZATION
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label7 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            label4 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            refresh = new Button();
            addrow = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label8 = new Label();
            textBox4 = new TextBox();
            button3 = new Button();
            label9 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(refresh);
            panel1.Controls.Add(addrow);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(24, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(261, 512);
            panel1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 421);
            label7.Name = "label7";
            label7.Size = new Size(105, 15);
            label7.TabIndex = 8;
            label7.Text = "Номер маршрута";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 392);
            label6.Name = "label6";
            label6.Size = new Size(91, 15);
            label6.TabIndex = 7;
            label6.Text = "Имя остановки";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(124, 418);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(124, 389);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(13, 365);
            button2.Name = "button2";
            button2.Size = new Size(211, 23);
            button2.TabIndex = 5;
            button2.Text = "Проверить остановку на машруте";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 230);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 4;
            label4.Text = "Условие WHERE:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 248);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(211, 79);
            textBox1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(13, 333);
            button1.Name = "button1";
            button1.Size = new Size(211, 26);
            button1.TabIndex = 4;
            button1.Text = "Применить условие WHERE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // refresh
            // 
            refresh.Location = new Point(63, 454);
            refresh.Name = "refresh";
            refresh.Size = new Size(120, 27);
            refresh.TabIndex = 2;
            refresh.Text = "Обновить таблицу";
            refresh.UseVisualStyleBackColor = true;
            refresh.Click += refresh_Click;
            // 
            // addrow
            // 
            addrow.Location = new Point(63, 487);
            addrow.Name = "addrow";
            addrow.Size = new Size(120, 22);
            addrow.TabIndex = 2;
            addrow.Text = "Добавить строку";
            addrow.UseVisualStyleBackColor = true;
            addrow.Click += addrow_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Пользователи", "Роли", "Работники", "Должности", "Категории", "Автобусы", "Остановки", "Маршруты", "Перевозка", "Отчёт", "Работники, Должности, Категории", "Остановки в маршруте" });
            listBox1.Location = new Point(27, 28);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(203, 184);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 10);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 1;
            label1.Text = "Выберите таблицу";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(291, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(610, 512);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.UserDeletingRow += dataGridView1_UserDeletingRow;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(646, 36);
            label2.Name = "label2";
            label2.Size = new Size(255, 15);
            label2.TabIndex = 2;
            label2.Text = "Изменять и удалять строки можно в таблице";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 36);
            label3.Name = "label3";
            label3.Size = new Size(391, 15);
            label3.TabIndex = 3;
            label3.Text = "В случае возникновения ошибок, рекоммендуется обновить таблицу";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 598);
            label5.Name = "label5";
            label5.Size = new Size(600, 15);
            label5.TabIndex = 4;
            label5.Text = "В базе данных где есть NOT NULL необходимо добавить DEFAULT значение. Иначе добавление не сработает";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 578);
            label8.Name = "label8";
            label8.Size = new Size(125, 15);
            label8.TabIndex = 5;
            label8.Text = "Строка для запросов:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(155, 575);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(661, 23);
            textBox4.TabIndex = 6;
            // 
            // button3
            // 
            button3.Location = new Point(822, 575);
            button3.Name = "button3";
            button3.Size = new Size(79, 23);
            button3.TabIndex = 7;
            button3.Text = "Применить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(24, 615);
            label9.Name = "label9";
            label9.Size = new Size(393, 15);
            label9.TabIndex = 8;
            label9.Text = "Строка для запросов используется для DML операций (кроме SELECT)";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 639);
            Controls.Add(label9);
            Controls.Add(button3);
            Controls.Add(textBox4);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            FormClosed += Form2_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ListBox listBox1;
        private DataGridView dataGridView1;
        private Button addrow;
        private Button refresh;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
        private TextBox textBox1;
        private Label label5;
        private Button button2;
        private Label label7;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label8;
        private TextBox textBox4;
        private Button button3;
        private Label label9;
    }
}