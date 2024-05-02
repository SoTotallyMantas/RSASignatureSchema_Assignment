namespace RSACertificate_Server
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
            StartServer = new Button();
            Signaturetextbox = new TextBox();
            Messagerichbox = new RichTextBox();
            Exponenttextbox = new TextBox();
            Modulustextbox = new TextBox();
            Messagelabel = new Label();
            Signaturelabel = new Label();
            Exponentlabel = new Label();
            Moduluslabel = new Label();
            button1 = new Button();
            Qprime = new TextBox();
            Pprime = new TextBox();
            label1 = new Label();
            label2 = new Label();
            CheckSignature = new Button();
            NewSignature = new Button();
            SendData = new Button();
            SuspendLayout();
            // 
            // StartServer
            // 
            StartServer.Location = new Point(25, 395);
            StartServer.Name = "StartServer";
            StartServer.Size = new Size(75, 23);
            StartServer.TabIndex = 0;
            StartServer.Text = "Start Server";
            StartServer.UseVisualStyleBackColor = true;
            StartServer.Click += StartServer_Click;
            // 
            // Signaturetextbox
            // 
            Signaturetextbox.Location = new Point(391, 57);
            Signaturetextbox.Name = "Signaturetextbox";
            Signaturetextbox.Size = new Size(100, 23);
            Signaturetextbox.TabIndex = 1;
            // 
            // Messagerichbox
            // 
            Messagerichbox.Location = new Point(12, 33);
            Messagerichbox.Name = "Messagerichbox";
            Messagerichbox.Size = new Size(340, 356);
            Messagerichbox.TabIndex = 2;
            Messagerichbox.Text = "";
            // 
            // Exponenttextbox
            // 
            Exponenttextbox.Location = new Point(391, 110);
            Exponenttextbox.Name = "Exponenttextbox";
            Exponenttextbox.Size = new Size(100, 23);
            Exponenttextbox.TabIndex = 3;
            // 
            // Modulustextbox
            // 
            Modulustextbox.Location = new Point(391, 160);
            Modulustextbox.Name = "Modulustextbox";
            Modulustextbox.Size = new Size(100, 23);
            Modulustextbox.TabIndex = 4;
            // 
            // Messagelabel
            // 
            Messagelabel.AutoSize = true;
            Messagelabel.Location = new Point(12, 9);
            Messagelabel.Name = "Messagelabel";
            Messagelabel.Size = new Size(53, 15);
            Messagelabel.TabIndex = 5;
            Messagelabel.Text = "Message";
            // 
            // Signaturelabel
            // 
            Signaturelabel.AutoSize = true;
            Signaturelabel.Location = new Point(391, 36);
            Signaturelabel.Name = "Signaturelabel";
            Signaturelabel.Size = new Size(57, 15);
            Signaturelabel.TabIndex = 6;
            Signaturelabel.Text = "Signature";
            // 
            // Exponentlabel
            // 
            Exponentlabel.AutoSize = true;
            Exponentlabel.Location = new Point(391, 92);
            Exponentlabel.Name = "Exponentlabel";
            Exponentlabel.Size = new Size(57, 15);
            Exponentlabel.TabIndex = 7;
            Exponentlabel.Text = "Exponent";
            // 
            // Moduluslabel
            // 
            Moduluslabel.AutoSize = true;
            Moduluslabel.Location = new Point(391, 142);
            Moduluslabel.Name = "Moduluslabel";
            Moduluslabel.Size = new Size(54, 15);
            Moduluslabel.TabIndex = 8;
            Moduluslabel.Text = "Modulus";
            // 
            // button1
            // 
            button1.Location = new Point(631, 366);
            button1.Name = "button1";
            button1.Size = new Size(157, 23);
            button1.TabIndex = 9;
            button1.Text = "GeneratePrimes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Qprime
            // 
            Qprime.Location = new Point(631, 337);
            Qprime.Name = "Qprime";
            Qprime.Size = new Size(157, 23);
            Qprime.TabIndex = 10;
            // 
            // Pprime
            // 
            Pprime.Location = new Point(631, 293);
            Pprime.Name = "Pprime";
            Pprime.Size = new Size(157, 23);
            Pprime.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(631, 319);
            label1.Name = "label1";
            label1.Size = new Size(16, 15);
            label1.TabIndex = 12;
            label1.Text = "Q";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(631, 275);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 13;
            label2.Text = "P";
            // 
            // CheckSignature
            // 
            CheckSignature.Location = new Point(193, 395);
            CheckSignature.Name = "CheckSignature";
            CheckSignature.Size = new Size(159, 23);
            CheckSignature.TabIndex = 14;
            CheckSignature.Text = "Check Signature";
            CheckSignature.UseVisualStyleBackColor = true;
            CheckSignature.Click += CheckSignature_Click;
            // 
            // NewSignature
            // 
            NewSignature.Location = new Point(633, 399);
            NewSignature.Name = "NewSignature";
            NewSignature.Size = new Size(155, 23);
            NewSignature.TabIndex = 15;
            NewSignature.Text = "OverWrite Signature";
            NewSignature.UseVisualStyleBackColor = true;
            NewSignature.Click += NewSignature_Click;
            // 
            // SendData
            // 
            SendData.Location = new Point(106, 395);
            SendData.Name = "SendData";
            SendData.Size = new Size(75, 23);
            SendData.TabIndex = 16;
            SendData.Text = "Send Data";
            SendData.UseVisualStyleBackColor = true;
            SendData.Click += SendData_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SendData);
            Controls.Add(NewSignature);
            Controls.Add(CheckSignature);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Pprime);
            Controls.Add(Qprime);
            Controls.Add(button1);
            Controls.Add(Moduluslabel);
            Controls.Add(Exponentlabel);
            Controls.Add(Signaturelabel);
            Controls.Add(Messagelabel);
            Controls.Add(Modulustextbox);
            Controls.Add(Exponenttextbox);
            Controls.Add(Messagerichbox);
            Controls.Add(Signaturetextbox);
            Controls.Add(StartServer);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartServer;
        private TextBox Signaturetextbox;
        private RichTextBox Messagerichbox;
        private TextBox Exponenttextbox;
        private TextBox Modulustextbox;
        private Label Messagelabel;
        private Label Signaturelabel;
        private Label Exponentlabel;
        private Label Moduluslabel;
        private Button button1;
        private TextBox Qprime;
        private TextBox Pprime;
        private Label label1;
        private Label label2;
        private Button CheckSignature;
        private Button NewSignature;
        private Button SendData;

        public TextBox Signaturetextbox1 { get => Signaturetextbox; set => Signaturetextbox = value; }
        public RichTextBox Messagerichbox1 { get => Messagerichbox; set => Messagerichbox = value; }
        public TextBox Exponenttextbox1 { get => Exponenttextbox; set => Exponenttextbox = value; }
        public TextBox Modulustextbox1 { get => Modulustextbox; set => Modulustextbox = value; }
    }
}