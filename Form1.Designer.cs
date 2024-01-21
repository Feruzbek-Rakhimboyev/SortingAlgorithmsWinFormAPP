namespace KursIShiSaralashAlgoritmlari
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
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
        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LabelAlgorithName = new Label();
            LabelInputElements = new Label();
            LabelSortingElements = new Label();
            ElementsBox = new TextBox();
            SortedNumbers = new Label();
            AboutAlgorithm = new TextBox();
            LabelAlgorithmAbout = new Label();
            InputStyleKeyboard = new RadioButton();
            InputStyleRandom = new RadioButton();
            LabelInputMethod = new Label();
            CompareSortingAlgorithmsTimes = new TextBox();
            labelTimeSpent = new Label();
            CompareSortingAlgorithmsIterations = new TextBox();
            labelTheBestSortingAlgorithm = new Label();
            TheFastSortingAlgorithm = new TextBox();
            labelTheFastSortingAlgorithm = new Label();
            labelIterations = new Label();
            TheSmartSortingAlgorithm = new Label();
            SortingButton = new Button();
            AlgorithmNamesList = new ComboBox();
            CurrentSortingTime = new TextBox();
            labelCUrrentAlgorithmTimeSpent = new Label();
            labelCUrrentAlgorithmIterations = new Label();
            CurrentSortingIterations = new TextBox();
            SuspendLayout();
            // 
            // LabelAlgorithName
            // 
            LabelAlgorithName.AutoSize = true;
            LabelAlgorithName.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelAlgorithName.Location = new Point(14, 20);
            LabelAlgorithName.Margin = new Padding(5, 0, 5, 0);
            LabelAlgorithName.Name = "LabelAlgorithName";
            LabelAlgorithName.Size = new Size(378, 40);
            LabelAlgorithName.TabIndex = 0;
            LabelAlgorithName.Text = "Saralash algoritmini tanlang:";
            // 
            // LabelInputElements
            // 
            LabelInputElements.AutoSize = true;
            LabelInputElements.Location = new Point(1082, 2);
            LabelInputElements.Margin = new Padding(5, 0, 5, 0);
            LabelInputElements.Name = "LabelInputElements";
            LabelInputElements.Size = new Size(255, 37);
            LabelInputElements.TabIndex = 4;
            LabelInputElements.Text = "Elementlarni kiriting";
            // 
            // LabelSortingElements
            // 
            LabelSortingElements.AutoSize = true;
            LabelSortingElements.Location = new Point(1804, 2);
            LabelSortingElements.Margin = new Padding(5, 0, 5, 0);
            LabelSortingElements.Name = "LabelSortingElements";
            LabelSortingElements.Size = new Size(385, 37);
            LabelSortingElements.TabIndex = 10;
            LabelSortingElements.Text = "Saralashdan keyingi elementlar";
            // 
            // ElementsBox
            // 
            ElementsBox.BorderStyle = BorderStyle.FixedSingle;
            ElementsBox.Location = new Point(825, 44);
            ElementsBox.Margin = new Padding(5);
            ElementsBox.Multiline = true;
            ElementsBox.Name = "ElementsBox";
            ElementsBox.Size = new Size(756, 890);
            ElementsBox.TabIndex = 5;
            // 
            // SortedNumbers
            // 
            SortedNumbers.BackColor = SystemColors.ButtonHighlight;
            SortedNumbers.BorderStyle = BorderStyle.FixedSingle;
            SortedNumbers.Location = new Point(1610, 45);
            SortedNumbers.Margin = new Padding(5, 0, 5, 0);
            SortedNumbers.Name = "SortedNumbers";
            SortedNumbers.Size = new Size(756, 890);
            SortedNumbers.TabIndex = 11;
            // 
            // AboutAlgorithm
            // 
            AboutAlgorithm.BackColor = SystemColors.ButtonHighlight;
            AboutAlgorithm.BorderStyle = BorderStyle.FixedSingle;
            AboutAlgorithm.Location = new Point(14, 341);
            AboutAlgorithm.Margin = new Padding(5, 0, 5, 0);
            AboutAlgorithm.Multiline = true;
            AboutAlgorithm.Name = "AboutAlgorithm";
            AboutAlgorithm.Size = new Size(782, 858);
            AboutAlgorithm.TabIndex = 9;
            // 
            // LabelAlgorithmAbout
            // 
            LabelAlgorithmAbout.AutoSize = true;
            LabelAlgorithmAbout.Location = new Point(60, 295);
            LabelAlgorithmAbout.Margin = new Padding(5, 0, 5, 0);
            LabelAlgorithmAbout.Name = "LabelAlgorithmAbout";
            LabelAlgorithmAbout.Size = new Size(572, 37);
            LabelAlgorithmAbout.TabIndex = 8;
            LabelAlgorithmAbout.Text = "Tanlangan saralash algoritmi haqida ma'lumot!";
            // 
            // InputStyleKeyboard
            // 
            InputStyleKeyboard.AutoSize = true;
            InputStyleKeyboard.BackColor = SystemColors.GradientInactiveCaption;
            InputStyleKeyboard.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InputStyleKeyboard.Location = new Point(31, 157);
            InputStyleKeyboard.Margin = new Padding(5);
            InputStyleKeyboard.Name = "InputStyleKeyboard";
            InputStyleKeyboard.Size = new Size(196, 41);
            InputStyleKeyboard.TabIndex = 2;
            InputStyleKeyboard.TabStop = true;
            InputStyleKeyboard.Text = "Klaviaturada";
            InputStyleKeyboard.UseVisualStyleBackColor = false;
            // 
            // InputStyleRandom
            // 
            InputStyleRandom.AutoSize = true;
            InputStyleRandom.BackColor = SystemColors.GradientInactiveCaption;
            InputStyleRandom.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InputStyleRandom.Location = new Point(31, 208);
            InputStyleRandom.Margin = new Padding(5);
            InputStyleRandom.Name = "InputStyleRandom";
            InputStyleRandom.Size = new Size(243, 41);
            InputStyleRandom.TabIndex = 3;
            InputStyleRandom.TabStop = true;
            InputStyleRandom.Text = "Tasodifiy tanlash";
            InputStyleRandom.UseVisualStyleBackColor = false;
            // 
            // LabelInputMethod
            // 
            LabelInputMethod.BackColor = SystemColors.GradientInactiveCaption;
            LabelInputMethod.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelInputMethod.Location = new Point(13, 98);
            LabelInputMethod.Margin = new Padding(5, 0, 5, 0);
            LabelInputMethod.Name = "LabelInputMethod";
            LabelInputMethod.RightToLeft = RightToLeft.No;
            LabelInputMethod.Size = new Size(400, 52);
            LabelInputMethod.TabIndex = 1;
            LabelInputMethod.Text = "Elementlarni kiritish usuli\r\n";
            // 
            // CompareSortingAlgorithmsTimes
            // 
            CompareSortingAlgorithmsTimes.BackColor = SystemColors.ButtonHighlight;
            CompareSortingAlgorithmsTimes.BorderStyle = BorderStyle.FixedSingle;
            CompareSortingAlgorithmsTimes.Location = new Point(1610, 985);
            CompareSortingAlgorithmsTimes.Margin = new Padding(4);
            CompareSortingAlgorithmsTimes.Multiline = true;
            CompareSortingAlgorithmsTimes.Name = "CompareSortingAlgorithmsTimes";
            CompareSortingAlgorithmsTimes.Size = new Size(369, 214);
            CompareSortingAlgorithmsTimes.TabIndex = 17;
            // 
            // labelTimeSpent
            // 
            labelTimeSpent.Location = new Point(1610, 944);
            labelTimeSpent.Margin = new Padding(4, 0, 4, 0);
            labelTimeSpent.Name = "labelTimeSpent";
            labelTimeSpent.Size = new Size(377, 37);
            labelTimeSpent.TabIndex = 18;
            labelTimeSpent.Text = "Saralash uchun ketgan vaqtlar\r\n\r\n";
            // 
            // CompareSortingAlgorithmsIterations
            // 
            CompareSortingAlgorithmsIterations.BackColor = SystemColors.ButtonHighlight;
            CompareSortingAlgorithmsIterations.BorderStyle = BorderStyle.FixedSingle;
            CompareSortingAlgorithmsIterations.Location = new Point(1997, 985);
            CompareSortingAlgorithmsIterations.Margin = new Padding(4);
            CompareSortingAlgorithmsIterations.Multiline = true;
            CompareSortingAlgorithmsIterations.Name = "CompareSortingAlgorithmsIterations";
            CompareSortingAlgorithmsIterations.Size = new Size(369, 214);
            CompareSortingAlgorithmsIterations.TabIndex = 19;
            // 
            // labelTheBestSortingAlgorithm
            // 
            labelTheBestSortingAlgorithm.Location = new Point(825, 1100);
            labelTheBestSortingAlgorithm.Margin = new Padding(4, 0, 4, 0);
            labelTheBestSortingAlgorithm.Name = "labelTheBestSortingAlgorithm";
            labelTheBestSortingAlgorithm.Size = new Size(454, 44);
            labelTheBestSortingAlgorithm.TabIndex = 21;
            labelTheBestSortingAlgorithm.Text = "Vaqt bo'yicha eng tezkor algoritm:\r\n\r\n";
            // 
            // TheFastSortingAlgorithm
            // 
            TheFastSortingAlgorithm.BackColor = SystemColors.ButtonHighlight;
            TheFastSortingAlgorithm.BorderStyle = BorderStyle.FixedSingle;
            TheFastSortingAlgorithm.Location = new Point(1303, 1101);
            TheFastSortingAlgorithm.Margin = new Padding(4);
            TheFastSortingAlgorithm.Name = "TheFastSortingAlgorithm";
            TheFastSortingAlgorithm.Size = new Size(278, 43);
            TheFastSortingAlgorithm.TabIndex = 16;
            // 
            // labelTheFastSortingAlgorithm
            // 
            labelTheFastSortingAlgorithm.AutoSize = true;
            labelTheFastSortingAlgorithm.Location = new Point(825, 1156);
            labelTheFastSortingAlgorithm.Margin = new Padding(4, 0, 4, 0);
            labelTheFastSortingAlgorithm.Name = "labelTheFastSortingAlgorithm";
            labelTheFastSortingAlgorithm.Size = new Size(470, 37);
            labelTheFastSortingAlgorithm.TabIndex = 14;
            labelTheFastSortingAlgorithm.Text = "Eng kam iteratsiyali saralash algoritmi:\r\n";
            // 
            // labelIterations
            // 
            labelIterations.AutoSize = true;
            labelIterations.Location = new Point(2074, 944);
            labelIterations.Margin = new Padding(4, 0, 4, 0);
            labelIterations.Name = "labelIterations";
            labelIterations.Size = new Size(210, 37);
            labelIterations.TabIndex = 15;
            labelIterations.Text = "Iteratsiyalar soni";
            // 
            // TheSmartSortingAlgorithm
            // 
            TheSmartSortingAlgorithm.BackColor = SystemColors.ButtonHighlight;
            TheSmartSortingAlgorithm.BorderStyle = BorderStyle.FixedSingle;
            TheSmartSortingAlgorithm.Location = new Point(1304, 1156);
            TheSmartSortingAlgorithm.Margin = new Padding(5, 0, 5, 0);
            TheSmartSortingAlgorithm.Name = "TheSmartSortingAlgorithm";
            TheSmartSortingAlgorithm.Size = new Size(278, 44);
            TheSmartSortingAlgorithm.TabIndex = 13;
            // 
            // SortingButton
            // 
            SortingButton.BackColor = SystemColors.ButtonHighlight;
            SortingButton.Location = new Point(386, 134);
            SortingButton.Margin = new Padding(2);
            SortingButton.Name = "SortingButton";
            SortingButton.Size = new Size(355, 115);
            SortingButton.TabIndex = 23;
            SortingButton.Text = "Start";
            SortingButton.UseVisualStyleBackColor = false;
            SortingButton.Click += SortingButton_Click_1;
            // 
            // AlgorithmNamesList
            // 
            AlgorithmNamesList.BackColor = SystemColors.ButtonHighlight;
            AlgorithmNamesList.FormattingEnabled = true;
            AlgorithmNamesList.Items.AddRange(new object[] { "Bubble Sort", "Selection Sort", "Insertion Sort", "Quick Sort" });
            AlgorithmNamesList.Location = new Point(431, 20);
            AlgorithmNamesList.Name = "AlgorithmNamesList";
            AlgorithmNamesList.Size = new Size(242, 45);
            AlgorithmNamesList.TabIndex = 24;
            // 
            // CurrentSortingTime
            // 
            CurrentSortingTime.BackColor = SystemColors.ButtonHighlight;
            CurrentSortingTime.BorderStyle = BorderStyle.FixedSingle;
            CurrentSortingTime.Location = new Point(1170, 985);
            CurrentSortingTime.Name = "CurrentSortingTime";
            CurrentSortingTime.Size = new Size(411, 43);
            CurrentSortingTime.TabIndex = 25;
            // 
            // labelCUrrentAlgorithmTimeSpent
            // 
            labelCUrrentAlgorithmTimeSpent.AutoSize = true;
            labelCUrrentAlgorithmTimeSpent.Location = new Point(825, 991);
            labelCUrrentAlgorithmTimeSpent.Name = "labelCUrrentAlgorithmTimeSpent";
            labelCUrrentAlgorithmTimeSpent.Size = new Size(339, 37);
            labelCUrrentAlgorithmTimeSpent.TabIndex = 26;
            labelCUrrentAlgorithmTimeSpent.Text = "Joriy algoritm ishlash vaqti:";
            // 
            // labelCUrrentAlgorithmIterations
            // 
            labelCUrrentAlgorithmIterations.AutoSize = true;
            labelCUrrentAlgorithmIterations.Location = new Point(825, 1046);
            labelCUrrentAlgorithmIterations.Name = "labelCUrrentAlgorithmIterations";
            labelCUrrentAlgorithmIterations.Size = new Size(393, 37);
            labelCUrrentAlgorithmIterations.TabIndex = 27;
            labelCUrrentAlgorithmIterations.Text = "Joriy algoritm iteratsiyalari soni:";
            // 
            // CurrentSortingIterations
            // 
            CurrentSortingIterations.BackColor = SystemColors.ButtonHighlight;
            CurrentSortingIterations.BorderStyle = BorderStyle.FixedSingle;
            CurrentSortingIterations.Location = new Point(1243, 1040);
            CurrentSortingIterations.Name = "CurrentSortingIterations";
            CurrentSortingIterations.Size = new Size(338, 43);
            CurrentSortingIterations.TabIndex = 28;
            // 
            // Form1
            // 
            AccessibleRole = AccessibleRole.ColumnHeader;
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = SystemColors.GradientInactiveCaption;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(2380, 1212);
            Controls.Add(CurrentSortingIterations);
            Controls.Add(labelCUrrentAlgorithmIterations);
            Controls.Add(labelCUrrentAlgorithmTimeSpent);
            Controls.Add(CurrentSortingTime);
            Controls.Add(AlgorithmNamesList);
            Controls.Add(SortingButton);
            Controls.Add(labelTheBestSortingAlgorithm);
            Controls.Add(CompareSortingAlgorithmsIterations);
            Controls.Add(labelTimeSpent);
            Controls.Add(CompareSortingAlgorithmsTimes);
            Controls.Add(TheFastSortingAlgorithm);
            Controls.Add(labelIterations);
            Controls.Add(labelTheFastSortingAlgorithm);
            Controls.Add(LabelInputMethod);
            Controls.Add(InputStyleRandom);
            Controls.Add(InputStyleKeyboard);
            Controls.Add(LabelAlgorithmAbout);
            Controls.Add(AboutAlgorithm);
            Controls.Add(TheSmartSortingAlgorithm);
            Controls.Add(SortedNumbers);
            Controls.Add(LabelSortingElements);
            Controls.Add(LabelInputElements);
            Controls.Add(ElementsBox);
            Controls.Add(LabelAlgorithName);
            Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ImeMode = ImeMode.On;
            Name = "Form1";
            Text = "Saralash Algoritmlari";
            TopMost = true;
            WindowState = FormWindowState.Minimized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LabelAlgorithName;
        private Label LabelInputElements;
        private Label LabelSortingElements;
        private TextBox ElementsBox;
        public Label SortedNumbers;
        private Label TheSmartSortingAlgorithm;
        private TextBox AboutAlgorithm;
        private Label LabelAlgorithmAbout;
        private RadioButton InputStyleKeyboard;
        private RadioButton InputStyleRandom;
        private Label LabelInputMethod;
        private Label labelTheFastSortingAlgorithm;
        private Label labelIterations;
        private TextBox TheFastSortingAlgorithm;
        private TextBox CompareSortingAlgorithmsTimes;
        private Label labelTimeSpent;
        private TextBox CompareSortingAlgorithmsIterations;
        private Label labelTheBestSortingAlgorithm;
        private Button SortingButton;
        private ComboBox AlgorithmNamesList;
        private TextBox CurrentSortingTime;
        private Label labelCUrrentAlgorithmTimeSpent;
        private Label labelCUrrentAlgorithmIterations;
        private TextBox CurrentSortingIterations;
    }
}
