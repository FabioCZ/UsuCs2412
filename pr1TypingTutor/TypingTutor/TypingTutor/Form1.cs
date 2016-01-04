using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypingTutor
{
    public partial class Form1 : Form
    {

        const int customPromptMaxLength = 300;
        Dictionary<string, Button> buttons = new Dictionary<string, Button>();
        Dictionary<string,int> missedKeys = new Dictionary<string,int>();
        KeysConverter kc = new KeysConverter();
        string resultsString;
        double accuracy =0;
        int errors = 0;
        string textBefore;
        int currCursor = 0;
        bool backspacePressed = false;
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            this.ActiveControl = typingBox;
            foreach(Control c in groupBoxKeyboard.Controls){
                if (c is Button)
                {
                    buttons.Add(c.Text, (Button) c);
                    if(c.Text.Length == 1){ //make sure only letter/char keys are added
                        missedKeys.Add(c.Text, 0);
                    }
                    
                }
            }
            missedKeys.Add(" ", 0);
        }

        private void loadPromptToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PromptStore.customPrompt = File.ReadAllText(openFileDialog1.FileName);
                if (PromptStore.customPrompt.Length > customPromptMaxLength)
                {
                    MessageBox.Show("Maximun allowed custom prompt length is " + customPromptMaxLength + 
                        " characters. Please choose a shorter prompt");
                    return;
                }
                radioButtonFile.Enabled = true;

            }
            else
            {
                MessageBox.Show("No file selected!");
            }
        }

        private void saveResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, resultsString);
            }
        }

        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Instructions:\n\n"+
                            "You can load a custom prompt from a .txt file, File->Select Prompt file, and the pick From File radio button\n\n" +
                            "You can save results summary to a file from File->Save Results (not enabled till you finish typing a prompt)\n\n" +
                            "Backspace is disabled in this typing tutor\n\n"+
                            "If you hold down a key or type super fast, things break, but I don't know what to do about it, sorry :(");
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Awesome Typing Tutor v1.0 \nCreated by Fabio Gottlicher\n(c) 2014");
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void typingBox_KeyDown(object sender, KeyEventArgs e)
        {
            Random randomGen = new Random();
            KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            KnownColor randomColorName = names[randomGen.Next(names.Length)];
            Color randomColor = Color.FromKnownColor(randomColorName);
            KeyColorHandler(e, randomColor);
            textBefore = typingBox.Text;
            backspacePressed = (e.KeyData.Equals(Keys.Back)) ? true : false;
        }

        private void typingBox_KeyUp(object sender, KeyEventArgs e)
        {
            typingBox.SelectionStart = (backspacePressed) ? currCursor + 1 : typingBox.SelectionStart;
            KeyColorHandler(e, default(Color));
            if (backspacePressed) return;
            PromptHandler();
        }

        private void typingBox_TextChanged(object sender, EventArgs e)
        {
            if (backspacePressed)
            {
                currCursor = typingBox.SelectionStart;
                typingBox.Text = textBefore;
            }
        }

        private void PromptHandler()
        {
            if (typingBox.Text.Length == 0) return;
            int currIndex = typingBox.Text.Length - 1;  //figure out how far we are.
            if (typingBox.Text.Substring(currIndex, 1) != labelPrompt.Text.Substring(currIndex, 1))
            {   
                errors++;
                if (labelPrompt.Text.Substring(currIndex, 1) == " ")
                {
                    missedKeys[" "]++;
                }
                missedKeys[labelPrompt.Text.Substring(currIndex, 1).ToUpper()]++;
            }

            accuracy = 100 - ((double) errors / ((double)currIndex + 1)) * 100;    //gets accuracy percentage
            labelErrors.Text =  errors.ToString();
            labelAccuracy.Text = Math.Round(accuracy).ToString() + "%";

            if (typingBox.Text.Length == labelPrompt.Text.Length)   //handles if the prompt is done
            {
                saveResultsToolStripMenuItem.Enabled = true;
                var sortedDict = from entry in missedKeys orderby entry.Value descending select entry;
                string mostMissedKeys = "";
                for (int i = 0; i < 5; i++)
                {
                    mostMissedKeys += "\"" + sortedDict.ElementAt(i).Key + "\"(" + sortedDict.ElementAt(i).Value + " times), ";
                }
                    resultsString = "Typing tutor results:\r\n" +
                                    "Date/Time: " + DateTime.Now.ToString("s", System.Globalization.CultureInfo.InvariantCulture) + "\r\n" +
                                    "Prompt: " + labelPrompt.Text + "\r\n" +
                                    "Errors: " + errors + "\r\n" +
                                    "Accuracy: " + Math.Round(accuracy).ToString() + "%\r\n" +
                                    "Most missed keys:" + mostMissedKeys;
                MessageBox.Show(resultsString);
                SelectNextPrompt();
            }
        }
        private void KeyColorHandler(KeyEventArgs e, Color c)
        {
                        //special cases:
            if (e.KeyData == Keys.Oemtilde)
            {
                buttons["`"].BackColor = c;
            } 
            else if(e.KeyData == Keys.OemMinus)
            {
                buttons["-"].BackColor = c;
            }
            else if(e.KeyData == Keys.Oemplus)
            {
                buttons["="].BackColor = c;
            }
            else if (e.KeyData == Keys.Back)
            {
                buttons["BKSP"].BackColor = c;
            }
            else if(e.KeyData == Keys.OemOpenBrackets)
            {
                buttons["["].BackColor = c;
            }
            else if (e.KeyData == Keys.Oem6)
            {
                buttons["]"].BackColor = c;
            }
            else if (e.KeyData == Keys.Oem5)
            {
                buttons["\\"].BackColor = c;
            }
            else if (e.KeyData == Keys.Oem1)
            {
                buttons[";"].BackColor = c;
            }
            else if (e.KeyData == Keys.Oem7)
            {
                buttons["'"].BackColor = c;
            }
            else if (e.KeyData == Keys.OemQuestion)
            {
                buttons["/"].BackColor = c;
            }
            else if (e.KeyData == Keys.OemPeriod)
            {
                buttons["."].BackColor = c;
            }
            else if (e.KeyData == Keys.Oemcomma)
            {
                buttons[","].BackColor = c;
            }
            else if(e.KeyData == Keys.Space)
            {
                buttons["SPACE"].BackColor = c;
            }
            else if (kc.ConvertToString(e.KeyData).Length == 1)
            {
                buttons[kc.ConvertToString(e.KeyData)].BackColor = c;
            }
            else if (e.KeyData == Keys.Tab)
            {
                buttons["TAB"].BackColor = c;
            }
            else if(e.KeyData == Keys.Capital)
            {
                if (Control.IsKeyLocked(Keys.CapsLock))
                {
                    buttons["CAPS"].BackColor = Color.Red;
                }
                else
                {
                    buttons["CAPS"].BackColor = default(Color);
                }
            }
            else if(e.KeyData == Keys.Enter)
            {
                buttons["ENTER"].BackColor = c;
            }
            else if(e.Shift)
            {
                buttons["L SHIFT"].BackColor = Color.Red;
                buttons["R SHIFT"].BackColor = Color.Red;

            }
            else if (!e.Shift)
            {
                buttons["L SHIFT"].BackColor = default(Color);
                buttons["R SHIFT"].BackColor = default(Color);

            }
        }
        
        private void SelectNextPrompt()
        {
            RadioButton currPrompt = null;
            RadioButton nextPrompt = null;
            foreach (Control c in groupBoxRadios.Controls)
            {
                if (c is RadioButton)
                {
                    currPrompt = (RadioButton)c;
                    if (currPrompt.Checked)
                    {
                        break;
                    }
                }
            }

            int nextIndex = (currPrompt.Name == "radioButtonFile") ? 1 : (Convert.ToInt32(currPrompt.Name.Substring(11, 1)) + 1) % 5;
            string nextName = "radioButton" + nextIndex;
            foreach (Control c in groupBoxRadios.Controls)
            {
                if (c.Name == nextName)
                {
                    nextPrompt = (RadioButton)c;
                    break;
                }
            }
            currPrompt.Checked = false;
            nextPrompt.Checked = true;
        }

        private void promptSelection_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                switch (rb.Name) { 
                    case "radioButton1":
                        labelPrompt.Text = PromptStore.prompt1;
                        break;
                    case "radioButton2":
                        labelPrompt.Text = PromptStore.prompt2;
                        break;
                    case "radioButton3":
                        labelPrompt.Text = PromptStore.prompt3;
                        break;
                    case "radioButton4":
                        labelPrompt.Text = PromptStore.prompt4;
                        break;
                    case "radioButton5":
                        labelPrompt.Text = PromptStore.prompt5;
                        break;
                    case "radioButtonFile":
                        labelPrompt.Text = PromptStore.customPrompt;
                        break;
                }
            }
            //reset stuffs
            typingBox.Text = "";
            errors = 0;
            labelErrors.Text = errors.ToString();
            accuracy = 0;
            labelAccuracy.Text = accuracy.ToString();
            foreach (var key in missedKeys.Keys.ToList())
            {
                missedKeys[key] = 0;
            }
        }




    }
}
