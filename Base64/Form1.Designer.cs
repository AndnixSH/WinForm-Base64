
namespace Base64
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.encFileBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.encTextBox = new System.Windows.Forms.RichTextBox();
            this.encResTextBox = new System.Windows.Forms.RichTextBox();
            this.encBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.decFileBtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.decTextBox = new System.Windows.Forms.RichTextBox();
            this.decResTextBox = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.encFileBtn);
            this.groupBox2.Location = new System.Drawing.Point(12, 362);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Encode files to Base64 format";
            // 
            // encFileBtn
            // 
            this.encFileBtn.AllowDrop = true;
            this.encFileBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.encFileBtn.Location = new System.Drawing.Point(24, 24);
            this.encFileBtn.Name = "encFileBtn";
            this.encFileBtn.Size = new System.Drawing.Size(299, 61);
            this.encFileBtn.TabIndex = 2;
            this.encFileBtn.Text = "Click or drop here to select a file";
            this.encFileBtn.UseVisualStyleBackColor = true;
            this.encFileBtn.Click += new System.EventHandler(this.encFileBtn_Click);
            this.encFileBtn.DragDrop += new System.Windows.Forms.DragEventHandler(this.encFileBtn_DragDrop);
            this.encFileBtn.DragEnter += new System.Windows.Forms.DragEventHandler(this.encFileBtn_DragEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.encTextBox);
            this.groupBox1.Controls.Add(this.encResTextBox);
            this.groupBox1.Controls.Add(this.encBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 337);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encode to Base64 format";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Result goes here:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Type (or paste) here:";
            // 
            // encTextBox
            // 
            this.encTextBox.Location = new System.Drawing.Point(19, 50);
            this.encTextBox.Name = "encTextBox";
            this.encTextBox.Size = new System.Drawing.Size(306, 95);
            this.encTextBox.TabIndex = 1;
            this.encTextBox.Text = "";
            // 
            // encResTextBox
            // 
            this.encResTextBox.Location = new System.Drawing.Point(19, 226);
            this.encResTextBox.Name = "encResTextBox";
            this.encResTextBox.Size = new System.Drawing.Size(306, 95);
            this.encResTextBox.TabIndex = 3;
            this.encResTextBox.Text = "";
            // 
            // encBtn
            // 
            this.encBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.encBtn.Location = new System.Drawing.Point(109, 156);
            this.encBtn.Name = "encBtn";
            this.encBtn.Size = new System.Drawing.Size(132, 39);
            this.encBtn.TabIndex = 2;
            this.encBtn.Text = "ENCODE";
            this.encBtn.UseVisualStyleBackColor = true;
            this.encBtn.Click += new System.EventHandler(this.encBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.decFileBtn);
            this.groupBox3.Location = new System.Drawing.Point(392, 362);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(349, 100);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Decode files from Base64 format";
            // 
            // decFileBtn
            // 
            this.decFileBtn.AllowDrop = true;
            this.decFileBtn.ForeColor = System.Drawing.Color.Red;
            this.decFileBtn.Location = new System.Drawing.Point(24, 24);
            this.decFileBtn.Name = "decFileBtn";
            this.decFileBtn.Size = new System.Drawing.Size(299, 61);
            this.decFileBtn.TabIndex = 2;
            this.decFileBtn.Text = "Click or drop here to select a file";
            this.decFileBtn.UseVisualStyleBackColor = true;
            this.decFileBtn.Click += new System.EventHandler(this.decFileBtn_Click);
            this.decFileBtn.DragDrop += new System.Windows.Forms.DragEventHandler(this.decFileBtn_DragDrop);
            this.decFileBtn.DragEnter += new System.Windows.Forms.DragEventHandler(this.decFileBtn_DragEnter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.decTextBox);
            this.groupBox4.Controls.Add(this.decResTextBox);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Location = new System.Drawing.Point(392, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(349, 337);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Decode to Base64 format";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Result goes here:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Type (or paste) here:";
            // 
            // decTextBox
            // 
            this.decTextBox.Location = new System.Drawing.Point(19, 50);
            this.decTextBox.Name = "decTextBox";
            this.decTextBox.Size = new System.Drawing.Size(306, 95);
            this.decTextBox.TabIndex = 1;
            this.decTextBox.Text = "";
            // 
            // decResTextBox
            // 
            this.decResTextBox.Location = new System.Drawing.Point(19, 226);
            this.decResTextBox.Name = "decResTextBox";
            this.decResTextBox.Size = new System.Drawing.Size(306, 95);
            this.decResTextBox.TabIndex = 3;
            this.decResTextBox.Text = "";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(109, 156);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 39);
            this.button4.TabIndex = 2;
            this.button4.Text = "DECODE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 469);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Base64 Tool";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button encFileBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox encTextBox;
        private System.Windows.Forms.RichTextBox encResTextBox;
        private System.Windows.Forms.Button encBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button decFileBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox decTextBox;
        private System.Windows.Forms.RichTextBox decResTextBox;
        private System.Windows.Forms.Button button4;
    }
}

