namespace EVE_OREoptimize
{
    partial class Form1
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
            this.label37 = new System.Windows.Forms.Label();
            this.optimize_output = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sellPriceButton = new System.Windows.Forms.RadioButton();
            this.buyPriceButton = new System.Windows.Forms.RadioButton();
            this.ratio_input = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.h_input = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.g_input = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.f_input = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.e_input = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.d_input = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.c_input = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.b_input = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.a_input = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.calculateMineral = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(297, 34);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(41, 20);
            this.label37.TabIndex = 27;
            this.label37.Text = "结果";
            // 
            // optimize_output
            // 
            this.optimize_output.Location = new System.Drawing.Point(298, 70);
            this.optimize_output.Multiline = true;
            this.optimize_output.Name = "optimize_output";
            this.optimize_output.Size = new System.Drawing.Size(675, 459);
            this.optimize_output.TabIndex = 26;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.sellPriceButton);
            this.groupBox3.Controls.Add(this.buyPriceButton);
            this.groupBox3.Controls.Add(this.ratio_input);
            this.groupBox3.Controls.Add(this.label36);
            this.groupBox3.Controls.Add(this.h_input);
            this.groupBox3.Controls.Add(this.label35);
            this.groupBox3.Controls.Add(this.g_input);
            this.groupBox3.Controls.Add(this.label34);
            this.groupBox3.Controls.Add(this.f_input);
            this.groupBox3.Controls.Add(this.label33);
            this.groupBox3.Controls.Add(this.e_input);
            this.groupBox3.Controls.Add(this.label32);
            this.groupBox3.Controls.Add(this.d_input);
            this.groupBox3.Controls.Add(this.label31);
            this.groupBox3.Controls.Add(this.c_input);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Controls.Add(this.b_input);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.a_input);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.calculateMineral);
            this.groupBox3.Location = new System.Drawing.Point(24, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 510);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "参数";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 32);
            this.button1.TabIndex = 26;
            this.button1.Text = "填入剪贴板中Excel数据";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sellPriceButton
            // 
            this.sellPriceButton.AutoSize = true;
            this.sellPriceButton.Checked = true;
            this.sellPriceButton.Location = new System.Drawing.Point(162, 274);
            this.sellPriceButton.Name = "sellPriceButton";
            this.sellPriceButton.Size = new System.Drawing.Size(85, 17);
            this.sellPriceButton.TabIndex = 25;
            this.sellPriceButton.TabStop = true;
            this.sellPriceButton.Text = "吉他卖单价";
            this.sellPriceButton.UseVisualStyleBackColor = true;
            // 
            // buyPriceButton
            // 
            this.buyPriceButton.AutoSize = true;
            this.buyPriceButton.Location = new System.Drawing.Point(10, 274);
            this.buyPriceButton.Name = "buyPriceButton";
            this.buyPriceButton.Size = new System.Drawing.Size(85, 17);
            this.buyPriceButton.TabIndex = 24;
            this.buyPriceButton.Text = "吉他买单价";
            this.buyPriceButton.UseVisualStyleBackColor = true;
            // 
            // ratio_input
            // 
            this.ratio_input.Location = new System.Drawing.Point(105, 235);
            this.ratio_input.Name = "ratio_input";
            this.ratio_input.Size = new System.Drawing.Size(156, 20);
            this.ratio_input.TabIndex = 23;
            this.ratio_input.Text = "0.75";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(6, 235);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(57, 20);
            this.label36.TabIndex = 22;
            this.label36.Text = "化矿率";
            // 
            // h_input
            // 
            this.h_input.Location = new System.Drawing.Point(105, 209);
            this.h_input.Name = "h_input";
            this.h_input.Size = new System.Drawing.Size(156, 20);
            this.h_input.TabIndex = 21;
            this.h_input.Text = "0";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(6, 207);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(53, 20);
            this.label35.TabIndex = 20;
            this.label35.Text = "莫尔石";
            // 
            // g_input
            // 
            this.g_input.Location = new System.Drawing.Point(105, 183);
            this.g_input.Name = "g_input";
            this.g_input.Size = new System.Drawing.Size(156, 20);
            this.g_input.TabIndex = 19;
            this.g_input.Text = "0";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(6, 181);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(57, 20);
            this.label34.TabIndex = 18;
            this.label34.Text = "超噬矿";
            // 
            // f_input
            // 
            this.f_input.Location = new System.Drawing.Point(105, 157);
            this.f_input.Name = "f_input";
            this.f_input.Size = new System.Drawing.Size(156, 20);
            this.f_input.TabIndex = 17;
            this.f_input.Text = "0";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(6, 155);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(89, 20);
            this.label33.TabIndex = 16;
            this.label33.Text = "晶状石英岩";
            // 
            // e_input
            // 
            this.e_input.Location = new System.Drawing.Point(105, 131);
            this.e_input.Name = "e_input";
            this.e_input.Size = new System.Drawing.Size(156, 20);
            this.e_input.TabIndex = 15;
            this.e_input.Text = "0";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(6, 129);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(89, 20);
            this.label32.TabIndex = 14;
            this.label32.Text = "超星诺克石";
            // 
            // d_input
            // 
            this.d_input.Location = new System.Drawing.Point(105, 105);
            this.d_input.Name = "d_input";
            this.d_input.Size = new System.Drawing.Size(156, 20);
            this.d_input.TabIndex = 13;
            this.d_input.Text = "0";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(6, 103);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(89, 20);
            this.label31.TabIndex = 12;
            this.label31.Text = "同位聚合体";
            // 
            // c_input
            // 
            this.c_input.Location = new System.Drawing.Point(105, 79);
            this.c_input.Name = "c_input";
            this.c_input.Size = new System.Drawing.Size(156, 20);
            this.c_input.TabIndex = 11;
            this.c_input.Text = "0";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(6, 77);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(85, 20);
            this.label30.TabIndex = 10;
            this.label30.Text = "类银超金属";
            // 
            // b_input
            // 
            this.b_input.Location = new System.Drawing.Point(105, 53);
            this.b_input.Name = "b_input";
            this.b_input.Size = new System.Drawing.Size(156, 20);
            this.b_input.TabIndex = 9;
            this.b_input.Text = "0";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(6, 51);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(85, 20);
            this.label28.TabIndex = 8;
            this.label28.Text = "类晶体胶矿";
            // 
            // a_input
            // 
            this.a_input.Location = new System.Drawing.Point(105, 27);
            this.a_input.Name = "a_input";
            this.a_input.Size = new System.Drawing.Size(156, 20);
            this.a_input.TabIndex = 7;
            this.a_input.Text = "0";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(6, 27);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(73, 20);
            this.label29.TabIndex = 6;
            this.label29.Text = "三钛合金";
            // 
            // calculateMineral
            // 
            this.calculateMineral.Location = new System.Drawing.Point(10, 406);
            this.calculateMineral.Name = "calculateMineral";
            this.calculateMineral.Size = new System.Drawing.Size(251, 32);
            this.calculateMineral.TabIndex = 0;
            this.calculateMineral.Text = "配矿";
            this.calculateMineral.UseVisualStyleBackColor = true;
            this.calculateMineral.Click += new System.EventHandler(this.calculateMineral_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(251, 32);
            this.button2.TabIndex = 27;
            this.button2.Text = "填入蓝图助手数据";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 582);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.optimize_output);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "EVE-OREoptimize";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox optimize_output;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton sellPriceButton;
        private System.Windows.Forms.RadioButton buyPriceButton;
        private System.Windows.Forms.TextBox ratio_input;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox h_input;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox g_input;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox f_input;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox e_input;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox d_input;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox c_input;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox b_input;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox a_input;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button calculateMineral;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

