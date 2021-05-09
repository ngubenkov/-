namespace Жестокие_Игры
{
    partial class MainScreen
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.tblPlayers = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnStart, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tblPlayers, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAddPlayer, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.76471F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.23529F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 301F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(794, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Жестокие игры";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStart.Location = new System.Drawing.Point(3, 404);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(794, 43);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tblPlayers
            // 
            this.tblPlayers.AutoScroll = true;
            this.tblPlayers.AutoSize = true;
            this.tblPlayers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblPlayers.ColumnCount = 2;
            this.tblPlayers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPlayers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 669F));
            this.tblPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPlayers.Location = new System.Drawing.Point(3, 103);
            this.tblPlayers.Name = "tblPlayers";
            this.tblPlayers.RowCount = 2;
            this.tblPlayers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPlayers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblPlayers.Size = new System.Drawing.Size(794, 295);
            this.tblPlayers.TabIndex = 2;
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddPlayer.Location = new System.Drawing.Point(650, 65);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(147, 32);
            this.btnAddPlayer.TabIndex = 3;
            this.btnAddPlayer.Text = "Добавить игрока";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click_1);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainScreen";
            this.Text = "Form1";

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.TableLayoutPanel tblPlayers;
    }
}

