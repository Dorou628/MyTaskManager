/*namespace MyTaskManager
{
    partial class Speech
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            StartSpeech = new Guna.UI2.WinForms.Guna2Button();
            txtSpeechContent = new Guna.UI2.WinForms.Guna2TextBox();
            SuspendLayout();
            // 
            // StartSpeech
            // 
            StartSpeech.BorderRadius = 10;
            StartSpeech.CustomizableEdges = customizableEdges1;
            StartSpeech.DisabledState.BorderColor = Color.DarkGray;
            StartSpeech.DisabledState.CustomBorderColor = Color.DarkGray;
            StartSpeech.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            StartSpeech.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            StartSpeech.Font = new Font("Segoe UI", 9F);
            StartSpeech.ForeColor = Color.White;
            StartSpeech.Location = new Point(209, 386);
            StartSpeech.Margin = new Padding(4, 4, 4, 4);
            StartSpeech.Name = "StartSpeech";
            StartSpeech.ShadowDecoration.CustomizableEdges = customizableEdges2;
            StartSpeech.Size = new Size(275, 67);
            StartSpeech.TabIndex = 0;
            StartSpeech.Text = "开始/结束";
            StartSpeech.Click += StartSpeech_Click;
            // 
            // txtSpeechContent
            // 
            txtSpeechContent.CustomizableEdges = customizableEdges3;
            txtSpeechContent.DefaultText = "";
            txtSpeechContent.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSpeechContent.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSpeechContent.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSpeechContent.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSpeechContent.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSpeechContent.Font = new Font("Segoe UI", 9F);
            txtSpeechContent.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSpeechContent.Location = new Point(15, 16);
            txtSpeechContent.Margin = new Padding(4, 5, 4, 5);
            txtSpeechContent.Multiline = true;
            txtSpeechContent.Name = "txtSpeechContent";
            txtSpeechContent.PlaceholderText = "";
            txtSpeechContent.ReadOnly = true;
            txtSpeechContent.ScrollBars = ScrollBars.Vertical;
            txtSpeechContent.SelectedText = "";
            txtSpeechContent.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtSpeechContent.Size = new Size(669, 325);
            txtSpeechContent.TabIndex = 1;
            txtSpeechContent.TextChanged += txtSpeechContent_TextChanged;
            // 
            // Speech
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 468);
            Controls.Add(txtSpeechContent);
            Controls.Add(StartSpeech);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Speech";
            Text = "Speech";
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button StartSpeech;
        private Guna.UI2.WinForms.Guna2TextBox txtSpeechContent;
    }
}*/
namespace MyTaskManager
{
    partial class Speech
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Speech));
            StartSpeech = new Guna.UI2.WinForms.Guna2Button();
            txtSpeechContent = new Guna.UI2.WinForms.Guna2TextBox();
            txtDeepSeekResult = new Guna.UI2.WinForms.Guna2TextBox();
            txtConditions = new Guna.UI2.WinForms.Guna2TextBox();
            btnSendToDeepSeek = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // StartSpeech
            // 
            StartSpeech.BorderRadius = 10;
            StartSpeech.CustomizableEdges = customizableEdges8;
            StartSpeech.DisabledState.BorderColor = Color.DarkGray;
            StartSpeech.DisabledState.CustomBorderColor = Color.DarkGray;
            StartSpeech.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            StartSpeech.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            StartSpeech.Font = new Font("Segoe UI", 9F);
            StartSpeech.ForeColor = Color.White;
            StartSpeech.Location = new Point(209, 386);
            StartSpeech.Margin = new Padding(4);
            StartSpeech.Name = "StartSpeech";
            StartSpeech.ShadowDecoration.CustomizableEdges = customizableEdges9;
            StartSpeech.Size = new Size(275, 67);
            StartSpeech.TabIndex = 0;
            StartSpeech.Text = "开始/结束";
            StartSpeech.Click += StartSpeech_Click;
            // 
            // txtSpeechContent
            // 
            txtSpeechContent.CustomizableEdges = customizableEdges10;
            txtSpeechContent.DefaultText = "";
            txtSpeechContent.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSpeechContent.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSpeechContent.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSpeechContent.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSpeechContent.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSpeechContent.Font = new Font("Segoe UI", 9F);
            txtSpeechContent.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSpeechContent.Location = new Point(15, 16);
            txtSpeechContent.Margin = new Padding(4, 5, 4, 5);
            txtSpeechContent.Multiline = true;
            txtSpeechContent.Name = "txtSpeechContent";
            txtSpeechContent.PlaceholderText = "";
            txtSpeechContent.ReadOnly = true;
            txtSpeechContent.ScrollBars = ScrollBars.Vertical;
            txtSpeechContent.SelectedText = "";
            txtSpeechContent.ShadowDecoration.CustomizableEdges = customizableEdges11;
            txtSpeechContent.Size = new Size(669, 200);
            txtSpeechContent.TabIndex = 1;
            txtSpeechContent.TextChanged += txtSpeechContent_TextChanged;
            // 
            // txtDeepSeekResult
            // 
            txtDeepSeekResult.CustomizableEdges = customizableEdges12;
            txtDeepSeekResult.DefaultText = "";
            txtDeepSeekResult.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtDeepSeekResult.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtDeepSeekResult.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtDeepSeekResult.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtDeepSeekResult.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDeepSeekResult.Font = new Font("Segoe UI", 9F);
            txtDeepSeekResult.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDeepSeekResult.Location = new Point(15, 226);
            txtDeepSeekResult.Margin = new Padding(4, 5, 4, 5);
            txtDeepSeekResult.Multiline = true;
            txtDeepSeekResult.Name = "txtDeepSeekResult";
            txtDeepSeekResult.PlaceholderText = "";
            txtDeepSeekResult.ReadOnly = true;
            txtDeepSeekResult.ScrollBars = ScrollBars.Vertical;
            txtDeepSeekResult.SelectedText = "";
            txtDeepSeekResult.ShadowDecoration.CustomizableEdges = customizableEdges13;
            txtDeepSeekResult.Size = new Size(669, 100);
            txtDeepSeekResult.TabIndex = 2;
            // 
            // txtConditions
            // 
            txtConditions.CustomizableEdges = customizableEdges14;
            txtConditions.DefaultText = resources.GetString("txtConditions.DefaultText");
            txtConditions.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtConditions.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtConditions.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtConditions.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtConditions.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtConditions.Font = new Font("Segoe UI", 9F);
            txtConditions.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtConditions.Location = new Point(15, 336);
            txtConditions.Margin = new Padding(4, 5, 4, 5);
            txtConditions.Name = "txtConditions";
            txtConditions.PlaceholderText = "输入 DeepSeek 处理条件";
            txtConditions.SelectedText = "";
            txtConditions.ShadowDecoration.CustomizableEdges = customizableEdges14;
            txtConditions.Size = new Size(669, 40);
            txtConditions.TabIndex = 3;
            txtConditions.TextChanged += txtConditions_TextChanged;
            // 
            // btnSendToDeepSeek
            // 
            btnSendToDeepSeek.BorderRadius = 10;
            btnSendToDeepSeek.CustomizableEdges = customizableEdges14;
            btnSendToDeepSeek.DisabledState.BorderColor = Color.DarkGray;
            btnSendToDeepSeek.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSendToDeepSeek.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSendToDeepSeek.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSendToDeepSeek.Font = new Font("Segoe UI", 9F);
            btnSendToDeepSeek.ForeColor = Color.White;
            btnSendToDeepSeek.Location = new Point(494, 386);
            btnSendToDeepSeek.Margin = new Padding(4);
            btnSendToDeepSeek.Name = "btnSendToDeepSeek";
            btnSendToDeepSeek.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnSendToDeepSeek.Size = new Size(190, 67);
            btnSendToDeepSeek.TabIndex = 4;
            btnSendToDeepSeek.Text = "创建任务";
            btnSendToDeepSeek.Click += btnSendToDeepSeek_Click;
            // 
            // Speech
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 468);
            Controls.Add(btnSendToDeepSeek);
            Controls.Add(txtConditions);
            Controls.Add(txtDeepSeekResult);
            Controls.Add(txtSpeechContent);
            Controls.Add(StartSpeech);
            Margin = new Padding(4);
            Name = "Speech";
            Text = "Speech";
            ResumeLayout(false);
        }

        private Guna.UI2.WinForms.Guna2Button StartSpeech;
        private Guna.UI2.WinForms.Guna2TextBox txtSpeechContent;
        private Guna.UI2.WinForms.Guna2TextBox txtDeepSeekResult;
        private Guna.UI2.WinForms.Guna2TextBox txtConditions;
        private Guna.UI2.WinForms.Guna2Button btnSendToDeepSeek;
    }
}