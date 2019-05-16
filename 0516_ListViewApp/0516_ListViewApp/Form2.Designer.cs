namespace _0516_ListViewApp
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("베토벤");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("슈베르트");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("모짜르트");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("클래식", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Britney Spears");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Mariah Carey");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Carpenters");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("팝", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("이승환");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("전인권");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("이효리");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("가요", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(33, 29);
            this.treeView1.Name = "treeView1";
            treeNode1.ImageIndex = 0;
            treeNode1.Name = "노드3";
            treeNode1.Text = "베토벤";
            treeNode2.ImageIndex = 0;
            treeNode2.Name = "노드4";
            treeNode2.Text = "슈베르트";
            treeNode3.ImageIndex = 0;
            treeNode3.Name = "노드5";
            treeNode3.Text = "모짜르트";
            treeNode4.ImageIndex = 1;
            treeNode4.Name = "노드0";
            treeNode4.SelectedImageIndex = 1;
            treeNode4.Text = "클래식";
            treeNode5.Name = "노드6";
            treeNode5.Text = "Britney Spears";
            treeNode6.Name = "노드8";
            treeNode6.Text = "Mariah Carey";
            treeNode7.Name = "노드9";
            treeNode7.Text = "Carpenters";
            treeNode8.ImageIndex = 1;
            treeNode8.Name = "노드1";
            treeNode8.SelectedImageIndex = 1;
            treeNode8.Text = "팝";
            treeNode9.Name = "노드10";
            treeNode9.Text = "이승환";
            treeNode10.Name = "노드11";
            treeNode10.Text = "전인권";
            treeNode11.Name = "노드12";
            treeNode11.Text = "이효리";
            treeNode12.ImageIndex = 1;
            treeNode12.Name = "노드2";
            treeNode12.SelectedImageIndex = 1;
            treeNode12.Text = "가요";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8,
            treeNode12});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(233, 186);
            this.treeView1.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-cd-filled-50 - 복사본.png");
            this.imageList1.Images.SetKeyName(1, "icons8-opened-folder-50 - 복사본.png");
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 231);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 21);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "노드추가";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(191, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "노드삭제";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}