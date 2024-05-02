namespace RSACertificateEndpoint
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
            Messagerichbox = new RichTextBox();
            label1 = new Label();
            Signaturetextbox = new TextBox();
            Exponenttextbox = new TextBox();
            Modulustextbox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ReceiveData = new Button();
            CheckSignature = new Button();
            SuspendLayout();
            // 
            // Messagerichbox
            // 
            Messagerichbox.Location = new Point(12, 27);
            Messagerichbox.Name = "Messagerichbox";
            Messagerichbox.Size = new Size(344, 322);
            Messagerichbox.TabIndex = 0;
            Messagerichbox.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 1;
            label1.Text = "Message";
            // 
            // Signaturetextbox
            // 
            Signaturetextbox.Location = new Point(362, 41);
            Signaturetextbox.Name = "Signaturetextbox";
            Signaturetextbox.Size = new Size(100, 23);
            Signaturetextbox.TabIndex = 2;
            // 
            // Exponenttextbox
            // 
            Exponenttextbox.Location = new Point(362, 85);
            Exponenttextbox.Name = "Exponenttextbox";
            Exponenttextbox.Size = new Size(100, 23);
            Exponenttextbox.TabIndex = 3;
            // 
            // Modulustextbox
            // 
            Modulustextbox.Location = new Point(362, 129);
            Modulustextbox.Name = "Modulustextbox";
            Modulustextbox.Size = new Size(100, 23);
            Modulustextbox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(362, 23);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 5;
            label2.Text = "Signature";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(362, 67);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 6;
            label3.Text = "Exponent";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(362, 111);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 7;
            label4.Text = "Modulus";
            // 
            // ReceiveData
            // 
            ReceiveData.Location = new Point(12, 415);
            ReceiveData.Name = "ReceiveData";
            ReceiveData.Size = new Size(136, 23);
            ReceiveData.TabIndex = 8;
            ReceiveData.Text = "Receive Data";
            ReceiveData.UseVisualStyleBackColor = true;
            ReceiveData.Click += ReceiveData_Click;
            // 
            // CheckSignature
            // 
            CheckSignature.Location = new Point(191, 415);
            CheckSignature.Name = "CheckSignature";
            CheckSignature.Size = new Size(165, 23);
            CheckSignature.TabIndex = 9;
            CheckSignature.Text = "Check Signature";
            CheckSignature.UseVisualStyleBackColor = true;
            CheckSignature.Click += CheckSignature_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CheckSignature);
            Controls.Add(ReceiveData);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Modulustextbox);
            Controls.Add(Exponenttextbox);
            Controls.Add(Signaturetextbox);
            Controls.Add(label1);
            Controls.Add(Messagerichbox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox Messagerichbox;
        private Label label1;
        private TextBox Signaturetextbox;
        private TextBox Exponenttextbox;
        private TextBox Modulustextbox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button ReceiveData;
        private Button CheckSignature;

        public RichTextBox Messagerichbox1 { get => Messagerichbox; set => Messagerichbox = value; }
        public TextBox Signaturetextbox1 { get => Signaturetextbox; set => Signaturetextbox = value; }
        public TextBox Exponenttextbox1 { get => Exponenttextbox; set => Exponenttextbox = value; }
        public TextBox Modulustextbox1 { get => Modulustextbox; set => Modulustextbox = value; }
    }
}