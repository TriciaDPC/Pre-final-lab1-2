using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace CreatingTextFile
{
    public partial class FrmRegistration : Form
    {
        
        public FrmRegistration()
        {
            InitializeComponent();
        }


        private void Register_Click(object sender, EventArgs e)
        {
            
                string StudNum = StudentNo.Text;
                string LastN = LastName.Text;
                string age = Age.Text;
                string Bday = Birthday.Text;
                string Firstname = FName.Text;
                string ConNum = ContactNo.Text;
                string Midlle = MI.Text;
                string Prog = Program.Text;
                string Gend = Gender.Text;

                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,
                Firstname + ".txt")))
                {

                    outputFile.WriteLine("Student No.: " +StudNum);
                    outputFile.WriteLine("Full Name: " + LastN+", " + Firstname + ", " + Midlle +".");
                    outputFile.WriteLine("Program: " + Prog);
                    outputFile.WriteLine("Gender: " + Gend);
                    outputFile.WriteLine("Age: " + age);
                    outputFile.WriteLine("Birthday: " + Bday);
                    outputFile.WriteLine("Contact Number: " + ConNum);

            }
            }
    }
}
