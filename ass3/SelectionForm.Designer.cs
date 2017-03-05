namespace ass3
{
    partial class SelectionForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.MovieBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CostBox = new System.Windows.Forms.TextBox();
            this.CategoryBox = new System.Windows.Forms.TextBox();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.MoviePB = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePB)).BeginInit();
            this.SuspendLayout();
            // 
            // MovieBox
            // 
            this.MovieBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MovieBox.FormattingEnabled = true;
            this.MovieBox.Items.AddRange(new object[] {
            "Season of the Witch",
            "The Green Hornet",
            "The Dilemma",
            "Death Race 2",
            "Company Men",
            "No Strings Attahced",
            "The Way Back",
            "The Mechanic",
            "The Rite",
            "Sanctum",
            "The Other Woman",
            "The Roommate",
            "Waiting For Forever",
            "Cedar Rapids",
            "Gnomeo and Juliet",
            "Just Go With it",
            "The Eagle",
            "I Am Number Four",
            "Footloose",
            "Real Steel"});
            this.MovieBox.Location = new System.Drawing.Point(22, 74);
            this.MovieBox.Name = "MovieBox";
            this.MovieBox.Size = new System.Drawing.Size(206, 20);
            this.MovieBox.TabIndex = 0;
            this.MovieBox.SelectedIndexChanged += new System.EventHandler(this.MovieBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.CostBox);
            this.groupBox1.Controls.Add(this.CategoryBox);
            this.groupBox1.Controls.Add(this.TitleBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.MoviePB);
            this.groupBox1.Location = new System.Drawing.Point(256, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 322);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your Selection";
            // 
            // CostBox
            // 
            this.CostBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CostBox.Location = new System.Drawing.Point(179, 275);
            this.CostBox.Name = "CostBox";
            this.CostBox.ReadOnly = true;
            this.CostBox.Size = new System.Drawing.Size(111, 21);
            this.CostBox.TabIndex = 6;
            // 
            // CategoryBox
            // 
            this.CategoryBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CategoryBox.Location = new System.Drawing.Point(17, 275);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.ReadOnly = true;
            this.CategoryBox.Size = new System.Drawing.Size(133, 21);
            this.CategoryBox.TabIndex = 5;
            this.CategoryBox.TextChanged += new System.EventHandler(this.CategoryBox_TextChanged);
            // 
            // TitleBox
            // 
            this.TitleBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TitleBox.Location = new System.Drawing.Point(17, 210);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.ReadOnly = true;
            this.TitleBox.Size = new System.Drawing.Size(273, 21);
            this.TitleBox.TabIndex = 4;
            this.TitleBox.TextChanged += new System.EventHandler(this.TitleBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Category";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose Your Movie";
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(74, 323);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(105, 37);
            this.NextButton.TabIndex = 3;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // MoviePB
            // 
            this.MoviePB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MoviePB.Location = new System.Drawing.Point(17, 32);
            this.MoviePB.Name = "MoviePB";
            this.MoviePB.Size = new System.Drawing.Size(253, 137);
            this.MoviePB.TabIndex = 0;
            this.MoviePB.TabStop = false;
            this.MoviePB.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 392);
            this.ControlBox = false;
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MovieBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectionForm";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MovieBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox MoviePB;
        private System.Windows.Forms.TextBox CostBox;
        private System.Windows.Forms.TextBox CategoryBox;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button NextButton;
    }
}

