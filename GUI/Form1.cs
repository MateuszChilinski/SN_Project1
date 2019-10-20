using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        private delegate void EventHandle();

        public Form1()
        {
            InitializeComponent();
            RunButton.Click += new System.EventHandler(this.RunButton_Click);
            TrainingFileButton.Click += new System.EventHandler(this.TrainingFileButton_Click);
            ChooseTestFileButton.Click += new System.EventHandler(this.ChooseTestFileButton_Click);
            SeedTextBox.KeyPress += SeedTextBox_KeyPress;
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
            EffectLabel.Visible = false;
            pythonDone = false;
            var cmd = "-u bpg.py";
            string afunc = "tanh";
            if (((string)ActivationFunctionComboBox.SelectedItem) == "Sigmoid")
                afunc = "sig";
            if (((string)ActivationFunctionComboBox.SelectedItem) == "Other")
                afunc = "other";
            var args = ChoseTrainingFileTextBox.Text + " " + ChooseTestFileTextBox.Text + " " + NeuronsByLayerNumber.Value + " " + LayersNumber.Value + " " + EpochsNumber.Value + " " + LearningRateNumber.Value + " " + SeedTextBox.Text + " " +
                afunc;
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
        private bool pythonDone = false;
        private void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data == null) return;

            if (pythonDone == true)
            {
                EffectLabel.Invoke((MethodInvoker)(() =>
                {
                    EffectLabel.Visible = true;
                    EffectLabel.Text = "Effectiveness: " + (int)(double.Parse(e.Data) * 100.0) + "%";
                }
                ));
                return;
            }
            //Debug.WriteLine(e.Data);
            ProgressBar.Invoke((MethodInvoker) (() => 
            {
                var val = (int) (double.Parse(e.Data) * 100.0);
                if(val == 100)
                    pythonDone = true;
                ProgressBar.Value = val;
                ProgressBar.Refresh(); 
            }
            
            ));
            //Invoke(new Action(() => ProgressBar.Value = (int)(double.Parse(e.Data) * 100.0)));
            //ProgressBar.Value = (int) (double.Parse(e.Data) * 100.0);
        }
        private void SeedTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
        }
    }
}
