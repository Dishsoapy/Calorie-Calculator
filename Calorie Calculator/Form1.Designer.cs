namespace Calorie_Calculator
{
    partial class formBMRCalculator
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.RichTextBox richTextHeading;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formBMRCalculator));
            this.numWeightKg = new System.Windows.Forms.NumericUpDown();
            this.numHeightInCm = new System.Windows.Forms.NumericUpDown();
            this.label_CurrentWeight = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.buttonFinalConversion = new System.Windows.Forms.Button();
            this.numFeet = new System.Windows.Forms.NumericUpDown();
            this.numInches = new System.Windows.Forms.NumericUpDown();
            this.cbMale = new System.Windows.Forms.CheckBox();
            this.cbFemale = new System.Windows.Forms.CheckBox();
            this.numWeightlbs = new System.Windows.Forms.NumericUpDown();
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxActivityLevel = new System.Windows.Forms.GroupBox();
            this.cbVery = new System.Windows.Forms.CheckBox();
            this.cbModerate = new System.Windows.Forms.CheckBox();
            this.cbLight = new System.Windows.Forms.CheckBox();
            this.cbSedentary = new System.Windows.Forms.CheckBox();
            this.textBoxBMR = new System.Windows.Forms.TextBox();
            this.linkLabelMe = new System.Windows.Forms.LinkLabel();
            richTextHeading = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numWeightKg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeightInCm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFeet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeightlbs)).BeginInit();
            this.groupBoxGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.groupBoxActivityLevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextHeading
            // 
            richTextHeading.AcceptsTab = true;
            richTextHeading.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            richTextHeading.ForeColor = System.Drawing.SystemColors.InfoText;
            richTextHeading.Location = new System.Drawing.Point(12, 3);
            richTextHeading.Name = "richTextHeading";
            richTextHeading.ReadOnly = true;
            richTextHeading.Size = new System.Drawing.Size(680, 99);
            richTextHeading.TabIndex = 14;
            richTextHeading.Text = resources.GetString("richTextHeading.Text");
            richTextHeading.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextHeading_LinkClicked);
            // 
            // numWeightKg
            // 
            this.numWeightKg.DecimalPlaces = 2;
            this.numWeightKg.Location = new System.Drawing.Point(125, 117);
            this.numWeightKg.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numWeightKg.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWeightKg.Name = "numWeightKg";
            this.numWeightKg.Size = new System.Drawing.Size(120, 20);
            this.numWeightKg.TabIndex = 0;
            this.numWeightKg.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numHeightInCm
            // 
            this.numHeightInCm.DecimalPlaces = 2;
            this.numHeightInCm.Location = new System.Drawing.Point(125, 147);
            this.numHeightInCm.Maximum = new decimal(new int[] {
            350,
            0,
            0,
            0});
            this.numHeightInCm.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHeightInCm.Name = "numHeightInCm";
            this.numHeightInCm.Size = new System.Drawing.Size(120, 20);
            this.numHeightInCm.TabIndex = 1;
            this.numHeightInCm.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_CurrentWeight
            // 
            this.label_CurrentWeight.AutoSize = true;
            this.label_CurrentWeight.Location = new System.Drawing.Point(56, 122);
            this.label_CurrentWeight.Name = "label_CurrentWeight";
            this.label_CurrentWeight.Size = new System.Drawing.Size(62, 13);
            this.label_CurrentWeight.TabIndex = 2;
            this.label_CurrentWeight.Text = "Weight (kg)";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(57, 149);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(61, 13);
            this.labelHeight.TabIndex = 3;
            this.labelHeight.Text = "Height (cm)";
            // 
            // buttonConvert
            // 
            this.buttonConvert.AutoSize = true;
            this.buttonConvert.Location = new System.Drawing.Point(264, 147);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(146, 23);
            this.buttonConvert.TabIndex = 4;
            this.buttonConvert.Text = "Convert Imperial to Metric";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // buttonFinalConversion
            // 
            this.buttonFinalConversion.Enabled = false;
            this.buttonFinalConversion.Location = new System.Drawing.Point(447, 216);
            this.buttonFinalConversion.Name = "buttonFinalConversion";
            this.buttonFinalConversion.Size = new System.Drawing.Size(75, 23);
            this.buttonFinalConversion.TabIndex = 5;
            this.buttonFinalConversion.Text = "Convert";
            this.buttonFinalConversion.UseVisualStyleBackColor = true;
            this.buttonFinalConversion.Visible = false;
            this.buttonFinalConversion.Click += new System.EventHandler(this.buttonFinalConversion_Click);
            // 
            // numFeet
            // 
            this.numFeet.Enabled = false;
            this.numFeet.Location = new System.Drawing.Point(427, 147);
            this.numFeet.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numFeet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFeet.Name = "numFeet";
            this.numFeet.Size = new System.Drawing.Size(120, 20);
            this.numFeet.TabIndex = 6;
            this.numFeet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFeet.Visible = false;
            // 
            // numInches
            // 
            this.numInches.Enabled = false;
            this.numInches.Location = new System.Drawing.Point(427, 178);
            this.numInches.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numInches.Name = "numInches";
            this.numInches.Size = new System.Drawing.Size(120, 20);
            this.numInches.TabIndex = 7;
            this.numInches.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numInches.Visible = false;
            // 
            // cbMale
            // 
            this.cbMale.AutoSize = true;
            this.cbMale.Location = new System.Drawing.Point(20, 42);
            this.cbMale.Name = "cbMale";
            this.cbMale.Size = new System.Drawing.Size(49, 17);
            this.cbMale.TabIndex = 8;
            this.cbMale.Text = "Male";
            this.cbMale.UseVisualStyleBackColor = true;
            this.cbMale.CheckedChanged += new System.EventHandler(this.cbMale_CheckedChanged);
            // 
            // cbFemale
            // 
            this.cbFemale.AutoSize = true;
            this.cbFemale.Location = new System.Drawing.Point(109, 42);
            this.cbFemale.Name = "cbFemale";
            this.cbFemale.Size = new System.Drawing.Size(60, 17);
            this.cbFemale.TabIndex = 9;
            this.cbFemale.Text = "Female";
            this.cbFemale.UseVisualStyleBackColor = true;
            this.cbFemale.CheckedChanged += new System.EventHandler(this.cbFemale_CheckedChanged);
            // 
            // numWeightlbs
            // 
            this.numWeightlbs.DecimalPlaces = 1;
            this.numWeightlbs.Enabled = false;
            this.numWeightlbs.Location = new System.Drawing.Point(427, 117);
            this.numWeightlbs.Maximum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.numWeightlbs.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWeightlbs.Name = "numWeightlbs";
            this.numWeightlbs.Size = new System.Drawing.Size(120, 20);
            this.numWeightlbs.TabIndex = 10;
            this.numWeightlbs.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWeightlbs.Visible = false;
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.Controls.Add(this.cbMale);
            this.groupBoxGender.Controls.Add(this.cbFemale);
            this.groupBoxGender.Location = new System.Drawing.Point(45, 216);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Size = new System.Drawing.Size(200, 100);
            this.groupBoxGender.TabIndex = 11;
            this.groupBoxGender.TabStop = false;
            this.groupBoxGender.Text = "Biological Gender";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(92, 180);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(26, 13);
            this.labelAge.TabIndex = 12;
            this.labelAge.Text = "Age";
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(125, 178);
            this.numAge.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numAge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(120, 20);
            this.numAge.TabIndex = 13;
            this.numAge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(596, 346);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 16;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // groupBoxActivityLevel
            // 
            this.groupBoxActivityLevel.Controls.Add(this.cbVery);
            this.groupBoxActivityLevel.Controls.Add(this.cbModerate);
            this.groupBoxActivityLevel.Controls.Add(this.cbLight);
            this.groupBoxActivityLevel.Controls.Add(this.cbSedentary);
            this.groupBoxActivityLevel.Location = new System.Drawing.Point(45, 322);
            this.groupBoxActivityLevel.Name = "groupBoxActivityLevel";
            this.groupBoxActivityLevel.Size = new System.Drawing.Size(502, 69);
            this.groupBoxActivityLevel.TabIndex = 17;
            this.groupBoxActivityLevel.TabStop = false;
            this.groupBoxActivityLevel.Text = "Activity Level";
            // 
            // cbVery
            // 
            this.cbVery.AutoSize = true;
            this.cbVery.Location = new System.Drawing.Point(382, 28);
            this.cbVery.Name = "cbVery";
            this.cbVery.Size = new System.Drawing.Size(80, 17);
            this.cbVery.TabIndex = 21;
            this.cbVery.Text = "Very Active";
            this.cbVery.UseVisualStyleBackColor = true;
            this.cbVery.CheckedChanged += new System.EventHandler(this.cbVery_CheckedChanged);
            // 
            // cbModerate
            // 
            this.cbModerate.AutoSize = true;
            this.cbModerate.Location = new System.Drawing.Point(244, 28);
            this.cbModerate.Name = "cbModerate";
            this.cbModerate.Size = new System.Drawing.Size(111, 17);
            this.cbModerate.TabIndex = 20;
            this.cbModerate.Text = "Moderately Active";
            this.cbModerate.UseVisualStyleBackColor = true;
            this.cbModerate.CheckedChanged += new System.EventHandler(this.cbModerate_CheckedChanged);
            // 
            // cbLight
            // 
            this.cbLight.AutoSize = true;
            this.cbLight.Location = new System.Drawing.Point(126, 28);
            this.cbLight.Name = "cbLight";
            this.cbLight.Size = new System.Drawing.Size(89, 17);
            this.cbLight.TabIndex = 19;
            this.cbLight.Text = "Lightly Active";
            this.cbLight.UseVisualStyleBackColor = true;
            this.cbLight.CheckedChanged += new System.EventHandler(this.cbLight_CheckedChanged);
            // 
            // cbSedentary
            // 
            this.cbSedentary.AutoSize = true;
            this.cbSedentary.Location = new System.Drawing.Point(20, 28);
            this.cbSedentary.Name = "cbSedentary";
            this.cbSedentary.Size = new System.Drawing.Size(74, 17);
            this.cbSedentary.TabIndex = 18;
            this.cbSedentary.Text = "Sedentary";
            this.cbSedentary.UseVisualStyleBackColor = true;
            this.cbSedentary.CheckedChanged += new System.EventHandler(this.cbSedentary_CheckedChanged);
            // 
            // textBoxBMR
            // 
            this.textBoxBMR.BackColor = System.Drawing.Color.LightGray;
            this.textBoxBMR.Enabled = false;
            this.textBoxBMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBMR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxBMR.Location = new System.Drawing.Point(149, 413);
            this.textBoxBMR.Name = "textBoxBMR";
            this.textBoxBMR.ReadOnly = true;
            this.textBoxBMR.Size = new System.Drawing.Size(400, 38);
            this.textBoxBMR.TabIndex = 22;
            this.textBoxBMR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxBMR.Visible = false;
            // 
            // linkLabelMe
            // 
            this.linkLabelMe.AutoSize = true;
            this.linkLabelMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelMe.LinkColor = System.Drawing.Color.Crimson;
            this.linkLabelMe.Location = new System.Drawing.Point(567, 532);
            this.linkLabelMe.Name = "linkLabelMe";
            this.linkLabelMe.Size = new System.Drawing.Size(125, 20);
            this.linkLabelMe.TabIndex = 23;
            this.linkLabelMe.TabStop = true;
            this.linkLabelMe.Text = "Visit My Website";
            this.linkLabelMe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelMe_LinkClicked);
            // 
            // formBMRCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(704, 561);
            this.Controls.Add(this.linkLabelMe);
            this.Controls.Add(this.textBoxBMR);
            this.Controls.Add(this.groupBoxActivityLevel);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(richTextHeading);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.groupBoxGender);
            this.Controls.Add(this.numWeightlbs);
            this.Controls.Add(this.numInches);
            this.Controls.Add(this.numFeet);
            this.Controls.Add(this.buttonFinalConversion);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.label_CurrentWeight);
            this.Controls.Add(this.numHeightInCm);
            this.Controls.Add(this.numWeightKg);
            this.MaximumSize = new System.Drawing.Size(720, 600);
            this.MinimumSize = new System.Drawing.Size(720, 600);
            this.Name = "formBMRCalculator";
            this.Text = "BMR Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.numWeightKg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeightInCm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFeet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeightlbs)).EndInit();
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.groupBoxActivityLevel.ResumeLayout(false);
            this.groupBoxActivityLevel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numWeightKg;
        private System.Windows.Forms.NumericUpDown numHeightInCm;
        private System.Windows.Forms.Label label_CurrentWeight;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Button buttonFinalConversion;
        private System.Windows.Forms.NumericUpDown numFeet;
        private System.Windows.Forms.NumericUpDown numInches;
        private System.Windows.Forms.CheckBox cbMale;
        private System.Windows.Forms.CheckBox cbFemale;
        private System.Windows.Forms.NumericUpDown numWeightlbs;
        private System.Windows.Forms.GroupBox groupBoxGender;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.GroupBox groupBoxActivityLevel;
        private System.Windows.Forms.CheckBox cbLight;
        private System.Windows.Forms.CheckBox cbSedentary;
        private System.Windows.Forms.CheckBox cbVery;
        private System.Windows.Forms.CheckBox cbModerate;
        private System.Windows.Forms.TextBox textBoxBMR;
        private System.Windows.Forms.LinkLabel linkLabelMe;
    }
}

