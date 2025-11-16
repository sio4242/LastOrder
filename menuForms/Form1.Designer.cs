namespace menuForms
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "코카콜라",
            "2,200원",
            "25개"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "칠성사이다",
            "1,800원",
            "20개"}, -1);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.홈ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.인기메뉴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.랭킹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.할인ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.장바구니ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.상품명 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.가격 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.재고 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.홈ToolStripMenuItem,
            this.인기메뉴ToolStripMenuItem,
            this.랭킹ToolStripMenuItem,
            this.할인ToolStripMenuItem,
            this.장바구니ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(751, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 홈ToolStripMenuItem
            // 
            this.홈ToolStripMenuItem.Name = "홈ToolStripMenuItem";
            this.홈ToolStripMenuItem.Size = new System.Drawing.Size(38, 24);
            this.홈ToolStripMenuItem.Text = "홈";
            // 
            // 인기메뉴ToolStripMenuItem
            // 
            this.인기메뉴ToolStripMenuItem.Name = "인기메뉴ToolStripMenuItem";
            this.인기메뉴ToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.인기메뉴ToolStripMenuItem.Text = "인기　메뉴";
            // 
            // 랭킹ToolStripMenuItem
            // 
            this.랭킹ToolStripMenuItem.Name = "랭킹ToolStripMenuItem";
            this.랭킹ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.랭킹ToolStripMenuItem.Text = "랭킹";
            // 
            // 할인ToolStripMenuItem
            // 
            this.할인ToolStripMenuItem.Name = "할인ToolStripMenuItem";
            this.할인ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.할인ToolStripMenuItem.Text = "할인";
            // 
            // 장바구니ToolStripMenuItem
            // 
            this.장바구니ToolStripMenuItem.Name = "장바구니ToolStripMenuItem";
            this.장바구니ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.장바구니ToolStripMenuItem.Text = "장바구니";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(12, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "카테고리>음료";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.상품명,
            this.가격,
            this.재고});
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listView1.Location = new System.Drawing.Point(15, 77);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(724, 322);
            this.listView1.TabIndex = 22;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // 상품명
            // 
            this.상품명.Text = "상품명";
            this.상품명.Width = 203;
            // 
            // 가격
            // 
            this.가격.Text = "가격";
            this.가격.Width = 83;
            // 
            // 재고
            // 
            this.재고.Text = "재고";
            this.재고.Width = 92;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 411);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "CategoryForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 홈ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 인기메뉴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 랭킹ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 할인ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 장바구니ToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader 상품명;
        private System.Windows.Forms.ColumnHeader 가격;
        private System.Windows.Forms.ColumnHeader 재고;
    }
}

