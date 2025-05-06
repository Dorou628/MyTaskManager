namespace MyTaskManager
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            StartSpeech = new Guna.UI2.WinForms.Guna2Button();
            txtSpeechContent = new Guna.UI2.WinForms.Guna2TextBox();
            SuspendLayout();
            // 
            // StartSpeech
            // 
            StartSpeech.BorderRadius = 10;
            StartSpeech.CustomizableEdges = customizableEdges5;
            StartSpeech.DisabledState.BorderColor = Color.DarkGray;
            StartSpeech.DisabledState.CustomBorderColor = Color.DarkGray;
            StartSpeech.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            StartSpeech.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            StartSpeech.Font = new Font("Segoe UI", 9F);
            StartSpeech.ForeColor = Color.White;
            StartSpeech.Location = new Point(171, 322);
            StartSpeech.Name = "StartSpeech";
            StartSpeech.ShadowDecoration.CustomizableEdges = customizableEdges6;
            StartSpeech.Size = new Size(225, 56);
            StartSpeech.TabIndex = 0;
            StartSpeech.Text = "开始/结束";
            StartSpeech.Click += StartSpeech_Click;
            // 
            // txtSpeechContent
            // 
            txtSpeechContent.CustomizableEdges = customizableEdges7;
            txtSpeechContent.DefaultText = "";
            txtSpeechContent.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSpeechContent.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSpeechContent.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSpeechContent.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSpeechContent.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSpeechContent.Font = new Font("Segoe UI", 9F);
            txtSpeechContent.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSpeechContent.Location = new Point(12, 13);
            txtSpeechContent.Margin = new Padding(3, 4, 3, 4);
            txtSpeechContent.Multiline = true;
            txtSpeechContent.Name = "txtSpeechContent";
            txtSpeechContent.PlaceholderText = "";
            txtSpeechContent.ReadOnly = true;
            txtSpeechContent.ScrollBars = ScrollBars.Vertical;
            txtSpeechContent.SelectedText = "";
            txtSpeechContent.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtSpeechContent.Size = new Size(547, 271);
            txtSpeechContent.TabIndex = 1;
            // 
            // Speech
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 390);
            Controls.Add(txtSpeechContent);
            Controls.Add(StartSpeech);
            Name = "Speech";
            Text = "Speech";
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button StartSpeech;
        private Guna.UI2.WinForms.Guna2TextBox txtSpeechContent;
    }
}