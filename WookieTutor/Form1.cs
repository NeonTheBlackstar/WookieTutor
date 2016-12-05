using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Media;

namespace WookieTutor
{
    public partial class Form1 : Form
    {
        string filePath = "";
        Dictionary<int, string> prompts;// = new Dictionary<int, string>();
        List<List<string>> data;// = new List<List<string>>();
        int questionSetId = 0;
        int answerId = 0;
        int promptsFirst = 0;
        int gainedPoints = 0;
        float maxPoints = 0;
        List<int> leftToDraw;
        int counter = 1;
        System.Windows.Forms.Timer runonce = new System.Windows.Forms.Timer();
        // Sounds //
        SoundPlayer wookieBad = new SoundPlayer(WookieTutor.Properties.Resources.wookie_bad);
        SoundPlayer wookieGood = new SoundPlayer(WookieTutor.Properties.Resources.wookie_good);

        public Form1()
        {
            InitializeComponent();

            runonce.Interval = 2500;
            runonce.Tick += (sender, args) => { temp(); };
            //runonce.AutoReset = false;
        }

        private void temp()
        {
            pictureBox2.BackgroundImage = global::WookieTutor.Properties.Resources.wookie_normal;
            pictureBox2.Refresh();
            textBox1.Text = String.Empty;
            runonce.Stop();
        }

        private int drawQuestionSet()
        {
            Random rnd = new Random();
            int index = rnd.Next(leftToDraw.Count);
            //leftToDraw.Remove(index);
            int value = leftToDraw[index];
            Console.WriteLine(string.Format("Index: {0}, value: {1}", index, value));
            leftToDraw.RemoveAt(index);
            Console.WriteLine(string.Join(",", leftToDraw));

            return value;
        }

        private void resetTest()
        {
            result_text.Text = String.Empty;
            leftToDraw = Enumerable.Range(0, data.Count()).ToList();
            Console.WriteLine(string.Join(",", leftToDraw));

            answerId = promptsFirst;
            questionSetId = drawQuestionSet();
            gainedPoints = 0;
            counter = 1;

            question_label.Text = String.Format("Question set {0}/{1}", counter, data.Count);
            question_text.Text = String.Format(prompts[answerId], data[questionSetId].ToArray());
            
            answer_butt.Enabled = true;
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //welcomePage//
        }

        private void load_butt_Click(object sender, EventArgs e)
        {
            DialogResult result = loadFile.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                filePath = loadFile.FileName;
                start_butt.Enabled = true;
            }
        }

        private void exit_butt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void start_butt_Click(object sender, EventArgs e)
        {
            prompts = new Dictionary<int, string>();
            data = new List<List<string>>();
            // Load data from file //
            var lines = File.ReadLines(filePath);
            foreach (var line in lines)
            {
                string line_data = line.Replace(Environment.NewLine, "");

                if (line_data[0] == '>')
                {
                    string[] splitted = line_data.Substring(1).Split('#');
                    //MessageBox.Show(string.Join(String.Empty, splitted));

                    prompts.Add(Int32.Parse(splitted[0]), splitted[1]);
                }
                else
                {
                    List<string> temp = new List<string>(line_data.Split(' '));
                    data.Add(temp);
                }
            }
            // END

            promptsFirst = prompts.Keys.Min(); // First question to initialize test
            maxPoints = prompts.Count * data.Count;

            resetTest();

            question_text.Text = String.Format(prompts[answerId], data[questionSetId].ToArray());

            answer_butt.Enabled = true;
            tabControl1.SelectTab("tabPage2");
        }

        private void answer_butt_Click(object sender, EventArgs e)
        {
            string answer = answer_text.Text;
            runonce.Stop();
            wookieBad.Stop();

            if (answer != String.Empty)
            {
                // Check if the answer is good
                if (answer == data[questionSetId][answerId])
                {
                    pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox2.BackgroundImage = global::WookieTutor.Properties.Resources.wookie_good_pic;
                    pictureBox2.Refresh();
                    textBox1.Text = "BrrRRrRRRrravo!";

                    wookieGood.Play();

                    result_text.Text = "Good. Have a cookie.";
                    gainedPoints += 1;
                }
                else
                {
                    /// Change pic
                    pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox2.BackgroundImage = global::WookieTutor.Properties.Resources.confusedchew;
                    pictureBox2.Refresh();
                    textBox1.Text = "What the rRrrRrrR, man?";

                    wookieBad.Play();

                    result_text.Text = String.Format("Wrong. The right answer for question \"{0}\" is {1}",
                        String.Format(prompts[answerId], data[questionSetId].ToArray()),
                        data[questionSetId][answerId]);
                }
                /// Change it back
                runonce.Start();
                /// end 

                answerId += 1;
                if (leftToDraw.Count != 0 || prompts.ContainsKey(answerId))
                {
                    if (!prompts.ContainsKey(answerId))
                    {
                        answerId = promptsFirst;
                        questionSetId = drawQuestionSet();
                        counter += 1;
                        question_label.Text = String.Format("Question set {0}/{1}", counter, data.Count);
                    }

                    question_text.Text = String.Format(prompts[answerId], data[questionSetId].ToArray());
                }
                else
                {
                    float perc = (gainedPoints / maxPoints) * 100;
                    result_text.Text = string.Format("You have scored {0}/{1} points, that makes it {2}%.", gainedPoints, maxPoints, perc);
                    answer_butt.Enabled = false;
                    question_text.Text = String.Empty;
                }

                answer_text.Text = String.Empty;
            }
        }

        private void replay_butt_Click(object sender, EventArgs e)
        {
            resetTest();
            answer_butt.Focus();
        }

        private void goback_butt_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage1");
        }

        private void lessonPage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void question_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void result_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void question_label_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
