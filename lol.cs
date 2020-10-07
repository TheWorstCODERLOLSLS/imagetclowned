using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

class Program
{

    public static string exec(string code)
    {
        Form newForm = new Form();
        Button newButton = new Button();
        try
        {
            var S = new StringReader(code); //we will use this to read our strings
            string CL; //Current Line
            int LineCount = 0;
            while ((CL = S.ReadLine()) != null)
            {
                LineCount = LineCount + 1;
                if (CL.Contains("newButton"))
                {
                    if (newForm.Visible)
                    {
                        CL = CL.Replace("newButton(\"", "");
                        CL = CL.Replace("\")", "");
                        newButton.Text = CL;
                        newButton.Visible = true;
                        newButton.FlatStyle = FlatStyle.Flat;
                        newButton.FlatAppearance.BorderSize = 0;
                        newButton.Dock = DockStyle.Top;
                        newButton.BackColor = Color.FromArgb(25, 25, 25);
                        newButton.ForeColor = Color.White;
                        newForm.Controls.Add(newButton);
                    }
                }
                if (CL.Contains("newForm"))
                {
                    CL = CL.Replace("newForm(\"", "");
                    CL = CL.Replace("\")", "");
                    newForm.Text = CL;
                    newForm.Visible = true;
                    newForm.ShowIcon = false;
                    newForm.BackColor = Color.FromArgb(20, 20, 20);
                    newForm.ForeColor = Color.White;
                }

            }
            LineCount = 0;
        }
        catch
        {
            MessageBox.Show("failed");
        }
        return "Worked";
    }
    public static void Main(string[] args)
    {
