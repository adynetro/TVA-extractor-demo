namespace TVA

{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox vatTextBox;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button computeButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.TextBox vatResult;

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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            vatTextBox = new TextBox();
            inputTextBox = new TextBox();
            resultTextBox = new TextBox();
            label1 = new Label();
            computeButton = new Button();
            aboutButton = new Button();
            vatResult = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            SuspendLayout();
            // 
            // vatTextBox
            // 
            resources.ApplyResources(vatTextBox, "vatTextBox");
            vatTextBox.Name = "vatTextBox";
            // 
            // inputTextBox
            // 
            resources.ApplyResources(inputTextBox, "inputTextBox");
            inputTextBox.Name = "inputTextBox";
            // 
            // resultTextBox
            // 
            resources.ApplyResources(resultTextBox, "resultTextBox");
            resultTextBox.Name = "resultTextBox";
            resultTextBox.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // computeButton
            // 
            resources.ApplyResources(computeButton, "computeButton");
            computeButton.Name = "computeButton";
            computeButton.Click += computeButton_Click;
            // 
            // aboutButton
            // 
            resources.ApplyResources(aboutButton, "aboutButton");
            aboutButton.Name = "aboutButton";
            aboutButton.Click += aboutButton_Click;
            // 
            // vatResult
            // 
            resources.ApplyResources(vatResult, "vatResult");
            vatResult.Name = "vatResult";
            vatResult.ReadOnly = true;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // groupBox1
            // 
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(vatResult);
            Controls.Add(vatTextBox);
            Controls.Add(inputTextBox);
            Controls.Add(resultTextBox);
            Controls.Add(label1);
            Controls.Add(computeButton);
            Controls.Add(aboutButton);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "MainWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Label label2;
        private Label label3;
        private Label label6;
        private GroupBox groupBox1;
    }
}