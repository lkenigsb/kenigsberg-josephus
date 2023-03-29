namespace JosephusGUI
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
            this.NumSol = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nSoldiers = new System.Windows.Forms.NumericUpDown();
            this.nCount = new System.Windows.Forms.NumericUpDown();
            this.bGo = new System.Windows.Forms.Button();
            this.pbSoldier = new System.Windows.Forms.PictureBox();
            this.pnlBattleField = new System.Windows.Forms.Panel();
            this.pbSword = new System.Windows.Forms.PictureBox();
            this.dead_soldier = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nSoldiers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSoldier)).BeginInit();
            this.pnlBattleField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dead_soldier)).BeginInit();
            this.SuspendLayout();
            // 
            // NumSol
            // 
            this.NumSol.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumSol.Location = new System.Drawing.Point(35, 30);
            this.NumSol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumSol.Name = "NumSol";
            this.NumSol.Size = new System.Drawing.Size(210, 31);
            this.NumSol.TabIndex = 0;
            this.NumSol.Text = "Number of Soldiers";
            this.NumSol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NumSol.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(35, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Countdown";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nSoldiers
            // 
            this.nSoldiers.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nSoldiers.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nSoldiers.Location = new System.Drawing.Point(269, 29);
            this.nSoldiers.Margin = new System.Windows.Forms.Padding(4);
            this.nSoldiers.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nSoldiers.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nSoldiers.Name = "nSoldiers";
            this.nSoldiers.ReadOnly = true;
            this.nSoldiers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nSoldiers.Size = new System.Drawing.Size(71, 35);
            this.nSoldiers.TabIndex = 2;
            this.nSoldiers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nSoldiers.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nSoldiers.ValueChanged += new System.EventHandler(this.nSoldiers_ValueChanged);
            // 
            // nCount
            // 
            this.nCount.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nCount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nCount.Location = new System.Drawing.Point(269, 90);
            this.nCount.Margin = new System.Windows.Forms.Padding(4);
            this.nCount.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nCount.Name = "nCount";
            this.nCount.Size = new System.Drawing.Size(71, 35);
            this.nCount.TabIndex = 3;
            this.nCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bGo
            // 
            this.bGo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bGo.BackgroundImage = global::JosephusGUI.Properties.Resources.sword;
            this.bGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bGo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bGo.Location = new System.Drawing.Point(381, 26);
            this.bGo.Margin = new System.Windows.Forms.Padding(4);
            this.bGo.Name = "bGo";
            this.bGo.Size = new System.Drawing.Size(81, 102);
            this.bGo.TabIndex = 4;
            this.bGo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bGo.UseVisualStyleBackColor = false;
            this.bGo.Click += new System.EventHandler(this.bGo_Click);
            // 
            // pbSoldier
            // 
            this.pbSoldier.Image = global::JosephusGUI.Properties.Resources.soldier_angry_2;
            this.pbSoldier.Location = new System.Drawing.Point(1111, 15);
            this.pbSoldier.Margin = new System.Windows.Forms.Padding(4);
            this.pbSoldier.Name = "pbSoldier";
            this.pbSoldier.Size = new System.Drawing.Size(77, 81);
            this.pbSoldier.TabIndex = 5;
            this.pbSoldier.TabStop = false;
            this.pbSoldier.Visible = false;
            // 
            // pnlBattleField
            // 
            this.pnlBattleField.Controls.Add(this.pbSword);
            this.pnlBattleField.Location = new System.Drawing.Point(336, 160);
            this.pnlBattleField.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBattleField.Name = "pnlBattleField";
            this.pnlBattleField.Size = new System.Drawing.Size(750, 750);
            this.pnlBattleField.TabIndex = 6;
            this.pnlBattleField.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pbSword
            // 
            this.pbSword.Image = global::JosephusGUI.Properties.Resources.sword;
            this.pbSword.Location = new System.Drawing.Point(374, 3);
            this.pbSword.Name = "pbSword";
            this.pbSword.Size = new System.Drawing.Size(36, 62);
            this.pbSword.TabIndex = 8;
            this.pbSword.TabStop = false;
            this.pbSword.Visible = false;
            // 
            // dead_soldier
            // 
            this.dead_soldier.BackgroundImage = global::JosephusGUI.Properties.Resources.rip_dead_cropped;
            this.dead_soldier.Image = global::JosephusGUI.Properties.Resources.rip_dead_cropped_2;
            this.dead_soldier.Location = new System.Drawing.Point(1179, 30);
            this.dead_soldier.Name = "dead_soldier";
            this.dead_soldier.Size = new System.Drawing.Size(63, 66);
            this.dead_soldier.TabIndex = 7;
            this.dead_soldier.TabStop = false;
            this.dead_soldier.Visible = false;
            this.dead_soldier.Click += new System.EventHandler(this.dead_soldier_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 925);
            this.Controls.Add(this.dead_soldier);
            this.Controls.Add(this.pnlBattleField);
            this.Controls.Add(this.pbSoldier);
            this.Controls.Add(this.bGo);
            this.Controls.Add(this.nCount);
            this.Controls.Add(this.nSoldiers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumSol);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nSoldiers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSoldier)).EndInit();
            this.pnlBattleField.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dead_soldier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label NumSol;
        private Label label2;
        private NumericUpDown nSoldiers;
        private NumericUpDown nCount;
        private Button bGo;
        private PictureBox pbSoldier;
        private Panel pnlBattleField;
        private PictureBox dead_soldier;
        private PictureBox pbSword;
    }
}