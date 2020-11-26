namespace AutoSloon
{
    partial class Main
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
            this.btn_closed = new System.Windows.Forms.Button();
            this.listBox_main = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_header = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_left = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_box = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_speed = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.label_racxod = new System.Windows.Forms.Label();
            this.label_privod = new System.Windows.Forms.Label();
            this.label_engine = new System.Windows.Forms.Label();
            this.panel_header.SuspendLayout();
            this.panel_left.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_closed
            // 
            this.btn_closed.FlatAppearance.BorderSize = 0;
            this.btn_closed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_closed.Location = new System.Drawing.Point(774, 2);
            this.btn_closed.Name = "btn_closed";
            this.btn_closed.Size = new System.Drawing.Size(30, 30);
            this.btn_closed.TabIndex = 3;
            this.btn_closed.Text = "X";
            this.btn_closed.UseVisualStyleBackColor = true;
            this.btn_closed.Click += new System.EventHandler(this.btn_closed_Click);
            // 
            // listBox_main
            // 
            this.listBox_main.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_main.FormattingEnabled = true;
            this.listBox_main.ItemHeight = 16;
            this.listBox_main.Location = new System.Drawing.Point(17, 39);
            this.listBox_main.Name = "listBox_main";
            this.listBox_main.Size = new System.Drawing.Size(449, 180);
            this.listBox_main.TabIndex = 4;
            this.listBox_main.SelectedIndexChanged += new System.EventHandler(this.listBox_main_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(105, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Список доступных машин:";
            // 
            // panel_header
            // 
            this.panel_header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_header.Controls.Add(this.btn_closed);
            this.panel_header.Controls.Add(this.label2);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(805, 35);
            this.panel_header.TabIndex = 6;
            this.panel_header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_header_MouseDown);
            this.panel_header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_header_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(5, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Главная форма";
            // 
            // panel_left
            // 
            this.panel_left.Controls.Add(this.label9);
            this.panel_left.Controls.Add(this.label8);
            this.panel_left.Controls.Add(this.label_racxod);
            this.panel_left.Controls.Add(this.label_time);
            this.panel_left.Controls.Add(this.label_speed);
            this.panel_left.Controls.Add(this.label_engine);
            this.panel_left.Controls.Add(this.label_privod);
            this.panel_left.Controls.Add(this.label_box);
            this.panel_left.Controls.Add(this.label7);
            this.panel_left.Controls.Add(this.label6);
            this.panel_left.Controls.Add(this.label5);
            this.panel_left.Controls.Add(this.label4);
            this.panel_left.Controls.Add(this.listBox_main);
            this.panel_left.Controls.Add(this.label3);
            this.panel_left.Controls.Add(this.label1);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 35);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(482, 464);
            this.panel_left.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(36, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "Дигатель:\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(287, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "Привод:\r\n";
            // 
            // label_box
            // 
            this.label_box.AutoSize = true;
            this.label_box.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_box.Location = new System.Drawing.Point(365, 291);
            this.label_box.Name = "label_box";
            this.label_box.Size = new System.Drawing.Size(36, 18);
            this.label_box.TabIndex = 6;
            this.label_box.Text = "box\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(287, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Коробка:\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(287, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Расход:\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(36, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Разгон:\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(36, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 36);
            this.label4.TabIndex = 6;
            this.label4.Text = "Максимальная \r\nскорость:\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(101, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Детальная характеристика:\r\n";
            // 
            // label_speed
            // 
            this.label_speed.AutoSize = true;
            this.label_speed.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_speed.Location = new System.Drawing.Point(150, 291);
            this.label_speed.Name = "label_speed";
            this.label_speed.Size = new System.Drawing.Size(52, 18);
            this.label_speed.TabIndex = 6;
            this.label_speed.Text = "speed";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_time.Location = new System.Drawing.Point(150, 320);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(41, 18);
            this.label_time.TabIndex = 6;
            this.label_time.Text = "time";
            // 
            // label_racxod
            // 
            this.label_racxod.AutoSize = true;
            this.label_racxod.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_racxod.Location = new System.Drawing.Point(362, 349);
            this.label_racxod.Name = "label_racxod";
            this.label_racxod.Size = new System.Drawing.Size(59, 18);
            this.label_racxod.TabIndex = 6;
            this.label_racxod.Text = "rashod";
            // 
            // label_privod
            // 
            this.label_privod.AutoSize = true;
            this.label_privod.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_privod.Location = new System.Drawing.Point(365, 320);
            this.label_privod.Name = "label_privod";
            this.label_privod.Size = new System.Drawing.Size(36, 18);
            this.label_privod.TabIndex = 6;
            this.label_privod.Text = "box\r\n";
            // 
            // label_engine
            // 
            this.label_engine.AutoSize = true;
            this.label_engine.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_engine.Location = new System.Drawing.Point(150, 349);
            this.label_engine.Name = "label_engine";
            this.label_engine.Size = new System.Drawing.Size(36, 18);
            this.label_engine.TabIndex = 6;
            this.label_engine.Text = "box\r\n";
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(805, 499);
            this.Controls.Add(this.panel_left);
            this.Controls.Add(this.panel_header);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.panel_left.ResumeLayout(false);
            this.panel_left.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_closed;
        private System.Windows.Forms.ListBox listBox_main;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_racxod;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label_speed;
        private System.Windows.Forms.Label label_engine;
        private System.Windows.Forms.Label label_privod;
    }
}