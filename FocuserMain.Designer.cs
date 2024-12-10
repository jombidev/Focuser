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
            listProc = new ListBox();
            timer1 = new System.Windows.Forms.Timer(components);
            btnRefresh = new Button();
            btnSelect = new Button();
            SuspendLayout();
            // 
            // listProc
            // 
            listProc.FormattingEnabled = true;
            listProc.Location = new Point(12, 15);
            listProc.Margin = new Padding(3, 4, 3, 4);
            listProc.Name = "listProc";
            listProc.Size = new Size(436, 319);
            listProc.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(12, 341);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(293, 47);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "새로고침";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(311, 341);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(137, 47);
            btnSelect.TabIndex = 2;
            btnSelect.Text = "선택";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // FocuserMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 400);
            ControlBox = false;
            Controls.Add(btnSelect);
            Controls.Add(btnRefresh);
            Controls.Add(listProc);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
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
        }

        private System.Windows.Forms.Timer timer1;

        #endregion

        private System.Windows.Forms.ListBox listProc;
        private Button btnRefresh;
        private Button btnSelect;
    }
}