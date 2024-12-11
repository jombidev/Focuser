namespace Focuser
{
    partial class FocuserMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FocuserMain));
            timer1 = new System.Windows.Forms.Timer(components);
            ____ = new Label();
            proc = new Label();
            _____ = new Label();
            activeProc = new Label();
            __ = new Label();
            timeRemaining = new Label();
            dateTimeTimer = new System.Windows.Forms.Timer(components);
            _ = new Label();
            enableAlert = new CheckBox();
            endTimeBox = new TextBox();
            label1 = new Label();
            memoTextBox = new TextBox();
            saveBtn = new Button();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // ____
            // 
            ____.AutoSize = true;
            ____.Location = new Point(12, 24);
            ____.Name = "____";
            ____.Size = new Size(65, 19);
            ____.TabIndex = 0;
            ____.Text = "프로세스";
            // 
            // proc
            // 
            proc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            proc.Location = new Point(83, 24);
            proc.Name = "proc";
            proc.Size = new Size(183, 19);
            proc.TabIndex = 1;
            proc.Text = "label1";
            proc.TextAlign = ContentAlignment.TopRight;
            // 
            // _____
            // 
            _____.AutoSize = true;
            _____.Location = new Point(12, 43);
            _____.Name = "_____";
            _____.Size = new Size(98, 19);
            _____.TabIndex = 2;
            _____.Text = "현재 프로세스";
            // 
            // activeProc
            // 
            activeProc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            activeProc.Location = new Point(116, 43);
            activeProc.Name = "activeProc";
            activeProc.Size = new Size(150, 19);
            activeProc.TabIndex = 3;
            activeProc.Text = "label1";
            activeProc.TextAlign = ContentAlignment.TopRight;
            // 
            // __
            // 
            __.AutoSize = true;
            __.Location = new Point(12, 62);
            __.Name = "__";
            __.Size = new Size(65, 19);
            __.TabIndex = 4;
            __.Text = "남은시간";
            // 
            // timeRemaining
            // 
            timeRemaining.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            timeRemaining.Location = new Point(83, 62);
            timeRemaining.Name = "timeRemaining";
            timeRemaining.Size = new Size(183, 19);
            timeRemaining.TabIndex = 5;
            timeRemaining.Text = "label1";
            timeRemaining.TextAlign = ContentAlignment.TopRight;
            // 
            // dateTimeTimer
            // 
            dateTimeTimer.Enabled = true;
            dateTimeTimer.Tick += dateTimeTimer_Tick;
            // 
            // _
            // 
            _.AutoSize = true;
            _.Location = new Point(12, 81);
            _.Name = "_";
            _.Size = new Size(0, 19);
            _.TabIndex = 6;
            // 
            // enableAlert
            // 
            enableAlert.AutoSize = true;
            enableAlert.Location = new Point(12, 84);
            enableAlert.Name = "enableAlert";
            enableAlert.Size = new Size(130, 23);
            enableAlert.TabIndex = 7;
            enableAlert.Text = "마감 n분전 알림";
            enableAlert.UseVisualStyleBackColor = true;
            // 
            // endTimeBox
            // 
            endTimeBox.Location = new Point(171, 85);
            endTimeBox.Name = "endTimeBox";
            endTimeBox.Size = new Size(69, 26);
            endTimeBox.TabIndex = 8;
            endTimeBox.TextChanged += endTimeBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(243, 88);
            label1.Name = "label1";
            label1.Size = new Size(23, 19);
            label1.TabIndex = 9;
            label1.Text = "분";
            // 
            // memoTextBox
            // 
            memoTextBox.Location = new Point(10, 128);
            memoTextBox.Multiline = true;
            memoTextBox.Name = "memoTextBox";
            memoTextBox.Size = new Size(256, 198);
            memoTextBox.TabIndex = 10;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(12, 332);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(254, 28);
            saveBtn.TabIndex = 11;
            saveBtn.Text = "저장";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // FocuserMain
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 584);
            ControlBox = false;
            Controls.Add(saveBtn);
            Controls.Add(memoTextBox);
            Controls.Add(label1);
            Controls.Add(endTimeBox);
            Controls.Add(enableAlert);
            Controls.Add(_);
            Controls.Add(timeRemaining);
            Controls.Add(__);
            Controls.Add(activeProc);
            Controls.Add(_____);
            Controls.Add(proc);
            Controls.Add(____);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 5, 3, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FocuserMain";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Focuser";
            TopMost = true;
            FormClosing += FocuserMain_FormClosing;
            Load += FocuserMain_Load;
            MouseDown += FocuserMain_MouseDown;
            MouseMove += FocuserMain_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Timer timer1;

        #endregion

        private Label ____;
        private Label proc;
        private Label _____;
        private Label activeProc;
        private Label __;
        private Label timeRemaining;
        private System.Windows.Forms.Timer dateTimeTimer;
        private Label _;
        private CheckBox enableAlert;
        private TextBox endTimeBox;
        private Label label1;
        private TextBox memoTextBox;
        private Button saveBtn;
    }
}