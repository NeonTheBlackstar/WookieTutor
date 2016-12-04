namespace WookieTutor
{
    partial class Form1
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
            this.footer = new System.Windows.Forms.Label();
            this.loadFile = new System.Windows.Forms.OpenFileDialog();
            this.answer_butt = new System.Windows.Forms.Button();
            this.tabControl1 = new WookieTutor.CustomTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.start_butt = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.exit_butt = new System.Windows.Forms.Button();
            this.load_butt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comment_label = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.replay_butt = new System.Windows.Forms.Button();
            this.goback_butt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.question_label = new System.Windows.Forms.Label();
            this.result_text = new System.Windows.Forms.RichTextBox();
            this.question_text = new System.Windows.Forms.RichTextBox();
            this.answer_text = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // footer
            // 
            this.footer.AutoSize = true;
            this.footer.BackColor = System.Drawing.Color.Black;
            this.footer.Font = new System.Drawing.Font("Lucida Sans", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.footer.ForeColor = System.Drawing.Color.Yellow;
            this.footer.Location = new System.Drawing.Point(-95, 453);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(834, 14);
            this.footer.TabIndex = 0;
            this.footer.Text = "                                                Made by Łukasz Ciecierski, Furry " +
    "Software  © 2016                                                ";
            // 
            // loadFile
            // 
            this.loadFile.Filter = "\"Wookie Tutor|*.wookie|All files|*.*\"";
            // 
            // answer_butt
            // 
            this.answer_butt.BackgroundImage = global::WookieTutor.Properties.Resources.beautiful_blue_stars_fill;
            this.answer_butt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.answer_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answer_butt.ForeColor = System.Drawing.Color.Yellow;
            this.answer_butt.Location = new System.Drawing.Point(512, 391);
            this.answer_butt.Name = "answer_butt";
            this.answer_butt.Size = new System.Drawing.Size(108, 27);
            this.answer_butt.TabIndex = 1;
            this.answer_butt.Text = "Answer";
            this.answer_butt.UseVisualStyleBackColor = true;
            this.answer_butt.Click += new System.EventHandler(this.answer_butt_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-6, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(654, 450);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BackgroundImage = global::WookieTutor.Properties.Resources.star_space_tile;
            this.tabPage1.Controls.Add(this.start_butt);
            this.tabPage1.Controls.Add(this.title);
            this.tabPage1.Controls.Add(this.exit_butt);
            this.tabPage1.Controls.Add(this.load_butt);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(646, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // start_butt
            // 
            this.start_butt.BackColor = System.Drawing.Color.Transparent;
            this.start_butt.BackgroundImage = global::WookieTutor.Properties.Resources.beautiful_blue_stars_fill;
            this.start_butt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.start_butt.Enabled = false;
            this.start_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_butt.ForeColor = System.Drawing.Color.Yellow;
            this.start_butt.Location = new System.Drawing.Point(389, 96);
            this.start_butt.Name = "start_butt";
            this.start_butt.Size = new System.Drawing.Size(185, 51);
            this.start_butt.TabIndex = 2;
            this.start_butt.Text = "Start Lesson";
            this.start_butt.UseVisualStyleBackColor = false;
            this.start_butt.Click += new System.EventHandler(this.start_butt_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Snap ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Yellow;
            this.title.Location = new System.Drawing.Point(364, 27);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(238, 37);
            this.title.TabIndex = 5;
            this.title.Text = "Wookie Tutor";
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // exit_butt
            // 
            this.exit_butt.BackColor = System.Drawing.Color.Transparent;
            this.exit_butt.BackgroundImage = global::WookieTutor.Properties.Resources.beautiful_blue_stars_fill;
            this.exit_butt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_butt.ForeColor = System.Drawing.Color.Yellow;
            this.exit_butt.Location = new System.Drawing.Point(389, 358);
            this.exit_butt.Name = "exit_butt";
            this.exit_butt.Size = new System.Drawing.Size(185, 48);
            this.exit_butt.TabIndex = 4;
            this.exit_butt.Text = "Exit";
            this.exit_butt.UseVisualStyleBackColor = false;
            this.exit_butt.Click += new System.EventHandler(this.exit_butt_Click);
            // 
            // load_butt
            // 
            this.load_butt.BackgroundImage = global::WookieTutor.Properties.Resources.beautiful_blue_stars_fill;
            this.load_butt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.load_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load_butt.ForeColor = System.Drawing.Color.Yellow;
            this.load_butt.Location = new System.Drawing.Point(389, 165);
            this.load_butt.Name = "load_butt";
            this.load_butt.Size = new System.Drawing.Size(185, 48);
            this.load_butt.TabIndex = 3;
            this.load_butt.Text = "Load Lesson";
            this.load_butt.UseVisualStyleBackColor = true;
            this.load_butt.Click += new System.EventHandler(this.load_butt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WookieTutor.Properties.Resources.chewy_2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-23, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(474, 407);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::WookieTutor.Properties.Resources.star_space_tile;
            this.tabPage2.Controls.Add(this.comment_label);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.replay_butt);
            this.tabPage2.Controls.Add(this.goback_butt);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.question_label);
            this.tabPage2.Controls.Add(this.result_text);
            this.tabPage2.Controls.Add(this.question_text);
            this.tabPage2.Controls.Add(this.answer_butt);
            this.tabPage2.Controls.Add(this.answer_text);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(646, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comment_label
            // 
            this.comment_label.AutoSize = true;
            this.comment_label.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comment_label.ForeColor = System.Drawing.Color.Yellow;
            this.comment_label.Location = new System.Drawing.Point(258, 154);
            this.comment_label.Name = "comment_label";
            this.comment_label.Size = new System.Drawing.Size(155, 15);
            this.comment_label.TabIndex = 9;
            this.comment_label.Text = "What the rRrrRrrR, man?";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::WookieTutor.Properties.Resources.wookie_normal;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(230, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(203, 161);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // replay_butt
            // 
            this.replay_butt.BackgroundImage = global::WookieTutor.Properties.Resources.beautiful_blue_stars_fill;
            this.replay_butt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.replay_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.replay_butt.ForeColor = System.Drawing.Color.Yellow;
            this.replay_butt.Location = new System.Drawing.Point(15, 81);
            this.replay_butt.Name = "replay_butt";
            this.replay_butt.Size = new System.Drawing.Size(89, 28);
            this.replay_butt.TabIndex = 7;
            this.replay_butt.Text = "Replay";
            this.replay_butt.UseVisualStyleBackColor = true;
            this.replay_butt.Click += new System.EventHandler(this.replay_butt_Click);
            // 
            // goback_butt
            // 
            this.goback_butt.BackgroundImage = global::WookieTutor.Properties.Resources.beautiful_blue_stars_fill;
            this.goback_butt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.goback_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goback_butt.ForeColor = System.Drawing.Color.Yellow;
            this.goback_butt.Location = new System.Drawing.Point(15, 7);
            this.goback_butt.Name = "goback_butt";
            this.goback_butt.Size = new System.Drawing.Size(89, 67);
            this.goback_butt.TabIndex = 6;
            this.goback_butt.Text = "<< Go back";
            this.goback_butt.UseVisualStyleBackColor = true;
            this.goback_butt.Click += new System.EventHandler(this.goback_butt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(26, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Result";
            // 
            // question_label
            // 
            this.question_label.AutoSize = true;
            this.question_label.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.question_label.ForeColor = System.Drawing.Color.Yellow;
            this.question_label.Location = new System.Drawing.Point(26, 160);
            this.question_label.Name = "question_label";
            this.question_label.Size = new System.Drawing.Size(86, 18);
            this.question_label.TabIndex = 4;
            this.question_label.Text = "Question";
            this.question_label.Click += new System.EventHandler(this.question_label_Click);
            // 
            // result_text
            // 
            this.result_text.BackColor = System.Drawing.Color.Black;
            this.result_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.result_text.ForeColor = System.Drawing.Color.Yellow;
            this.result_text.Location = new System.Drawing.Point(26, 304);
            this.result_text.Name = "result_text";
            this.result_text.ReadOnly = true;
            this.result_text.Size = new System.Drawing.Size(594, 57);
            this.result_text.TabIndex = 3;
            this.result_text.Text = "";
            this.result_text.TextChanged += new System.EventHandler(this.result_text_TextChanged);
            // 
            // question_text
            // 
            this.question_text.BackColor = System.Drawing.Color.Black;
            this.question_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.question_text.ForeColor = System.Drawing.Color.Yellow;
            this.question_text.Location = new System.Drawing.Point(26, 182);
            this.question_text.Name = "question_text";
            this.question_text.ReadOnly = true;
            this.question_text.Size = new System.Drawing.Size(594, 59);
            this.question_text.TabIndex = 2;
            this.question_text.Text = "";
            this.question_text.TextChanged += new System.EventHandler(this.question_text_TextChanged);
            // 
            // answer_text
            // 
            this.answer_text.BackColor = System.Drawing.Color.Black;
            this.answer_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answer_text.ForeColor = System.Drawing.Color.Yellow;
            this.answer_text.Location = new System.Drawing.Point(26, 394);
            this.answer_text.Name = "answer_text";
            this.answer_text.Size = new System.Drawing.Size(480, 21);
            this.answer_text.TabIndex = 0;
            // 
            // Form1
            // 
            this.AcceptButton = this.answer_butt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::WookieTutor.Properties.Resources.star_space_tile;
            this.ClientSize = new System.Drawing.Size(639, 468);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.footer);
            this.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "Form1";
            this.Text = "Wookie Tutor 2016";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label footer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button start_butt;
        private System.Windows.Forms.Button load_butt;
        private System.Windows.Forms.Button exit_butt;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.OpenFileDialog loadFile;
        private CustomTabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox answer_text;
        private System.Windows.Forms.Button answer_butt;
        private System.Windows.Forms.Button goback_butt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label question_label;
        private System.Windows.Forms.RichTextBox result_text;
        private System.Windows.Forms.RichTextBox question_text;
        private System.Windows.Forms.Button replay_butt;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label comment_label;
    }
}

