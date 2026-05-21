namespace CybersecurityChatbot_GUI
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
            ChatBox = new RichTextBox();
            SendButton = new Button();
            InputBox = new TextBox();
            SuspendLayout();
            // 
            // ChatBox
            // 
            ChatBox.BackColor = SystemColors.ActiveCaptionText;
            ChatBox.ForeColor = Color.Cyan;
            ChatBox.Location = new Point(12, 12);
            ChatBox.Name = "ChatBox";
            ChatBox.ReadOnly = true;
            ChatBox.Size = new Size(752, 263);
            ChatBox.TabIndex = 0;
            ChatBox.Text = "";
       
            // 
            // SendButton
            // 
            SendButton.BackColor = Color.Cyan;
            SendButton.Location = new Point(497, 346);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(191, 23);
            SendButton.TabIndex = 1;
            SendButton.Text = "Send";
            SendButton.UseVisualStyleBackColor = false;
           
            // 
            // InputBox
            // 
            InputBox.BackColor = SystemColors.InfoText;
            InputBox.ForeColor = SystemColors.ButtonHighlight;
            InputBox.Location = new Point(34, 347);
            InputBox.Name = "InputBox";
            InputBox.Size = new Size(341, 23);
            InputBox.TabIndex = 2;
            
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(800, 450);
            Controls.Add(InputBox);
            Controls.Add(SendButton);
            Controls.Add(ChatBox);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Cybersecurity Awareness Bot";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox ChatBox;
        private Button SendButton;
        private TextBox InputBox;
    }
}
