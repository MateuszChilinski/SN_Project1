using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        private delegate void EventHandle();

        public Form1()
        {
            InitializeComponent();
        }

        private void TrainingFileButton_Click(object sender, EventArgs e)
        {
            var FD = new System.Windows.Forms.OpenFileDialog();
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileToOpen = FD.FileName;
                ChoseTrainingFileTextBox.Text = fileToOpen;
                System.IO.FileInfo File = new System.IO.FileInfo(FD.FileName);

                //OR

                System.IO.StreamReader reader = new System.IO.StreamReader(fileToOpen);
                //etc
            }
        }

        private void ChooseTestFileButton_Click(object sender, EventArgs e)
        {
            var FD = new System.Windows.Forms.OpenFileDialog();
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileToOpen = FD.FileName;
                ChooseTestFileTextBox.Text = fileToOpen;
                System.IO.FileInfo File = new System.IO.FileInfo(FD.FileName);

                //OR

                System.IO.StreamReader reader = new System.IO.StreamReader(fileToOpen);
                //etc
            }
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            var cmd = "-u bpg.py";
            var args = ChoseTrainingFileTextBox.Text + " " + ChooseTestFileTextBox.Text + " " + NeuronsByLayerNumber.Value + " " + LayersNumber.Value + " " + EpochsNumber.Value + " " + LearningRateNumber.Value;
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "python.exe",
                    Arguments = cmd + " " + args,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                },
                EnableRaisingEvents = true
            };
            process.ErrorDataReceived += Process_OutputDataReceived;
            process.OutputDataReceived += Process_OutputDataReceived;
            Debug.WriteLine(cmd + " " + args);
            process.Start();
            process.BeginOutputReadLine();
        }

        private void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data == null) return;
            //Debug.WriteLine(e.Data);
            ProgressBar.Invoke((Action) (() => 
            {
                ProgressBar.Value = (int)(double.Parse(e.Data) * 100.0);
                ProgressBar.Refresh(); 
            }
            
            ));
            //Invoke(new Action(() => ProgressBar.Value = (int)(double.Parse(e.Data) * 100.0)));
            //ProgressBar.Value = (int) (double.Parse(e.Data) * 100.0);
        }
    }
}
