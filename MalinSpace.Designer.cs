namespace MalinAstrionics
{
    partial class MalinSpace
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
            this.TextBoxObserved = new System.Windows.Forms.TextBox();
            this.TextBoxRest = new System.Windows.Forms.TextBox();
            this.groupBoxVelocity = new System.Windows.Forms.GroupBox();
            this.ButtonVelocity = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxDistance = new System.Windows.Forms.GroupBox();
            this.ButtonStarDistance = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxParaAngle = new System.Windows.Forms.TextBox();
            this.groupBoxTemperature = new System.Windows.Forms.GroupBox();
            this.UpDownPlusMinus = new System.Windows.Forms.DomainUpDown();
            this.ButtonKelvin = new System.Windows.Forms.Button();
            this.labelCelsius = new System.Windows.Forms.Label();
            this.TextBoxCelsius = new System.Windows.Forms.TextBox();
            this.groupBoxHorizon = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UpDownNotation = new System.Windows.Forms.NumericUpDown();
            this.ButtonSchRadius = new System.Windows.Forms.Button();
            this.labelMass = new System.Windows.Forms.Label();
            this.TextBoxMass = new System.Windows.Forms.TextBox();
            this.ListViewResults = new System.Windows.Forms.ListView();
            this.columnVelocity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDistance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnKelvin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHorizon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatusStripInfo = new System.Windows.Forms.StatusStrip();
            this.groupBoxFlag = new System.Windows.Forms.GroupBox();
            this.ButtonFrench = new System.Windows.Forms.Button();
            this.ButtonUK = new System.Windows.Forms.Button();
            this.ButtonGerman = new System.Windows.Forms.Button();
            this.groupBoxVelocity.SuspendLayout();
            this.groupBoxDistance.SuspendLayout();
            this.groupBoxTemperature.SuspendLayout();
            this.groupBoxHorizon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownNotation)).BeginInit();
            this.groupBoxFlag.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxObserved
            // 
            this.TextBoxObserved.Location = new System.Drawing.Point(34, 62);
            this.TextBoxObserved.Name = "TextBoxObserved";
            this.TextBoxObserved.Size = new System.Drawing.Size(158, 36);
            this.TextBoxObserved.TabIndex = 4;
            this.TextBoxObserved.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxObserved_KeyPress);
            // 
            // TextBoxRest
            // 
            this.TextBoxRest.Location = new System.Drawing.Point(34, 131);
            this.TextBoxRest.Name = "TextBoxRest";
            this.TextBoxRest.Size = new System.Drawing.Size(158, 36);
            this.TextBoxRest.TabIndex = 5;
            this.TextBoxRest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxObserved_KeyPress);
            // 
            // groupBoxVelocity
            // 
            this.groupBoxVelocity.Controls.Add(this.ButtonVelocity);
            this.groupBoxVelocity.Controls.Add(this.label5);
            this.groupBoxVelocity.Controls.Add(this.label1);
            this.groupBoxVelocity.Controls.Add(this.TextBoxObserved);
            this.groupBoxVelocity.Controls.Add(this.TextBoxRest);
            this.groupBoxVelocity.Font = new System.Drawing.Font("Constantia", 13.8F);
            this.groupBoxVelocity.Location = new System.Drawing.Point(24, 28);
            this.groupBoxVelocity.Name = "groupBoxVelocity";
            this.groupBoxVelocity.Size = new System.Drawing.Size(430, 173);
            this.groupBoxVelocity.TabIndex = 6;
            this.groupBoxVelocity.TabStop = false;
            this.groupBoxVelocity.Text = "Star Velocity";
            // 
            // ButtonVelocity
            // 
            this.ButtonVelocity.Location = new System.Drawing.Point(278, 116);
            this.ButtonVelocity.Name = "ButtonVelocity";
            this.ButtonVelocity.Size = new System.Drawing.Size(135, 51);
            this.ButtonVelocity.TabIndex = 9;
            this.ButtonVelocity.Text = "Calculate";
            this.ButtonVelocity.UseVisualStyleBackColor = true;
            this.ButtonVelocity.Click += new System.EventHandler(this.ButtonVelocity_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rest Wavelenght(nm)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Observed Wavelenght(nm)";
            // 
            // groupBoxDistance
            // 
            this.groupBoxDistance.Controls.Add(this.ButtonStarDistance);
            this.groupBoxDistance.Controls.Add(this.label3);
            this.groupBoxDistance.Controls.Add(this.TextBoxParaAngle);
            this.groupBoxDistance.Font = new System.Drawing.Font("Constantia", 13.8F);
            this.groupBoxDistance.Location = new System.Drawing.Point(24, 246);
            this.groupBoxDistance.Name = "groupBoxDistance";
            this.groupBoxDistance.Size = new System.Drawing.Size(430, 107);
            this.groupBoxDistance.TabIndex = 7;
            this.groupBoxDistance.TabStop = false;
            this.groupBoxDistance.Text = "Star Distance";
            // 
            // ButtonStarDistance
            // 
            this.ButtonStarDistance.Location = new System.Drawing.Point(278, 49);
            this.ButtonStarDistance.Name = "ButtonStarDistance";
            this.ButtonStarDistance.Size = new System.Drawing.Size(135, 51);
            this.ButtonStarDistance.TabIndex = 9;
            this.ButtonStarDistance.Text = "Calculate";
            this.ButtonStarDistance.UseVisualStyleBackColor = true;
            this.ButtonStarDistance.Click += new System.EventHandler(this.ButtonVelocity_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Parallax Angle(arcseconds)";
            // 
            // TextBoxParaAngle
            // 
            this.TextBoxParaAngle.Location = new System.Drawing.Point(34, 64);
            this.TextBoxParaAngle.Name = "TextBoxParaAngle";
            this.TextBoxParaAngle.Size = new System.Drawing.Size(158, 36);
            this.TextBoxParaAngle.TabIndex = 4;
            this.TextBoxParaAngle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxObserved_KeyPress);
            // 
            // groupBoxTemperature
            // 
            this.groupBoxTemperature.Controls.Add(this.UpDownPlusMinus);
            this.groupBoxTemperature.Controls.Add(this.ButtonKelvin);
            this.groupBoxTemperature.Controls.Add(this.labelCelsius);
            this.groupBoxTemperature.Controls.Add(this.TextBoxCelsius);
            this.groupBoxTemperature.Font = new System.Drawing.Font("Constantia", 13.8F);
            this.groupBoxTemperature.Location = new System.Drawing.Point(24, 403);
            this.groupBoxTemperature.Name = "groupBoxTemperature";
            this.groupBoxTemperature.Size = new System.Drawing.Size(430, 108);
            this.groupBoxTemperature.TabIndex = 8;
            this.groupBoxTemperature.TabStop = false;
            this.groupBoxTemperature.Text = "Temperature in Kelvin";
            // 
            // UpDownPlusMinus
            // 
            this.UpDownPlusMinus.Items.Add("+");
            this.UpDownPlusMinus.Items.Add("-");
            this.UpDownPlusMinus.Location = new System.Drawing.Point(6, 65);
            this.UpDownPlusMinus.Name = "UpDownPlusMinus";
            this.UpDownPlusMinus.ReadOnly = true;
            this.UpDownPlusMinus.Size = new System.Drawing.Size(48, 36);
            this.UpDownPlusMinus.TabIndex = 10;
            this.UpDownPlusMinus.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // ButtonKelvin
            // 
            this.ButtonKelvin.Location = new System.Drawing.Point(278, 50);
            this.ButtonKelvin.Name = "ButtonKelvin";
            this.ButtonKelvin.Size = new System.Drawing.Size(135, 51);
            this.ButtonKelvin.TabIndex = 9;
            this.ButtonKelvin.Text = "Calculate";
            this.ButtonKelvin.UseVisualStyleBackColor = true;
            this.ButtonKelvin.Click += new System.EventHandler(this.ButtonVelocity_Click);
            // 
            // labelCelsius
            // 
            this.labelCelsius.AutoSize = true;
            this.labelCelsius.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCelsius.Location = new System.Drawing.Point(21, 38);
            this.labelCelsius.Name = "labelCelsius";
            this.labelCelsius.Size = new System.Drawing.Size(140, 21);
            this.labelCelsius.TabIndex = 6;
            this.labelCelsius.Text = "Celsius(degree C)";
            // 
            // TextBoxCelsius
            // 
            this.TextBoxCelsius.Location = new System.Drawing.Point(60, 64);
            this.TextBoxCelsius.Name = "TextBoxCelsius";
            this.TextBoxCelsius.Size = new System.Drawing.Size(158, 36);
            this.TextBoxCelsius.TabIndex = 4;
            this.TextBoxCelsius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxObserved_KeyPress);
            // 
            // groupBoxHorizon
            // 
            this.groupBoxHorizon.Controls.Add(this.label2);
            this.groupBoxHorizon.Controls.Add(this.UpDownNotation);
            this.groupBoxHorizon.Controls.Add(this.ButtonSchRadius);
            this.groupBoxHorizon.Controls.Add(this.labelMass);
            this.groupBoxHorizon.Controls.Add(this.TextBoxMass);
            this.groupBoxHorizon.Font = new System.Drawing.Font("Constantia", 13.8F);
            this.groupBoxHorizon.Location = new System.Drawing.Point(24, 561);
            this.groupBoxHorizon.Name = "groupBoxHorizon";
            this.groupBoxHorizon.Size = new System.Drawing.Size(430, 108);
            this.groupBoxHorizon.TabIndex = 9;
            this.groupBoxHorizon.TabStop = false;
            this.groupBoxHorizon.Text = "Event Horizon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(174, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "* 10";
            // 
            // UpDownNotation
            // 
            this.UpDownNotation.Location = new System.Drawing.Point(194, 37);
            this.UpDownNotation.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            -2147483648});
            this.UpDownNotation.Name = "UpDownNotation";
            this.UpDownNotation.Size = new System.Drawing.Size(59, 36);
            this.UpDownNotation.TabIndex = 10;
            this.UpDownNotation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpDownNotation.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ButtonSchRadius
            // 
            this.ButtonSchRadius.Location = new System.Drawing.Point(278, 50);
            this.ButtonSchRadius.Name = "ButtonSchRadius";
            this.ButtonSchRadius.Size = new System.Drawing.Size(135, 51);
            this.ButtonSchRadius.TabIndex = 9;
            this.ButtonSchRadius.Text = "Calculate";
            this.ButtonSchRadius.UseVisualStyleBackColor = true;
            this.ButtonSchRadius.Click += new System.EventHandler(this.ButtonVelocity_Click);
            // 
            // labelMass
            // 
            this.labelMass.AutoSize = true;
            this.labelMass.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMass.Location = new System.Drawing.Point(21, 38);
            this.labelMass.Name = "labelMass";
            this.labelMass.Size = new System.Drawing.Size(155, 21);
            this.labelMass.TabIndex = 6;
            this.labelMass.Text = "Blackhole Mass(Kg)";
            // 
            // TextBoxMass
            // 
            this.TextBoxMass.Location = new System.Drawing.Point(34, 64);
            this.TextBoxMass.Name = "TextBoxMass";
            this.TextBoxMass.Size = new System.Drawing.Size(142, 36);
            this.TextBoxMass.TabIndex = 4;
            this.TextBoxMass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxObserved_KeyPress);
            // 
            // ListViewResults
            // 
            this.ListViewResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnVelocity,
            this.columnDistance,
            this.columnKelvin,
            this.columnHorizon});
            this.ListViewResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListViewResults.HideSelection = false;
            this.ListViewResults.Location = new System.Drawing.Point(479, 51);
            this.ListViewResults.Margin = new System.Windows.Forms.Padding(4);
            this.ListViewResults.Name = "ListViewResults";
            this.ListViewResults.Size = new System.Drawing.Size(728, 502);
            this.ListViewResults.TabIndex = 31;
            this.ListViewResults.UseCompatibleStateImageBehavior = false;
            this.ListViewResults.View = System.Windows.Forms.View.Details;
            // 
            // columnVelocity
            // 
            this.columnVelocity.Text = "Star Velocity (m/s)";
            this.columnVelocity.Width = 170;
            // 
            // columnDistance
            // 
            this.columnDistance.Text = "Star Distance (parsec)";
            this.columnDistance.Width = 192;
            // 
            // columnKelvin
            // 
            this.columnKelvin.Text = "Kelvin (K)";
            this.columnKelvin.Width = 107;
            // 
            // columnHorizon
            // 
            this.columnHorizon.Text = "Event horizon (metres)";
            this.columnHorizon.Width = 199;
            // 
            // StatusStripInfo
            // 
            this.StatusStripInfo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStripInfo.Location = new System.Drawing.Point(0, 675);
            this.StatusStripInfo.Name = "StatusStripInfo";
            this.StatusStripInfo.Size = new System.Drawing.Size(1237, 22);
            this.StatusStripInfo.TabIndex = 32;
            this.StatusStripInfo.Text = "TestInfomation";
            // 
            // groupBoxFlag
            // 
            this.groupBoxFlag.Controls.Add(this.ButtonFrench);
            this.groupBoxFlag.Controls.Add(this.ButtonUK);
            this.groupBoxFlag.Controls.Add(this.ButtonGerman);
            this.groupBoxFlag.Location = new System.Drawing.Point(508, 565);
            this.groupBoxFlag.Name = "groupBoxFlag";
            this.groupBoxFlag.Size = new System.Drawing.Size(676, 93);
            this.groupBoxFlag.TabIndex = 33;
            this.groupBoxFlag.TabStop = false;
            // 
            // ButtonFrench
            // 
            this.ButtonFrench.BackgroundImage = global::MalinAstrionics.Properties.Resources.france;
            this.ButtonFrench.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonFrench.Location = new System.Drawing.Point(281, 22);
            this.ButtonFrench.Name = "ButtonFrench";
            this.ButtonFrench.Size = new System.Drawing.Size(120, 66);
            this.ButtonFrench.TabIndex = 4;
            this.ButtonFrench.UseVisualStyleBackColor = true;
            this.ButtonFrench.Click += new System.EventHandler(this.ButtonUK_Click);
            // 
            // ButtonUK
            // 
            this.ButtonUK.BackgroundImage = global::MalinAstrionics.Properties.Resources.uk;
            this.ButtonUK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonUK.ImageIndex = 0;
            this.ButtonUK.Location = new System.Drawing.Point(84, 21);
            this.ButtonUK.Name = "ButtonUK";
            this.ButtonUK.Size = new System.Drawing.Size(120, 66);
            this.ButtonUK.TabIndex = 3;
            this.ButtonUK.UseVisualStyleBackColor = true;
            // 
            // ButtonGerman
            // 
            this.ButtonGerman.BackgroundImage = global::MalinAstrionics.Properties.Resources.germanySQ;
            this.ButtonGerman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonGerman.Location = new System.Drawing.Point(482, 21);
            this.ButtonGerman.Name = "ButtonGerman";
            this.ButtonGerman.Size = new System.Drawing.Size(120, 66);
            this.ButtonGerman.TabIndex = 2;
            this.ButtonGerman.UseVisualStyleBackColor = true;
            this.ButtonGerman.Click += new System.EventHandler(this.ButtonUK_Click);
            // 
            // MalinSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 697);
            this.Controls.Add(this.groupBoxFlag);
            this.Controls.Add(this.StatusStripInfo);
            this.Controls.Add(this.ListViewResults);
            this.Controls.Add(this.groupBoxHorizon);
            this.Controls.Add(this.groupBoxTemperature);
            this.Controls.Add(this.groupBoxDistance);
            this.Controls.Add(this.groupBoxVelocity);
            this.Name = "MalinSpace";
            this.Text = "MalinSpace";
            this.Load += new System.EventHandler(this.MalinSpace_Load);
            this.groupBoxVelocity.ResumeLayout(false);
            this.groupBoxVelocity.PerformLayout();
            this.groupBoxDistance.ResumeLayout(false);
            this.groupBoxDistance.PerformLayout();
            this.groupBoxTemperature.ResumeLayout(false);
            this.groupBoxTemperature.PerformLayout();
            this.groupBoxHorizon.ResumeLayout(false);
            this.groupBoxHorizon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownNotation)).EndInit();
            this.groupBoxFlag.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextBoxObserved;
        private System.Windows.Forms.TextBox TextBoxRest;
        private System.Windows.Forms.GroupBox groupBoxVelocity;
        private System.Windows.Forms.Button ButtonVelocity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxDistance;
        private System.Windows.Forms.Button ButtonStarDistance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxParaAngle;
        private System.Windows.Forms.GroupBox groupBoxTemperature;
        private System.Windows.Forms.Button ButtonKelvin;
        private System.Windows.Forms.Label labelCelsius;
        private System.Windows.Forms.TextBox TextBoxCelsius;
        private System.Windows.Forms.GroupBox groupBoxHorizon;
        private System.Windows.Forms.Button ButtonSchRadius;
        private System.Windows.Forms.Label labelMass;
        private System.Windows.Forms.TextBox TextBoxMass;
        private System.Windows.Forms.ListView ListViewResults;
        private System.Windows.Forms.ColumnHeader columnVelocity;
        private System.Windows.Forms.ColumnHeader columnDistance;
        private System.Windows.Forms.ColumnHeader columnKelvin;
        private System.Windows.Forms.ColumnHeader columnHorizon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown UpDownNotation;
        private System.Windows.Forms.DomainUpDown UpDownPlusMinus;
        private System.Windows.Forms.StatusStrip StatusStripInfo;
        private System.Windows.Forms.GroupBox groupBoxFlag;
        private System.Windows.Forms.Button ButtonGerman;
        private System.Windows.Forms.Button ButtonFrench;
        private System.Windows.Forms.Button ButtonUK;
    }
}