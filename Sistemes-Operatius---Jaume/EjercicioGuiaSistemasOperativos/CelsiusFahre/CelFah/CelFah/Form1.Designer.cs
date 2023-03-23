namespace CelFah
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.fatocebutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.celciusBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fahrenheitBox = new System.Windows.Forms.TextBox();
            this.cetofabutton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Convert celsius to fahrenheit";
            // 
            // fatocebutton
            // 
            this.fatocebutton.Location = new System.Drawing.Point(435, 211);
            this.fatocebutton.Name = "fatocebutton";
            this.fatocebutton.Size = new System.Drawing.Size(160, 23);
            this.fatocebutton.TabIndex = 3;
            this.fatocebutton.Text = "Fahrenheit to Celsius";
            this.fatocebutton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Convert fahrenheit to celsius";
            // 
            // celciusBox
            // 
            this.celciusBox.Location = new System.Drawing.Point(96, 80);
            this.celciusBox.Name = "celciusBox";
            this.celciusBox.Size = new System.Drawing.Size(100, 22);
            this.celciusBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Celsius";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fahrenheit";
            // 
            // fahrenheitBox
            // 
            this.fahrenheitBox.Location = new System.Drawing.Point(96, 212);
            this.fahrenheitBox.Name = "fahrenheitBox";
            this.fahrenheitBox.Size = new System.Drawing.Size(100, 22);
            this.fahrenheitBox.TabIndex = 6;
            // 
            // cetofabutton
            // 
            this.cetofabutton.Location = new System.Drawing.Point(435, 79);
            this.cetofabutton.Name = "cetofabutton";
            this.cetofabutton.Size = new System.Drawing.Size(160, 23);
            this.cetofabutton.TabIndex = 8;
            this.cetofabutton.Text = "Celsius to Fahrenheit";
            this.cetofabutton.UseVisualStyleBackColor = true;
            this.cetofabutton.Click += new System.EventHandler(this.cetofabutton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(121, 315);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 9;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // disconnectButton
            // 
            this.disconnectButton.Location = new System.Drawing.Point(257, 315);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(122, 23);
            this.disconnectButton.TabIndex = 10;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.cetofabutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fahrenheitBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.celciusBox);
            this.Controls.Add(this.fatocebutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button fatocebutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox celciusBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fahrenheitBox;
        private System.Windows.Forms.Button cetofabutton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button disconnectButton;
    }
}

