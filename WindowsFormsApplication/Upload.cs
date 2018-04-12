using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class Upload : Form
    {
        public Upload()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Multiselect = true;
            file.ShowDialog();

            file.Filter ="allfiles|*.png";

            int cont = 0;
            string[] Fnome;
            foreach(string item in file.FileNames)
            {
                Fnome = item.Split('\\');
                File.Copy(item, "C:\\file\\" + Fnome[Fnome.Length - 1], true);
                cont++;
            }

            MessageBox.Show("Uploaded " + cont + " Files.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < progressBar.Maximum; i++)
            {
                progressBar.Value = i;
            }
        }

        //private Timer time = new Timer();

        //// Call this method from the constructor of the form.
        //private void InitializeMyTimer()
        //{
        //    // Set the interval for the timer.
        //    time.Interval = 250;
        //    // Connect the Tick event of the timer to its event handler.
        //    time.Tick += new EventHandler(IncreaseProgressBar);
        //    // Start the timer.
        //    time.Start();
        //}

        //private void IncreaseProgressBar(object sender, EventArgs e)
        //{
        //    // Increment the value of the ProgressBar a value of one each time.
        //    progressBar.Increment(1);
        //    // Display the textual value of the ProgressBar in the StatusBar control's first panel.
        //    textBox1.Text = progressBar.Value.ToString() + "% Completed";
        //    // Determine if we have completed by comparing the value of the Value property to the Maximum value.
        //    if (progressBar.Value == progressBar.Maximum)
        //        // Stop the timer.
        //        time.Stop();
        //}
    }
}