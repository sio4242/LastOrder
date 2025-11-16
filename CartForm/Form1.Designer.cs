namespace CartForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.홈ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.인기메뉴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.랭킹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.할인ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.장바구니ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.카테고리 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.상품명 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.가격 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.개수 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.menuStrip1.Size = new System.Drawing.Size(722, 28);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "장바구니";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(541, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 33);
            this.button1.TabIndex = 23;
            this.button1.Text = "주문하기";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.카테고리,
            this.상품명,
            this.가격,
            this.개수});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(16, 87);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(686, 269);
            this.listView1.TabIndex = 24;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // 카테고리
            // 
            this.카테고리.Text = "카테고리";
            this.카테고리.Width = 99;
            // 
            // 상품명
            // 
            this.상품명.Text = "상품명";
            this.상품명.Width = 132;
            // 
            // 가격
            // 
            this.가격.Text = "가격";
            this.가격.Width = 87;
            // 
            // 개수
            // 
            this.개수.Text = "담은 개수";
            this.개수.Width = 119;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 422);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "CartForm";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader 카테고리;
        private System.Windows.Forms.ColumnHeader 상품명;
        private System.Windows.Forms.ColumnHeader 가격;
        private System.Windows.Forms.ColumnHeader 개수;
    }
}

