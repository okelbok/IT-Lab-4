namespace Lab4_IT
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;

		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.TabControl MainTabControl;
			System.Windows.Forms.Panel TextPanel;
			System.Windows.Forms.Label EDSLabel;
			System.Windows.Forms.Label HashLabel;
			System.Windows.Forms.Label YLabel;
			System.Windows.Forms.Label ResultTextLabel;
			System.Windows.Forms.Label GLabel;
			System.Windows.Forms.Label InitialTextLabel;
			System.Windows.Forms.Panel RegisterPanel;
			System.Windows.Forms.Label KLabel;
			System.Windows.Forms.Label XLabel;
			System.Windows.Forms.Label HLabel;
			System.Windows.Forms.Label PLabel;
			System.Windows.Forms.Label QLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.MainTabPage = new System.Windows.Forms.TabPage();
			this.EDSTextBox = new System.Windows.Forms.TextBox();
			this.HashTextBox = new System.Windows.Forms.TextBox();
			this.YTextBox = new System.Windows.Forms.TextBox();
			this.ResultTextBox = new System.Windows.Forms.TextBox();
			this.GTextBox = new System.Windows.Forms.TextBox();
			this.InitialTextBox = new System.Windows.Forms.TextBox();
			this.KTextBox = new System.Windows.Forms.TextBox();
			this.XTextBox = new System.Windows.Forms.TextBox();
			this.HTextBox = new System.Windows.Forms.TextBox();
			this.PTextBox = new System.Windows.Forms.TextBox();
			this.QTextBox = new System.Windows.Forms.TextBox();
			this.ClearFieldsButton = new System.Windows.Forms.Button();
			this.EDSActionButton = new System.Windows.Forms.Button();
			this.OutputButton = new System.Windows.Forms.Button();
			this.InputButton = new System.Windows.Forms.Button();
			this.SignRadioButton = new System.Windows.Forms.RadioButton();
			this.VerifySignatureRadioButton = new System.Windows.Forms.RadioButton();
			this.InputDialog = new System.Windows.Forms.OpenFileDialog();
			this.OutputDialog = new System.Windows.Forms.SaveFileDialog();
			MainTabControl = new System.Windows.Forms.TabControl();
			TextPanel = new System.Windows.Forms.Panel();
			EDSLabel = new System.Windows.Forms.Label();
			HashLabel = new System.Windows.Forms.Label();
			YLabel = new System.Windows.Forms.Label();
			ResultTextLabel = new System.Windows.Forms.Label();
			GLabel = new System.Windows.Forms.Label();
			InitialTextLabel = new System.Windows.Forms.Label();
			RegisterPanel = new System.Windows.Forms.Panel();
			KLabel = new System.Windows.Forms.Label();
			XLabel = new System.Windows.Forms.Label();
			HLabel = new System.Windows.Forms.Label();
			PLabel = new System.Windows.Forms.Label();
			QLabel = new System.Windows.Forms.Label();
			MainTabControl.SuspendLayout();
			this.MainTabPage.SuspendLayout();
			TextPanel.SuspendLayout();
			RegisterPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainTabControl
			// 
			MainTabControl.Controls.Add(this.MainTabPage);
			MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			MainTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			MainTabControl.Location = new System.Drawing.Point(0, 0);
			MainTabControl.Margin = new System.Windows.Forms.Padding(5);
			MainTabControl.Name = "MainTabControl";
			MainTabControl.SelectedIndex = 0;
			MainTabControl.Size = new System.Drawing.Size(974, 757);
			MainTabControl.TabIndex = 1;
			MainTabControl.TabStop = false;
			// 
			// MainTabPage
			// 
			this.MainTabPage.Controls.Add(TextPanel);
			this.MainTabPage.Controls.Add(RegisterPanel);
			this.MainTabPage.Location = new System.Drawing.Point(4, 38);
			this.MainTabPage.Margin = new System.Windows.Forms.Padding(5);
			this.MainTabPage.Name = "MainTabPage";
			this.MainTabPage.Padding = new System.Windows.Forms.Padding(5);
			this.MainTabPage.Size = new System.Drawing.Size(966, 715);
			this.MainTabPage.TabIndex = 0;
			this.MainTabPage.Text = "Электронная цифровая подпись на базе алгоритма DSA";
			this.MainTabPage.UseVisualStyleBackColor = true;
			// 
			// TextPanel
			// 
			TextPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			TextPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			TextPanel.Controls.Add(EDSLabel);
			TextPanel.Controls.Add(HashLabel);
			TextPanel.Controls.Add(YLabel);
			TextPanel.Controls.Add(this.EDSTextBox);
			TextPanel.Controls.Add(this.HashTextBox);
			TextPanel.Controls.Add(this.YTextBox);
			TextPanel.Controls.Add(this.ResultTextBox);
			TextPanel.Controls.Add(ResultTextLabel);
			TextPanel.Controls.Add(this.GTextBox);
			TextPanel.Controls.Add(GLabel);
			TextPanel.Controls.Add(this.InitialTextBox);
			TextPanel.Controls.Add(InitialTextLabel);
			TextPanel.Location = new System.Drawing.Point(371, 0);
			TextPanel.Name = "TextPanel";
			TextPanel.Size = new System.Drawing.Size(595, 712);
			TextPanel.TabIndex = 1;
			// 
			// EDSLabel
			// 
			EDSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			EDSLabel.Location = new System.Drawing.Point(17, 402);
			EDSLabel.Name = "EDSLabel";
			EDSLabel.Size = new System.Drawing.Size(84, 34);
			EDSLabel.TabIndex = 20;
			EDSLabel.Text = "ЭЦП:";
			EDSLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// HashLabel
			// 
			HashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			HashLabel.Location = new System.Drawing.Point(17, 349);
			HashLabel.Name = "HashLabel";
			HashLabel.Size = new System.Drawing.Size(84, 34);
			HashLabel.TabIndex = 19;
			HashLabel.Text = "Хэш:";
			HashLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// YLabel
			// 
			YLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			YLabel.Location = new System.Drawing.Point(17, 296);
			YLabel.Name = "YLabel";
			YLabel.Size = new System.Drawing.Size(84, 34);
			YLabel.TabIndex = 18;
			YLabel.Text = "Y:";
			YLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// EDSTextBox
			// 
			this.EDSTextBox.Location = new System.Drawing.Point(107, 402);
			this.EDSTextBox.Name = "EDSTextBox";
			this.EDSTextBox.ReadOnly = true;
			this.EDSTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.EDSTextBox.Size = new System.Drawing.Size(479, 34);
			this.EDSTextBox.TabIndex = 15;
			this.EDSTextBox.TabStop = false;
			// 
			// HashTextBox
			// 
			this.HashTextBox.Location = new System.Drawing.Point(107, 349);
			this.HashTextBox.Name = "HashTextBox";
			this.HashTextBox.ReadOnly = true;
			this.HashTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.HashTextBox.Size = new System.Drawing.Size(479, 34);
			this.HashTextBox.TabIndex = 14;
			this.HashTextBox.TabStop = false;
			// 
			// YTextBox
			// 
			this.YTextBox.Location = new System.Drawing.Point(107, 296);
			this.YTextBox.Name = "YTextBox";
			this.YTextBox.ReadOnly = true;
			this.YTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.YTextBox.Size = new System.Drawing.Size(479, 34);
			this.YTextBox.TabIndex = 13;
			this.YTextBox.TabStop = false;
			// 
			// ResultTextBox
			// 
			this.ResultTextBox.Location = new System.Drawing.Point(16, 490);
			this.ResultTextBox.Multiline = true;
			this.ResultTextBox.Name = "ResultTextBox";
			this.ResultTextBox.ReadOnly = true;
			this.ResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.ResultTextBox.Size = new System.Drawing.Size(569, 210);
			this.ResultTextBox.TabIndex = 16;
			this.ResultTextBox.TabStop = false;
			// 
			// ResultTextLabel
			// 
			ResultTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			ResultTextLabel.Location = new System.Drawing.Point(17, 446);
			ResultTextLabel.Name = "ResultTextLabel";
			ResultTextLabel.Size = new System.Drawing.Size(568, 41);
			ResultTextLabel.TabIndex = 10;
			ResultTextLabel.Text = "Подписанный текст:";
			ResultTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// GTextBox
			// 
			this.GTextBox.Location = new System.Drawing.Point(105, 245);
			this.GTextBox.Name = "GTextBox";
			this.GTextBox.ReadOnly = true;
			this.GTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.GTextBox.Size = new System.Drawing.Size(479, 34);
			this.GTextBox.TabIndex = 12;
			this.GTextBox.TabStop = false;
			// 
			// GLabel
			// 
			GLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			GLabel.Location = new System.Drawing.Point(15, 245);
			GLabel.Name = "GLabel";
			GLabel.Size = new System.Drawing.Size(84, 34);
			GLabel.TabIndex = 8;
			GLabel.Text = "G:";
			GLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// InitialTextBox
			// 
			this.InitialTextBox.Location = new System.Drawing.Point(16, 47);
			this.InitialTextBox.Multiline = true;
			this.InitialTextBox.Name = "InitialTextBox";
			this.InitialTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.InitialTextBox.Size = new System.Drawing.Size(568, 188);
			this.InitialTextBox.TabIndex = 11;
			this.InitialTextBox.TextChanged += new System.EventHandler(this.ParameterTextBox_TextChanged);
			// 
			// InitialTextLabel
			// 
			InitialTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			InitialTextLabel.Location = new System.Drawing.Point(17, 6);
			InitialTextLabel.Name = "InitialTextLabel";
			InitialTextLabel.Size = new System.Drawing.Size(568, 41);
			InitialTextLabel.TabIndex = 7;
			InitialTextLabel.Text = "Исходный текст:";
			InitialTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// RegisterPanel
			// 
			RegisterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			RegisterPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			RegisterPanel.Controls.Add(this.VerifySignatureRadioButton);
			RegisterPanel.Controls.Add(this.SignRadioButton);
			RegisterPanel.Controls.Add(this.KTextBox);
			RegisterPanel.Controls.Add(KLabel);
			RegisterPanel.Controls.Add(XLabel);
			RegisterPanel.Controls.Add(this.XTextBox);
			RegisterPanel.Controls.Add(HLabel);
			RegisterPanel.Controls.Add(this.HTextBox);
			RegisterPanel.Controls.Add(this.PTextBox);
			RegisterPanel.Controls.Add(PLabel);
			RegisterPanel.Controls.Add(QLabel);
			RegisterPanel.Controls.Add(this.QTextBox);
			RegisterPanel.Controls.Add(this.ClearFieldsButton);
			RegisterPanel.Controls.Add(this.EDSActionButton);
			RegisterPanel.Controls.Add(this.OutputButton);
			RegisterPanel.Controls.Add(this.InputButton);
			RegisterPanel.Location = new System.Drawing.Point(0, 0);
			RegisterPanel.Name = "RegisterPanel";
			RegisterPanel.Size = new System.Drawing.Size(360, 707);
			RegisterPanel.TabIndex = 0;
			// 
			// KTextBox
			// 
			this.KTextBox.Location = new System.Drawing.Point(71, 296);
			this.KTextBox.Name = "KTextBox";
			this.KTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.KTextBox.Size = new System.Drawing.Size(279, 34);
			this.KTextBox.TabIndex = 4;
			this.KTextBox.TextChanged += new System.EventHandler(this.ParameterTextBox_TextChanged);
			// 
			// KLabel
			// 
			KLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			KLabel.Location = new System.Drawing.Point(11, 296);
			KLabel.Name = "KLabel";
			KLabel.Size = new System.Drawing.Size(54, 34);
			KLabel.TabIndex = 21;
			KLabel.Text = "K:";
			KLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// XLabel
			// 
			XLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			XLabel.Location = new System.Drawing.Point(11, 227);
			XLabel.Name = "XLabel";
			XLabel.Size = new System.Drawing.Size(54, 34);
			XLabel.TabIndex = 20;
			XLabel.Text = "X:";
			XLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// XTextBox
			// 
			this.XTextBox.Location = new System.Drawing.Point(71, 227);
			this.XTextBox.Name = "XTextBox";
			this.XTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.XTextBox.Size = new System.Drawing.Size(279, 34);
			this.XTextBox.TabIndex = 3;
			this.XTextBox.TextChanged += new System.EventHandler(this.ParameterTextBox_TextChanged);
			// 
			// HLabel
			// 
			HLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			HLabel.Location = new System.Drawing.Point(11, 157);
			HLabel.Name = "HLabel";
			HLabel.Size = new System.Drawing.Size(54, 34);
			HLabel.TabIndex = 18;
			HLabel.Text = "H:";
			HLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// HTextBox
			// 
			this.HTextBox.Location = new System.Drawing.Point(74, 157);
			this.HTextBox.Name = "HTextBox";
			this.HTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.HTextBox.Size = new System.Drawing.Size(279, 34);
			this.HTextBox.TabIndex = 2;
			this.HTextBox.TextChanged += new System.EventHandler(this.ParameterTextBox_TextChanged);
			// 
			// PTextBox
			// 
			this.PTextBox.Location = new System.Drawing.Point(71, 87);
			this.PTextBox.Name = "PTextBox";
			this.PTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.PTextBox.Size = new System.Drawing.Size(279, 34);
			this.PTextBox.TabIndex = 1;
			this.PTextBox.TextChanged += new System.EventHandler(this.ParameterTextBox_TextChanged);
			// 
			// PLabel
			// 
			PLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			PLabel.Location = new System.Drawing.Point(11, 87);
			PLabel.Name = "PLabel";
			PLabel.Size = new System.Drawing.Size(54, 34);
			PLabel.TabIndex = 15;
			PLabel.Text = "P:";
			PLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// QLabel
			// 
			QLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			QLabel.Location = new System.Drawing.Point(11, 24);
			QLabel.Name = "QLabel";
			QLabel.Size = new System.Drawing.Size(54, 34);
			QLabel.TabIndex = 14;
			QLabel.Text = "Q:";
			QLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// QTextBox
			// 
			this.QTextBox.Location = new System.Drawing.Point(71, 24);
			this.QTextBox.Name = "QTextBox";
			this.QTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.QTextBox.Size = new System.Drawing.Size(279, 34);
			this.QTextBox.TabIndex = 0;
			this.QTextBox.TextChanged += new System.EventHandler(this.ParameterTextBox_TextChanged);
			// 
			// ClearFieldsButton
			// 
			this.ClearFieldsButton.Location = new System.Drawing.Point(11, 640);
			this.ClearFieldsButton.Name = "ClearFieldsButton";
			this.ClearFieldsButton.Size = new System.Drawing.Size(339, 60);
			this.ClearFieldsButton.TabIndex = 10;
			this.ClearFieldsButton.Text = "Очистить все поля";
			this.ClearFieldsButton.UseVisualStyleBackColor = true;
			this.ClearFieldsButton.Click += new System.EventHandler(this.ClearFieldsButton_Click);
			// 
			// EDSActionButton
			// 
			this.EDSActionButton.Enabled = false;
			this.EDSActionButton.Location = new System.Drawing.Point(14, 427);
			this.EDSActionButton.Name = "EDSActionButton";
			this.EDSActionButton.Size = new System.Drawing.Size(339, 60);
			this.EDSActionButton.TabIndex = 7;
			this.EDSActionButton.Text = "Выполнить действие";
			this.EDSActionButton.UseVisualStyleBackColor = true;
			this.EDSActionButton.Click += new System.EventHandler(this.EDSActionButton_Click);
			// 
			// OutputButton
			// 
			this.OutputButton.Location = new System.Drawing.Point(14, 565);
			this.OutputButton.Name = "OutputButton";
			this.OutputButton.Size = new System.Drawing.Size(339, 60);
			this.OutputButton.TabIndex = 9;
			this.OutputButton.Text = "Сохранить в файл";
			this.OutputButton.UseVisualStyleBackColor = true;
			this.OutputButton.Click += new System.EventHandler(this.OutputButton_Click);
			// 
			// InputButton
			// 
			this.InputButton.Location = new System.Drawing.Point(14, 499);
			this.InputButton.Name = "InputButton";
			this.InputButton.Size = new System.Drawing.Size(339, 60);
			this.InputButton.TabIndex = 8;
			this.InputButton.Text = "Ввести из файла";
			this.InputButton.UseVisualStyleBackColor = true;
			this.InputButton.Click += new System.EventHandler(this.InputButton_Click);
			// 
			// SignRadioButton
			// 
			this.SignRadioButton.AutoSize = true;
			this.SignRadioButton.Location = new System.Drawing.Point(16, 350);
			this.SignRadioButton.Name = "SignRadioButton";
			this.SignRadioButton.Size = new System.Drawing.Size(227, 33);
			this.SignRadioButton.TabIndex = 5;
			this.SignRadioButton.TabStop = true;
			this.SignRadioButton.Text = "Подписать текст";
			this.SignRadioButton.UseVisualStyleBackColor = true;
			this.SignRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
			// 
			// VerifySignatureRadioButton
			// 
			this.VerifySignatureRadioButton.AutoSize = true;
			this.VerifySignatureRadioButton.Location = new System.Drawing.Point(16, 389);
			this.VerifySignatureRadioButton.Name = "VerifySignatureRadioButton";
			this.VerifySignatureRadioButton.Size = new System.Drawing.Size(264, 33);
			this.VerifySignatureRadioButton.TabIndex = 6;
			this.VerifySignatureRadioButton.TabStop = true;
			this.VerifySignatureRadioButton.Text = "Проверить подпись";
			this.VerifySignatureRadioButton.UseVisualStyleBackColor = true;
			this.VerifySignatureRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
			// 
			// InputDialog
			// 
			this.InputDialog.Filter = "Text files (*.txt)|*.txt";
			// 
			// OutputDialog
			// 
			this.OutputDialog.DefaultExt = "txt";
			this.OutputDialog.Filter = "Text files (*.txt)|*.txt";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(974, 757);
			this.Controls.Add(MainTabControl);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Теория информации, ЛР4. ЭЦП на базе DSA. Колбеко Влада, гр. 351003";
			MainTabControl.ResumeLayout(false);
			this.MainTabPage.ResumeLayout(false);
			TextPanel.ResumeLayout(false);
			TextPanel.PerformLayout();
			RegisterPanel.ResumeLayout(false);
			RegisterPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabPage MainTabPage;
		private System.Windows.Forms.TextBox ResultTextBox;
		private System.Windows.Forms.TextBox GTextBox;
		private System.Windows.Forms.TextBox InitialTextBox;
		private System.Windows.Forms.Button ClearFieldsButton;
		private System.Windows.Forms.Button EDSActionButton;
		private System.Windows.Forms.Button OutputButton;
		private System.Windows.Forms.Button InputButton;
		private System.Windows.Forms.TextBox QTextBox;
		private System.Windows.Forms.TextBox KTextBox;
		private System.Windows.Forms.TextBox XTextBox;
		private System.Windows.Forms.TextBox HTextBox;
		private System.Windows.Forms.TextBox PTextBox;
		private System.Windows.Forms.TextBox EDSTextBox;
		private System.Windows.Forms.TextBox HashTextBox;
		private System.Windows.Forms.TextBox YTextBox;
		private System.Windows.Forms.RadioButton VerifySignatureRadioButton;
		private System.Windows.Forms.RadioButton SignRadioButton;
		private System.Windows.Forms.OpenFileDialog InputDialog;
		private System.Windows.Forms.SaveFileDialog OutputDialog;
	}
}

