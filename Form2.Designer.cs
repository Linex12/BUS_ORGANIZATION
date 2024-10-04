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
            refresh = new Button();
            addrow = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(refresh);
            panel1.Controls.Add(addrow);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(200, 120);
            panel1.Name = "panel1";
            panel1.Size = new Size(142, 350);
            panel1.TabIndex = 0;
            // 
            // refresh
            // 
            refresh.Location = new Point(57, 270);
            refresh.Name = "refresh";
            refresh.Size = new Size(75, 23);
            refresh.TabIndex = 2;
            refresh.Text = "Обновить";
            refresh.UseVisualStyleBackColor = true;
            refresh.Click += refresh_Click;
            // 
            // addrow
            // 
            addrow.Location = new Point(57, 309);
            addrow.Name = "addrow";
            addrow.Size = new Size(75, 38);
            addrow.TabIndex = 2;
            addrow.Text = "Добавить строку";
            addrow.UseVisualStyleBackColor = true;
            addrow.Click += addrow_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Пользователи", "Роли", "Работники", "Должности", "Категории", "Автобусы", "Остановки", "Маршруты", "Перевозка" });
            listBox1.Location = new Point(12, 37);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 154);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 1;
            label1.Text = "Выберите таблицу";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(348, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(460, 350);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.UserDeletingRow += dataGridView1_UserDeletingRow;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(348, 77);
            label2.Name = "label2";
            label2.Size = new Size(255, 15);
            label2.TabIndex = 2;
            label2.Text = "Изменять и удалять строки можно в таблице";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(348, 92);
            label3.Name = "label3";
            label3.Size = new Size(391, 15);
            label3.TabIndex = 3;
            label3.Text = "В случае возникновения ошибок, рекоммендуется обновить таблицу";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 593);
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
    }
}