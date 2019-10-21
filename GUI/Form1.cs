using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
            SeedTextBox.KeyPress += SeedTextBox_KeyPress;
            TrainingFileComboBox.DropDown += TrainingFileComboBox_DropDown;
            TestingFileComboBox.DropDown += TestingFileComboBox_DropDown;
            RegressionRadioButton.CheckedChanged += new System.EventHandler(this.RegressionRadioButton_CheckedChanged);
            ClassificationRadioButton.CheckedChanged += new System.EventHandler(this.RegressionRadioButton_CheckedChanged);
        }

        private void TestingFileComboBox_DropDown(object sender, EventArgs e)
        {
            string mydir = ClassificationRadioButton.Checked ? "classification/" : "regression/";
            TestingFileComboBox.Items.Clear();
            string[] files = Directory.GetFiles(mydir);

            foreach (string filePath in files)
            { 
                if(filePath.Contains("test"))
                    TestingFileComboBox.Items.Add(Path.GetFileName(filePath));
            }
        }

        private void TrainingFileComboBox_DropDown(object sender, EventArgs e)
        {
            string mydir = ClassificationRadioButton.Checked ? "classification/" : "regression/";
            TrainingFileComboBox.Items.Clear();
            string[] files = Directory.GetFiles(mydir);

            foreach (string filePath in files)
            {
                if (filePath.Contains("train"))
                    TrainingFileComboBox.Items.Add(Path.GetFileName(filePath));
            }
        }
        private void RunPython()
        {
            string mydir = ClassificationRadioButton.Checked ? "classification/" : "regression/";
            string taskType = ClassificationRadioButton.Checked ? "class" : "reg";
            EffectLabel.Visible = false;
            pythonDone = false;

            var cmd = "-u bpg.py";
            string afunc = "tanh";
            if (((string)ActivationFunctionComboBox.SelectedItem) == "Sigmoid")
                afunc = "sig";
            if (((string)ActivationFunctionComboBox.SelectedItem) == "Other")
                afunc = "other";
            var args = mydir + (string)TrainingFileComboBox.SelectedItem + " " + mydir + (string)TestingFileComboBox.SelectedItem + " " + NeuronsByLayerNumber.Value + " " + LayersNumber.Value + " " + EpochsNumber.Value + " " + LearningRateNumber.Value + " " + SeedTextBox.Text + " " +
                afunc + " " + taskType;
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
        private void RunButton_Click(object sender, EventArgs e)
        {
            ChartBox.Image = null;
            RunPython();
        }
        private void RunR()
        {
            var path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

            var cmd = ClassificationRadioButton.Checked ? "class.R" : "function.R";
            var args = path.Replace("\\", "/") + "/";
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "Rscript.exe",
                    Arguments = cmd + " " + args,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                },
                EnableRaisingEvents = true
            };
            process.ErrorDataReceived += ProcessR_OutputDataReceived;
            process.OutputDataReceived += ProcessR_OutputDataReceived;
            Debug.WriteLine(cmd + " " + args);
            process.Start();
            process.BeginOutputReadLine();
            RLabel.Invoke((MethodInvoker)(() =>
            {
                RLabel.Visible = true;
            }
            ));
        }
        private void ProcessR_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            Debug.WriteLine(e.Data);
            if (e.Data == null) return;
            string data = e.Data.ToString().Replace("\"", "");
            if (data.Contains("[1] "))
            {
                ChartBox.Invoke((MethodInvoker)(() =>
                {
                    ChartBox.Image = Image.FromFile(data.Substring(4, data.Length-4)+ ".png");
                }
                ));
                RLabel.Invoke((MethodInvoker)(() =>
                {
                    RLabel.Visible = false;
                }
                ));
            }
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
                RunR();
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

        private void RegressionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            TrainingFileComboBox.SelectedItem = null;
            TrainingFileComboBox.Items.Clear();
            TestingFileComboBox.SelectedItem = null;
            TestingFileComboBox.Items.Clear();
        }
    }
}
