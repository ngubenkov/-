namespace Жестокие_Игры
{
    partial class PlayersStatistics
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblStatistics = new System.Windows.Forms.Label();
            this.tblStatistics = new System.Windows.Forms.TableLayoutPanel();
            this.lblPlace = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tblStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.57057F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.42943F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel2.Controls.Add(this.lblStatistics, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tblStatistics, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.0991F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.9009F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 444);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblStatistics
            // 
            this.lblStatistics.AutoSize = true;
            this.lblStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatistics.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblStatistics.Location = new System.Drawing.Point(139, 0);
            this.lblStatistics.Name = "lblStatistics";
            this.lblStatistics.Size = new System.Drawing.Size(522, 107);
            this.lblStatistics.TabIndex = 0;
            this.lblStatistics.Text = "Статистика";
            this.lblStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblStatistics
            // 
            this.tblStatistics.AutoSize = true;
            this.tblStatistics.ColumnCount = 3;
            this.tblStatistics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.61809F));
            this.tblStatistics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.38191F));
            this.tblStatistics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tblStatistics.Controls.Add(this.lblPlace, 0, 0);
            this.tblStatistics.Controls.Add(this.label2, 1, 0);
            this.tblStatistics.Controls.Add(this.label3, 2, 0);
            this.tblStatistics.Location = new System.Drawing.Point(139, 110);
            this.tblStatistics.Name = "tblStatistics";
            this.tblStatistics.RowCount = 2;
            this.tblStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblStatistics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblStatistics.Size = new System.Drawing.Size(468, 45);
            this.tblStatistics.TabIndex = 1;
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlace.Location = new System.Drawing.Point(3, 0);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(75, 25);
            this.lblPlace.TabIndex = 0;
            this.lblPlace.Text = "Место";
            this.lblPlace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Игрок";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(345, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Очки";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayersStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PlayersStatistics";
            this.Text = "PlayersStatistics";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tblStatistics.ResumeLayout(false);
            this.tblStatistics.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblStatistics;
        private System.Windows.Forms.TableLayoutPanel tblStatistics;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}