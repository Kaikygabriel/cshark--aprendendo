namespace Soporfazer
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            NomeP = new TextBox();
            MarcaP = new TextBox();
            button1 = new Button();
            label3 = new Label();
            Aparecer = new ListBox();
            Sair = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome do produto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 109);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 1;
            label2.Text = "marca do produto";
            label2.Click += label2_Click;
            // 
            // NomeP
            // 
            NomeP.Location = new Point(15, 60);
            NomeP.Name = "NomeP";
            NomeP.Size = new Size(271, 23);
            NomeP.TabIndex = 2;
            // 
            // MarcaP
            // 
            MarcaP.Location = new Point(15, 140);
            MarcaP.Name = "MarcaP";
            MarcaP.Size = new Size(271, 23);
            MarcaP.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(15, 194);
            button1.Name = "button1";
            button1.Size = new Size(271, 23);
            button1.TabIndex = 4;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(559, 49);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 5;
            // 
            // Aparecer
            // 
            Aparecer.FormattingEnabled = true;
            Aparecer.Location = new Point(351, 57);
            Aparecer.Name = "Aparecer";
            Aparecer.Size = new Size(409, 169);
            Aparecer.TabIndex = 6;
            // 
            // Sair
            // 
            Sair.Location = new Point(12, 401);
            Sair.Name = "Sair";
            Sair.Size = new Size(80, 37);
            Sair.TabIndex = 7;
            Sair.Text = "Sair";
            Sair.UseVisualStyleBackColor = true;
            Sair.Visible = false;
            Sair.Click += Sair_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Sair);
            Controls.Add(Aparecer);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(MarcaP);
            Controls.Add(NomeP);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox NomeP;
        private TextBox MarcaP;
        private Button button1;
        private Label label3;
        private ListBox Aparecer;
        private Button Sair;
    }
}