namespace _0521_quiz
{
    partial class Form2
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
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("워드");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("파워포인트");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("엑셀");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("비지오");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("아웃룩");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("오피스", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("메모장");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("그림판");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("계산기");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("보조프로그램", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("내 컴퓨터", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode21});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(29, 23);
            this.treeView1.Name = "treeView1";
            treeNode12.Name = "노드6";
            treeNode12.Text = "워드";
            treeNode13.Name = "노드7";
            treeNode13.Text = "파워포인트";
            treeNode14.Name = "노드8";
            treeNode14.Text = "엑셀";
            treeNode15.Name = "노드9";
            treeNode15.Text = "비지오";
            treeNode16.Name = "노드10";
            treeNode16.Text = "아웃룩";
            treeNode17.Name = "노드4";
            treeNode17.Text = "오피스";
            treeNode18.Name = "노드11";
            treeNode18.Text = "메모장";
            treeNode19.Name = "노드12";
            treeNode19.Text = "그림판";
            treeNode20.Name = "노드13";
            treeNode20.Text = "계산기";
            treeNode21.Name = "노드5";
            treeNode21.Text = "보조프로그램";
            treeNode22.Name = "노드0";
            treeNode22.Text = "내 컴퓨터";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode22});
            this.treeView1.Size = new System.Drawing.Size(257, 250);
            this.treeView1.TabIndex = 0;
            this.treeView1.DoubleClick += new System.EventHandler(this.TreeView1_DoubleClick);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(321, 23);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(259, 250);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.DoubleClick += new System.EventHandler(this.ListView1_DoubleClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 315);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listView1;
    }
}