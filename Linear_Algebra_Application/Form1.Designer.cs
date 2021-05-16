
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
            this.button1 = new System.Windows.Forms.Button();
            this.vectorList = new System.Windows.Forms.ListBox();
            this.btn_Vector1 = new System.Windows.Forms.Button();
            this.lb_array1 = new System.Windows.Forms.Label();
            this.lb_array2 = new System.Windows.Forms.Label();
            this.btn_Vector2 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lb_VectorLength = new System.Windows.Forms.Label();
            this.btn_DotProdoct = new System.Windows.Forms.Button();
            this.lb_DotProduct = new System.Windows.Forms.Label();
            this.Btn_Angle = new System.Windows.Forms.Button();
            this.lb_Angle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 16);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(528, 45);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(571, 16);
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
            this.vectorList.Location = new System.Drawing.Point(12, 84);
            this.vectorList.Name = "vectorList";
            this.vectorList.Size = new System.Drawing.Size(332, 156);
            this.vectorList.TabIndex = 3;
            this.vectorList.SelectedIndexChanged += new System.EventHandler(this.vectorList_SelectedIndexChanged);
            // 
            // btn_Vector1
            // 
            this.btn_Vector1.Location = new System.Drawing.Point(350, 86);
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
            this.lb_array1.Location = new System.Drawing.Point(469, 86);
            this.lb_array1.Name = "lb_array1";
            this.lb_array1.Size = new System.Drawing.Size(106, 38);
            this.lb_array1.TabIndex = 5;
            this.lb_array1.Text = "Array 1";
            // 
            // lb_array2
            // 
            this.lb_array2.AutoSize = true;
            this.lb_array2.Location = new System.Drawing.Point(469, 151);
            this.lb_array2.Name = "lb_array2";
            this.lb_array2.Size = new System.Drawing.Size(106, 38);
            this.lb_array2.TabIndex = 6;
            this.lb_array2.Text = "Array 2";
            // 
            // btn_Vector2
            // 
            this.btn_Vector2.Location = new System.Drawing.Point(350, 174);
            this.btn_Vector2.Name = "btn_Vector2";
            this.btn_Vector2.Size = new System.Drawing.Size(82, 66);
            this.btn_Vector2.TabIndex = 7;
            this.btn_Vector2.Text = "2";
            this.btn_Vector2.UseVisualStyleBackColor = true;
            this.btn_Vector2.Click += new System.EventHandler(this.btn_Vector2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(332, 55);
            this.button2.TabIndex = 8;
            this.button2.Text = "Vector Length";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // lb_VectorLength
            // 
            this.lb_VectorLength.AutoSize = true;
            this.lb_VectorLength.Location = new System.Drawing.Point(362, 271);
            this.lb_VectorLength.Name = "lb_VectorLength";
            this.lb_VectorLength.Size = new System.Drawing.Size(0, 38);
            this.lb_VectorLength.TabIndex = 9;
            // 
            // btn_DotProdoct
            // 
            this.btn_DotProdoct.Location = new System.Drawing.Point(12, 340);
            this.btn_DotProdoct.Name = "btn_DotProdoct";
            this.btn_DotProdoct.Size = new System.Drawing.Size(332, 55);
            this.btn_DotProdoct.TabIndex = 10;
            this.btn_DotProdoct.Text = "Dot Product";
            this.btn_DotProdoct.UseVisualStyleBackColor = true;
            this.btn_DotProdoct.Click += new System.EventHandler(this.btn_DotProdoct_Click);
            // 
            // lb_DotProduct
            // 
            this.lb_DotProduct.AutoSize = true;
            this.lb_DotProduct.Location = new System.Drawing.Point(362, 357);
            this.lb_DotProduct.Name = "lb_DotProduct";
            this.lb_DotProduct.Size = new System.Drawing.Size(0, 38);
            this.lb_DotProduct.TabIndex = 11;
            // 
            // Btn_Angle
            // 
            this.Btn_Angle.Location = new System.Drawing.Point(12, 417);
            this.Btn_Angle.Name = "Btn_Angle";
            this.Btn_Angle.Size = new System.Drawing.Size(332, 55);
            this.Btn_Angle.TabIndex = 12;
            this.Btn_Angle.Text = "Angle";
            this.Btn_Angle.UseVisualStyleBackColor = true;
            this.Btn_Angle.Click += new System.EventHandler(this.Btn_Angle_Click);
            // 
            // lb_Angle
            // 
            this.lb_Angle.AutoSize = true;
            this.lb_Angle.Location = new System.Drawing.Point(362, 425);
            this.lb_Angle.Name = "lb_Angle";
            this.lb_Angle.Size = new System.Drawing.Size(0, 38);
            this.lb_Angle.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(696, 500);
            this.Controls.Add(this.lb_Angle);
            this.Controls.Add(this.Btn_Angle);
            this.Controls.Add(this.lb_DotProduct);
            this.Controls.Add(this.btn_DotProdoct);
            this.Controls.Add(this.lb_VectorLength);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Vector2);
            this.Controls.Add(this.lb_array2);
            this.Controls.Add(this.lb_array1);
            this.Controls.Add(this.btn_Vector1);
            this.Controls.Add(this.vectorList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Linear Algebra & Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox vectorList;
        private System.Windows.Forms.Button btn_Vector1;
        private System.Windows.Forms.Label lb_array1;
        private System.Windows.Forms.Label lb_array2;
        private System.Windows.Forms.Button btn_Vector2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lb_VectorLength;
        private System.Windows.Forms.Button btn_DotProdoct;
        private System.Windows.Forms.Label lb_DotProduct;
        private System.Windows.Forms.Button Btn_Angle;
        private System.Windows.Forms.Label lb_Angle;
    }
}

