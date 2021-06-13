
namespace Memory_Segmentation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.InsertProcess = new System.Windows.Forms.Button();
            this.DrawMemory = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.MemoryDrawTable = new System.Windows.Forms.DataGridView();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.NOfSegmentsCell = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SegmentSizeCell = new System.Windows.Forms.TextBox();
            this.InsertSegment = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BestFit = new System.Windows.Forms.RadioButton();
            this.FirstFit = new System.Windows.Forms.RadioButton();
            this.SegmentNameCell = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DeallocateCell = new System.Windows.Forms.TextBox();
            this.Deallocate = new System.Windows.Forms.Button();
            this.WorstFit = new System.Windows.Forms.RadioButton();
            this.IsOldProcessCheck = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProcessNumberCell = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.HoleAddressCell = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.HoleSizeCell = new System.Windows.Forms.TextBox();
            this.InsertHole = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.MemorySizeCell = new System.Windows.Forms.TextBox();
            this.InsertMemorySize = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MemoryDrawTable)).BeginInit();
            this.SuspendLayout();
            // 
            // InsertProcess
            // 
            this.InsertProcess.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InsertProcess.ForeColor = System.Drawing.SystemColors.Highlight;
            this.InsertProcess.Location = new System.Drawing.Point(24, 371);
            this.InsertProcess.Name = "InsertProcess";
            this.InsertProcess.Size = new System.Drawing.Size(284, 46);
            this.InsertProcess.TabIndex = 124;
            this.InsertProcess.Text = "Insert Process Info";
            this.InsertProcess.UseVisualStyleBackColor = true;
            this.InsertProcess.Click += new System.EventHandler(this.InsertProceesButton_Click);
            // 
            // DrawMemory
            // 
            this.DrawMemory.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DrawMemory.ForeColor = System.Drawing.SystemColors.Highlight;
            this.DrawMemory.Location = new System.Drawing.Point(523, 760);
            this.DrawMemory.Name = "DrawMemory";
            this.DrawMemory.Size = new System.Drawing.Size(248, 43);
            this.DrawMemory.TabIndex = 118;
            this.DrawMemory.Text = "Draw Memory";
            this.DrawMemory.UseVisualStyleBackColor = true;
            this.DrawMemory.Click += new System.EventHandler(this.DrawMemoryButton_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.Color.Red;
            this.label26.Location = new System.Drawing.Point(17, 494);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(0, 15);
            this.label26.TabIndex = 113;
            // 
            // MemoryDrawTable
            // 
            this.MemoryDrawTable.AllowUserToAddRows = false;
            this.MemoryDrawTable.AllowUserToDeleteRows = false;
            this.MemoryDrawTable.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.MemoryDrawTable.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.MemoryDrawTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.MemoryDrawTable.ColumnHeadersHeight = 40;
            this.MemoryDrawTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MemoryDrawTable.DefaultCellStyle = dataGridViewCellStyle1;
            this.MemoryDrawTable.GridColor = System.Drawing.SystemColors.Desktop;
            this.MemoryDrawTable.Location = new System.Drawing.Point(523, 264);
            this.MemoryDrawTable.Name = "MemoryDrawTable";
            this.MemoryDrawTable.RowHeadersWidth = 51;
            this.MemoryDrawTable.RowTemplate.Height = 29;
            this.MemoryDrawTable.Size = new System.Drawing.Size(248, 475);
            this.MemoryDrawTable.TabIndex = 112;
            this.MemoryDrawTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MemoryDrawTable_CellContentClick);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label28.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label28.Location = new System.Drawing.Point(223, 28);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(407, 51);
            this.label28.TabIndex = 110;
            this.label28.Text = "Memory Segmentation";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label29.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label29.Location = new System.Drawing.Point(24, 307);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(125, 21);
            this.label29.TabIndex = 125;
            this.label29.Text = "Process Number";
            // 
            // NOfSegmentsCell
            // 
            this.NOfSegmentsCell.Location = new System.Drawing.Point(208, 342);
            this.NOfSegmentsCell.Name = "NOfSegmentsCell";
            this.NOfSegmentsCell.Size = new System.Drawing.Size(100, 23);
            this.NOfSegmentsCell.TabIndex = 127;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(24, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 129;
            this.label1.Text = "N.of Segments";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(24, 477);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 21);
            this.label3.TabIndex = 131;
            this.label3.Text = "Segment Name";
            // 
            // SegmentSizeCell
            // 
            this.SegmentSizeCell.Location = new System.Drawing.Point(208, 517);
            this.SegmentSizeCell.Name = "SegmentSizeCell";
            this.SegmentSizeCell.Size = new System.Drawing.Size(100, 23);
            this.SegmentSizeCell.TabIndex = 132;
            // 
            // InsertSegment
            // 
            this.InsertSegment.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InsertSegment.ForeColor = System.Drawing.SystemColors.Highlight;
            this.InsertSegment.Location = new System.Drawing.Point(24, 546);
            this.InsertSegment.Name = "InsertSegment";
            this.InsertSegment.Size = new System.Drawing.Size(284, 46);
            this.InsertSegment.TabIndex = 130;
            this.InsertSegment.Text = "Insert Process Segment";
            this.InsertSegment.UseVisualStyleBackColor = true;
            this.InsertSegment.Click += new System.EventHandler(this.InsertSegmentButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(24, 515);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 134;
            this.label2.Text = "Segment Size";
            // 
            // BestFit
            // 
            this.BestFit.AutoSize = true;
            this.BestFit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BestFit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BestFit.Location = new System.Drawing.Point(114, 264);
            this.BestFit.Name = "BestFit";
            this.BestFit.Size = new System.Drawing.Size(78, 25);
            this.BestFit.TabIndex = 135;
            this.BestFit.TabStop = true;
            this.BestFit.Text = "Best Fit";
            this.BestFit.UseVisualStyleBackColor = true;
            // 
            // FirstFit
            // 
            this.FirstFit.AutoSize = true;
            this.FirstFit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstFit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FirstFit.Location = new System.Drawing.Point(29, 264);
            this.FirstFit.Name = "FirstFit";
            this.FirstFit.Size = new System.Drawing.Size(79, 25);
            this.FirstFit.TabIndex = 136;
            this.FirstFit.TabStop = true;
            this.FirstFit.Text = "First Fit";
            this.FirstFit.UseVisualStyleBackColor = true;
            // 
            // SegmentNameCell
            // 
            this.SegmentNameCell.Location = new System.Drawing.Point(208, 479);
            this.SegmentNameCell.Name = "SegmentNameCell";
            this.SegmentNameCell.Size = new System.Drawing.Size(100, 23);
            this.SegmentNameCell.TabIndex = 138;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(24, 690);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 21);
            this.label5.TabIndex = 140;
            this.label5.Text = " Deallocate Process  :";
            // 
            // DeallocateCell
            // 
            this.DeallocateCell.Location = new System.Drawing.Point(208, 692);
            this.DeallocateCell.Name = "DeallocateCell";
            this.DeallocateCell.Size = new System.Drawing.Size(100, 23);
            this.DeallocateCell.TabIndex = 141;
            // 
            // Deallocate
            // 
            this.Deallocate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Deallocate.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Deallocate.Location = new System.Drawing.Point(24, 760);
            this.Deallocate.Name = "Deallocate";
            this.Deallocate.Size = new System.Drawing.Size(284, 46);
            this.Deallocate.TabIndex = 139;
            this.Deallocate.Text = " Deallocate";
            this.Deallocate.UseVisualStyleBackColor = true;
            this.Deallocate.Click += new System.EventHandler(this.DeallocateButton_Click);
            // 
            // WorstFit
            // 
            this.WorstFit.AutoSize = true;
            this.WorstFit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WorstFit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.WorstFit.Location = new System.Drawing.Point(208, 264);
            this.WorstFit.Name = "WorstFit";
            this.WorstFit.Size = new System.Drawing.Size(90, 25);
            this.WorstFit.TabIndex = 144;
            this.WorstFit.TabStop = true;
            this.WorstFit.Text = "Worst Fit";
            this.WorstFit.UseVisualStyleBackColor = true;
            // 
            // IsOldProcessCheck
            // 
            this.IsOldProcessCheck.AutoSize = true;
            this.IsOldProcessCheck.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IsOldProcessCheck.ForeColor = System.Drawing.Color.Black;
            this.IsOldProcessCheck.Location = new System.Drawing.Point(29, 729);
            this.IsOldProcessCheck.Name = "IsOldProcessCheck";
            this.IsOldProcessCheck.Size = new System.Drawing.Size(126, 25);
            this.IsOldProcessCheck.TabIndex = 145;
            this.IsOldProcessCheck.Text = "Is Old Process";
            this.IsOldProcessCheck.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(17, 659);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(317, 15);
            this.label4.TabIndex = 146;
            this.label4.Text = "--------------------------------------------------------------";
            // 
            // ProcessNumberCell
            // 
            this.ProcessNumberCell.Location = new System.Drawing.Point(208, 309);
            this.ProcessNumberCell.Name = "ProcessNumberCell";
            this.ProcessNumberCell.Size = new System.Drawing.Size(100, 23);
            this.ProcessNumberCell.TabIndex = 147;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(17, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(797, 15);
            this.label6.TabIndex = 154;
            this.label6.Text = "---------------------------------------------------------------------------------" +
    "-----------------------------------------------------------------------------";
            // 
            // HoleAddressCell
            // 
            this.HoleAddressCell.Location = new System.Drawing.Point(208, 104);
            this.HoleAddressCell.Name = "HoleAddressCell";
            this.HoleAddressCell.Size = new System.Drawing.Size(100, 23);
            this.HoleAddressCell.TabIndex = 153;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(24, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 21);
            this.label7.TabIndex = 152;
            this.label7.Text = "Hole Size";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(24, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 21);
            this.label8.TabIndex = 150;
            this.label8.Text = "Hole Address";
            // 
            // HoleSizeCell
            // 
            this.HoleSizeCell.Location = new System.Drawing.Point(208, 142);
            this.HoleSizeCell.Name = "HoleSizeCell";
            this.HoleSizeCell.Size = new System.Drawing.Size(100, 23);
            this.HoleSizeCell.TabIndex = 151;
            // 
            // InsertHole
            // 
            this.InsertHole.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InsertHole.ForeColor = System.Drawing.SystemColors.Highlight;
            this.InsertHole.Location = new System.Drawing.Point(24, 171);
            this.InsertHole.Name = "InsertHole";
            this.InsertHole.Size = new System.Drawing.Size(284, 46);
            this.InsertHole.TabIndex = 149;
            this.InsertHole.Text = "Insert Hole";
            this.InsertHole.UseVisualStyleBackColor = true;
            this.InsertHole.Click += new System.EventHandler(this.InsertHoleButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(17, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 15);
            this.label9.TabIndex = 148;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label10.Location = new System.Drawing.Point(523, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 21);
            this.label10.TabIndex = 158;
            this.label10.Text = "Memory Size";
            // 
            // MemorySizeCell
            // 
            this.MemorySizeCell.Location = new System.Drawing.Point(671, 119);
            this.MemorySizeCell.Name = "MemorySizeCell";
            this.MemorySizeCell.Size = new System.Drawing.Size(100, 23);
            this.MemorySizeCell.TabIndex = 157;
            // 
            // InsertMemorySize
            // 
            this.InsertMemorySize.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InsertMemorySize.ForeColor = System.Drawing.SystemColors.Highlight;
            this.InsertMemorySize.Location = new System.Drawing.Point(523, 171);
            this.InsertMemorySize.Name = "InsertMemorySize";
            this.InsertMemorySize.Size = new System.Drawing.Size(248, 46);
            this.InsertMemorySize.TabIndex = 156;
            this.InsertMemorySize.Text = "Insert Memory Size";
            this.InsertMemorySize.UseVisualStyleBackColor = true;
            this.InsertMemorySize.Click += new System.EventHandler(this.InsertMemorySizeButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(523, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 15);
            this.label11.TabIndex = 155;
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Reset.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Reset.Location = new System.Drawing.Point(364, 171);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(95, 46);
            this.Reset.TabIndex = 159;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 825);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.MemorySizeCell);
            this.Controls.Add(this.InsertMemorySize);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.HoleAddressCell);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.HoleSizeCell);
            this.Controls.Add(this.InsertHole);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ProcessNumberCell);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IsOldProcessCheck);
            this.Controls.Add(this.WorstFit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DeallocateCell);
            this.Controls.Add(this.Deallocate);
            this.Controls.Add(this.SegmentNameCell);
            this.Controls.Add(this.FirstFit);
            this.Controls.Add(this.BestFit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SegmentSizeCell);
            this.Controls.Add(this.InsertSegment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.NOfSegmentsCell);
            this.Controls.Add(this.InsertProcess);
            this.Controls.Add(this.DrawMemory);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.MemoryDrawTable);
            this.Controls.Add(this.label28);
            this.Name = "Form1";
            this.Text = "Memory Segmentation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MemoryDrawTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InsertProcess;
        private System.Windows.Forms.Button DrawMemory;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DataGridView MemoryDrawTable;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox NOfSegmentsCell;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SegmentSizeCell;
        private System.Windows.Forms.Button InsertSegment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton BestFit;
        private System.Windows.Forms.RadioButton FirstFit;
        private System.Windows.Forms.TextBox SegmentNameCell;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DeallocateCell;
        private System.Windows.Forms.Button Deallocate;
        private System.Windows.Forms.RadioButton WorstFit;
        private System.Windows.Forms.CheckBox IsOldProcessCheck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ProcessNumberCell;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox HoleAddressCell;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox HoleSizeCell;
        private System.Windows.Forms.Button InsertHole;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox MemorySizeCell;
        private System.Windows.Forms.Button InsertMemorySize;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Reset;
    }
}

