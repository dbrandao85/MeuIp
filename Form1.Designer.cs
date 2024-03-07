namespace MeuIp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnSerch = new Button();
            txtBoxResult = new RichTextBox();
            SuspendLayout();
            // 
            // btnSerch
            // 
            btnSerch.Location = new Point(30, 27);
            btnSerch.Name = "btnSerch";
            btnSerch.Size = new Size(172, 47);
            btnSerch.TabIndex = 0;
            btnSerch.Text = "Pesquisar IPs";
            btnSerch.UseVisualStyleBackColor = true;
            btnSerch.Click += btnSerch_Click;
            // 
            // txtBoxResult
            // 
            txtBoxResult.Location = new Point(30, 119);
            txtBoxResult.Name = "txtBoxResult";
            txtBoxResult.ReadOnly = true;
            txtBoxResult.Size = new Size(426, 302);
            txtBoxResult.TabIndex = 1;
            txtBoxResult.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 450);
            Controls.Add(txtBoxResult);
            Controls.Add(btnSerch);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "MeuIP";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSerch;
        private RichTextBox txtBoxResult;
    }
}
