﻿
namespace Party_MS2
{
    partial class AdminIndex2
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("申请人基本信息管理");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("成绩审查");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("思想汇报管理");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("基本资料管理", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("发展计划管理");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("思政教育管理");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("函调管理");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("计划、培训及函调管理", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("会议管理");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("文书管理");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("联系管理员");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("退出");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("系统", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiNavMenu1 = new Sunny.UI.UINavMenu();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uiAvatar1 = new Sunny.UI.UIAvatar();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uiNavMenu1);
            this.panel1.Location = new System.Drawing.Point(1, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 672);
            this.panel1.TabIndex = 0;
            // 
            // uiNavMenu1
            // 
            this.uiNavMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.uiNavMenu1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uiNavMenu1.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.uiNavMenu1.ExpandSelectFirst = false;
            this.uiNavMenu1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.uiNavMenu1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiNavMenu1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiNavMenu1.FullRowSelect = true;
            this.uiNavMenu1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.uiNavMenu1.ItemHeight = 50;
            this.uiNavMenu1.Location = new System.Drawing.Point(3, 3);
            this.uiNavMenu1.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.uiNavMenu1.Name = "uiNavMenu1";
            treeNode1.Name = "节点1";
            treeNode1.Text = "申请人基本信息管理";
            treeNode2.Name = "节点2";
            treeNode2.Text = "成绩审查";
            treeNode3.Name = "节点4";
            treeNode3.Text = "思想汇报管理";
            treeNode4.Name = "基本资料管理";
            treeNode4.Text = "基本资料管理";
            treeNode5.Name = "节点9";
            treeNode5.Text = "发展计划管理";
            treeNode6.Name = "节点10";
            treeNode6.Text = "思政教育管理";
            treeNode7.Name = "节点11";
            treeNode7.Text = "函调管理";
            treeNode8.Name = "节点5";
            treeNode8.Text = "计划、培训及函调管理";
            treeNode9.Name = "节点6";
            treeNode9.Text = "会议管理";
            treeNode10.Name = "节点7";
            treeNode10.Text = "文书管理";
            treeNode11.Name = "节点13";
            treeNode11.Text = "联系管理员";
            treeNode12.Name = "节点14";
            treeNode12.Text = "退出";
            treeNode13.Name = "节点8";
            treeNode13.Text = "系统";
            this.uiNavMenu1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode13});
            this.uiNavMenu1.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiNavMenu1.ScrollBarHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiNavMenu1.ScrollBarPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiNavMenu1.ScrollFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.uiNavMenu1.SecondBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.uiNavMenu1.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.uiNavMenu1.SelectedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.uiNavMenu1.SelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.uiNavMenu1.SelectedHighColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.uiNavMenu1.ShowLines = false;
            this.uiNavMenu1.Size = new System.Drawing.Size(252, 669);
            this.uiNavMenu1.Style = Sunny.UI.UIStyle.LayuiRed;
            this.uiNavMenu1.TabIndex = 5;
            this.uiNavMenu1.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiNavMenu1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiNavMenu1.MenuItemClick += new Sunny.UI.UINavMenu.OnMenuItemClick(this.uiNavMenu1_MenuItemClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uiAvatar1);
            this.panel2.Controls.Add(this.uiLabel1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(1, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1297, 46);
            this.panel2.TabIndex = 1;
            // 
            // uiAvatar1
            // 
            this.uiAvatar1.AvatarSize = 50;
            this.uiAvatar1.FillColor = System.Drawing.Color.Red;
            this.uiAvatar1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiAvatar1.ForeColor = System.Drawing.Color.Yellow;
            this.uiAvatar1.Location = new System.Drawing.Point(1244, -1);
            this.uiAvatar1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiAvatar1.Name = "uiAvatar1";
            this.uiAvatar1.Size = new System.Drawing.Size(53, 57);
            this.uiAvatar1.Style = Sunny.UI.UIStyle.Custom;
            this.uiAvatar1.SymbolSize = 40;
            this.uiAvatar1.TabIndex = 0;
            this.uiAvatar1.Text = "uiAvatar1";
            this.uiAvatar1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Red;
            this.uiLabel1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.Yellow;
            this.uiLabel1.Location = new System.Drawing.Point(100, 7);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(369, 35);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "吉林大学党务管理信息系统";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Party_MS2.Properties.Resources.t01cd4b59a94db03b3b;
            this.pictureBox1.Location = new System.Drawing.Point(35, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Location = new System.Drawing.Point(265, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1066, 672);
            this.panel3.TabIndex = 2;
            // 
            // AdminIndex2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 727);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminIndex2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminIndex2";
            this.Load += new System.EventHandler(this.AdminIndex2_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Sunny.UI.UINavMenu uiNavMenu1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UIAvatar uiAvatar1;
        private Sunny.UI.UILabel uiLabel1;
    }
}