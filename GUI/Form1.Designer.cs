namespace GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ChartBox = new System.Windows.Forms.PictureBox();
            this.NeuronsByLayerNumber = new System.Windows.Forms.NumericUpDown();
            this.NeuronsByLayerLabel = new System.Windows.Forms.Label();
            this.LayersLabel = new System.Windows.Forms.Label();
            this.LayersNumber = new System.Windows.Forms.NumericUpDown();
            this.EpochsLabel = new System.Windows.Forms.Label();
            this.EpochsNumber = new System.Windows.Forms.NumericUpDown();
            this.LearningRateLabel = new System.Windows.Forms.Label();
            this.LearningRateNumber = new System.Windows.Forms.NumericUpDown();
            this.RunButton = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.SeedLabel = new System.Windows.Forms.Label();
            this.SeedTextBox = new System.Windows.Forms.TextBox();
            this.EffectLabel = new System.Windows.Forms.Label();
            this.ActivationFunctionComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.TrainingFileComboBox = new System.Windows.Forms.ComboBox();
            this.TestingFileComboBox = new System.Windows.Forms.ComboBox();
            this.ClassificationRadioButton = new System.Windows.Forms.RadioButton();
            this.RegressionRadioButton = new System.Windows.Forms.RadioButton();
            this.TypeBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RLabel = new System.Windows.Forms.Label();
            this.EffectLabel2 = new System.Windows.Forms.Label();
            this.BiasesCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ChartBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NeuronsByLayerNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayersNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpochsNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LearningRateNumber)).BeginInit();
            this.TypeBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChartBox
            // 
            this.ChartBox.Location = new System.Drawing.Point(11, 10);
            this.ChartBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChartBox.Name = "ChartBox";
            this.ChartBox.Size = new System.Drawing.Size(1269, 593);
            this.ChartBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ChartBox.TabIndex = 0;
            this.ChartBox.TabStop = false;
            // 
            // NeuronsByLayerNumber
            // 
            this.NeuronsByLayerNumber.Location = new System.Drawing.Point(1432, 352);
            this.NeuronsByLayerNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NeuronsByLayerNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NeuronsByLayerNumber.Name = "NeuronsByLayerNumber";
            this.NeuronsByLayerNumber.Size = new System.Drawing.Size(107, 22);
            this.NeuronsByLayerNumber.TabIndex = 1;
            this.NeuronsByLayerNumber.TabStop = false;
            this.NeuronsByLayerNumber.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // NeuronsByLayerLabel
            // 
            this.NeuronsByLayerLabel.AutoSize = true;
            this.NeuronsByLayerLabel.Location = new System.Drawing.Point(1315, 354);
            this.NeuronsByLayerLabel.Name = "NeuronsByLayerLabel";
            this.NeuronsByLayerLabel.Size = new System.Drawing.Size(116, 17);
            this.NeuronsByLayerLabel.TabIndex = 2;
            this.NeuronsByLayerLabel.Text = "Neurons by layer";
            // 
            // LayersLabel
            // 
            this.LayersLabel.AutoSize = true;
            this.LayersLabel.Location = new System.Drawing.Point(1315, 384);
            this.LayersLabel.Name = "LayersLabel";
            this.LayersLabel.Size = new System.Drawing.Size(51, 17);
            this.LayersLabel.TabIndex = 4;
            this.LayersLabel.Text = "Layers";
            // 
            // LayersNumber
            // 
            this.LayersNumber.Location = new System.Drawing.Point(1433, 382);
            this.LayersNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LayersNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.LayersNumber.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.LayersNumber.Name = "LayersNumber";
            this.LayersNumber.Size = new System.Drawing.Size(107, 22);
            this.LayersNumber.TabIndex = 3;
            this.LayersNumber.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // EpochsLabel
            // 
            this.EpochsLabel.AutoSize = true;
            this.EpochsLabel.Location = new System.Drawing.Point(1316, 415);
            this.EpochsLabel.Name = "EpochsLabel";
            this.EpochsLabel.Size = new System.Drawing.Size(55, 17);
            this.EpochsLabel.TabIndex = 6;
            this.EpochsLabel.Text = "Epochs";
            // 
            // EpochsNumber
            // 
            this.EpochsNumber.Location = new System.Drawing.Point(1433, 414);
            this.EpochsNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EpochsNumber.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.EpochsNumber.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.EpochsNumber.Name = "EpochsNumber";
            this.EpochsNumber.Size = new System.Drawing.Size(107, 22);
            this.EpochsNumber.TabIndex = 5;
            this.EpochsNumber.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // LearningRateLabel
            // 
            this.LearningRateLabel.AutoSize = true;
            this.LearningRateLabel.Location = new System.Drawing.Point(1315, 448);
            this.LearningRateLabel.Name = "LearningRateLabel";
            this.LearningRateLabel.Size = new System.Drawing.Size(98, 17);
            this.LearningRateLabel.TabIndex = 8;
            this.LearningRateLabel.Text = "Learning Rate";
            // 
            // LearningRateNumber
            // 
            this.LearningRateNumber.DecimalPlaces = 2;
            this.LearningRateNumber.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.LearningRateNumber.Location = new System.Drawing.Point(1433, 446);
            this.LearningRateNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LearningRateNumber.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.LearningRateNumber.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.LearningRateNumber.Name = "LearningRateNumber";
            this.LearningRateNumber.Size = new System.Drawing.Size(107, 22);
            this.LearningRateNumber.TabIndex = 7;
            this.LearningRateNumber.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(1301, 571);
            this.RunButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(237, 31);
            this.RunButton.TabIndex = 9;
            this.RunButton.Text = "Train and test";
            this.RunButton.UseVisualStyleBackColor = true;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(1302, 616);
            this.ProgressBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(236, 28);
            this.ProgressBar.Step = 1;
            this.ProgressBar.TabIndex = 14;
            // 
            // SeedLabel
            // 
            this.SeedLabel.AutoSize = true;
            this.SeedLabel.Location = new System.Drawing.Point(1315, 482);
            this.SeedLabel.Name = "SeedLabel";
            this.SeedLabel.Size = new System.Drawing.Size(41, 17);
            this.SeedLabel.TabIndex = 16;
            this.SeedLabel.Text = "Seed";
            // 
            // SeedTextBox
            // 
            this.SeedTextBox.Location = new System.Drawing.Point(1433, 480);
            this.SeedTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeedTextBox.Name = "SeedTextBox";
            this.SeedTextBox.Size = new System.Drawing.Size(107, 22);
            this.SeedTextBox.TabIndex = 17;
            this.SeedTextBox.Text = "69142";
            // 
            // EffectLabel
            // 
            this.EffectLabel.AutoSize = true;
            this.EffectLabel.Location = new System.Drawing.Point(1367, 660);
            this.EffectLabel.Name = "EffectLabel";
            this.EffectLabel.Size = new System.Drawing.Size(120, 17);
            this.EffectLabel.TabIndex = 18;
            this.EffectLabel.Text = "Effectiveness: n%";
            this.EffectLabel.Visible = false;
            // 
            // ActivationFunctionComboBox
            // 
            this.ActivationFunctionComboBox.FormattingEnabled = true;
            this.ActivationFunctionComboBox.Items.AddRange(new object[] {
            "Sigmoid",
            "Tanh",
            "Arctan"});
            this.ActivationFunctionComboBox.Location = new System.Drawing.Point(1433, 514);
            this.ActivationFunctionComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ActivationFunctionComboBox.Name = "ActivationFunctionComboBox";
            this.ActivationFunctionComboBox.Size = new System.Drawing.Size(108, 24);
            this.ActivationFunctionComboBox.TabIndex = 19;
            this.ActivationFunctionComboBox.Text = "Tanh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1315, 516);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Activation fun.";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(1319, 28);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(225, 301);
            this.richTextBox1.TabIndex = 21;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // TrainingFileComboBox
            // 
            this.TrainingFileComboBox.FormattingEnabled = true;
            this.TrainingFileComboBox.Location = new System.Drawing.Point(187, 30);
            this.TrainingFileComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TrainingFileComboBox.Name = "TrainingFileComboBox";
            this.TrainingFileComboBox.Size = new System.Drawing.Size(241, 24);
            this.TrainingFileComboBox.TabIndex = 22;
            // 
            // TestingFileComboBox
            // 
            this.TestingFileComboBox.FormattingEnabled = true;
            this.TestingFileComboBox.Location = new System.Drawing.Point(187, 66);
            this.TestingFileComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TestingFileComboBox.Name = "TestingFileComboBox";
            this.TestingFileComboBox.Size = new System.Drawing.Size(241, 24);
            this.TestingFileComboBox.TabIndex = 23;
            // 
            // ClassificationRadioButton
            // 
            this.ClassificationRadioButton.AutoSize = true;
            this.ClassificationRadioButton.Checked = true;
            this.ClassificationRadioButton.Location = new System.Drawing.Point(5, 30);
            this.ClassificationRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClassificationRadioButton.Name = "ClassificationRadioButton";
            this.ClassificationRadioButton.Size = new System.Drawing.Size(111, 21);
            this.ClassificationRadioButton.TabIndex = 24;
            this.ClassificationRadioButton.TabStop = true;
            this.ClassificationRadioButton.Text = "Classification";
            this.ClassificationRadioButton.UseVisualStyleBackColor = true;
            // 
            // RegressionRadioButton
            // 
            this.RegressionRadioButton.AutoSize = true;
            this.RegressionRadioButton.Location = new System.Drawing.Point(5, 67);
            this.RegressionRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegressionRadioButton.Name = "RegressionRadioButton";
            this.RegressionRadioButton.Size = new System.Drawing.Size(101, 21);
            this.RegressionRadioButton.TabIndex = 25;
            this.RegressionRadioButton.TabStop = true;
            this.RegressionRadioButton.Text = "Regression";
            this.RegressionRadioButton.UseVisualStyleBackColor = true;
            // 
            // TypeBox
            // 
            this.TypeBox.Controls.Add(this.ClassificationRadioButton);
            this.TypeBox.Controls.Add(this.RegressionRadioButton);
            this.TypeBox.Location = new System.Drawing.Point(11, 616);
            this.TypeBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TypeBox.Size = new System.Drawing.Size(178, 130);
            this.TypeBox.TabIndex = 26;
            this.TypeBox.TabStop = false;
            this.TypeBox.Text = "Type of task";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TrainingFileComboBox);
            this.groupBox1.Controls.Add(this.TestingFileComboBox);
            this.groupBox1.Location = new System.Drawing.Point(224, 616);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(483, 130);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Files in use";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Testing data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Training data";
            // 
            // RLabel
            // 
            this.RLabel.AutoSize = true;
            this.RLabel.Location = new System.Drawing.Point(1316, 714);
            this.RLabel.Name = "RLabel";
            this.RLabel.Size = new System.Drawing.Size(240, 17);
            this.RLabel.TabIndex = 28;
            this.RLabel.Text = "R is drawing the graph, please wait...";
            this.RLabel.Visible = false;
            // 
            // EffectLabel2
            // 
            this.EffectLabel2.AutoSize = true;
            this.EffectLabel2.Location = new System.Drawing.Point(1367, 687);
            this.EffectLabel2.Name = "EffectLabel2";
            this.EffectLabel2.Size = new System.Drawing.Size(120, 17);
            this.EffectLabel2.TabIndex = 29;
            this.EffectLabel2.Text = "Effectiveness: n%";
            this.EffectLabel2.Visible = false;
            // 
            // BiasesCheckBox
            // 
            this.BiasesCheckBox.AutoSize = true;
            this.BiasesCheckBox.Checked = true;
            this.BiasesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BiasesCheckBox.Location = new System.Drawing.Point(1319, 545);
            this.BiasesCheckBox.Name = "BiasesCheckBox";
            this.BiasesCheckBox.Size = new System.Drawing.Size(72, 21);
            this.BiasesCheckBox.TabIndex = 30;
            this.BiasesCheckBox.Text = "Biases";
            this.BiasesCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1577, 766);
            this.Controls.Add(this.BiasesCheckBox);
            this.Controls.Add(this.EffectLabel2);
            this.Controls.Add(this.RLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ActivationFunctionComboBox);
            this.Controls.Add(this.EffectLabel);
            this.Controls.Add(this.SeedTextBox);
            this.Controls.Add(this.SeedLabel);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.LearningRateLabel);
            this.Controls.Add(this.LearningRateNumber);
            this.Controls.Add(this.EpochsLabel);
            this.Controls.Add(this.EpochsNumber);
            this.Controls.Add(this.LayersLabel);
            this.Controls.Add(this.LayersNumber);
            this.Controls.Add(this.NeuronsByLayerLabel);
            this.Controls.Add(this.NeuronsByLayerNumber);
            this.Controls.Add(this.ChartBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "SN Proj1";
            ((System.ComponentModel.ISupportInitialize)(this.ChartBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NeuronsByLayerNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayersNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpochsNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LearningRateNumber)).EndInit();
            this.TypeBox.ResumeLayout(false);
            this.TypeBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ChartBox;
        private System.Windows.Forms.NumericUpDown NeuronsByLayerNumber;
        private System.Windows.Forms.Label NeuronsByLayerLabel;
        private System.Windows.Forms.Label LayersLabel;
        private System.Windows.Forms.NumericUpDown LayersNumber;
        private System.Windows.Forms.Label EpochsLabel;
        private System.Windows.Forms.NumericUpDown EpochsNumber;
        private System.Windows.Forms.Label LearningRateLabel;
        private System.Windows.Forms.NumericUpDown LearningRateNumber;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label SeedLabel;
        private System.Windows.Forms.TextBox SeedTextBox;
        private System.Windows.Forms.Label EffectLabel;
        private System.Windows.Forms.ComboBox ActivationFunctionComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox TrainingFileComboBox;
        private System.Windows.Forms.ComboBox TestingFileComboBox;
        private System.Windows.Forms.RadioButton ClassificationRadioButton;
        private System.Windows.Forms.RadioButton RegressionRadioButton;
        private System.Windows.Forms.GroupBox TypeBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label RLabel;
        private System.Windows.Forms.Label EffectLabel2;
        private System.Windows.Forms.CheckBox BiasesCheckBox;
    }
}

