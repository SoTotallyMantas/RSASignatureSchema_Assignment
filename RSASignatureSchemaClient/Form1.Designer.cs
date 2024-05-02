namespace RSACertificateClient
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
            SendData = new Button();
            MessageRichBox = new RichTextBox();
            Pprime = new TextBox();
            Qprime = new TextBox();
            GenerateValues = new Button();
            Plabel = new Label();
            Qlabel = new Label();
            Messagelabel = new Label();
            SuspendLayout();
            // 
            // SendData
            // 
            SendData.Location = new Point(21, 408);
            SendData.Name = "SendData";
            SendData.Size = new Size(75, 23);
            SendData.TabIndex = 0;
            SendData.Text = "SendData";
            SendData.UseVisualStyleBackColor = true;
            SendData.Click += SendData_Click;
            // 
            // MessageRichBox
            // 
            MessageRichBox.Location = new Point(21, 22);
            MessageRichBox.Name = "MessageRichBox";
            MessageRichBox.Size = new Size(341, 341);
            MessageRichBox.TabIndex = 1;
            MessageRichBox.Text = "";
            // 
            // Pprime
            // 
            Pprime.Location = new Point(443, 40);
            Pprime.Name = "Pprime";
            Pprime.Size = new Size(100, 23);
            Pprime.TabIndex = 2;
            // 
            // Qprime
            // 
            Qprime.Location = new Point(581, 41);
            Qprime.Name = "Qprime";
            Qprime.Size = new Size(100, 23);
            Qprime.TabIndex = 3;
            // 
            // GenerateValues
            // 
            GenerateValues.Location = new Point(443, 91);
            GenerateValues.Name = "GenerateValues";
            GenerateValues.Size = new Size(238, 23);
            GenerateValues.TabIndex = 4;
            GenerateValues.Text = "GenerateValues";
            GenerateValues.UseVisualStyleBackColor = true;
            GenerateValues.Click += GenerateValues_Click;
            // 
            // Plabel
            // 
            Plabel.AutoSize = true;
            Plabel.Location = new Point(443, 20);
            Plabel.Name = "Plabel";
            Plabel.Size = new Size(14, 15);
            Plabel.TabIndex = 5;
            Plabel.Text = "P";
            // 
            // Qlabel
            // 
            Qlabel.AutoSize = true;
            Qlabel.Location = new Point(581, 20);
            Qlabel.Name = "Qlabel";
            Qlabel.Size = new Size(16, 15);
            Qlabel.TabIndex = 6;
            Qlabel.Text = "Q";
            // 
            // Messagelabel
            // 
            Messagelabel.AutoSize = true;
            Messagelabel.Location = new Point(26, 4);
            Messagelabel.Name = "Messagelabel";
            Messagelabel.Size = new Size(53, 15);
            Messagelabel.TabIndex = 7;
            Messagelabel.Text = "Message";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Messagelabel);
            Controls.Add(Qlabel);
            Controls.Add(Plabel);
            Controls.Add(GenerateValues);
            Controls.Add(Qprime);
            Controls.Add(Pprime);
            Controls.Add(MessageRichBox);
            Controls.Add(SendData);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SendData;
        private RichTextBox MessageRichBox;
        private TextBox Pprime;
        private TextBox Qprime;
        private Button GenerateValues;
        private Label Plabel;
        private Label Qlabel;
        private Label Messagelabel;
        private Button button1;
    }
}