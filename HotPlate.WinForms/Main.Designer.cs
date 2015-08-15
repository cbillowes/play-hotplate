namespace HotPlate.WinForms
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pButtons = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.grdHotPlate = new System.Windows.Forms.DataGridView();
            this.bgHotPlateIterations = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHotPlate)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pButtons
            // 
            this.pButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pButtons.Controls.Add(this.btnStart);
            this.pButtons.Location = new System.Drawing.Point(3, 3);
            this.pButtons.Name = "pButtons";
            this.pButtons.Size = new System.Drawing.Size(626, 58);
            this.pButtons.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(9, 9);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 30);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // grdHotPlate
            // 
            this.grdHotPlate.AllowUserToAddRows = false;
            this.grdHotPlate.AllowUserToDeleteRows = false;
            this.grdHotPlate.AllowUserToResizeColumns = false;
            this.grdHotPlate.AllowUserToResizeRows = false;
            this.grdHotPlate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdHotPlate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdHotPlate.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdHotPlate.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.grdHotPlate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdHotPlate.CausesValidation = false;
            this.grdHotPlate.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.grdHotPlate.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grdHotPlate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHotPlate.ColumnHeadersVisible = false;
            this.grdHotPlate.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdHotPlate.EnableHeadersVisualStyles = false;
            this.grdHotPlate.Location = new System.Drawing.Point(3, 67);
            this.grdHotPlate.Name = "grdHotPlate";
            this.grdHotPlate.ReadOnly = true;
            this.grdHotPlate.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grdHotPlate.RowHeadersVisible = false;
            this.grdHotPlate.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10);
            this.grdHotPlate.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grdHotPlate.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grdHotPlate.RowTemplate.DefaultCellStyle.Format = "N2";
            this.grdHotPlate.RowTemplate.DefaultCellStyle.NullValue = "N/A";
            this.grdHotPlate.RowTemplate.Height = 24;
            this.grdHotPlate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdHotPlate.ShowCellErrors = false;
            this.grdHotPlate.ShowCellToolTips = false;
            this.grdHotPlate.ShowEditingIcon = false;
            this.grdHotPlate.ShowRowErrors = false;
            this.grdHotPlate.Size = new System.Drawing.Size(626, 266);
            this.grdHotPlate.TabIndex = 1;
            // 
            // bgHotPlateIterations
            // 
            this.bgHotPlateIterations.WorkerReportsProgress = true;
            this.bgHotPlateIterations.WorkerSupportsCancellation = true;
            this.bgHotPlateIterations.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgHotPlateIterations_DoWork);
            this.bgHotPlateIterations.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgHotPlateIterations_ProgressChanged);
            this.bgHotPlateIterations.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgHotPlateIterations_RunWorkerCompleted);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Location = new System.Drawing.Point(3, 339);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 62);
            this.panel1.TabIndex = 2;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(9, 18);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            this.lblStatus.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 403);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grdHotPlate);
            this.Controls.Add(this.pButtons);
            this.Name = "Main";
            this.Text = "Hot Plate Challenge";
            this.pButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdHotPlate)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pButtons;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.DataGridView grdHotPlate;
        private System.ComponentModel.BackgroundWorker bgHotPlateIterations;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStatus;
    }
}

