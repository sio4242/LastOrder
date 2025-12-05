namespace Main
{
    partial class Form3
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
            this.listViewSales = new System.Windows.Forms.ListView();
            this.listViewDetail = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.상품관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.매출관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.입고출고ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.매출통계ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.이벤트ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.점원ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.관리자문의ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewSales
            // 
            this.listViewSales.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader7});
            this.listViewSales.FullRowSelect = true;
            this.listViewSales.HideSelection = false;
            this.listViewSales.Location = new System.Drawing.Point(12, 81);
            this.listViewSales.Name = "listViewSales";
            this.listViewSales.Size = new System.Drawing.Size(439, 286);
            this.listViewSales.TabIndex = 0;
            this.listViewSales.UseCompatibleStateImageBehavior = false;
            this.listViewSales.View = System.Windows.Forms.View.Details;
            this.listViewSales.SelectedIndexChanged += new System.EventHandler(this.listViewSales_SelectedIndexChanged);
            // 
            // listViewDetail
            // 
            this.listViewDetail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewDetail.FullRowSelect = true;
            this.listViewDetail.HideSelection = false;
            this.listViewDetail.Location = new System.Drawing.Point(478, 81);
            this.listViewDetail.Name = "listViewDetail";
            this.listViewDetail.Size = new System.Drawing.Size(439, 286);
            this.listViewDetail.TabIndex = 1;
            this.listViewDetail.UseCompatibleStateImageBehavior = false;
            this.listViewDetail.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(8, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "환불";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "매출번호";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "날짜";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "총금액";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "상품명";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "수량";
            this.columnHeader5.Width = 70;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "금액";
            this.columnHeader6.Width = 100;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(804, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "환불";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "환불 여부";
            this.columnHeader7.Width = 80;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.상품관리ToolStripMenuItem,
            this.매출관리ToolStripMenuItem,
            this.이벤트ToolStripMenuItem,
            this.점원ToolStripMenuItem,
            this.관리자문의ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(929, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 상품관리ToolStripMenuItem
            // 
            this.상품관리ToolStripMenuItem.Name = "상품관리ToolStripMenuItem";
            this.상품관리ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.상품관리ToolStripMenuItem.Text = "상품관리";
            // 
            // 매출관리ToolStripMenuItem
            // 
            this.매출관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.입고출고ToolStripMenuItem,
            this.매출통계ToolStripMenuItem});
            this.매출관리ToolStripMenuItem.Name = "매출관리ToolStripMenuItem";
            this.매출관리ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.매출관리ToolStripMenuItem.Text = "매출관리";
            // 
            // 입고출고ToolStripMenuItem
            // 
            this.입고출고ToolStripMenuItem.Name = "입고출고ToolStripMenuItem";
            this.입고출고ToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.입고출고ToolStripMenuItem.Text = "입고/출고";
            // 
            // 매출통계ToolStripMenuItem
            // 
            this.매출통계ToolStripMenuItem.Name = "매출통계ToolStripMenuItem";
            this.매출통계ToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.매출통계ToolStripMenuItem.Text = "매출 통계";
            // 
            // 이벤트ToolStripMenuItem
            // 
            this.이벤트ToolStripMenuItem.Name = "이벤트ToolStripMenuItem";
            this.이벤트ToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.이벤트ToolStripMenuItem.Text = "이벤트";
            // 
            // 점원ToolStripMenuItem
            // 
            this.점원ToolStripMenuItem.Name = "점원ToolStripMenuItem";
            this.점원ToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.점원ToolStripMenuItem.Text = "점원 관리";
            // 
            // 관리자문의ToolStripMenuItem
            // 
            this.관리자문의ToolStripMenuItem.Name = "관리자문의ToolStripMenuItem";
            this.관리자문의ToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.관리자문의ToolStripMenuItem.Text = "관리자 문의";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(929, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewDetail);
            this.Controls.Add(this.listViewSales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewSales;
        private System.Windows.Forms.ListView listViewDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 상품관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 매출관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 입고출고ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 매출통계ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 이벤트ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 점원ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 관리자문의ToolStripMenuItem;
    }
}