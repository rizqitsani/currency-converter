
namespace CurrencyConverter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.inputBoxLabel = new System.Windows.Forms.Label();
            this.usdRadioButton = new System.Windows.Forms.RadioButton();
            this.eurRadioButton = new System.Windows.Forms.RadioButton();
            this.radioButtonLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.outputBoxLabel = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(229, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Currency Converter";
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(59, 171);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(249, 27);
            this.inputBox.TabIndex = 1;
            // 
            // inputBoxLabel
            // 
            this.inputBoxLabel.AutoSize = true;
            this.inputBoxLabel.Location = new System.Drawing.Point(59, 148);
            this.inputBoxLabel.Name = "inputBoxLabel";
            this.inputBoxLabel.Size = new System.Drawing.Size(33, 20);
            this.inputBoxLabel.TabIndex = 2;
            this.inputBoxLabel.Text = "IDR";
            // 
            // usdRadioButton
            // 
            this.usdRadioButton.AutoSize = true;
            this.usdRadioButton.Location = new System.Drawing.Point(59, 241);
            this.usdRadioButton.Name = "usdRadioButton";
            this.usdRadioButton.Size = new System.Drawing.Size(59, 24);
            this.usdRadioButton.TabIndex = 3;
            this.usdRadioButton.TabStop = true;
            this.usdRadioButton.Text = "USD";
            this.usdRadioButton.UseVisualStyleBackColor = true;
            // 
            // eurRadioButton
            // 
            this.eurRadioButton.AutoSize = true;
            this.eurRadioButton.Location = new System.Drawing.Point(59, 271);
            this.eurRadioButton.Name = "eurRadioButton";
            this.eurRadioButton.Size = new System.Drawing.Size(57, 24);
            this.eurRadioButton.TabIndex = 4;
            this.eurRadioButton.TabStop = true;
            this.eurRadioButton.Text = "EUR";
            this.eurRadioButton.UseVisualStyleBackColor = true;
            // 
            // radioButtonLabel
            // 
            this.radioButtonLabel.AutoSize = true;
            this.radioButtonLabel.Location = new System.Drawing.Point(59, 218);
            this.radioButtonLabel.Name = "radioButtonLabel";
            this.radioButtonLabel.Size = new System.Drawing.Size(55, 20);
            this.radioButtonLabel.TabIndex = 5;
            this.radioButtonLabel.Text = "Option";
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(364, 171);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(94, 29);
            this.convertButton.TabIndex = 6;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // outputBoxLabel
            // 
            this.outputBoxLabel.AutoSize = true;
            this.outputBoxLabel.Location = new System.Drawing.Point(500, 148);
            this.outputBoxLabel.Name = "outputBoxLabel";
            this.outputBoxLabel.Size = new System.Drawing.Size(49, 20);
            this.outputBoxLabel.TabIndex = 8;
            this.outputBoxLabel.Text = "Result";
            // 
            // outputBox
            // 
            this.outputBox.Enabled = false;
            this.outputBox.Location = new System.Drawing.Point(500, 171);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(249, 27);
            this.outputBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputBoxLabel);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.radioButtonLabel);
            this.Controls.Add(this.eurRadioButton);
            this.Controls.Add(this.usdRadioButton);
            this.Controls.Add(this.inputBoxLabel);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Currency Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label inputBoxLabel;
        private System.Windows.Forms.RadioButton usdRadioButton;
        private System.Windows.Forms.RadioButton eurRadioButton;
        private System.Windows.Forms.Label radioButtonLabel;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label outputBoxLabel;
        private System.Windows.Forms.TextBox outputBox;
    }
}

