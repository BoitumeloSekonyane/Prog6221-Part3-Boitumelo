using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CyberCrimeFightingBotPart2GUI
{
    public partial class Form1 : Form
    {
        private Chatbot bot;
        private User currentUser;

        //This is to create a new instance of the QuizManager class, which will be used to manage the quiz questions and answers.
        private QuizManager quizManager;
        private int currentQuestionIndex = 0;
        private int score = 0;

        //This is to create a new instance of the DatabaseHelper class, which will be used to interact with the database.
        private DatabaseHelper db = new DatabaseHelper();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstTopics.Items.Add("my purpose");
            lstTopics.Items.Add("Password Safety");
            lstTopics.Items.Add("Phishing");
            lstTopics.Items.Add("Privacy");
            lstTopics.Items.Add("Scams");
            lstTopics.Items.Add("Safe Browsing");
            lstTopics.Items.Add("Social Engineering");

            txtChat.AppendText("BOT: Welcome to the CyberCrime Fighting Bot!\r\n");
            txtChat.AppendText("BOT: Please enter your name and press Start to launch the program.\r\n");

            //This is placed here to play the welcome sound when the form loads
            try
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("welcome.wav");
                player.Play();
            }
            catch
            {
                MessageBox.Show("Sound file could not play.");
            }

            //QUIZ MANAGER
            quizManager = new QuizManager();

            tabControl1.Visible = false;
        }

        // This is to activate the Start button
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter your name.");
                return;
            }

            currentUser = new User(txtName.Text);
            bot = new Chatbot(currentUser);

            lblAscii.Text = bot.GetAsciiArt();

            txtChat.AppendText("BOT: Welcome " + currentUser.Name + "!\r\n");
            txtChat.AppendText("BOT: Ask me anything about cybersecurity.\r\n");

            //Playing my information sound when the user presses Start, this will assist the user in understanding how to use the program and what it is about.
            bot.PlayVoiceGreeting("information.wav");

             tabControl1.Visible = true;
             pnLogin.Visible = false;

        }

        // This is to activate the Send button
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMessage.Text))
            {
                return;
            }

            string userMessage = txtMessage.Text;

            txtChat.SelectionColor = Color.Yellow;
            txtChat.AppendText(currentUser.Name + ": " + userMessage + "\r\n");

            string response = bot.RespondToUserInput(userMessage);

            txtChat.AppendText("BOT: " + response + "\r\n\r\n");

            txtMessage.Clear();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSend_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dtpReminder_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnViewTasks_Click(object sender, EventArgs e)
        {
            dgvTasks.Rows.Clear();

            DataTable table = db.GetTasks();

            foreach (DataRow row in table.Rows)
            {
                bool isCompleted = row["Status"].ToString() == "Completed";

                dgvTasks.Rows.Add(
                    row["TaskID"],
                    row["Title"],
                    row["Description"],
                    row["ReminderDate"],
                    isCompleted
                );
            }
        }

        private void btnCompleteTask_Click(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a task first.");
                return;
            }

            int id = Convert.ToInt32(dgvTasks.SelectedRows[0].Cells["TaskID"].Value);

            db.CompleteTask(id);

            MessageBox.Show("Task marked as completed.");

            btnViewTasks_Click(sender, e);
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a task first.");
                return;
            }

            int id = Convert.ToInt32(dgvTasks.SelectedRows[0].Cells["TaskID"].Value);

            db.DeleteTask(id);

            MessageBox.Show("Task deleted.");

            btnViewTasks_Click(sender, e);
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTaskTitle.Text))
            {
                MessageBox.Show("Please enter a task title.");
                return;
            }

            TaskItem task = new TaskItem();

            task.Title = txtTaskTitle.Text;
            task.Description = txtTaskDescription.Text;
            task.ReminderDate = dtpReminder.Value;
            task.Status = "Pending";

            db.AddTask(task);

            MessageBox.Show("Task added successfully!");

            txtTaskTitle.Clear();
            txtTaskDescription.Clear();
        }

        private void DisplayQuestion()
        {

            MessageBox.Show("Displaying Question " + (currentQuestionIndex + 1));

            QuizQuestions q = quizManager.Questions[currentQuestionIndex];

            lblQuestion.Text = q.Question;

            btnA.Text = "A. " + q.OptionA;
            btnB.Text = "B. " + q.OptionB;
            btnC.Text = "C. " + q.OptionC;
            btnD.Text = "D. " + q.OptionD;

            //This is to hide the "True" or "False" empty options of "C" and "D" 
            btnC.Visible = !string.IsNullOrEmpty(q.OptionC);
            btnD.Visible = !string.IsNullOrEmpty(q.OptionD);

            btnC.Enabled = btnC.Visible;
            btnD.Enabled = btnD.Visible;

            //This is to display the current question number and the total number of questions in the quiz.
            lblQuestionNumber.Text =
                "Question " +
                (currentQuestionIndex + 1) +
                    " of " +
                quizManager.Questions.Count;



        }
        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            score = 0;
            currentQuestionIndex = 0;
            lblScore.Text = "Score: 0";
            DisplayQuestion();
            MessageBox.Show("Quiz Started!");
        }

        private void CheckAnswer(string selectedOption)
            {

            QuizQuestions q = quizManager.Questions[currentQuestionIndex];

            if (selectedOption == q.CorrectAnswer)
            {
                score++;
                lblFeedback.ForeColor = Color.Lime;
                lblFeedback.Text =
                    "✔ Correct!\n" +
                    q.Explanation;
            }
            else
            {
                lblFeedback.ForeColor = Color.Red;
                lblFeedback.Text =
                    "✘ Incorrect.\n" +
                    q.Explanation;
            }

            currentQuestionIndex++;

            lblScore.Text = "Score: " + score;

            if (currentQuestionIndex < quizManager.Questions.Count)
            {
                DisplayQuestion();
            }
            else
            {
                //This is to calculate the percentage score of the quiz by dividing the user's score by the total number of questions and multiplying by 100. The result is then displayed in a message box along with the user's score and the total number of questions.
                double percentage =
                 (double)score / quizManager.Questions.Count * 100;

                MessageBox.Show(
                "Quiz Completed!\n\n" +
                "Score: " + score +
                " / " + quizManager.Questions.Count +
                "\nPercentage: " +
                percentage.ToString("0") +
                "%");

            }

        }

        private void btnA_Click(object sender, EventArgs e)
        {
            CheckAnswer("A");
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            CheckAnswer("B");
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            CheckAnswer("C");
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            CheckAnswer("D");
        }

        //This is to handle the event when a cell value in the DataGridView is changed. It checks if the changed cell is in the "Completed" column, and if so, it retrieves the task ID and the new completion status. If the task is marked as completed, it calls the CompleteTask method from the DatabaseHelper class to update the task's status in the database.
        private void dgvTasks_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvTasks.Columns[e.ColumnIndex].Name == "Completed")
            {
                int id = Convert.ToInt32(dgvTasks.Rows[e.RowIndex].Cells["TaskID"].Value);
                bool done = (bool)dgvTasks.Rows[e.RowIndex].Cells["Completed"].Value;

                if (done)
                {
                    db.CompleteTask(id);
                }
            }
        }

        //This is to ensure that the changes made in the DataGridView are committed immediately when the user checks or unchecks the "Completed" checkbox. Without this, the change might not be registered until the cell loses focus, which could lead to confusion or errors in updating the task status.
        private void dgvTasks_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvTasks.IsCurrentCellDirty)
            {
                dgvTasks.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void btnRestartQuiz_Click(object sender, EventArgs e)
        {
            score = 0;
            currentQuestionIndex = 0;

            lblScore.Text = "Score: 0";
            lblFeedback.Text = "";

            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;

            DisplayQuestion();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
