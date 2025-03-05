namespace Soporfazer
{
    partial class Form3
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
            button1 = new Button();
            Ver = new Button();
            Ver2 = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(302, 360);
            button1.Name = "button1";
            button1.Size = new Size(181, 69);
            button1.TabIndex = 1;
            button1.Text = "Sair";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Ver
            // 
            Ver.Location = new Point(313, 198);
            Ver.Name = "Ver";
            Ver.Size = new Size(170, 83);
            Ver.TabIndex = 4;
            Ver.Text = "ver";
            Ver.UseVisualStyleBackColor = true;
            Ver.Click += Ver_Click;
            // 
            // Ver2
            // 
            Ver2.FormattingEnabled = true;
            Ver2.Location = new Point(231, 26);
            Ver2.Name = "Ver2";
            Ver2.Size = new Size(343, 154);
            Ver2.TabIndex = 5;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Ver2);
            Controls.Add(Ver);
            Controls.Add(button1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button Ver;
        public ListBox Ver2;
    }
}