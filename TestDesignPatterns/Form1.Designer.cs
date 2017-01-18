namespace TestDesignPatterns
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
            this.btnTestStrategyPattern = new System.Windows.Forms.Button();
            this.btnOldWay = new System.Windows.Forms.Button();
            this.btnTestObserverPattern = new System.Windows.Forms.Button();
            this.btnTestProgramToInterfaces = new System.Windows.Forms.Button();
            this.btnTestDecoratorPattern = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTestStrategyPattern
            // 
            this.btnTestStrategyPattern.Location = new System.Drawing.Point(24, 12);
            this.btnTestStrategyPattern.Name = "btnTestStrategyPattern";
            this.btnTestStrategyPattern.Size = new System.Drawing.Size(193, 23);
            this.btnTestStrategyPattern.TabIndex = 0;
            this.btnTestStrategyPattern.Text = "Test Strategy Pattern";
            this.btnTestStrategyPattern.UseVisualStyleBackColor = true;
            this.btnTestStrategyPattern.Click += new System.EventHandler(this.btnTestStrategyPattern_Click);
            // 
            // btnOldWay
            // 
            this.btnOldWay.Location = new System.Drawing.Point(24, 41);
            this.btnOldWay.Name = "btnOldWay";
            this.btnOldWay.Size = new System.Drawing.Size(193, 23);
            this.btnOldWay.TabIndex = 1;
            this.btnOldWay.Text = "Old Way";
            this.btnOldWay.UseVisualStyleBackColor = true;
            this.btnOldWay.Click += new System.EventHandler(this.btnOldWay_Click);
            // 
            // btnTestObserverPattern
            // 
            this.btnTestObserverPattern.Location = new System.Drawing.Point(24, 71);
            this.btnTestObserverPattern.Name = "btnTestObserverPattern";
            this.btnTestObserverPattern.Size = new System.Drawing.Size(193, 23);
            this.btnTestObserverPattern.TabIndex = 2;
            this.btnTestObserverPattern.Text = "Test Observer Pattern";
            this.btnTestObserverPattern.UseVisualStyleBackColor = true;
            this.btnTestObserverPattern.Click += new System.EventHandler(this.btnTestObserverPattern_Click);
            // 
            // btnTestProgramToInterfaces
            // 
            this.btnTestProgramToInterfaces.Location = new System.Drawing.Point(24, 101);
            this.btnTestProgramToInterfaces.Name = "btnTestProgramToInterfaces";
            this.btnTestProgramToInterfaces.Size = new System.Drawing.Size(193, 23);
            this.btnTestProgramToInterfaces.TabIndex = 3;
            this.btnTestProgramToInterfaces.Text = "Test Program to Interfaces";
            this.btnTestProgramToInterfaces.UseVisualStyleBackColor = true;
            this.btnTestProgramToInterfaces.Click += new System.EventHandler(this.btnTestProgramToInterfaces_Click);
            // 
            // btnTestDecoratorPattern
            // 
            this.btnTestDecoratorPattern.Location = new System.Drawing.Point(24, 131);
            this.btnTestDecoratorPattern.Name = "btnTestDecoratorPattern";
            this.btnTestDecoratorPattern.Size = new System.Drawing.Size(193, 23);
            this.btnTestDecoratorPattern.TabIndex = 4;
            this.btnTestDecoratorPattern.Text = "Test Decorator Pattern";
            this.btnTestDecoratorPattern.UseVisualStyleBackColor = true;
            this.btnTestDecoratorPattern.Click += new System.EventHandler(this.btnTestDecoratorPattern_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnTestDecoratorPattern);
            this.Controls.Add(this.btnTestProgramToInterfaces);
            this.Controls.Add(this.btnTestObserverPattern);
            this.Controls.Add(this.btnOldWay);
            this.Controls.Add(this.btnTestStrategyPattern);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTestStrategyPattern;
        private System.Windows.Forms.Button btnOldWay;
        private System.Windows.Forms.Button btnTestObserverPattern;
        private System.Windows.Forms.Button btnTestProgramToInterfaces;
        private System.Windows.Forms.Button btnTestDecoratorPattern;
    }
}

