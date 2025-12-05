namespace Main
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnEtc = new System.Windows.Forms.Button();
            this.btnCold = new System.Windows.Forms.Button();
            this.btnSnack = new System.Windows.Forms.Button();
            this.btnDrink = new System.Windows.Forms.Button();
            this.listViewProduct = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewCart = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddCart = new System.Windows.Forms.Button();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.상품관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.매출관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.입고출고ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.이벤트ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.매출통계ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.점원ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.관리자문의ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAll);
            this.groupBox1.Controls.Add(this.btnEtc);
            this.groupBox1.Controls.Add(this.btnCold);
            this.groupBox1.Controls.Add(this.btnSnack);
            this.groupBox1.Controls.Add(this.btnDrink);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(992, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "카테고리";
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.Thistle;
            this.btnAll.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAll.Location = new System.Drawing.Point(610, 22);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(113, 56);
            this.btnAll.TabIndex = 5;
            this.btnAll.Text = "전체";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnEtc
            // 
            this.btnEtc.BackColor = System.Drawing.Color.Thistle;
            this.btnEtc.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEtc.Location = new System.Drawing.Point(464, 22);
            this.btnEtc.Name = "btnEtc";
            this.btnEtc.Size = new System.Drawing.Size(113, 56);
            this.btnEtc.TabIndex = 4;
            this.btnEtc.Text = "기타";
            this.btnEtc.UseVisualStyleBackColor = false;
            this.btnEtc.Click += new System.EventHandler(this.btnEtc_Click);
            // 
            // btnCold
            // 
            this.btnCold.BackColor = System.Drawing.Color.Thistle;
            this.btnCold.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCold.Location = new System.Drawing.Point(320, 22);
            this.btnCold.Name = "btnCold";
            this.btnCold.Size = new System.Drawing.Size(113, 56);
            this.btnCold.TabIndex = 3;
            this.btnCold.Text = "냉장";
            this.btnCold.UseVisualStyleBackColor = false;
            this.btnCold.Click += new System.EventHandler(this.btnCold_Click);
            // 
            // btnSnack
            // 
            this.btnSnack.BackColor = System.Drawing.Color.Thistle;
            this.btnSnack.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSnack.Location = new System.Drawing.Point(169, 24);
            this.btnSnack.Name = "btnSnack";
            this.btnSnack.Size = new System.Drawing.Size(113, 56);
            this.btnSnack.TabIndex = 2;
            this.btnSnack.Text = "과자";
            this.btnSnack.UseVisualStyleBackColor = false;
            this.btnSnack.Click += new System.EventHandler(this.btnSnack_Click);
            // 
            // btnDrink
            // 
            this.btnDrink.BackColor = System.Drawing.Color.Thistle;
            this.btnDrink.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDrink.Location = new System.Drawing.Point(17, 24);
            this.btnDrink.Name = "btnDrink";
            this.btnDrink.Size = new System.Drawing.Size(113, 56);
            this.btnDrink.TabIndex = 1;
            this.btnDrink.Text = "음료";
            this.btnDrink.UseVisualStyleBackColor = false;
            this.btnDrink.Click += new System.EventHandler(this.btnDrink_Click);
            // 
            // listViewProduct
            // 
            this.listViewProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewProduct.HideSelection = false;
            this.listViewProduct.Location = new System.Drawing.Point(12, 177);
            this.listViewProduct.Name = "listViewProduct";
            this.listViewProduct.Size = new System.Drawing.Size(481, 216);
            this.listViewProduct.TabIndex = 1;
            this.listViewProduct.UseCompatibleStateImageBehavior = false;
            this.listViewProduct.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "상품명";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "가격";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "재고";
            // 
            // listViewCart
            // 
            this.listViewCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewCart.HideSelection = false;
            this.listViewCart.Location = new System.Drawing.Point(524, 146);
            this.listViewCart.Name = "listViewCart";
            this.listViewCart.Size = new System.Drawing.Size(480, 275);
            this.listViewCart.TabIndex = 2;
            this.listViewCart.UseCompatibleStateImageBehavior = false;
            this.listViewCart.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "상품명";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "수량";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "금액";
            // 
            // btnAddCart
            // 
            this.btnAddCart.BackColor = System.Drawing.Color.Thistle;
            this.btnAddCart.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAddCart.Location = new System.Drawing.Point(12, 412);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(157, 30);
            this.btnAddCart.TabIndex = 3;
            this.btnAddCart.Text = "담기";
            this.btnAddCart.UseVisualStyleBackColor = false;
            this.btnAddCart.Click += new System.EventHandler(this.btnAddCart_Click);
            // 
            // numQty
            // 
            this.numQty.Location = new System.Drawing.Point(332, 412);
            this.numQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(157, 25);
            this.numQty.TabIndex = 4;
            this.numQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTotal.Location = new System.Drawing.Point(520, 449);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(137, 20);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "총 금액 : 0원";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Thistle;
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPay.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPay.Location = new System.Drawing.Point(891, 439);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(113, 41);
            this.btnPay.TabIndex = 6;
            this.btnPay.Text = "결제하기";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(1027, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 상품관리ToolStripMenuItem
            // 
            this.상품관리ToolStripMenuItem.Name = "상품관리ToolStripMenuItem";
            this.상품관리ToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            this.상품관리ToolStripMenuItem.Text = "상품관리";
            this.상품관리ToolStripMenuItem.Click += new System.EventHandler(this.상품조회ToolStripMenuItem_Click);
            // 
            // 매출관리ToolStripMenuItem
            // 
            this.매출관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.입고출고ToolStripMenuItem,
            this.매출통계ToolStripMenuItem});
            this.매출관리ToolStripMenuItem.Name = "매출관리ToolStripMenuItem";
            this.매출관리ToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            this.매출관리ToolStripMenuItem.Text = "매출관리";
            this.매출관리ToolStripMenuItem.Click += new System.EventHandler(this.매출조회ToolStripMenuItem_Click);
            // 
            // 입고출고ToolStripMenuItem
            // 
            this.입고출고ToolStripMenuItem.Name = "입고출고ToolStripMenuItem";
            this.입고출고ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.입고출고ToolStripMenuItem.Text = "입고/출고";
            this.입고출고ToolStripMenuItem.Click += new System.EventHandler(this.입고출고ToolStripMenuItem_Click);
            // 
            // 이벤트ToolStripMenuItem
            // 
            this.이벤트ToolStripMenuItem.Name = "이벤트ToolStripMenuItem";
            this.이벤트ToolStripMenuItem.Size = new System.Drawing.Size(68, 26);
            this.이벤트ToolStripMenuItem.Text = "이벤트";
            this.이벤트ToolStripMenuItem.Click += new System.EventHandler(this.이벤트ToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(891, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "환불";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // 매출통계ToolStripMenuItem
            // 
            this.매출통계ToolStripMenuItem.Name = "매출통계ToolStripMenuItem";
            this.매출통계ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.매출통계ToolStripMenuItem.Text = "매출 통계";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(392, 25);
            this.textBox1.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(418, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "검색";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1027, 533);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.numQty);
            this.Controls.Add(this.btnAddCart);
            this.Controls.Add(this.listViewCart);
            this.Controls.Add(this.listViewProduct);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "POS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCold;
        private System.Windows.Forms.Button btnSnack;
        private System.Windows.Forms.Button btnDrink;
        private System.Windows.Forms.Button btnEtc;
        private System.Windows.Forms.ListView listViewProduct;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView listViewCart;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnAddCart;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 상품관리ToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem 매출관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 입고출고ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 이벤트ToolStripMenuItem;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.ToolStripMenuItem 매출통계ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 점원ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 관리자문의ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}

