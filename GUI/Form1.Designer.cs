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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.RunButton = new System.Windows.Forms.Button();
            this.ChoseTrainingFileTextBox = new System.Windows.Forms.TextBox();
            this.TrainingFileButton = new System.Windows.Forms.Button();
            this.ChooseTestFileButton = new System.Windows.Forms.Button();
            this.ChooseTestFileTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NeuronsByLayerNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayersNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpochsNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            10,
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
            this.LayersLabel.Location = new System.Drawing.Point(554, 70);
            this.LayersLabel.Name = "LayersLabel";
            this.LayersLabel.Size = new System.Drawing.Size(56, 20);
            this.LayersLabel.TabIndex = 4;
            this.LayersLabel.Text = "Layers";
            // 
            // LayersNumber
            // 
            this.LayersNumber.Location = new System.Drawing.Point(686, 68);
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
            3,
            0,
            0,
            0});
            // 
            // EpochsLabel
            // 
            this.EpochsLabel.AutoSize = true;
            this.EpochsLabel.Location = new System.Drawing.Point(554, 102);
            this.EpochsLabel.Name = "EpochsLabel";
            this.EpochsLabel.Size = new System.Drawing.Size(63, 20);
            this.EpochsLabel.TabIndex = 6;
            this.EpochsLabel.Text = "Epochs";
            // 
            // EpochsNumber
            // 
            this.EpochsNumber.Location = new System.Drawing.Point(686, 100);
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
            10,
            0,
            0,
            0});
            // 
            // LearningRateLabel
            // 
            this.LearningRateLabel.AutoSize = true;
            this.LearningRateLabel.Location = new System.Drawing.Point(554, 134);
            this.LearningRateLabel.Name = "LearningRateLabel";
            this.LearningRateLabel.Size = new System.Drawing.Size(110, 20);
            this.LearningRateLabel.TabIndex = 8;
            this.LearningRateLabel.Text = "Learning Rate";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericUpDown1.Location = new System.Drawing.Point(686, 132);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(741, 322);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(248, 39);
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
            // 
            // TrainingFileButton
            // 
            this.TrainingFileButton.Location = new System.Drawing.Point(353, 366);
            this.TrainingFileButton.Name = "TrainingFileButton";
            this.TrainingFileButton.Size = new System.Drawing.Size(180, 35);
            this.TrainingFileButton.TabIndex = 11;
            this.TrainingFileButton.Text = "Choose training file";
            this.TrainingFileButton.UseVisualStyleBackColor = true;
            this.TrainingFileButton.Click += new System.EventHandler(this.TrainingFileButton_Click);
            // 
            // ChooseTestFileButton
            // 
            this.ChooseTestFileButton.Location = new System.Drawing.Point(353, 414);
            this.ChooseTestFileButton.Name = "ChooseTestFileButton";
            this.ChooseTestFileButton.Size = new System.Drawing.Size(180, 35);
            this.ChooseTestFileButton.TabIndex = 13;
            this.ChooseTestFileButton.Text = "Choose testing file";
            this.ChooseTestFileButton.UseVisualStyleBackColor = true;
            this.ChooseTestFileButton.Click += new System.EventHandler(this.ChooseTestFileButton_Click);
            // 
            // ChooseTestFileTextBox
            // 
            this.ChooseTestFileTextBox.Location = new System.Drawing.Point(12, 418);
            this.ChooseTestFileTextBox.Name = "ChooseTestFileTextBox";
            this.ChooseTestFileTextBox.Size = new System.Drawing.Size(335, 26);
            this.ChooseTestFileTextBox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 636);
            this.Controls.Add(this.ChooseTestFileButton);
            this.Controls.Add(this.ChooseTestFileTextBox);
            this.Controls.Add(this.TrainingFileButton);
            this.Controls.Add(this.ChoseTrainingFileTextBox);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.LearningRateLabel);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.EpochsLabel);
            this.Controls.Add(this.EpochsNumber);
            this.Controls.Add(this.LayersLabel);
            this.Controls.Add(this.LayersNumber);
            this.Controls.Add(this.NeuronsByLayerLabel);
            this.Controls.Add(this.NeuronsByLayerNumber);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NeuronsByLayerNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayersNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpochsNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.TextBox ChoseTrainingFileTextBox;
        private System.Windows.Forms.Button TrainingFileButton;
        private System.Windows.Forms.Button ChooseTestFileButton;
        private System.Windows.Forms.TextBox ChooseTestFileTextBox;
    }
}

