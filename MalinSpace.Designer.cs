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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MalinSpace));
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.styleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxVelocity.SuspendLayout();
            this.groupBoxDistance.SuspendLayout();
            this.groupBoxTemperature.SuspendLayout();
            this.groupBoxHorizon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownNotation)).BeginInit();
            this.groupBoxFlag.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxObserved
            // 
            resources.ApplyResources(this.TextBoxObserved, "TextBoxObserved");
            this.TextBoxObserved.Name = "TextBoxObserved";
            this.TextBoxObserved.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxObserved_KeyPress);
            // 
            // TextBoxRest
            // 
            resources.ApplyResources(this.TextBoxRest, "TextBoxRest");
            this.TextBoxRest.Name = "TextBoxRest";
            this.TextBoxRest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxObserved_KeyPress);
            // 
            // groupBoxVelocity
            // 
            this.groupBoxVelocity.Controls.Add(this.ButtonVelocity);
            this.groupBoxVelocity.Controls.Add(this.label5);
            this.groupBoxVelocity.Controls.Add(this.label1);
            this.groupBoxVelocity.Controls.Add(this.TextBoxObserved);
            this.groupBoxVelocity.Controls.Add(this.TextBoxRest);
            resources.ApplyResources(this.groupBoxVelocity, "groupBoxVelocity");
            this.groupBoxVelocity.Name = "groupBoxVelocity";
            this.groupBoxVelocity.TabStop = false;
            // 
            // ButtonVelocity
            // 
            resources.ApplyResources(this.ButtonVelocity, "ButtonVelocity");
            this.ButtonVelocity.Name = "ButtonVelocity";
            this.ButtonVelocity.UseVisualStyleBackColor = true;
            this.ButtonVelocity.Click += new System.EventHandler(this.ButtonVelocity_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBoxDistance
            // 
            this.groupBoxDistance.Controls.Add(this.ButtonStarDistance);
            this.groupBoxDistance.Controls.Add(this.label3);
            this.groupBoxDistance.Controls.Add(this.TextBoxParaAngle);
            resources.ApplyResources(this.groupBoxDistance, "groupBoxDistance");
            this.groupBoxDistance.Name = "groupBoxDistance";
            this.groupBoxDistance.TabStop = false;
            // 
            // ButtonStarDistance
            // 
            resources.ApplyResources(this.ButtonStarDistance, "ButtonStarDistance");
            this.ButtonStarDistance.Name = "ButtonStarDistance";
            this.ButtonStarDistance.UseVisualStyleBackColor = true;
            this.ButtonStarDistance.Click += new System.EventHandler(this.ButtonVelocity_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // TextBoxParaAngle
            // 
            resources.ApplyResources(this.TextBoxParaAngle, "TextBoxParaAngle");
            this.TextBoxParaAngle.Name = "TextBoxParaAngle";
            this.TextBoxParaAngle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxObserved_KeyPress);
            // 
            // groupBoxTemperature
            // 
            this.groupBoxTemperature.Controls.Add(this.UpDownPlusMinus);
            this.groupBoxTemperature.Controls.Add(this.ButtonKelvin);
            this.groupBoxTemperature.Controls.Add(this.labelCelsius);
            this.groupBoxTemperature.Controls.Add(this.TextBoxCelsius);
            resources.ApplyResources(this.groupBoxTemperature, "groupBoxTemperature");
            this.groupBoxTemperature.Name = "groupBoxTemperature";
            this.groupBoxTemperature.TabStop = false;
            // 
            // UpDownPlusMinus
            // 
            this.UpDownPlusMinus.Items.Add(resources.GetString("UpDownPlusMinus.Items"));
            this.UpDownPlusMinus.Items.Add(resources.GetString("UpDownPlusMinus.Items1"));
            resources.ApplyResources(this.UpDownPlusMinus, "UpDownPlusMinus");
            this.UpDownPlusMinus.Name = "UpDownPlusMinus";
            this.UpDownPlusMinus.ReadOnly = true;
            // 
            // ButtonKelvin
            // 
            resources.ApplyResources(this.ButtonKelvin, "ButtonKelvin");
            this.ButtonKelvin.Name = "ButtonKelvin";
            this.ButtonKelvin.UseVisualStyleBackColor = true;
            this.ButtonKelvin.Click += new System.EventHandler(this.ButtonVelocity_Click);
            // 
            // labelCelsius
            // 
            resources.ApplyResources(this.labelCelsius, "labelCelsius");
            this.labelCelsius.Name = "labelCelsius";
            // 
            // TextBoxCelsius
            // 
            resources.ApplyResources(this.TextBoxCelsius, "TextBoxCelsius");
            this.TextBoxCelsius.Name = "TextBoxCelsius";
            this.TextBoxCelsius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxObserved_KeyPress);
            // 
            // groupBoxHorizon
            // 
            this.groupBoxHorizon.Controls.Add(this.label2);
            this.groupBoxHorizon.Controls.Add(this.UpDownNotation);
            this.groupBoxHorizon.Controls.Add(this.ButtonSchRadius);
            this.groupBoxHorizon.Controls.Add(this.labelMass);
            this.groupBoxHorizon.Controls.Add(this.TextBoxMass);
            resources.ApplyResources(this.groupBoxHorizon, "groupBoxHorizon");
            this.groupBoxHorizon.Name = "groupBoxHorizon";
            this.groupBoxHorizon.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // UpDownNotation
            // 
            resources.ApplyResources(this.UpDownNotation, "UpDownNotation");
            this.UpDownNotation.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            -2147483648});
            this.UpDownNotation.Name = "UpDownNotation";
            this.UpDownNotation.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ButtonSchRadius
            // 
            resources.ApplyResources(this.ButtonSchRadius, "ButtonSchRadius");
            this.ButtonSchRadius.Name = "ButtonSchRadius";
            this.ButtonSchRadius.UseVisualStyleBackColor = true;
            this.ButtonSchRadius.Click += new System.EventHandler(this.ButtonVelocity_Click);
            // 
            // labelMass
            // 
            resources.ApplyResources(this.labelMass, "labelMass");
            this.labelMass.Name = "labelMass";
            // 
            // TextBoxMass
            // 
            resources.ApplyResources(this.TextBoxMass, "TextBoxMass");
            this.TextBoxMass.Name = "TextBoxMass";
            this.TextBoxMass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxObserved_KeyPress);
            // 
            // ListViewResults
            // 
            this.ListViewResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnVelocity,
            this.columnDistance,
            this.columnKelvin,
            this.columnHorizon});
            resources.ApplyResources(this.ListViewResults, "ListViewResults");
            this.ListViewResults.HideSelection = false;
            this.ListViewResults.Name = "ListViewResults";
            this.ListViewResults.UseCompatibleStateImageBehavior = false;
            this.ListViewResults.View = System.Windows.Forms.View.Details;
            // 
            // columnVelocity
            // 
            resources.ApplyResources(this.columnVelocity, "columnVelocity");
            // 
            // columnDistance
            // 
            resources.ApplyResources(this.columnDistance, "columnDistance");
            // 
            // columnKelvin
            // 
            resources.ApplyResources(this.columnKelvin, "columnKelvin");
            // 
            // columnHorizon
            // 
            resources.ApplyResources(this.columnHorizon, "columnHorizon");
            // 
            // StatusStripInfo
            // 
            this.StatusStripInfo.ImageScalingSize = new System.Drawing.Size(20, 20);
            resources.ApplyResources(this.StatusStripInfo, "StatusStripInfo");
            this.StatusStripInfo.Name = "StatusStripInfo";
            // 
            // groupBoxFlag
            // 
            this.groupBoxFlag.Controls.Add(this.ButtonFrench);
            this.groupBoxFlag.Controls.Add(this.ButtonUK);
            this.groupBoxFlag.Controls.Add(this.ButtonGerman);
            resources.ApplyResources(this.groupBoxFlag, "groupBoxFlag");
            this.groupBoxFlag.Name = "groupBoxFlag";
            this.groupBoxFlag.TabStop = false;
            // 
            // ButtonFrench
            // 
            this.ButtonFrench.BackgroundImage = global::MalinAstrionics.Properties.Resources.france;
            resources.ApplyResources(this.ButtonFrench, "ButtonFrench");
            this.ButtonFrench.Name = "ButtonFrench";
            this.ButtonFrench.UseVisualStyleBackColor = true;
            this.ButtonFrench.Click += new System.EventHandler(this.ButtonUK_Click);
            // 
            // ButtonUK
            // 
            this.ButtonUK.BackgroundImage = global::MalinAstrionics.Properties.Resources.uk;
            resources.ApplyResources(this.ButtonUK, "ButtonUK");
            this.ButtonUK.Name = "ButtonUK";
            this.ButtonUK.UseVisualStyleBackColor = true;
            this.ButtonUK.Click += new System.EventHandler(this.ButtonUK_Click);
            // 
            // ButtonGerman
            // 
            this.ButtonGerman.BackgroundImage = global::MalinAstrionics.Properties.Resources.germanySQ;
            resources.ApplyResources(this.ButtonGerman, "ButtonGerman");
            this.ButtonGerman.Name = "ButtonGerman";
            this.ButtonGerman.UseVisualStyleBackColor = true;
            this.ButtonGerman.Click += new System.EventHandler(this.ButtonUK_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.styleToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // styleToolStripMenuItem
            // 
            this.styleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modeToolStripMenuItem,
            this.colourToolStripMenuItem});
            this.styleToolStripMenuItem.Name = "styleToolStripMenuItem";
            resources.ApplyResources(this.styleToolStripMenuItem, "styleToolStripMenuItem");
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dayToolStripMenuItem,
            this.nightToolStripMenuItem});
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            resources.ApplyResources(this.modeToolStripMenuItem, "modeToolStripMenuItem");
            // 
            // dayToolStripMenuItem
            // 
            this.dayToolStripMenuItem.Name = "dayToolStripMenuItem";
            resources.ApplyResources(this.dayToolStripMenuItem, "dayToolStripMenuItem");
            // 
            // nightToolStripMenuItem
            // 
            this.nightToolStripMenuItem.Name = "nightToolStripMenuItem";
            resources.ApplyResources(this.nightToolStripMenuItem, "nightToolStripMenuItem");
            // 
            // colourToolStripMenuItem
            // 
            this.colourToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formToolStripMenuItem,
            this.buttonsToolStripMenuItem});
            this.colourToolStripMenuItem.Name = "colourToolStripMenuItem";
            resources.ApplyResources(this.colourToolStripMenuItem, "colourToolStripMenuItem");
            // 
            // formToolStripMenuItem
            // 
            this.formToolStripMenuItem.Name = "formToolStripMenuItem";
            resources.ApplyResources(this.formToolStripMenuItem, "formToolStripMenuItem");
            // 
            // buttonsToolStripMenuItem
            // 
            this.buttonsToolStripMenuItem.Name = "buttonsToolStripMenuItem";
            resources.ApplyResources(this.buttonsToolStripMenuItem, "buttonsToolStripMenuItem");
            // 
            // MalinSpace
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxFlag);
            this.Controls.Add(this.StatusStripInfo);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ListViewResults);
            this.Controls.Add(this.groupBoxHorizon);
            this.Controls.Add(this.groupBoxTemperature);
            this.Controls.Add(this.groupBoxDistance);
            this.Controls.Add(this.groupBoxVelocity);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MalinSpace";
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem styleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buttonsToolStripMenuItem;
    }
}