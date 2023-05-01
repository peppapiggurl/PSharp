// Not complete!


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Made by Poseidon Cheats (DetroitJack)
   to code better in C# if you don't know anything!*/

// The code only works for WinForms.
// DO NOT TOUCH CODE OR CHANGE ANYTHING UNLESS YOU HAVE A BRAIN!!

namespace P_Sharp
{
    public static class PSharp
    {
        // Let's check if the project is made in WinForms or not.

        // Print Function
        public static void Prnt(object obj)
        {
            Console.WriteLine(obj.ToString());
        }

        // Variable Function (Shit) || Please remember that PSharp doesn't have simple functions but some
        // advanced ones.
        private static Dictionary<string, object> variables = new Dictionary<string, object>();

        public static void SetVar(string name, object value)
        {
            variables[name] = value;
        }

        // Open File Dialog
        public static string OpenFileDialog(string title, string fileFilter)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = title;
            dialog.Filter = fileFilter;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                return dialog.FileName;
            }
            else
            {
                return null;
            }
        }


        // Save File Dialog
        public static void SaveFileDialog(string title, string fileFilter, string content)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = title;
            dialog.Filter = fileFilter;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(dialog.FileName))
                {
                    writer.Write(content);
                }
            }
        }

        // Control flow
        public static void If(object condition, Action action)
        {
            bool conditionResult;

            if (condition is bool)
            {
                conditionResult = (bool)condition;
            }
            else if (condition is string)
            {
                conditionResult = !string.IsNullOrEmpty((string)condition);
            }
            else
            {
                throw new ArgumentException("Condition must be a boolean or a string.");
            }

            if (conditionResult)
            {
                action();
            }
        }

        public static void If(object condition, Action ifAction, Action elseAction)
        {
            bool conditionResult;

            if (condition is bool)
            {
                conditionResult = (bool)condition;
            }
            else if (condition is string)
            {
                conditionResult = !string.IsNullOrEmpty((string)condition);
            }
            else
            {
                throw new ArgumentException("Condition must be a boolean or a string.");
            }

            if (conditionResult)
            {
                ifAction();
            }
            else
            {
                elseAction();
            }
        }

        public static void If(object condition, Action ifAction, Action elseIfAction, object elseIfCondition)
        {
            bool conditionResult;

            if (condition is bool)
            {
                conditionResult = (bool)condition;
            }
            else if (condition is string)
            {
                conditionResult = !string.IsNullOrEmpty((string)condition);
            }
            else
            {
                throw new ArgumentException("Condition must be a boolean or a string. ~ PSharp Doesn't Support Anything Else Than A Boolean Or String.");
            }

            if (conditionResult)
            {
                ifAction();
            }
            else
            {
                bool elseIfConditionResult;

                if (elseIfCondition is bool)
                {
                    elseIfConditionResult = (bool)elseIfCondition;
                }
                else if (elseIfCondition is string)
                {
                    elseIfConditionResult = !string.IsNullOrEmpty((string)elseIfCondition);
                }
                else
                {
                    throw new ArgumentException("Else-if condition must be a boolean or a string.");
                }

                if (elseIfConditionResult)
                {
                    elseIfAction();
                }
            }
        }


    }

}
