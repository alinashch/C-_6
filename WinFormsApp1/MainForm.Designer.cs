namespace WinFormsApp1
{
    partial class MainForm
    {

        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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


        private void InitializeComponent()
        {
            classComboBox = new ComboBox();
            methodComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            paramsPanel = new FlowLayoutPanel();
            executeButton = new Button();
            label4 = new Label();
            resultBox = new TextBox();
            SuspendLayout();
            // 
            // classComboBox
            // 
            classComboBox.FormattingEnabled = true;
            classComboBox.Location = new Point(12, 33);
            classComboBox.Name = "classComboBox";
            classComboBox.Size = new Size(200, 23);
            classComboBox.TabIndex = 0;
            classComboBox.SelectedValueChanged += ClassComboBox_SelectedValueChanged;
            // 
            // methodComboBox
            // 
            methodComboBox.FormattingEnabled = true;
            methodComboBox.Location = new Point(12, 115);
            methodComboBox.Name = "methodComboBox";
            methodComboBox.Size = new Size(200, 23);
            methodComboBox.TabIndex = 1;
            methodComboBox.SelectedValueChanged += MethodComboBox_SelectedValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(81, 9);
            label1.Name = "label1";
            label1.Size = new Size(125, 21);
            label1.TabIndex = 2;
            label1.Text = "Выберите класс:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(81, 80);
            label2.Name = "label2";
            label2.Size = new Size(131, 21);
            label2.TabIndex = 3;
            label2.Text = "Выберите метод:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(231, 59);
            label3.Name = "label3";
            label3.Size = new Size(147, 21);
            label3.TabIndex = 4;
            label3.Text = "Введите парамтры:";
            // 
            // paramsPanel
            // 
            paramsPanel.FlowDirection = FlowDirection.TopDown;
            paramsPanel.Location = new Point(245, 93);
            paramsPanel.Name = "paramsPanel";
            paramsPanel.Size = new Size(115, 24);
            paramsPanel.TabIndex = 5;
            // 
            // executeButton
            // 
            executeButton.Location = new Point(12, 155);
            executeButton.Name = "executeButton";
            executeButton.Size = new Size(75, 23);
            executeButton.TabIndex = 6;
            executeButton.Text = "Выполнить ";
            executeButton.UseVisualStyleBackColor = true;
            executeButton.Click += ExecuteButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(119, 154);
            label4.Name = "label4";
            label4.Size = new Size(47, 21);
            label4.TabIndex = 7;
            label4.Text = "Итог:";
            // 
            // resultBox
            // 
            resultBox.Location = new Point(181, 156);
            resultBox.Name = "resultBox";
            resultBox.ReadOnly = true;
            resultBox.Size = new Size(267, 23);
            resultBox.TabIndex = 8;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 226);
            Controls.Add(resultBox);
            Controls.Add(label4);
            Controls.Add(executeButton);
            Controls.Add(paramsPanel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(methodComboBox);
            Controls.Add(classComboBox);
            Name = "MainForm";
            Text = "Task 6";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox classComboBox;
        private ComboBox methodComboBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private FlowLayoutPanel paramsPanel;
        private Button executeButton;
        private Label label4;
        private TextBox resultBox;
    }
}