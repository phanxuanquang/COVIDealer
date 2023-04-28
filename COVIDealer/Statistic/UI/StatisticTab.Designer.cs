namespace COVIDealer
{
    partial class StatisticTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.Location_Label = new System.Windows.Forms.Label();
            this.Statistics_Panel = new System.Windows.Forms.Panel();
            this.treatedCase_Panel = new System.Windows.Forms.Panel();
            this.newTreatedCaseLabel = new System.Windows.Forms.Label();
            this.treatedCase = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.deathCase_Panel = new System.Windows.Forms.Panel();
            this.newDeathCaseLabel = new System.Windows.Forms.Label();
            this.deathCase = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totalCase_Panel = new System.Windows.Forms.Panel();
            this.newCaseLabel = new System.Windows.Forms.Label();
            this.covidCase = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Label();
            this.statisticTable = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.statisticChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.caseButton = new Guna.UI2.WinForms.Guna2Button();
            this.treatedCaseButton = new Guna.UI2.WinForms.Guna2Button();
            this.deathCaseButton = new Guna.UI2.WinForms.Guna2Button();
            this.Statistics_Panel.SuspendLayout();
            this.treatedCase_Panel.SuspendLayout();
            this.deathCase_Panel.SuspendLayout();
            this.totalCase_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statisticTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticChart)).BeginInit();
            this.SuspendLayout();
            // 
            // Location_Label
            // 
            this.Location_Label.AutoSize = true;
            this.Location_Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Location_Label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Location_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(145)))));
            this.Location_Label.Location = new System.Drawing.Point(3, 0);
            this.Location_Label.Name = "Location_Label";
            this.Location_Label.Size = new System.Drawing.Size(118, 28);
            this.Location_Label.TabIndex = 6;
            this.Location_Label.Text = "► Thế giới:";
            this.Location_Label.Click += new System.EventHandler(this.Location_Label_Click);
            // 
            // Statistics_Panel
            // 
            this.Statistics_Panel.Controls.Add(this.treatedCase_Panel);
            this.Statistics_Panel.Controls.Add(this.deathCase_Panel);
            this.Statistics_Panel.Controls.Add(this.totalCase_Panel);
            this.Statistics_Panel.Controls.Add(this.Location_Label);
            this.Statistics_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Statistics_Panel.Location = new System.Drawing.Point(0, 0);
            this.Statistics_Panel.Name = "Statistics_Panel";
            this.Statistics_Panel.Size = new System.Drawing.Size(1118, 111);
            this.Statistics_Panel.TabIndex = 7;
            // 
            // treatedCase_Panel
            // 
            this.treatedCase_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treatedCase_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(236)))));
            this.treatedCase_Panel.Controls.Add(this.newTreatedCaseLabel);
            this.treatedCase_Panel.Controls.Add(this.treatedCase);
            this.treatedCase_Panel.Controls.Add(this.label4);
            this.treatedCase_Panel.Location = new System.Drawing.Point(379, 32);
            this.treatedCase_Panel.Name = "treatedCase_Panel";
            this.treatedCase_Panel.Size = new System.Drawing.Size(360, 79);
            this.treatedCase_Panel.TabIndex = 8;
            // 
            // newTreatedCaseLabel
            // 
            this.newTreatedCaseLabel.BackColor = System.Drawing.Color.Transparent;
            this.newTreatedCaseLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.newTreatedCaseLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.newTreatedCaseLabel.Location = new System.Drawing.Point(0, 55);
            this.newTreatedCaseLabel.Name = "newTreatedCaseLabel";
            this.newTreatedCaseLabel.Size = new System.Drawing.Size(360, 20);
            this.newTreatedCaseLabel.TabIndex = 7;
            this.newTreatedCaseLabel.Text = "0 ca mới trong 24 giờ qua";
            this.newTreatedCaseLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // treatedCase
            // 
            this.treatedCase.BackColor = System.Drawing.Color.Transparent;
            this.treatedCase.Dock = System.Windows.Forms.DockStyle.Top;
            this.treatedCase.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.treatedCase.ForeColor = System.Drawing.Color.Green;
            this.treatedCase.Location = new System.Drawing.Point(0, 20);
            this.treatedCase.Name = "treatedCase";
            this.treatedCase.Size = new System.Drawing.Size(360, 35);
            this.treatedCase.TabIndex = 5;
            this.treatedCase.Text = "0";
            this.treatedCase.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(360, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "KHỎI BỆNH";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // deathCase_Panel
            // 
            this.deathCase_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deathCase_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.deathCase_Panel.Controls.Add(this.newDeathCaseLabel);
            this.deathCase_Panel.Controls.Add(this.deathCase);
            this.deathCase_Panel.Controls.Add(this.label6);
            this.deathCase_Panel.Location = new System.Drawing.Point(758, 32);
            this.deathCase_Panel.Name = "deathCase_Panel";
            this.deathCase_Panel.Size = new System.Drawing.Size(360, 79);
            this.deathCase_Panel.TabIndex = 9;
            // 
            // newDeathCaseLabel
            // 
            this.newDeathCaseLabel.BackColor = System.Drawing.Color.Transparent;
            this.newDeathCaseLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.newDeathCaseLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.newDeathCaseLabel.Location = new System.Drawing.Point(0, 55);
            this.newDeathCaseLabel.Name = "newDeathCaseLabel";
            this.newDeathCaseLabel.Size = new System.Drawing.Size(360, 20);
            this.newDeathCaseLabel.TabIndex = 7;
            this.newDeathCaseLabel.Text = "0 ca mới trong 24 giờ qua";
            this.newDeathCaseLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // deathCase
            // 
            this.deathCase.BackColor = System.Drawing.Color.Transparent;
            this.deathCase.Dock = System.Windows.Forms.DockStyle.Top;
            this.deathCase.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.deathCase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.deathCase.Location = new System.Drawing.Point(0, 20);
            this.deathCase.Name = "deathCase";
            this.deathCase.Size = new System.Drawing.Size(360, 35);
            this.deathCase.TabIndex = 5;
            this.deathCase.Text = "0";
            this.deathCase.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(360, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "TỬ VONG";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // totalCase_Panel
            // 
            this.totalCase_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.totalCase_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.totalCase_Panel.Controls.Add(this.newCaseLabel);
            this.totalCase_Panel.Controls.Add(this.covidCase);
            this.totalCase_Panel.Controls.Add(this.ok);
            this.totalCase_Panel.Location = new System.Drawing.Point(0, 32);
            this.totalCase_Panel.Name = "totalCase_Panel";
            this.totalCase_Panel.Size = new System.Drawing.Size(360, 79);
            this.totalCase_Panel.TabIndex = 7;
            // 
            // newCaseLabel
            // 
            this.newCaseLabel.BackColor = System.Drawing.Color.Transparent;
            this.newCaseLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.newCaseLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.newCaseLabel.Location = new System.Drawing.Point(0, 55);
            this.newCaseLabel.Name = "newCaseLabel";
            this.newCaseLabel.Size = new System.Drawing.Size(360, 20);
            this.newCaseLabel.TabIndex = 6;
            this.newCaseLabel.Text = "0 ca mới trong 24 giờ qua";
            this.newCaseLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // covidCase
            // 
            this.covidCase.BackColor = System.Drawing.Color.Transparent;
            this.covidCase.Dock = System.Windows.Forms.DockStyle.Top;
            this.covidCase.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.covidCase.ForeColor = System.Drawing.Color.Red;
            this.covidCase.Location = new System.Drawing.Point(0, 20);
            this.covidCase.Name = "covidCase";
            this.covidCase.Size = new System.Drawing.Size(360, 35);
            this.covidCase.TabIndex = 5;
            this.covidCase.Text = "0";
            this.covidCase.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.Color.Transparent;
            this.ok.Dock = System.Windows.Forms.DockStyle.Top;
            this.ok.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ok.Location = new System.Drawing.Point(0, 0);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(360, 20);
            this.ok.TabIndex = 4;
            this.ok.Text = "NHIỄM BỆNH";
            this.ok.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // statisticTable
            // 
            this.statisticTable.AllowUserToAddRows = false;
            this.statisticTable.AllowUserToDeleteRows = false;
            this.statisticTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.statisticTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.statisticTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.statisticTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.statisticTable.BackgroundColor = System.Drawing.Color.White;
            this.statisticTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statisticTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.statisticTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.statisticTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.statisticTable.ColumnHeadersHeight = 21;
            this.statisticTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.statisticTable.DefaultCellStyle = dataGridViewCellStyle12;
            this.statisticTable.EnableHeadersVisualStyles = false;
            this.statisticTable.GridColor = System.Drawing.Color.Gray;
            this.statisticTable.Location = new System.Drawing.Point(0, 167);
            this.statisticTable.Name = "statisticTable";
            this.statisticTable.ReadOnly = true;
            this.statisticTable.RowHeadersVisible = false;
            this.statisticTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.statisticTable.Size = new System.Drawing.Size(656, 572);
            this.statisticTable.TabIndex = 8;
            this.statisticTable.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.statisticTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.statisticTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.statisticTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.statisticTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.statisticTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.statisticTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.statisticTable.ThemeStyle.GridColor = System.Drawing.Color.Gray;
            this.statisticTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Gray;
            this.statisticTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.statisticTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.statisticTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.statisticTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.statisticTable.ThemeStyle.HeaderStyle.Height = 21;
            this.statisticTable.ThemeStyle.ReadOnly = true;
            this.statisticTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.statisticTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.statisticTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.statisticTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.statisticTable.ThemeStyle.RowsStyle.Height = 22;
            this.statisticTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.statisticTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tỉnh/Thành phố";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tổng số ca";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "24 giờ qua";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tử vong";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(145)))));
            this.label1.Location = new System.Drawing.Point(2, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "► Tình hình dịch cả nước";
            // 
            // statisticChart
            // 
            this.statisticChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.Name = "ChartArea1";
            this.statisticChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.statisticChart.Legends.Add(legend4);
            this.statisticChart.Location = new System.Drawing.Point(644, 210);
            this.statisticChart.Name = "statisticChart";
            this.statisticChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            this.statisticChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Blue};
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Case";
            series4.YValuesPerPoint = 2;
            this.statisticChart.Series.Add(series4);
            this.statisticChart.Size = new System.Drawing.Size(587, 529);
            this.statisticChart.TabIndex = 12;
            this.statisticChart.Text = "chart1";
            title4.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            title4.Name = "Case";
            title4.Text = "Số ca nhiễm";
            this.statisticChart.Titles.Add(title4);
            // 
            // caseButton
            // 
            this.caseButton.Animated = true;
            this.caseButton.BorderRadius = 5;
            this.caseButton.CheckedState.FillColor = System.Drawing.Color.Red;
            this.caseButton.CheckedState.ForeColor = System.Drawing.Color.White;
            this.caseButton.CheckedState.Parent = this.caseButton;
            this.caseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.caseButton.CustomImages.Parent = this.caseButton;
            this.caseButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.caseButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caseButton.ForeColor = System.Drawing.Color.Black;
            this.caseButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(154)))), ((int)(((byte)(155)))));
            this.caseButton.HoverState.Parent = this.caseButton;
            this.caseButton.Location = new System.Drawing.Point(662, 167);
            this.caseButton.Name = "caseButton";
            this.caseButton.ShadowDecoration.Parent = this.caseButton;
            this.caseButton.Size = new System.Drawing.Size(144, 45);
            this.caseButton.TabIndex = 13;
            this.caseButton.Text = "Số ca nhiễm bệnh";
            this.caseButton.Click += new System.EventHandler(this.caseButton_Click);
            // 
            // treatedCaseButton
            // 
            this.treatedCaseButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treatedCaseButton.Animated = true;
            this.treatedCaseButton.BorderRadius = 5;
            this.treatedCaseButton.CheckedState.FillColor = System.Drawing.Color.Green;
            this.treatedCaseButton.CheckedState.ForeColor = System.Drawing.Color.White;
            this.treatedCaseButton.CheckedState.Parent = this.treatedCaseButton;
            this.treatedCaseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treatedCaseButton.CustomImages.Parent = this.treatedCaseButton;
            this.treatedCaseButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(236)))));
            this.treatedCaseButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treatedCaseButton.ForeColor = System.Drawing.Color.Black;
            this.treatedCaseButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(249)))), ((int)(((byte)(96)))));
            this.treatedCaseButton.HoverState.Parent = this.treatedCaseButton;
            this.treatedCaseButton.Location = new System.Drawing.Point(814, 167);
            this.treatedCaseButton.Name = "treatedCaseButton";
            this.treatedCaseButton.ShadowDecoration.Parent = this.treatedCaseButton;
            this.treatedCaseButton.Size = new System.Drawing.Size(144, 45);
            this.treatedCaseButton.TabIndex = 14;
            this.treatedCaseButton.Text = "Số ca khỏi bệnh";
            this.treatedCaseButton.Click += new System.EventHandler(this.treatedCaseButton_Click);
            // 
            // deathCaseButton
            // 
            this.deathCaseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deathCaseButton.Animated = true;
            this.deathCaseButton.BorderRadius = 5;
            this.deathCaseButton.CheckedState.FillColor = System.Drawing.Color.Gray;
            this.deathCaseButton.CheckedState.ForeColor = System.Drawing.Color.White;
            this.deathCaseButton.CheckedState.Parent = this.deathCaseButton;
            this.deathCaseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deathCaseButton.CustomImages.Parent = this.deathCaseButton;
            this.deathCaseButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.deathCaseButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deathCaseButton.ForeColor = System.Drawing.Color.Black;
            this.deathCaseButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.deathCaseButton.HoverState.Parent = this.deathCaseButton;
            this.deathCaseButton.Location = new System.Drawing.Point(966, 167);
            this.deathCaseButton.Name = "deathCaseButton";
            this.deathCaseButton.ShadowDecoration.Parent = this.deathCaseButton;
            this.deathCaseButton.Size = new System.Drawing.Size(144, 45);
            this.deathCaseButton.TabIndex = 15;
            this.deathCaseButton.Text = "Số ca tử vong";
            this.deathCaseButton.Click += new System.EventHandler(this.deathCaseButton_Click);
            // 
            // StatisticTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.statisticTable);
            this.Controls.Add(this.deathCaseButton);
            this.Controls.Add(this.treatedCaseButton);
            this.Controls.Add(this.caseButton);
            this.Controls.Add(this.statisticChart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Statistics_Panel);
            this.Name = "StatisticTab";
            this.Size = new System.Drawing.Size(1118, 739);
            this.Statistics_Panel.ResumeLayout(false);
            this.Statistics_Panel.PerformLayout();
            this.treatedCase_Panel.ResumeLayout(false);
            this.deathCase_Panel.ResumeLayout(false);
            this.totalCase_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statisticTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Location_Label;
        private System.Windows.Forms.Panel Statistics_Panel;
        private System.Windows.Forms.Panel totalCase_Panel;
        private System.Windows.Forms.Label covidCase;
        private System.Windows.Forms.Label ok;
        private System.Windows.Forms.Panel treatedCase_Panel;
        private System.Windows.Forms.Label treatedCase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel deathCase_Panel;
        private System.Windows.Forms.Label deathCase;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label newDeathCaseLabel;
        private System.Windows.Forms.Label newTreatedCaseLabel;
        private System.Windows.Forms.Label newCaseLabel;
        private Guna.UI.WinForms.GunaDataGridView statisticTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart statisticChart;
        private Guna.UI2.WinForms.Guna2Button caseButton;
        private Guna.UI2.WinForms.Guna2Button treatedCaseButton;
        private Guna.UI2.WinForms.Guna2Button deathCaseButton;
    }
}
