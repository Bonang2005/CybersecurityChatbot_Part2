namespace CybersecurityChatbot_GUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            ChatBox = new RichTextBox();
            SendButton = new Button();
            InputBox = new TextBox();
            SuspendLayout();

            // ChatBox
            ChatBox.BackColor = Color.Black;
            ChatBox.ForeColor = Color.Cyan;
            ChatBox.Location = new Point(12, 12);
            ChatBox.Name = "ChatBox";
            ChatBox.ReadOnly = true;
            ChatBox.Size = new Size(752, 300);
            ChatBox.TabIndex = 0;
            ChatBox.Text = "";

            // SendButton
            SendButton.BackColor = Color.Cyan;
            SendButton.ForeColor = Color.Black;
            SendButton.Location = new Point(600, 346);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(100, 30);
            SendButton.TabIndex = 1;
            SendButton.Text = "Send";
            SendButton.UseVisualStyleBackColor = false;
            SendButton.Click += sendButton_Click;

            // InputBox
            InputBox.BackColor = Color.Black;
            InputBox.ForeColor = Color.White;
            InputBox.Location = new Point(12, 347);
            InputBox.Name = "InputBox";
            InputBox.Size = new Size(570, 30);
            InputBox.TabIndex = 2;
            InputBox.KeyPress += inputBox_KeyPress;

            // Form1
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(InputBox);
            Controls.Add(SendButton);
            Controls.Add(ChatBox);
            Name = "Form1";
            Text = "Cybersecurity Awareness Bot";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private RichTextBox ChatBox;
        private Button SendButton;
        private TextBox InputBox;
    }
}
