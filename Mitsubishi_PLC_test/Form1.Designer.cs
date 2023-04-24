namespace Mitsubishi_PLC_test
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
            this.components = new System.ComponentModel.Container();
            this.btnCon = new System.Windows.Forms.Button();
            this.btnDiscon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOn = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.Button();
            this.lamp1 = new System.Windows.Forms.Button();
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.tbData1 = new System.Windows.Forms.TextBox();
            this.tbData2 = new System.Windows.Forms.TextBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCon
            // 
            this.btnCon.Location = new System.Drawing.Point(61, 69);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(147, 40);
            this.btnCon.TabIndex = 0;
            this.btnCon.Text = "Connect";
            this.btnCon.UseVisualStyleBackColor = true;
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // btnDiscon
            // 
            this.btnDiscon.Location = new System.Drawing.Point(248, 69);
            this.btnDiscon.Name = "btnDiscon";
            this.btnDiscon.Size = new System.Drawing.Size(147, 40);
            this.btnDiscon.TabIndex = 1;
            this.btnDiscon.Text = "Disconnect";
            this.btnDiscon.UseVisualStyleBackColor = true;
            this.btnDiscon.Click += new System.EventHandler(this.btnDiscon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "연결상태:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(135, 130);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(17, 12);
            this.lblState.TabIndex = 3;
            this.lblState.Text = "...";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(46, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 117);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PLC1";
            // 
            // btnOn
            // 
            this.btnOn.Location = new System.Drawing.Point(46, 217);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(71, 40);
            this.btnOn.TabIndex = 5;
            this.btnOn.Text = "ON";
            this.btnOn.UseVisualStyleBackColor = true;
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // btnOff
            // 
            this.btnOff.Location = new System.Drawing.Point(137, 217);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(71, 40);
            this.btnOff.TabIndex = 6;
            this.btnOff.Text = "OFF";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // lamp1
            // 
            this.lamp1.BackColor = System.Drawing.Color.LightGray;
            this.lamp1.Location = new System.Drawing.Point(269, 217);
            this.lamp1.Name = "lamp1";
            this.lamp1.Size = new System.Drawing.Size(71, 40);
            this.lamp1.TabIndex = 7;
            this.lamp1.Text = "Y20";
            this.lamp1.UseVisualStyleBackColor = false;
            this.lamp1.Click += new System.EventHandler(this.lamp1_Click);
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // tbData1
            // 
            this.tbData1.Location = new System.Drawing.Point(124, 291);
            this.tbData1.Name = "tbData1";
            this.tbData1.Size = new System.Drawing.Size(100, 21);
            this.tbData1.TabIndex = 8;
            this.tbData1.Text = "0";
            this.tbData1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbData1.TextChanged += new System.EventHandler(this.tbData1_TextChanged);
            // 
            // tbData2
            // 
            this.tbData2.Location = new System.Drawing.Point(124, 341);
            this.tbData2.Name = "tbData2";
            this.tbData2.Size = new System.Drawing.Size(100, 21);
            this.tbData2.TabIndex = 9;
            this.tbData2.Text = "0";
            this.tbData2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbData2.TextChanged += new System.EventHandler(this.tbData2_TextChanged);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(248, 339);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 10;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "D0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "D10";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.tbData2);
            this.Controls.Add(this.tbData1);
            this.Controls.Add(this.lamp1);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.btnOn);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDiscon);
            this.Controls.Add(this.btnCon);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.Button btnDiscon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOn;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Button lamp1;
        private System.Windows.Forms.Timer tmrUpdate;
        private System.Windows.Forms.TextBox tbData1;
        private System.Windows.Forms.TextBox tbData2;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

