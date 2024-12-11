namespace Focuser
{
    partial class FocuserStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FocuserStart));
            listProc = new ListBox();
            btnRefresh = new Button();
            btnSelect = new Button();
            when = new DateTimePicker();
            whenLabel = new Label();
            SuspendLayout();
            // 
            // listProc
            // 
            listProc.FormattingEnabled = true;
            listProc.Location = new Point(14, 14);
            listProc.Margin = new Padding(3, 5, 3, 5);
            listProc.Name = "listProc";
            listProc.Size = new Size(498, 365);
            listProc.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(14, 420);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(335, 60);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "새로고침";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(355, 420);
            btnSelect.Margin = new Padding(3, 4, 3, 4);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(157, 60);
            btnSelect.TabIndex = 2;
            btnSelect.Text = "드가자";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // when
            // 
            when.CustomFormat = "";
            when.Location = new Point(76, 387);
            when.Name = "when";
            when.Size = new Size(436, 26);
            when.TabIndex = 3;
            // 
            // whenLabel
            // 
            whenLabel.AutoSize = true;
            whenLabel.Location = new Point(18, 391);
            whenLabel.Name = "whenLabel";
            whenLabel.Size = new Size(51, 19);
            whenLabel.TabIndex = 4;
            whenLabel.Text = "마감일";
            // 
            // FocuserStart
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 494);
            ControlBox = false;
            Controls.Add(whenLabel);
            Controls.Add(when);
            Controls.Add(btnSelect);
            Controls.Add(btnRefresh);
            Controls.Add(listProc);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 5, 3, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FocuserStart";
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

        #endregion

        private System.Windows.Forms.ListBox listProc;
        private Button btnRefresh;
        private Button btnSelect;
        private DateTimePicker when;
        private Label whenLabel;
    }
}