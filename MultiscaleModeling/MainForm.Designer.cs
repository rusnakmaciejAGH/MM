namespace grain_growth
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
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
            this.PB = new System.Windows.Forms.PictureBox();
            this.gridGroupBox = new System.Windows.Forms.GroupBox();
            this.gridZoomLabel = new System.Windows.Forms.Label();
            this.gridZoomNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.gridPeriodicLabel = new System.Windows.Forms.Label();
            this.gridPeriodicCheckBox = new System.Windows.Forms.CheckBox();
            this.gridWidthLabel = new System.Windows.Forms.Label();
            this.gridWidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.gridHeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.gridHeightLabel = new System.Windows.Forms.Label();
            this.inclusionsGroupBox = new System.Windows.Forms.GroupBox();
            this.inclusionCircleButton = new System.Windows.Forms.Button();
            this.inclusionSquareButton = new System.Windows.Forms.Button();
            this.inclusionRadiusNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.inclusionRadiusLabel = new System.Windows.Forms.Label();
            this.caGroupBox = new System.Windows.Forms.GroupBox();
            this.caNeighborhoodComboBox = new System.Windows.Forms.ComboBox();
            this.caNeighborhoodLabel = new System.Windows.Forms.Label();
            this.caSimulateButton = new System.Windows.Forms.Button();
            this.caAddRandomGrainsButton = new System.Windows.Forms.Button();
            this.caGrainsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.caGrainsLabel = new System.Windows.Forms.Label();
            this.mcStepsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.mcStepsLabel = new System.Windows.Forms.Label();
            this.mcNeighborhoodComboBox = new System.Windows.Forms.ComboBox();
            this.mcSimulateButton = new System.Windows.Forms.Button();
            this.mcNeighborhoodLabel = new System.Windows.Forms.Label();
            this.mcInitRandomGrainsButton = new System.Windows.Forms.Button();
            this.mcGrainsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.mcGrainsLabel = new System.Windows.Forms.Label();
            this.dpGroupBox = new System.Windows.Forms.GroupBox();
            this.dpSelectButton = new System.Windows.Forms.Button();
            this.dpChangeIdCheckBox = new System.Windows.Forms.CheckBox();
            this.ExportButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ImportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB)).BeginInit();
            this.gridGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridZoomNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridWidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHeightNumericUpDown)).BeginInit();
            this.inclusionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inclusionRadiusNumericUpDown)).BeginInit();
            this.caGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caGrainsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcStepsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcGrainsNumericUpDown)).BeginInit();
            this.dpGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PB
            // 
            this.PB.BackColor = System.Drawing.Color.MistyRose;
            this.PB.Location = new System.Drawing.Point(16, 18);
            this.PB.Margin = new System.Windows.Forms.Padding(6);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(126, 138);
            this.PB.TabIndex = 0;
            this.PB.TabStop = false;
            this.PB.Click += new System.EventHandler(this.PB_Click);
            this.PB.Paint += new System.Windows.Forms.PaintEventHandler(this.PB_Paint);
            // 
            // gridGroupBox
            // 
            this.gridGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gridGroupBox.Controls.Add(this.gridZoomLabel);
            this.gridGroupBox.Controls.Add(this.gridZoomNumericUpDown);
            this.gridGroupBox.Controls.Add(this.gridPeriodicLabel);
            this.gridGroupBox.Controls.Add(this.gridPeriodicCheckBox);
            this.gridGroupBox.Controls.Add(this.gridWidthLabel);
            this.gridGroupBox.Controls.Add(this.gridWidthNumericUpDown);
            this.gridGroupBox.Controls.Add(this.gridHeightNumericUpDown);
            this.gridGroupBox.Controls.Add(this.gridHeightLabel);
            this.gridGroupBox.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gridGroupBox.Location = new System.Drawing.Point(1117, 15);
            this.gridGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.gridGroupBox.Name = "gridGroupBox";
            this.gridGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.gridGroupBox.Size = new System.Drawing.Size(219, 160);
            this.gridGroupBox.TabIndex = 4;
            this.gridGroupBox.TabStop = false;
            this.gridGroupBox.Text = "Grid";
            this.gridGroupBox.Enter += new System.EventHandler(this.gridGroupBox_Enter);
            // 
            // gridZoomLabel
            // 
            this.gridZoomLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridZoomLabel.Location = new System.Drawing.Point(11, 104);
            this.gridZoomLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.gridZoomLabel.Name = "gridZoomLabel";
            this.gridZoomLabel.Size = new System.Drawing.Size(60, 22);
            this.gridZoomLabel.TabIndex = 7;
            this.gridZoomLabel.Text = "Zoom:";
            // 
            // gridZoomNumericUpDown
            // 
            this.gridZoomNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridZoomNumericUpDown.Location = new System.Drawing.Point(100, 102);
            this.gridZoomNumericUpDown.Margin = new System.Windows.Forms.Padding(6);
            this.gridZoomNumericUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.gridZoomNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gridZoomNumericUpDown.Name = "gridZoomNumericUpDown";
            this.gridZoomNumericUpDown.Size = new System.Drawing.Size(100, 23);
            this.gridZoomNumericUpDown.TabIndex = 6;
            this.gridZoomNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gridZoomNumericUpDown.ValueChanged += new System.EventHandler(this.gridZoomNumericUpDown_ValueChanged);
            // 
            // gridPeriodicLabel
            // 
            this.gridPeriodicLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPeriodicLabel.AutoSize = true;
            this.gridPeriodicLabel.Location = new System.Drawing.Point(7, 138);
            this.gridPeriodicLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.gridPeriodicLabel.Name = "gridPeriodicLabel";
            this.gridPeriodicLabel.Size = new System.Drawing.Size(80, 17);
            this.gridPeriodicLabel.TabIndex = 5;
            this.gridPeriodicLabel.Text = "Periodic:";
            // 
            // gridPeriodicCheckBox
            // 
            this.gridPeriodicCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPeriodicCheckBox.AutoSize = true;
            this.gridPeriodicCheckBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gridPeriodicCheckBox.Checked = true;
            this.gridPeriodicCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gridPeriodicCheckBox.Location = new System.Drawing.Point(122, 138);
            this.gridPeriodicCheckBox.Margin = new System.Windows.Forms.Padding(6);
            this.gridPeriodicCheckBox.Name = "gridPeriodicCheckBox";
            this.gridPeriodicCheckBox.Size = new System.Drawing.Size(18, 17);
            this.gridPeriodicCheckBox.TabIndex = 4;
            this.gridPeriodicCheckBox.UseVisualStyleBackColor = false;
            // 
            // gridWidthLabel
            // 
            this.gridWidthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridWidthLabel.AutoSize = true;
            this.gridWidthLabel.Location = new System.Drawing.Point(10, 69);
            this.gridWidthLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.gridWidthLabel.Name = "gridWidthLabel";
            this.gridWidthLabel.Size = new System.Drawing.Size(56, 17);
            this.gridWidthLabel.TabIndex = 3;
            this.gridWidthLabel.Text = "Width:";
            // 
            // gridWidthNumericUpDown
            // 
            this.gridWidthNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridWidthNumericUpDown.Location = new System.Drawing.Point(100, 67);
            this.gridWidthNumericUpDown.Margin = new System.Windows.Forms.Padding(6);
            this.gridWidthNumericUpDown.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.gridWidthNumericUpDown.Name = "gridWidthNumericUpDown";
            this.gridWidthNumericUpDown.Size = new System.Drawing.Size(100, 23);
            this.gridWidthNumericUpDown.TabIndex = 2;
            this.gridWidthNumericUpDown.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.gridWidthNumericUpDown.ValueChanged += new System.EventHandler(this.girdProperties_Changed);
            // 
            // gridHeightNumericUpDown
            // 
            this.gridHeightNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridHeightNumericUpDown.Location = new System.Drawing.Point(100, 32);
            this.gridHeightNumericUpDown.Margin = new System.Windows.Forms.Padding(6);
            this.gridHeightNumericUpDown.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.gridHeightNumericUpDown.Name = "gridHeightNumericUpDown";
            this.gridHeightNumericUpDown.Size = new System.Drawing.Size(100, 23);
            this.gridHeightNumericUpDown.TabIndex = 1;
            this.gridHeightNumericUpDown.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.gridHeightNumericUpDown.ValueChanged += new System.EventHandler(this.girdProperties_Changed);
            // 
            // gridHeightLabel
            // 
            this.gridHeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridHeightLabel.AutoSize = true;
            this.gridHeightLabel.Location = new System.Drawing.Point(10, 35);
            this.gridHeightLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.gridHeightLabel.Name = "gridHeightLabel";
            this.gridHeightLabel.Size = new System.Drawing.Size(64, 17);
            this.gridHeightLabel.TabIndex = 0;
            this.gridHeightLabel.Text = "Height:";
            // 
            // inclusionsGroupBox
            // 
            this.inclusionsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inclusionsGroupBox.Controls.Add(this.inclusionCircleButton);
            this.inclusionsGroupBox.Controls.Add(this.inclusionSquareButton);
            this.inclusionsGroupBox.Controls.Add(this.inclusionRadiusNumericUpDown);
            this.inclusionsGroupBox.Controls.Add(this.inclusionRadiusLabel);
            this.inclusionsGroupBox.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inclusionsGroupBox.Location = new System.Drawing.Point(1114, 187);
            this.inclusionsGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.inclusionsGroupBox.Name = "inclusionsGroupBox";
            this.inclusionsGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.inclusionsGroupBox.Size = new System.Drawing.Size(221, 168);
            this.inclusionsGroupBox.TabIndex = 5;
            this.inclusionsGroupBox.TabStop = false;
            this.inclusionsGroupBox.Text = "Inclusions";
            // 
            // inclusionCircleButton
            // 
            this.inclusionCircleButton.BackColor = System.Drawing.SystemColors.Control;
            this.inclusionCircleButton.Location = new System.Drawing.Point(14, 117);
            this.inclusionCircleButton.Margin = new System.Windows.Forms.Padding(6);
            this.inclusionCircleButton.Name = "inclusionCircleButton";
            this.inclusionCircleButton.Size = new System.Drawing.Size(176, 38);
            this.inclusionCircleButton.TabIndex = 10;
            this.inclusionCircleButton.Text = "Circle";
            this.inclusionCircleButton.UseVisualStyleBackColor = false;
            this.inclusionCircleButton.Click += new System.EventHandler(this.stateButton_Click);
            // 
            // inclusionSquareButton
            // 
            this.inclusionSquareButton.Location = new System.Drawing.Point(14, 67);
            this.inclusionSquareButton.Margin = new System.Windows.Forms.Padding(6);
            this.inclusionSquareButton.Name = "inclusionSquareButton";
            this.inclusionSquareButton.Size = new System.Drawing.Size(176, 38);
            this.inclusionSquareButton.TabIndex = 9;
            this.inclusionSquareButton.Text = "Square";
            this.inclusionSquareButton.UseVisualStyleBackColor = false;
            this.inclusionSquareButton.Click += new System.EventHandler(this.stateButton_Click);
            // 
            // inclusionRadiusNumericUpDown
            // 
            this.inclusionRadiusNumericUpDown.Location = new System.Drawing.Point(91, 32);
            this.inclusionRadiusNumericUpDown.Margin = new System.Windows.Forms.Padding(6);
            this.inclusionRadiusNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.inclusionRadiusNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inclusionRadiusNumericUpDown.Name = "inclusionRadiusNumericUpDown";
            this.inclusionRadiusNumericUpDown.Size = new System.Drawing.Size(100, 23);
            this.inclusionRadiusNumericUpDown.TabIndex = 8;
            this.inclusionRadiusNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // inclusionRadiusLabel
            // 
            this.inclusionRadiusLabel.AutoSize = true;
            this.inclusionRadiusLabel.Location = new System.Drawing.Point(10, 35);
            this.inclusionRadiusLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.inclusionRadiusLabel.Name = "inclusionRadiusLabel";
            this.inclusionRadiusLabel.Size = new System.Drawing.Size(64, 17);
            this.inclusionRadiusLabel.TabIndex = 0;
            this.inclusionRadiusLabel.Text = "Radius:";
            // 
            // caGroupBox
            // 
            this.caGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.caGroupBox.Controls.Add(this.caNeighborhoodComboBox);
            this.caGroupBox.Controls.Add(this.caNeighborhoodLabel);
            this.caGroupBox.Controls.Add(this.caSimulateButton);
            this.caGroupBox.Controls.Add(this.caAddRandomGrainsButton);
            this.caGroupBox.Controls.Add(this.caGrainsNumericUpDown);
            this.caGroupBox.Controls.Add(this.caGrainsLabel);
            this.caGroupBox.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.caGroupBox.Location = new System.Drawing.Point(1114, 367);
            this.caGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.caGroupBox.Name = "caGroupBox";
            this.caGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.caGroupBox.Size = new System.Drawing.Size(221, 251);
            this.caGroupBox.TabIndex = 6;
            this.caGroupBox.TabStop = false;
            this.caGroupBox.Text = "CA";
            // 
            // caNeighborhoodComboBox
            // 
            this.caNeighborhoodComboBox.FormattingEnabled = true;
            this.caNeighborhoodComboBox.Items.AddRange(new object[] {
            "Moorea\'a",
            "Von Neumann\'a"});
            this.caNeighborhoodComboBox.Location = new System.Drawing.Point(17, 130);
            this.caNeighborhoodComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.caNeighborhoodComboBox.Name = "caNeighborhoodComboBox";
            this.caNeighborhoodComboBox.Size = new System.Drawing.Size(174, 23);
            this.caNeighborhoodComboBox.TabIndex = 5;
            // 
            // caNeighborhoodLabel
            // 
            this.caNeighborhoodLabel.AutoSize = true;
            this.caNeighborhoodLabel.Location = new System.Drawing.Point(49, 107);
            this.caNeighborhoodLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.caNeighborhoodLabel.Name = "caNeighborhoodLabel";
            this.caNeighborhoodLabel.Size = new System.Drawing.Size(112, 17);
            this.caNeighborhoodLabel.TabIndex = 4;
            this.caNeighborhoodLabel.Text = "Neighborhood:";
            // 
            // caSimulateButton
            // 
            this.caSimulateButton.Location = new System.Drawing.Point(16, 165);
            this.caSimulateButton.Margin = new System.Windows.Forms.Padding(6);
            this.caSimulateButton.Name = "caSimulateButton";
            this.caSimulateButton.Size = new System.Drawing.Size(174, 76);
            this.caSimulateButton.TabIndex = 3;
            this.caSimulateButton.Text = "Simulate";
            this.caSimulateButton.UseVisualStyleBackColor = true;
            this.caSimulateButton.Click += new System.EventHandler(this.caSimulateButton_Click);
            // 
            // caAddRandomGrainsButton
            // 
            this.caAddRandomGrainsButton.Location = new System.Drawing.Point(52, 54);
            this.caAddRandomGrainsButton.Margin = new System.Windows.Forms.Padding(6);
            this.caAddRandomGrainsButton.Name = "caAddRandomGrainsButton";
            this.caAddRandomGrainsButton.Size = new System.Drawing.Size(139, 38);
            this.caAddRandomGrainsButton.TabIndex = 2;
            this.caAddRandomGrainsButton.Text = "Add";
            this.caAddRandomGrainsButton.UseVisualStyleBackColor = true;
            this.caAddRandomGrainsButton.Click += new System.EventHandler(this.caAddRandomGrainsButton_Click);
            // 
            // caGrainsNumericUpDown
            // 
            this.caGrainsNumericUpDown.Location = new System.Drawing.Point(91, 19);
            this.caGrainsNumericUpDown.Margin = new System.Windows.Forms.Padding(6);
            this.caGrainsNumericUpDown.Name = "caGrainsNumericUpDown";
            this.caGrainsNumericUpDown.Size = new System.Drawing.Size(100, 23);
            this.caGrainsNumericUpDown.TabIndex = 1;
            this.caGrainsNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // caGrainsLabel
            // 
            this.caGrainsLabel.AutoSize = true;
            this.caGrainsLabel.Location = new System.Drawing.Point(10, 22);
            this.caGrainsLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.caGrainsLabel.Name = "caGrainsLabel";
            this.caGrainsLabel.Size = new System.Drawing.Size(64, 17);
            this.caGrainsLabel.TabIndex = 0;
            this.caGrainsLabel.Text = "Grains:";
            // 
            // mcStepsNumericUpDown
            // 
            this.mcStepsNumericUpDown.Location = new System.Drawing.Point(0, 0);
            this.mcStepsNumericUpDown.Name = "mcStepsNumericUpDown";
            this.mcStepsNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.mcStepsNumericUpDown.TabIndex = 0;
            // 
            // mcStepsLabel
            // 
            this.mcStepsLabel.Location = new System.Drawing.Point(0, 0);
            this.mcStepsLabel.Name = "mcStepsLabel";
            this.mcStepsLabel.Size = new System.Drawing.Size(100, 23);
            this.mcStepsLabel.TabIndex = 0;
            // 
            // mcNeighborhoodComboBox
            // 
            this.mcNeighborhoodComboBox.Location = new System.Drawing.Point(0, 0);
            this.mcNeighborhoodComboBox.Name = "mcNeighborhoodComboBox";
            this.mcNeighborhoodComboBox.Size = new System.Drawing.Size(121, 25);
            this.mcNeighborhoodComboBox.TabIndex = 0;
            // 
            // mcSimulateButton
            // 
            this.mcSimulateButton.Location = new System.Drawing.Point(0, 0);
            this.mcSimulateButton.Name = "mcSimulateButton";
            this.mcSimulateButton.Size = new System.Drawing.Size(75, 23);
            this.mcSimulateButton.TabIndex = 0;
            // 
            // mcNeighborhoodLabel
            // 
            this.mcNeighborhoodLabel.Location = new System.Drawing.Point(0, 0);
            this.mcNeighborhoodLabel.Name = "mcNeighborhoodLabel";
            this.mcNeighborhoodLabel.Size = new System.Drawing.Size(100, 23);
            this.mcNeighborhoodLabel.TabIndex = 0;
            // 
            // mcInitRandomGrainsButton
            // 
            this.mcInitRandomGrainsButton.Location = new System.Drawing.Point(0, 0);
            this.mcInitRandomGrainsButton.Name = "mcInitRandomGrainsButton";
            this.mcInitRandomGrainsButton.Size = new System.Drawing.Size(75, 23);
            this.mcInitRandomGrainsButton.TabIndex = 0;
            // 
            // mcGrainsNumericUpDown
            // 
            this.mcGrainsNumericUpDown.Location = new System.Drawing.Point(0, 0);
            this.mcGrainsNumericUpDown.Name = "mcGrainsNumericUpDown";
            this.mcGrainsNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.mcGrainsNumericUpDown.TabIndex = 0;
            // 
            // mcGrainsLabel
            // 
            this.mcGrainsLabel.Location = new System.Drawing.Point(0, 0);
            this.mcGrainsLabel.Name = "mcGrainsLabel";
            this.mcGrainsLabel.Size = new System.Drawing.Size(100, 23);
            this.mcGrainsLabel.TabIndex = 0;
            // 
            // dpGroupBox
            // 
            this.dpGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dpGroupBox.Controls.Add(this.ImportButton);
            this.dpGroupBox.Controls.Add(this.ExportButton);
            this.dpGroupBox.Controls.Add(this.dpSelectButton);
            this.dpGroupBox.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dpGroupBox.Location = new System.Drawing.Point(1181, 630);
            this.dpGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.dpGroupBox.Name = "dpGroupBox";
            this.dpGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.dpGroupBox.Size = new System.Drawing.Size(154, 185);
            this.dpGroupBox.TabIndex = 8;
            this.dpGroupBox.TabStop = false;
            this.dpGroupBox.Text = "Dual Phase";
            // 
            // dpSelectButton
            // 
            this.dpSelectButton.BackColor = System.Drawing.SystemColors.Control;
            this.dpSelectButton.Location = new System.Drawing.Point(21, 32);
            this.dpSelectButton.Margin = new System.Windows.Forms.Padding(6);
            this.dpSelectButton.Name = "dpSelectButton";
            this.dpSelectButton.Size = new System.Drawing.Size(121, 38);
            this.dpSelectButton.TabIndex = 2;
            this.dpSelectButton.Text = "Select";
            this.dpSelectButton.UseVisualStyleBackColor = false;
            this.dpSelectButton.Click += new System.EventHandler(this.stateButton_Click);
            // 
            // dpChangeIdCheckBox
            // 
            this.dpChangeIdCheckBox.AutoSize = true;
            this.dpChangeIdCheckBox.Checked = true;
            this.dpChangeIdCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dpChangeIdCheckBox.Location = new System.Drawing.Point(1127, 662);
            this.dpChangeIdCheckBox.Margin = new System.Windows.Forms.Padding(6);
            this.dpChangeIdCheckBox.Name = "dpChangeIdCheckBox";
            this.dpChangeIdCheckBox.Size = new System.Drawing.Size(18, 17);
            this.dpChangeIdCheckBox.TabIndex = 1;
            this.dpChangeIdCheckBox.UseVisualStyleBackColor = true;
            // 
            // ExportButton
            // 
            this.ExportButton.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ExportButton.Location = new System.Drawing.Point(19, 79);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(123, 37);
            this.ExportButton.TabIndex = 9;
            this.ExportButton.Text = "Export";
            this.ExportButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(1100, 639);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "ChangeID";
            // 
            // ImportButton
            // 
            this.ImportButton.Location = new System.Drawing.Point(19, 122);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(123, 39);
            this.ImportButton.TabIndex = 10;
            this.ImportButton.Text = "Import";
            this.ImportButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1353, 1045);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dpGroupBox);
            this.Controls.Add(this.caGroupBox);
            this.Controls.Add(this.dpChangeIdCheckBox);
            this.Controls.Add(this.inclusionsGroupBox);
            this.Controls.Add(this.gridGroupBox);
            this.Controls.Add(this.PB);
            this.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "Cellular automata - Multiscale Modeling";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB)).EndInit();
            this.gridGroupBox.ResumeLayout(false);
            this.gridGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridZoomNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridWidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHeightNumericUpDown)).EndInit();
            this.inclusionsGroupBox.ResumeLayout(false);
            this.inclusionsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inclusionRadiusNumericUpDown)).EndInit();
            this.caGroupBox.ResumeLayout(false);
            this.caGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caGrainsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcStepsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcGrainsNumericUpDown)).EndInit();
            this.dpGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB;
        private System.Windows.Forms.GroupBox gridGroupBox;
        private System.Windows.Forms.Label gridWidthLabel;
        private System.Windows.Forms.NumericUpDown gridWidthNumericUpDown;
        private System.Windows.Forms.NumericUpDown gridHeightNumericUpDown;
        private System.Windows.Forms.Label gridHeightLabel;
        private System.Windows.Forms.Label gridZoomLabel;
        private System.Windows.Forms.NumericUpDown gridZoomNumericUpDown;
        private System.Windows.Forms.Label gridPeriodicLabel;
        private System.Windows.Forms.CheckBox gridPeriodicCheckBox;
        private System.Windows.Forms.GroupBox inclusionsGroupBox;
        private System.Windows.Forms.Button inclusionCircleButton;
        private System.Windows.Forms.Button inclusionSquareButton;
        private System.Windows.Forms.NumericUpDown inclusionRadiusNumericUpDown;
        private System.Windows.Forms.Label inclusionRadiusLabel;
        private System.Windows.Forms.GroupBox caGroupBox;
        private System.Windows.Forms.Button caAddRandomGrainsButton;
        private System.Windows.Forms.NumericUpDown caGrainsNumericUpDown;
        private System.Windows.Forms.Label caGrainsLabel;
        private System.Windows.Forms.Button caSimulateButton;
        private System.Windows.Forms.ComboBox caNeighborhoodComboBox;
        private System.Windows.Forms.Label caNeighborhoodLabel;
        private System.Windows.Forms.ComboBox mcNeighborhoodComboBox;
        private System.Windows.Forms.Label mcNeighborhoodLabel;
        private System.Windows.Forms.Button mcSimulateButton;
        private System.Windows.Forms.Button mcInitRandomGrainsButton;
        private System.Windows.Forms.NumericUpDown mcGrainsNumericUpDown;
        private System.Windows.Forms.Label mcGrainsLabel;
        private System.Windows.Forms.NumericUpDown mcStepsNumericUpDown;
        private System.Windows.Forms.Label mcStepsLabel;
        private System.Windows.Forms.GroupBox dpGroupBox;
        private System.Windows.Forms.Button dpSelectButton;
        private System.Windows.Forms.CheckBox dpChangeIdCheckBox;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ImportButton;
    }
}

