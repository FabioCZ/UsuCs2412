using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw6
{
    public partial class Form1 : Form
    {
        QuestionTree questionTree = new QuestionTree("Is it front engine car?", false);
        TreeNode currNode;
        bool firstQuestion = true;     //forgot that you have to ask the "are you ready" part, so this "awesome" solution had to come around.

        public Form1()
        {
            InitializeComponent();
            buildQuestionTree();
            currNode = questionTree.root;
            labelQuestion.Text = "Are you ready?";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (firstQuestion)
            {
                if (e.KeyChar.ToString().Equals("y") || e.KeyChar.ToString().Equals("Y"))
                {
                    labelQuestion.Text = currNode.question;
                    firstQuestion = false;
                }
                else
                {
                    MessageBox.Show("Too bad you don't want to play");
                    Application.Exit();
                }
                return;
            }
            //yes handler
            if (e.KeyChar.ToString().Equals("y") || e.KeyChar.ToString().Equals("Y"))     
            {
                
                if (currNode.isLastQuestion)
                {
                    MessageBox.Show("Yay, you won!");
                    Application.Exit();
                    //yes on last q
                }
                else
                {
                    currNode = currNode.yes;
                    labelQuestion.Text = currNode.question;
                    //yes on normal q
                }

            }
            //no handler
            else
            {
                
                if (currNode.isLastQuestion)
                {
                    MessageBox.Show("You lose :(");
                    Application.Exit();
                    //no on last q
                }
                else
                {
                    currNode = currNode.no;
                    labelQuestion.Text = currNode.question;
                    //no on normal q
                }
            }
        }

        public void buildQuestionTree()
        {
            questionTree.insertQuestion("", "Is it front engine car?", false);
            questionTree.insertQuestion("y", "Is it rear wheel drive?", false);
            questionTree.insertQuestion("n", "Is it Italian?", false);
            questionTree.insertQuestion("yy", "Does it have a I6 engine?", false);
            questionTree.insertQuestion("yn", "Does it have a VR6 engine?", false);
            questionTree.insertQuestion("ny", "Does it have a horse in its logo?", false);
            questionTree.insertQuestion("nn", "Is it German?", false);

            questionTree.insertQuestion("yyy", "Is it a BMW E36 328i? ", true);
            questionTree.insertQuestion("yyn", "Is it a Nissan 240SX?", true);
            questionTree.insertQuestion("yny", "Is it a VW Golf R32?", true);
            questionTree.insertQuestion("ynn", "Is it a Toyota Camry?", true);
            questionTree.insertQuestion("nyy", "Is it a Ferrari Testarossa?", true);
            questionTree.insertQuestion("nyn", "Is it a Lamborghini Murciélago?", true);
            questionTree.insertQuestion("nny", "Is it a Porsche 911 GT3?", true);
            questionTree.insertQuestion("nnn", "Is it a Honda NSX?", true);

        }
    }
}
