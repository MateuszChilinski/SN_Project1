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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NeuronsByLayerNumber = new System.Windows.Forms.NumericUpDown();
            this.NeuronsByLayerLabel = new System.Windows.Forms.Label();
            this.LayersLabel = new System.Windows.Forms.Label();
            this.LayersNumber = new System.Windows.Forms.NumericUpDown();
            this.EpochsLabel = new System.Windows.Forms.Label();
            this.EpochsNumber = new System.Windows.Forms.NumericUpDown();
            this.LearningRateLabel = new System.Windows.Forms.Label();
            this.LearningRateNumber = new System.Windows.Forms.NumericUpDown();
            this.RunButton = new System.Windows.Forms.Button();
            this.ChoseTrainingFileTextBox = new System.Windows.Forms.TextBox();
            this.TrainingFileButton = new System.Windows.Forms.Button();
            this.ChooseTestFileButton = new System.Windows.Forms.Button();
            this.ChooseTestFileTextBox = new System.Windows.Forms.TextBox();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.SeedLabel = new System.Windows.Forms.Label();
            this.SeedTextBox = new System.Windows.Forms.TextBox();
            this.EffectLabel = new System.Windows.Forms.Label();
            this.ActivationFunctionComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NeuronsByLayerNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayersNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpochsNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LearningRateNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(521, 337);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // NeuronsByLayerNumber
            // 
            this.NeuronsByLayerNumber.Location = new System.Drawing.Point(686, 36);
            this.NeuronsByLayerNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NeuronsByLayerNumber.Name = "NeuronsByLayerNumber";
            this.NeuronsByLayerNumber.Size = new System.Drawing.Size(120, 26);
            this.NeuronsByLayerNumber.TabIndex = 1;
            this.NeuronsByLayerNumber.TabStop = false;
            this.NeuronsByLayerNumber.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // NeuronsByLayerLabel
            // 
            this.NeuronsByLayerLabel.AutoSize = true;
            this.NeuronsByLayerLabel.Location = new System.Drawing.Point(554, 38);
            this.NeuronsByLayerLabel.Name = "NeuronsByLayerLabel";
            this.NeuronsByLayerLabel.Size = new System.Drawing.Size(126, 20);
            this.NeuronsByLayerLabel.TabIndex = 2;
            this.NeuronsByLayerLabel.Text = "Neurons by layer";
            // 
            // LayersLabel
            // 
            this.LayersLabel.AutoSize = true;
            this.LayersLabel.Location = new System.Drawing.Point(554, 76);
            this.LayersLabel.Name = "LayersLabel";
            this.LayersLabel.Size = new System.Drawing.Size(56, 20);
            this.LayersLabel.TabIndex = 4;
            this.LayersLabel.Text = "Layers";
            // 
            // LayersNumber
            // 
            this.LayersNumber.Location = new System.Drawing.Point(687, 74);
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
            this.LayersNumber.Size = new System.Drawing.Size(120, 26);
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
            this.EpochsLabel.Location = new System.Drawing.Point(555, 115);
            this.EpochsLabel.Name = "EpochsLabel";
            this.EpochsLabel.Size = new System.Drawing.Size(63, 20);
            this.EpochsLabel.TabIndex = 6;
            this.EpochsLabel.Text = "Epochs";
            // 
            // EpochsNumber
            // 
            this.EpochsNumber.Location = new System.Drawing.Point(687, 113);
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
            this.EpochsNumber.Size = new System.Drawing.Size(120, 26);
            this.EpochsNumber.TabIndex = 5;
            this.EpochsNumber.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // LearningRateLabel
            // 
            this.LearningRateLabel.AutoSize = true;
            this.LearningRateLabel.Location = new System.Drawing.Point(554, 156);
            this.LearningRateLabel.Name = "LearningRateLabel";
            this.LearningRateLabel.Size = new System.Drawing.Size(110, 20);
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
            this.LearningRateNumber.Location = new System.Drawing.Point(687, 154);
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
            this.LearningRateNumber.Size = new System.Drawing.Size(120, 26);
            this.LearningRateNumber.TabIndex = 7;
            this.LearningRateNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(539, 310);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(267, 39);
            this.RunButton.TabIndex = 9;
            this.RunButton.Text = "Train and test";
            this.RunButton.UseVisualStyleBackColor = true;
            // 
            // ChoseTrainingFileTextBox
            // 
            this.ChoseTrainingFileTextBox.Location = new System.Drawing.Point(12, 370);
            this.ChoseTrainingFileTextBox.Name = "ChoseTrainingFileTextBox";
            this.ChoseTrainingFileTextBox.Size = new System.Drawing.Size(335, 26);
            this.ChoseTrainingFileTextBox.TabIndex = 10;
            this.ChoseTrainingFileTextBox.Text = "classification/data.three_gauss.train.100.csv";
            // 
            // TrainingFileButton
            // 
            this.TrainingFileButton.Location = new System.Drawing.Point(353, 366);
            this.TrainingFileButton.Name = "TrainingFileButton";
            this.TrainingFileButton.Size = new System.Drawing.Size(180, 35);
            this.TrainingFileButton.TabIndex = 11;
            this.TrainingFileButton.Text = "Choose training file";
            this.TrainingFileButton.UseVisualStyleBackColor = true;
            // 
            // ChooseTestFileButton
            // 
            this.ChooseTestFileButton.Location = new System.Drawing.Point(353, 414);
            this.ChooseTestFileButton.Name = "ChooseTestFileButton";
            this.ChooseTestFileButton.Size = new System.Drawing.Size(180, 35);
            this.ChooseTestFileButton.TabIndex = 13;
            this.ChooseTestFileButton.Text = "Choose testing file";
            this.ChooseTestFileButton.UseVisualStyleBackColor = true;
            // 
            // ChooseTestFileTextBox
            // 
            this.ChooseTestFileTextBox.Location = new System.Drawing.Point(12, 418);
            this.ChooseTestFileTextBox.Name = "ChooseTestFileTextBox";
            this.ChooseTestFileTextBox.Size = new System.Drawing.Size(335, 26);
            this.ChooseTestFileTextBox.TabIndex = 12;
            this.ChooseTestFileTextBox.Text = "classification/data.three_gauss.test.100.csv";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(540, 366);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(266, 35);
            this.ProgressBar.Step = 1;
            this.ProgressBar.TabIndex = 14;
            // 
            // SeedLabel
            // 
            this.SeedLabel.AutoSize = true;
            this.SeedLabel.Location = new System.Drawing.Point(554, 199);
            this.SeedLabel.Name = "SeedLabel";
            this.SeedLabel.Size = new System.Drawing.Size(47, 20);
            this.SeedLabel.TabIndex = 16;
            this.SeedLabel.Text = "Seed";
            // 
            // SeedTextBox
            // 
            this.SeedTextBox.Location = new System.Drawing.Point(687, 196);
            this.SeedTextBox.Name = "SeedTextBox";
            this.SeedTextBox.Size = new System.Drawing.Size(120, 26);
            this.SeedTextBox.TabIndex = 17;
            this.SeedTextBox.Text = "69142";
            // 
            // EffectLabel
            // 
            this.EffectLabel.AutoSize = true;
            this.EffectLabel.Location = new System.Drawing.Point(613, 421);
            this.EffectLabel.Name = "EffectLabel";
            this.EffectLabel.Size = new System.Drawing.Size(136, 20);
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
            "Other"});
            this.ActivationFunctionComboBox.Location = new System.Drawing.Point(687, 238);
            this.ActivationFunctionComboBox.Name = "ActivationFunctionComboBox";
            this.ActivationFunctionComboBox.Size = new System.Drawing.Size(121, 28);
            this.ActivationFunctionComboBox.TabIndex = 19;
            this.ActivationFunctionComboBox.Text = "Tanh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(554, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Activation fun.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 636);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ActivationFunctionComboBox);
            this.Controls.Add(this.EffectLabel);
            this.Controls.Add(this.SeedTextBox);
            this.Controls.Add(this.SeedLabel);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.ChooseTestFileButton);
            this.Controls.Add(this.ChooseTestFileTextBox);
            this.Controls.Add(this.TrainingFileButton);
            this.Controls.Add(this.ChoseTrainingFileTextBox);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.LearningRateLabel);
            this.Controls.Add(this.LearningRateNumber);
            this.Controls.Add(this.EpochsLabel);
            this.Controls.Add(this.EpochsNumber);
            this.Controls.Add(this.LayersLabel);
            this.Controls.Add(this.LayersNumber);
            this.Controls.Add(this.NeuronsByLayerLabel);
            this.Controls.Add(this.NeuronsByLayerNumber);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "SN Proj1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NeuronsByLayerNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayersNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpochsNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LearningRateNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown NeuronsByLayerNumber;
        private System.Windows.Forms.Label NeuronsByLayerLabel;
        private System.Windows.Forms.Label LayersLabel;
        private System.Windows.Forms.NumericUpDown LayersNumber;
        private System.Windows.Forms.Label EpochsLabel;
        private System.Windows.Forms.NumericUpDown EpochsNumber;
        private System.Windows.Forms.Label LearningRateLabel;
        private System.Windows.Forms.NumericUpDown LearningRateNumber;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.TextBox ChoseTrainingFileTextBox;
        private System.Windows.Forms.Button TrainingFileButton;
        private System.Windows.Forms.Button ChooseTestFileButton;
        private System.Windows.Forms.TextBox ChooseTestFileTextBox;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label SeedLabel;
        private System.Windows.Forms.TextBox SeedTextBox;
        private System.Windows.Forms.Label EffectLabel;
        private System.Windows.Forms.ComboBox ActivationFunctionComboBox;
        private System.Windows.Forms.Label label1;
    }
}

