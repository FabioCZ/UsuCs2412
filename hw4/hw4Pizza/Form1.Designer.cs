namespace hw4Pizza
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioLarge = new System.Windows.Forms.RadioButton();
            this.radioMedium = new System.Windows.Forms.RadioButton();
            this.radioSmall = new System.Windows.Forms.RadioButton();
            this.GroupBoxToppings = new System.Windows.Forms.GroupBox();
            this.checkMushrooms = new System.Windows.Forms.CheckBox();
            this.checkSpinach = new System.Windows.Forms.CheckBox();
            this.checkOnion = new System.Windows.Forms.CheckBox();
            this.checkSausage = new System.Windows.Forms.CheckBox();
            this.checkPepperoni = new System.Windows.Forms.CheckBox();
            this.numericUpDownBreadsticks = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownCheesesticks = new System.Windows.Forms.NumericUpDown();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.GroupBoxToppings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBreadsticks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCheesesticks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PIZZA ORDER FORM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioLarge);
            this.groupBox1.Controls.Add(this.radioMedium);
            this.groupBox1.Controls.Add(this.radioSmall);
            this.groupBox1.Location = new System.Drawing.Point(16, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 51);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size ($5/6/7)";
            // 
            // radioLarge
            // 
            this.radioLarge.AutoSize = true;
            this.radioLarge.Location = new System.Drawing.Point(131, 20);
            this.radioLarge.Name = "radioLarge";
            this.radioLarge.Size = new System.Drawing.Size(52, 17);
            this.radioLarge.TabIndex = 2;
            this.radioLarge.TabStop = true;
            this.radioLarge.Text = "Large";
            this.radioLarge.UseVisualStyleBackColor = true;
            // 
            // radioMedium
            // 
            this.radioMedium.AutoSize = true;
            this.radioMedium.Location = new System.Drawing.Point(63, 20);
            this.radioMedium.Name = "radioMedium";
            this.radioMedium.Size = new System.Drawing.Size(62, 17);
            this.radioMedium.TabIndex = 1;
            this.radioMedium.TabStop = true;
            this.radioMedium.Text = "Medium";
            this.radioMedium.UseVisualStyleBackColor = true;
            // 
            // radioSmall
            // 
            this.radioSmall.AutoSize = true;
            this.radioSmall.Location = new System.Drawing.Point(7, 20);
            this.radioSmall.Name = "radioSmall";
            this.radioSmall.Size = new System.Drawing.Size(50, 17);
            this.radioSmall.TabIndex = 0;
            this.radioSmall.TabStop = true;
            this.radioSmall.Text = "Small";
            this.radioSmall.UseVisualStyleBackColor = true;
            // 
            // GroupBoxToppings
            // 
            this.GroupBoxToppings.Controls.Add(this.checkMushrooms);
            this.GroupBoxToppings.Controls.Add(this.checkSpinach);
            this.GroupBoxToppings.Controls.Add(this.checkOnion);
            this.GroupBoxToppings.Controls.Add(this.checkSausage);
            this.GroupBoxToppings.Controls.Add(this.checkPepperoni);
            this.GroupBoxToppings.Location = new System.Drawing.Point(16, 87);
            this.GroupBoxToppings.Name = "GroupBoxToppings";
            this.GroupBoxToppings.Size = new System.Drawing.Size(186, 135);
            this.GroupBoxToppings.TabIndex = 2;
            this.GroupBoxToppings.TabStop = false;
            this.GroupBoxToppings.Text = "Topings ($.50ea)";
            // 
            // checkMushrooms
            // 
            this.checkMushrooms.AutoSize = true;
            this.checkMushrooms.Location = new System.Drawing.Point(6, 112);
            this.checkMushrooms.Name = "checkMushrooms";
            this.checkMushrooms.Size = new System.Drawing.Size(80, 17);
            this.checkMushrooms.TabIndex = 4;
            this.checkMushrooms.Text = "Mushrooms";
            this.checkMushrooms.UseVisualStyleBackColor = true;
            // 
            // checkSpinach
            // 
            this.checkSpinach.AutoSize = true;
            this.checkSpinach.Location = new System.Drawing.Point(6, 89);
            this.checkSpinach.Name = "checkSpinach";
            this.checkSpinach.Size = new System.Drawing.Size(65, 17);
            this.checkSpinach.TabIndex = 3;
            this.checkSpinach.Text = "Spinach";
            this.checkSpinach.UseVisualStyleBackColor = true;
            // 
            // checkOnion
            // 
            this.checkOnion.AutoSize = true;
            this.checkOnion.Location = new System.Drawing.Point(6, 66);
            this.checkOnion.Name = "checkOnion";
            this.checkOnion.Size = new System.Drawing.Size(54, 17);
            this.checkOnion.TabIndex = 2;
            this.checkOnion.Text = "Onion";
            this.checkOnion.UseVisualStyleBackColor = true;
            // 
            // checkSausage
            // 
            this.checkSausage.AutoSize = true;
            this.checkSausage.Location = new System.Drawing.Point(6, 43);
            this.checkSausage.Name = "checkSausage";
            this.checkSausage.Size = new System.Drawing.Size(68, 17);
            this.checkSausage.TabIndex = 1;
            this.checkSausage.Text = "Sausage";
            this.checkSausage.UseVisualStyleBackColor = true;
            // 
            // checkPepperoni
            // 
            this.checkPepperoni.AutoSize = true;
            this.checkPepperoni.Location = new System.Drawing.Point(7, 20);
            this.checkPepperoni.Name = "checkPepperoni";
            this.checkPepperoni.Size = new System.Drawing.Size(74, 17);
            this.checkPepperoni.TabIndex = 0;
            this.checkPepperoni.Text = "Pepperoni";
            this.checkPepperoni.UseVisualStyleBackColor = true;
            // 
            // numericUpDownBreadsticks
            // 
            this.numericUpDownBreadsticks.Location = new System.Drawing.Point(318, 38);
            this.numericUpDownBreadsticks.Name = "numericUpDownBreadsticks";
            this.numericUpDownBreadsticks.Size = new System.Drawing.Size(37, 20);
            this.numericUpDownBreadsticks.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Breadsticks ($.50ea)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cheesesticks ($1ea)";
            // 
            // numericUpDownCheesesticks
            // 
            this.numericUpDownCheesesticks.Location = new System.Drawing.Point(318, 64);
            this.numericUpDownCheesesticks.Name = "numericUpDownCheesesticks";
            this.numericUpDownCheesesticks.Size = new System.Drawing.Size(37, 20);
            this.numericUpDownCheesesticks.TabIndex = 5;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(211, 130);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(144, 20);
            this.textBoxName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Name:";
            // 
            // buttonOrder
            // 
            this.buttonOrder.Location = new System.Drawing.Point(211, 153);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(144, 40);
            this.buttonOrder.TabIndex = 9;
            this.buttonOrder.Text = "Place order";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "created by Fabio Gottlicher";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 231);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownCheesesticks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownBreadsticks);
            this.Controls.Add(this.GroupBoxToppings);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pizza order form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GroupBoxToppings.ResumeLayout(false);
            this.GroupBoxToppings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBreadsticks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCheesesticks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox GroupBoxToppings;
        private System.Windows.Forms.NumericUpDown numericUpDownBreadsticks;
        private System.Windows.Forms.RadioButton radioLarge;
        private System.Windows.Forms.RadioButton radioMedium;
        private System.Windows.Forms.RadioButton radioSmall;
        private System.Windows.Forms.CheckBox checkMushrooms;
        private System.Windows.Forms.CheckBox checkSpinach;
        private System.Windows.Forms.CheckBox checkOnion;
        private System.Windows.Forms.CheckBox checkSausage;
        private System.Windows.Forms.CheckBox checkPepperoni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownCheesesticks;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Label label5;
    }
}

