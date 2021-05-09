
namespace Linear_Algebra_Application
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.vectorList = new System.Windows.Forms.ListBox();
            this.btn_Vector1 = new System.Windows.Forms.Button();
            this.lb_array1 = new System.Windows.Forms.Label();
            this.lb_array2 = new System.Windows.Forms.Label();
            this.btn_Vector2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 33);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(528, 45);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vector:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(705, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vectorList
            // 
            this.vectorList.FormattingEnabled = true;
            this.vectorList.ItemHeight = 38;
            this.vectorList.Location = new System.Drawing.Point(146, 101);
            this.vectorList.Name = "vectorList";
            this.vectorList.Size = new System.Drawing.Size(332, 156);
            this.vectorList.TabIndex = 3;
            this.vectorList.SelectedIndexChanged += new System.EventHandler(this.vectorList_SelectedIndexChanged);
            // 
            // btn_Vector1
            // 
            this.btn_Vector1.Location = new System.Drawing.Point(484, 103);
            this.btn_Vector1.Name = "btn_Vector1";
            this.btn_Vector1.Size = new System.Drawing.Size(82, 66);
            this.btn_Vector1.TabIndex = 4;
            this.btn_Vector1.Text = "1";
            this.btn_Vector1.UseVisualStyleBackColor = true;
            this.btn_Vector1.Click += new System.EventHandler(this.button2_Click);
            // 
            // lb_array1
            // 
            this.lb_array1.AutoSize = true;
            this.lb_array1.Location = new System.Drawing.Point(603, 103);
            this.lb_array1.Name = "lb_array1";
            this.lb_array1.Size = new System.Drawing.Size(106, 38);
            this.lb_array1.TabIndex = 5;
            this.lb_array1.Text = "Array 1";
            // 
            // lb_array2
            // 
            this.lb_array2.AutoSize = true;
            this.lb_array2.Location = new System.Drawing.Point(603, 170);
            this.lb_array2.Name = "lb_array2";
            this.lb_array2.Size = new System.Drawing.Size(106, 38);
            this.lb_array2.TabIndex = 6;
            this.lb_array2.Text = "Array 2";
            // 
            // btn_Vector2
            // 
            this.btn_Vector2.Location = new System.Drawing.Point(484, 191);
            this.btn_Vector2.Name = "btn_Vector2";
            this.btn_Vector2.Size = new System.Drawing.Size(82, 66);
            this.btn_Vector2.TabIndex = 7;
            this.btn_Vector2.Text = "2";
            this.btn_Vector2.UseVisualStyleBackColor = true;
            this.btn_Vector2.Click += new System.EventHandler(this.btn_Vector2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 424);
            this.Controls.Add(this.btn_Vector2);
            this.Controls.Add(this.lb_array2);
            this.Controls.Add(this.lb_array1);
            this.Controls.Add(this.btn_Vector1);
            this.Controls.Add(this.vectorList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox vectorList;
        private System.Windows.Forms.Button btn_Vector1;
        private System.Windows.Forms.Label lb_array1;
        private System.Windows.Forms.Label lb_array2;
        private System.Windows.Forms.Button btn_Vector2;
    }
}

