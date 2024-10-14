namespace LiveSplit.HPBingo.Forms
{
    partial class HPBingoHostControl
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
            this.counterTable = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.bingoValue = new System.Windows.Forms.Label();
            this.hPBingoHostControlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hpBingoScoreTracker1 = new LiveSplit.HPBingo.Forms.HPBingoScoreTracker();
            this.hpBingoScoreTracker2 = new LiveSplit.HPBingo.Forms.HPBingoScoreTracker();
            this.hpBingoScoreTracker3 = new LiveSplit.HPBingo.Forms.HPBingoScoreTracker();
            this.hpBingoScoreTracker4 = new LiveSplit.HPBingo.Forms.HPBingoScoreTracker();
            this.hpBingoScoreTracker5 = new LiveSplit.HPBingo.Forms.HPBingoScoreTracker();
            this.hpBingoScoreTracker6 = new LiveSplit.HPBingo.Forms.HPBingoScoreTracker();
            this.hpBingoScoreTracker7 = new LiveSplit.HPBingo.Forms.HPBingoScoreTracker();
            this.hpBingoScoreTracker8 = new LiveSplit.HPBingo.Forms.HPBingoScoreTracker();
            this.hpBingoScoreTracker9 = new LiveSplit.HPBingo.Forms.HPBingoScoreTracker();
            this.hpBingoScoreTracker10 = new LiveSplit.HPBingo.Forms.HPBingoScoreTracker();
            this.counterTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hPBingoHostControlBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // counterTable
            // 
            this.counterTable.ColumnCount = 2;
            this.counterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.counterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.counterTable.Controls.Add(this.label11, 0, 10);
            this.counterTable.Controls.Add(this.bingoValue, 1, 10);
            this.counterTable.Controls.Add(this.hpBingoScoreTracker1, 0, 0);
            this.counterTable.Controls.Add(this.hpBingoScoreTracker2, 0, 1);
            this.counterTable.Controls.Add(this.hpBingoScoreTracker3, 0, 2);
            this.counterTable.Controls.Add(this.hpBingoScoreTracker4, 0, 3);
            this.counterTable.Controls.Add(this.hpBingoScoreTracker5, 0, 4);
            this.counterTable.Controls.Add(this.hpBingoScoreTracker6, 0, 5);
            this.counterTable.Controls.Add(this.hpBingoScoreTracker7, 0, 6);
            this.counterTable.Controls.Add(this.hpBingoScoreTracker8, 0, 7);
            this.counterTable.Controls.Add(this.hpBingoScoreTracker9, 0, 8);
            this.counterTable.Controls.Add(this.hpBingoScoreTracker10, 0, 9);
            this.counterTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.counterTable.Location = new System.Drawing.Point(0, 0);
            this.counterTable.Name = "counterTable";
            this.counterTable.RowCount = 11;
            this.counterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.counterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.counterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.counterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.counterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.counterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.counterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.counterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.counterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.counterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.counterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.counterTable.Size = new System.Drawing.Size(444, 450);
            this.counterTable.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", this.hPBingoHostControlBindingSource, "LabelColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(3, 400);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(216, 50);
            this.label11.TabIndex = 21;
            this.label11.Text = "Goals";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bingoValue
            // 
            this.bingoValue.AutoSize = true;
            this.bingoValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bingoValue.Location = new System.Drawing.Point(225, 400);
            this.bingoValue.Name = "bingoValue";
            this.bingoValue.Size = new System.Drawing.Size(216, 50);
            this.bingoValue.TabIndex = 11;
            this.bingoValue.Text = "0 / 0";
            this.bingoValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hPBingoHostControlBindingSource
            // 
            this.hPBingoHostControlBindingSource.DataSource = typeof(LiveSplit.HPBingo.Forms.HPBingoHostControl);
            // 
            // hpBingoScoreTracker1
            // 
            this.hpBingoScoreTracker1.BackColor = System.Drawing.Color.Transparent;
            this.counterTable.SetColumnSpan(this.hpBingoScoreTracker1, 2);
            this.hpBingoScoreTracker1.CounterColor = System.Drawing.SystemColors.ControlText;
            this.hpBingoScoreTracker1.CounterFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hpBingoScoreTracker1.DataBindings.Add(new System.Windows.Forms.Binding("LabelColor", this.hPBingoHostControlBindingSource, "LabelColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.hpBingoScoreTracker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hpBingoScoreTracker1.GoalType = LiveSplit.HPBingo.Types.BingoGoal.BG_Star;
            this.hpBingoScoreTracker1.Label = "Stars";
            this.hpBingoScoreTracker1.LabelColor = System.Drawing.SystemColors.ControlText;
            this.hpBingoScoreTracker1.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hpBingoScoreTracker1.Location = new System.Drawing.Point(3, 3);
            this.hpBingoScoreTracker1.Name = "hpBingoScoreTracker1";
            this.hpBingoScoreTracker1.Size = new System.Drawing.Size(438, 34);
            this.hpBingoScoreTracker1.TabIndex = 22;
            this.hpBingoScoreTracker1.Value = 0;
            // 
            // hpBingoScoreTracker2
            // 
            this.hpBingoScoreTracker2.BackColor = System.Drawing.Color.Transparent;
            this.counterTable.SetColumnSpan(this.hpBingoScoreTracker2, 2);
            this.hpBingoScoreTracker2.CounterColor = System.Drawing.SystemColors.ControlText;
            this.hpBingoScoreTracker2.CounterFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hpBingoScoreTracker2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hpBingoScoreTracker2.GoalType = LiveSplit.HPBingo.Types.BingoGoal.BG_Armorstand;
            this.hpBingoScoreTracker2.Label = "Armorstands";
            this.hpBingoScoreTracker2.LabelColor = System.Drawing.SystemColors.ControlText;
            this.hpBingoScoreTracker2.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hpBingoScoreTracker2.Location = new System.Drawing.Point(3, 43);
            this.hpBingoScoreTracker2.Name = "hpBingoScoreTracker2";
            this.hpBingoScoreTracker2.Size = new System.Drawing.Size(438, 34);
            this.hpBingoScoreTracker2.TabIndex = 23;
            this.hpBingoScoreTracker2.Value = 0;
            // 
            // hpBingoScoreTracker3
            // 
            this.hpBingoScoreTracker3.BackColor = System.Drawing.Color.Transparent;
            this.counterTable.SetColumnSpan(this.hpBingoScoreTracker3, 2);
            this.hpBingoScoreTracker3.CounterColor = System.Drawing.SystemColors.ControlText;
            this.hpBingoScoreTracker3.CounterFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hpBingoScoreTracker3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hpBingoScoreTracker3.GoalType = LiveSplit.HPBingo.Types.BingoGoal.BG_Cauldron;
            this.hpBingoScoreTracker3.Label = "Cauldrons";
            this.hpBingoScoreTracker3.LabelColor = System.Drawing.SystemColors.ControlText;
            this.hpBingoScoreTracker3.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hpBingoScoreTracker3.Location = new System.Drawing.Point(3, 83);
            this.hpBingoScoreTracker3.Name = "hpBingoScoreTracker3";
            this.hpBingoScoreTracker3.Size = new System.Drawing.Size(438, 34);
            this.hpBingoScoreTracker3.TabIndex = 24;
            this.hpBingoScoreTracker3.Value = 0;
            // 
            // hpBingoScoreTracker4
            // 
            this.hpBingoScoreTracker4.BackColor = System.Drawing.Color.Transparent;
            this.counterTable.SetColumnSpan(this.hpBingoScoreTracker4, 2);
            this.hpBingoScoreTracker4.CounterColor = System.Drawing.SystemColors.ControlText;
            this.hpBingoScoreTracker4.CounterFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hpBingoScoreTracker4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hpBingoScoreTracker4.GoalType = LiveSplit.HPBingo.Types.BingoGoal.BG_Pot;
            this.hpBingoScoreTracker4.Label = "Pots";
            this.hpBingoScoreTracker4.LabelColor = System.Drawing.SystemColors.ControlText;
            this.hpBingoScoreTracker4.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hpBingoScoreTracker4.Location = new System.Drawing.Point(3, 123);
            this.hpBingoScoreTracker4.Name = "hpBingoScoreTracker4";
            this.hpBingoScoreTracker4.Size = new System.Drawing.Size(438, 34);
            this.hpBingoScoreTracker4.TabIndex = 25;
            this.hpBingoScoreTracker4.Value = 0;
            // 
            // hpBingoScoreTracker5
            // 
            this.hpBingoScoreTracker5.BackColor = System.Drawing.Color.Transparent;
            this.counterTable.SetColumnSpan(this.hpBingoScoreTracker5, 2);
            this.hpBingoScoreTracker5.CounterColor = System.Drawing.SystemColors.ControlText;
            this.hpBingoScoreTracker5.CounterFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hpBingoScoreTracker5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hpBingoScoreTracker5.GoalType = LiveSplit.HPBingo.Types.BingoGoal.BG_Imp;
            this.hpBingoScoreTracker5.Label = "Imps";
            this.hpBingoScoreTracker5.LabelColor = System.Drawing.SystemColors.ControlText;
            this.hpBingoScoreTracker5.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hpBingoScoreTracker5.Location = new System.Drawing.Point(3, 163);
            this.hpBingoScoreTracker5.Name = "hpBingoScoreTracker5";
            this.hpBingoScoreTracker5.Size = new System.Drawing.Size(438, 34);
            this.hpBingoScoreTracker5.TabIndex = 26;
            this.hpBingoScoreTracker5.Value = 0;
            // 
            // hpBingoScoreTracker6
            // 
            this.hpBingoScoreTracker6.BackColor = System.Drawing.Color.Transparent;
            this.counterTable.SetColumnSpan(this.hpBingoScoreTracker6, 2);
            this.hpBingoScoreTracker6.CounterColor = System.Drawing.SystemColors.ControlText;
            this.hpBingoScoreTracker6.CounterFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hpBingoScoreTracker6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hpBingoScoreTracker6.GoalType = LiveSplit.HPBingo.Types.BingoGoal.BG_Spider;
            this.hpBingoScoreTracker6.Label = "Spiders";
            this.hpBingoScoreTracker6.LabelColor = System.Drawing.SystemColors.ControlText;
            this.hpBingoScoreTracker6.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hpBingoScoreTracker6.Location = new System.Drawing.Point(3, 203);
            this.hpBingoScoreTracker6.Name = "hpBingoScoreTracker6";
            this.hpBingoScoreTracker6.Size = new System.Drawing.Size(438, 34);
            this.hpBingoScoreTracker6.TabIndex = 27;
            this.hpBingoScoreTracker6.Value = 0;
            // 
            // hpBingoScoreTracker7
            // 
            this.hpBingoScoreTracker7.BackColor = System.Drawing.Color.Transparent;
            this.counterTable.SetColumnSpan(this.hpBingoScoreTracker7, 2);
            this.hpBingoScoreTracker7.CounterColor = System.Drawing.SystemColors.ControlText;
            this.hpBingoScoreTracker7.CounterFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hpBingoScoreTracker7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hpBingoScoreTracker7.GoalType = LiveSplit.HPBingo.Types.BingoGoal.BG_Pixie;
            this.hpBingoScoreTracker7.Label = "Pixies";
            this.hpBingoScoreTracker7.LabelColor = System.Drawing.SystemColors.ControlText;
            this.hpBingoScoreTracker7.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hpBingoScoreTracker7.Location = new System.Drawing.Point(3, 243);
            this.hpBingoScoreTracker7.Name = "hpBingoScoreTracker7";
            this.hpBingoScoreTracker7.Size = new System.Drawing.Size(438, 34);
            this.hpBingoScoreTracker7.TabIndex = 28;
            this.hpBingoScoreTracker7.Value = 0;
            // 
            // hpBingoScoreTracker8
            // 
            this.hpBingoScoreTracker8.BackColor = System.Drawing.Color.Transparent;
            this.counterTable.SetColumnSpan(this.hpBingoScoreTracker8, 2);
            this.hpBingoScoreTracker8.CounterColor = System.Drawing.SystemColors.ControlText;
            this.hpBingoScoreTracker8.CounterFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hpBingoScoreTracker8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hpBingoScoreTracker8.GoalType = LiveSplit.HPBingo.Types.BingoGoal.BG_Frog;
            this.hpBingoScoreTracker8.Label = "Frogs";
            this.hpBingoScoreTracker8.LabelColor = System.Drawing.SystemColors.ControlText;
            this.hpBingoScoreTracker8.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hpBingoScoreTracker8.Location = new System.Drawing.Point(3, 283);
            this.hpBingoScoreTracker8.Name = "hpBingoScoreTracker8";
            this.hpBingoScoreTracker8.Size = new System.Drawing.Size(438, 34);
            this.hpBingoScoreTracker8.TabIndex = 29;
            this.hpBingoScoreTracker8.Value = 0;
            // 
            // hpBingoScoreTracker9
            // 
            this.hpBingoScoreTracker9.BackColor = System.Drawing.Color.Transparent;
            this.counterTable.SetColumnSpan(this.hpBingoScoreTracker9, 2);
            this.hpBingoScoreTracker9.CounterColor = System.Drawing.SystemColors.ControlText;
            this.hpBingoScoreTracker9.CounterFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hpBingoScoreTracker9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hpBingoScoreTracker9.GoalType = LiveSplit.HPBingo.Types.BingoGoal.BG_Bark;
            this.hpBingoScoreTracker9.Label = "Wiggentree Barks";
            this.hpBingoScoreTracker9.LabelColor = System.Drawing.SystemColors.ControlText;
            this.hpBingoScoreTracker9.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hpBingoScoreTracker9.Location = new System.Drawing.Point(3, 323);
            this.hpBingoScoreTracker9.Name = "hpBingoScoreTracker9";
            this.hpBingoScoreTracker9.Size = new System.Drawing.Size(438, 34);
            this.hpBingoScoreTracker9.TabIndex = 30;
            this.hpBingoScoreTracker9.Value = 0;
            // 
            // hpBingoScoreTracker10
            // 
            this.hpBingoScoreTracker10.BackColor = System.Drawing.Color.Transparent;
            this.counterTable.SetColumnSpan(this.hpBingoScoreTracker10, 2);
            this.hpBingoScoreTracker10.CounterColor = System.Drawing.SystemColors.ControlText;
            this.hpBingoScoreTracker10.CounterFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hpBingoScoreTracker10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hpBingoScoreTracker10.GoalType = LiveSplit.HPBingo.Types.BingoGoal.BG_Mucus;
            this.hpBingoScoreTracker10.Label = "Flobberworm Mucus";
            this.hpBingoScoreTracker10.LabelColor = System.Drawing.SystemColors.ControlText;
            this.hpBingoScoreTracker10.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hpBingoScoreTracker10.Location = new System.Drawing.Point(3, 363);
            this.hpBingoScoreTracker10.Name = "hpBingoScoreTracker10";
            this.hpBingoScoreTracker10.Size = new System.Drawing.Size(438, 34);
            this.hpBingoScoreTracker10.TabIndex = 31;
            this.hpBingoScoreTracker10.Value = 0;
            // 
            // HPBingoHostControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.counterTable);
            this.Name = "HPBingoHostControl";
            this.Size = new System.Drawing.Size(444, 450);
            this.counterTable.ResumeLayout(false);
            this.counterTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hPBingoHostControlBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel counterTable;
        private System.Windows.Forms.Label bingoValue;
        private System.Windows.Forms.Label label11;
        private HPBingoScoreTracker hpBingoScoreTracker1;
        private HPBingoScoreTracker hpBingoScoreTracker2;
        private HPBingoScoreTracker hpBingoScoreTracker3;
        private HPBingoScoreTracker hpBingoScoreTracker4;
        private HPBingoScoreTracker hpBingoScoreTracker5;
        private HPBingoScoreTracker hpBingoScoreTracker6;
        private HPBingoScoreTracker hpBingoScoreTracker7;
        private HPBingoScoreTracker hpBingoScoreTracker8;
        private HPBingoScoreTracker hpBingoScoreTracker9;
        private HPBingoScoreTracker hpBingoScoreTracker10;
        private System.Windows.Forms.BindingSource hPBingoHostControlBindingSource;
    }
}