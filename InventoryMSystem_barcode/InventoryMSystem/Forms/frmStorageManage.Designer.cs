﻿namespace InventoryMSystem
{
    partial class frmStorageManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStorageManage));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvNotStoragedPInfo = new System.Windows.Forms.DataGridView();
            this.btnStorageP = new System.Windows.Forms.Button();
            this.btnRefreshNotStoragedP = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbSelectAllNotStoragedP = new System.Windows.Forms.CheckBox();
            this.btnGetTag = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotStoragedPInfo)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvNotStoragedPInfo);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 465);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dgvNotStoragedPInfo
            // 
            this.dgvNotStoragedPInfo.AllowUserToAddRows = false;
            this.dgvNotStoragedPInfo.AllowUserToDeleteRows = false;
            this.dgvNotStoragedPInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotStoragedPInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNotStoragedPInfo.Location = new System.Drawing.Point(3, 17);
            this.dgvNotStoragedPInfo.Name = "dgvNotStoragedPInfo";
            this.dgvNotStoragedPInfo.ReadOnly = true;
            this.dgvNotStoragedPInfo.RowHeadersWidth = 20;
            this.dgvNotStoragedPInfo.RowTemplate.Height = 23;
            this.dgvNotStoragedPInfo.Size = new System.Drawing.Size(658, 445);
            this.dgvNotStoragedPInfo.TabIndex = 0;
            // 
            // btnStorageP
            // 
            this.btnStorageP.Location = new System.Drawing.Point(687, 66);
            this.btnStorageP.Name = "btnStorageP";
            this.btnStorageP.Size = new System.Drawing.Size(90, 30);
            this.btnStorageP.TabIndex = 2;
            this.btnStorageP.Text = "入库";
            this.btnStorageP.UseVisualStyleBackColor = true;
            this.btnStorageP.Click += new System.EventHandler(this.btnStorageP_Click);
            // 
            // btnRefreshNotStoragedP
            // 
            this.btnRefreshNotStoragedP.Location = new System.Drawing.Point(687, 115);
            this.btnRefreshNotStoragedP.Name = "btnRefreshNotStoragedP";
            this.btnRefreshNotStoragedP.Size = new System.Drawing.Size(90, 30);
            this.btnRefreshNotStoragedP.TabIndex = 2;
            this.btnRefreshNotStoragedP.Text = "刷新";
            this.btnRefreshNotStoragedP.UseVisualStyleBackColor = true;
            this.btnRefreshNotStoragedP.Click += new System.EventHandler(this.btnRefreshNotStoragedP_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(707, 547);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(90, 30);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "退出";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(8, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(793, 502);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.cbSelectAllNotStoragedP);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnRefreshNotStoragedP);
            this.tabPage1.Controls.Add(this.btnGetTag);
            this.tabPage1.Controls.Add(this.btnStorageP);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(785, 476);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "未入库产品信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbSelectAllNotStoragedP
            // 
            this.cbSelectAllNotStoragedP.AutoSize = true;
            this.cbSelectAllNotStoragedP.Location = new System.Drawing.Point(48, 26);
            this.cbSelectAllNotStoragedP.Name = "cbSelectAllNotStoragedP";
            this.cbSelectAllNotStoragedP.Size = new System.Drawing.Size(15, 14);
            this.cbSelectAllNotStoragedP.TabIndex = 3;
            this.cbSelectAllNotStoragedP.UseVisualStyleBackColor = true;
            this.cbSelectAllNotStoragedP.CheckedChanged += new System.EventHandler(this.cbSelectAllNotStoragedP_CheckedChanged);
            // 
            // btnGetTag
            // 
            this.btnGetTag.Location = new System.Drawing.Point(687, 18);
            this.btnGetTag.Name = "btnGetTag";
            this.btnGetTag.Size = new System.Drawing.Size(90, 30);
            this.btnGetTag.TabIndex = 2;
            this.btnGetTag.Text = "扫描";
            this.btnGetTag.UseVisualStyleBackColor = true;
            this.btnGetTag.Click += new System.EventHandler(this.btnGetTag_Click);
            // 
            // frmStorageManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 586);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnQuit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmStorageManage";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "入库管理";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotStoragedPInfo)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvNotStoragedPInfo;
        private System.Windows.Forms.Button btnStorageP;
        private System.Windows.Forms.Button btnRefreshNotStoragedP;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox cbSelectAllNotStoragedP;
        private System.Windows.Forms.Button btnGetTag;
    }
}