using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw6
{
    public class QuestionTree
    {

        public QuestionTree(String firstQuestion, bool isLastQuestion)
        {
            root = new TreeNode(firstQuestion, isLastQuestion);
        }

        public TreeNode root;

        public void insertQuestion(String questionPath, String question, bool isLastQuestion)
        {
            insertQuestion(ref root, questionPath, question, isLastQuestion);
        }

        public void insertQuestion(ref TreeNode t, String questionPath, String question, bool isLastQuestion)
        {
            if(String.IsNullOrEmpty(questionPath)){
                t = new TreeNode(question, isLastQuestion);
                return;
            }
            if (questionPath[0].ToString().Equals("y")) // source: http://stackoverflow.com/questions/3878820/c-how-to-get-first-char-of-a-string
            {
                questionPath = questionPath.Remove(0, 1);
                insertQuestion(ref t.yes, questionPath, question, isLastQuestion);
            }
            else
            {
                questionPath = questionPath.Remove(0, 1);
                insertQuestion(ref t.no, questionPath, question, isLastQuestion);
            }
        }


    }

    public class TreeNode
    {

        public TreeNode yes, no;
        public String question;
        public bool isLastQuestion;
        public TreeNode(String question, bool isLastQuestion)
        {
            this.question = question;
            this.isLastQuestion = isLastQuestion;
            this.yes = null;
            this.no = null;
        }
    }
}
