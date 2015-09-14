namespace CW_File_Viewer_2._0
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.filev = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewfile = new System.Windows.Forms.Button();
            this.lrcv = new System.Windows.Forms.TextBox();
            this.folderbroser = new System.Windows.Forms.FolderBrowserDialog();
            this.sfpath = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.axSkinFramework1 = new AxXtremeSkinFramework.AxSkinFramework();
            this.write = new System.Windows.Forms.Button();
            this.recover = new System.Windows.Forms.Button();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axSkinFramework1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // filev
            // 
            this.filev.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.filev.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filev.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.filev.GridLines = true;
            this.filev.Location = new System.Drawing.Point(13, 42);
            this.filev.Margin = new System.Windows.Forms.Padding(4);
            this.filev.Name = "filev";
            this.filev.Size = new System.Drawing.Size(367, 653);
            this.filev.TabIndex = 13;
            this.filev.UseCompatibleStateImageBehavior = false;
            this.filev.View = System.Windows.Forms.View.Details;
            this.filev.SelectedIndexChanged += new System.EventHandler(this.filev_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "文件名";
            this.columnHeader1.Width = 549;
            // 
            // viewfile
            // 
            this.viewfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.viewfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.viewfile.ForeColor = System.Drawing.Color.White;
            this.viewfile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.viewfile.Location = new System.Drawing.Point(13, 8);
            this.viewfile.Margin = new System.Windows.Forms.Padding(4);
            this.viewfile.Name = "viewfile";
            this.viewfile.Size = new System.Drawing.Size(100, 25);
            this.viewfile.TabIndex = 12;
            this.viewfile.Text = "浏览";
            this.viewfile.UseVisualStyleBackColor = false;
            this.viewfile.Click += new System.EventHandler(this.viewfile_Click);
            // 
            // lrcv
            // 
            this.lrcv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lrcv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lrcv.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lrcv.Location = new System.Drawing.Point(387, 110);
            this.lrcv.Multiline = true;
            this.lrcv.Name = "lrcv";
            this.lrcv.Size = new System.Drawing.Size(697, 548);
            this.lrcv.TabIndex = 14;
            this.lrcv.TextChanged += new System.EventHandler(this.lrcv_TextChanged);
            // 
            // sfpath
            // 
            this.sfpath.AutoSize = true;
            this.sfpath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sfpath.Location = new System.Drawing.Point(182, 13);
            this.sfpath.Name = "sfpath";
            this.sfpath.Size = new System.Drawing.Size(39, 15);
            this.sfpath.TabIndex = 15;
            this.sfpath.Text = "None";
            // 
            // back
            // 
            this.back.BackgroundImage = global::CW_File_Viewer_2._0.Properties.Resources.back;
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Location = new System.Drawing.Point(120, 8);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(25, 25);
            this.back.TabIndex = 17;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // next
            // 
            this.next.BackgroundImage = global::CW_File_Viewer_2._0.Properties.Resources.next;
            this.next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.next.Location = new System.Drawing.Point(151, 8);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(25, 25);
            this.next.TabIndex = 18;
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // axSkinFramework1
            // 
            this.axSkinFramework1.Enabled = true;
            this.axSkinFramework1.Location = new System.Drawing.Point(0, 0);
            this.axSkinFramework1.Name = "axSkinFramework1";
            this.axSkinFramework1.TabIndex = 0;
            // 
            // write
            // 
            this.write.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.write.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.write.Location = new System.Drawing.Point(387, 664);
            this.write.Name = "write";
            this.write.Size = new System.Drawing.Size(338, 31);
            this.write.TabIndex = 19;
            this.write.Text = "写入";
            this.write.UseVisualStyleBackColor = true;
            this.write.Click += new System.EventHandler(this.write_Click);
            // 
            // recover
            // 
            this.recover.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.recover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recover.Location = new System.Drawing.Point(745, 664);
            this.recover.Name = "recover";
            this.recover.Size = new System.Drawing.Size(339, 31);
            this.recover.TabIndex = 19;
            this.recover.Text = "还原";
            this.recover.UseVisualStyleBackColor = true;
            this.recover.Click += new System.EventHandler(this.recover_Click);
            // 
            // player
            // 
            this.player.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(387, 42);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(697, 62);
            this.player.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 703);
            this.Controls.Add(this.player);
            this.Controls.Add(this.recover);
            this.Controls.Add(this.write);
            this.Controls.Add(this.next);
            this.Controls.Add(this.back);
            this.Controls.Add(this.filev);
            this.Controls.Add(this.viewfile);
            this.Controls.Add(this.lrcv);
            this.Controls.Add(this.sfpath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CW File Viewer 2.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axSkinFramework1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView filev;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button viewfile;
        private System.Windows.Forms.TextBox lrcv;
        private System.Windows.Forms.FolderBrowserDialog folderbroser;
        private System.Windows.Forms.Label sfpath;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button next;
        private AxXtremeSkinFramework.AxSkinFramework axSkinFramework1;
        private System.Windows.Forms.Button write;
        private System.Windows.Forms.Button recover;
        private AxWMPLib.AxWindowsMediaPlayer player;

    }
}

