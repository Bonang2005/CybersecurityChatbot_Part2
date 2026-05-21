namespace CybersecurityChatbot_GUI
{
    // This class handles the GUI and user interaction
    public partial class Form1 : Form
    {
        // User profile to track session info
        private UserProfile user;

        public Form1()
        {
            InitializeComponent();
        }

        // This runs when the form loads
        private void Form1_Load(object sender, EventArgs e)
        {
            // Play voice greeting
            AudioPlayer.PlayGreeting();

            // Show ASCII art logo in chat box
            ChatBox.AppendText("  ╔══════════════════════════════════════════╗\n");
            ChatBox.AppendText("  ║    CYBERSECURITY AWARENESS CHATBOT      ║\n");
            ChatBox.AppendText("  ║        Keeping You Safe Online          ║\n");
            ChatBox.AppendText("  ╚══════════════════════════════════════════╝\n\n");

            // Ask for the user's name
            string name = Microsoft.VisualBasic.Interaction.InputBox(
                "Welcome! What is your name?",
                "Cybersecurity Chatbot",
                "");

            // Validate name
            if (string.IsNullOrWhiteSpace(name))
                name = "User";

            // String manipulation - capitalise first letter
            name = char.ToUpper(name[0]) + name.Substring(1).ToLower();

            // Create user profile
            user = new UserProfile(name);

            // Show welcome message
            ChatBox.AppendText("  Welcome, " + user.Name + "!\n");
            ChatBox.AppendText("  Type 'help' to see what I can do.\n");
            ChatBox.AppendText("  Type 'bye' to exit.\n\n");
        }

        // This runs when the Send button is clicked
        private void sendButton_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        // This runs when Enter is pressed in the input box
        private void inputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendMessage();
            }
        }

        // This method sends the message and displays the response
        private void SendMessage()
        {
            string input = InputBox.Text.Trim();

            // Validation
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Please type a message first!");
                return;
            }

            // Show user message in yellow
            ChatBox.SelectionColor = Color.Yellow;
            ChatBox.AppendText("  " + user.Name + ": " + input + "\n");

            // Get response from chatbot
            string response = ChatBot.GetResponse(input, user);

            // Show bot response in cyan
            ChatBox.SelectionColor = Color.Cyan;
            ChatBox.AppendText("  [BOT]: " + response + "\n\n");

            // Clear input box
            InputBox.Text = "";

            // Check if user said bye
            if (input.ToLower() == "bye" || input.ToLower() == "exit")
            {
                MessageBox.Show("Session Summary:\n\nName: " + user.Name +
                              "\nMessages Sent: " + user.MessageCount +
                              "\nFavourite Topic: " + user.FavouriteTopic);
                Application.Exit();
            }
        }
    }
}