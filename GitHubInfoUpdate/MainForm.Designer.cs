namespace GitHubInfoUpdate
{
    partial class MainForm
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
            groupBox1 = new GroupBox();
            bodyBox = new TextBox();
            label6 = new Label();
            publishTimeBox = new TextBox();
            label5 = new Label();
            createTimeBox = new TextBox();
            label4 = new Label();
            nameBox = new TextBox();
            label3 = new Label();
            tagBox = new TextBox();
            label2 = new Label();
            urlBox = new TextBox();
            label1 = new Label();
            prereleaseCheckBox = new CheckBox();
            groupBox2 = new GroupBox();
            deleteButton = new Button();
            monitorButton = new Button();
            repoBox = new TextBox();
            ownerBox = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label9 = new Label();
            monitorListView = new ListView();
            label10 = new Label();
            releaseListView = new ListView();
            setVerButton = new Button();
            silenceBox = new CheckBox();
            progressBar1 = new ProgressBar();
            label11 = new Label();
            nowTagBox = new TextBox();
            nowDateBox = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(bodyBox);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(publishTimeBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(createTimeBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(nameBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tagBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(urlBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(prereleaseCheckBox);
            groupBox1.Location = new Point(387, 304);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(561, 515);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Release";
            // 
            // bodyBox
            // 
            bodyBox.Location = new Point(6, 187);
            bodyBox.Multiline = true;
            bodyBox.Name = "bodyBox";
            bodyBox.ReadOnly = true;
            bodyBox.ScrollBars = ScrollBars.Vertical;
            bodyBox.Size = new Size(547, 320);
            bodyBox.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 164);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 11;
            label6.Text = "Body";
            // 
            // publishTimeBox
            // 
            publishTimeBox.Location = new Point(360, 129);
            publishTimeBox.Name = "publishTimeBox";
            publishTimeBox.ReadOnly = true;
            publishTimeBox.Size = new Size(150, 27);
            publishTimeBox.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(261, 132);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 9;
            label5.Text = "PublishTime";
            // 
            // createTimeBox
            // 
            createTimeBox.Location = new Point(105, 129);
            createTimeBox.Name = "createTimeBox";
            createTimeBox.ReadOnly = true;
            createTimeBox.Size = new Size(150, 27);
            createTimeBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 132);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 7;
            label4.Text = "CreateTime";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(64, 96);
            nameBox.Name = "nameBox";
            nameBox.ReadOnly = true;
            nameBox.Size = new Size(418, 27);
            nameBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 99);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 5;
            label3.Text = "Name";
            // 
            // tagBox
            // 
            tagBox.Location = new Point(42, 63);
            tagBox.Name = "tagBox";
            tagBox.ReadOnly = true;
            tagBox.Size = new Size(209, 27);
            tagBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 66);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 3;
            label2.Text = "Tag";
            // 
            // urlBox
            // 
            urlBox.Location = new Point(42, 30);
            urlBox.Name = "urlBox";
            urlBox.ReadOnly = true;
            urlBox.Size = new Size(511, 27);
            urlBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 33);
            label1.Name = "label1";
            label1.Size = new Size(30, 20);
            label1.TabIndex = 1;
            label1.Text = "Url";
            // 
            // prereleaseCheckBox
            // 
            prereleaseCheckBox.AutoSize = true;
            prereleaseCheckBox.Enabled = false;
            prereleaseCheckBox.Location = new Point(257, 66);
            prereleaseCheckBox.Name = "prereleaseCheckBox";
            prereleaseCheckBox.Size = new Size(111, 24);
            prereleaseCheckBox.TabIndex = 0;
            prereleaseCheckBox.Text = "PreRelease";
            prereleaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(deleteButton);
            groupBox2.Controls.Add(monitorButton);
            groupBox2.Controls.Add(repoBox);
            groupBox2.Controls.Add(ownerBox);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(11, 304);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(370, 100);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Edit Monitor";
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(294, 26);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(70, 60);
            deleteButton.TabIndex = 5;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // monitorButton
            // 
            monitorButton.Location = new Point(225, 26);
            monitorButton.Name = "monitorButton";
            monitorButton.Size = new Size(63, 60);
            monitorButton.TabIndex = 4;
            monitorButton.Text = "Add";
            monitorButton.UseVisualStyleBackColor = true;
            monitorButton.Click += monitorButton_Click;
            // 
            // repoBox
            // 
            repoBox.Location = new Point(69, 59);
            repoBox.Name = "repoBox";
            repoBox.Size = new Size(150, 27);
            repoBox.TabIndex = 3;
            // 
            // ownerBox
            // 
            ownerBox.Location = new Point(69, 26);
            ownerBox.Name = "ownerBox";
            ownerBox.Size = new Size(150, 27);
            ownerBox.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 62);
            label8.Name = "label8";
            label8.Size = new Size(48, 20);
            label8.TabIndex = 1;
            label8.Text = "Repo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 29);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 0;
            label7.Text = "Owner";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 9);
            label9.Name = "label9";
            label9.Size = new Size(76, 20);
            label9.TabIndex = 3;
            label9.Text = "Monitors";
            // 
            // monitorListView
            // 
            monitorListView.AutoArrange = false;
            monitorListView.FullRowSelect = true;
            monitorListView.Location = new Point(12, 32);
            monitorListView.MultiSelect = false;
            monitorListView.Name = "monitorListView";
            monitorListView.Size = new Size(936, 261);
            monitorListView.TabIndex = 4;
            monitorListView.UseCompatibleStateImageBehavior = false;
            monitorListView.View = View.Details;
            monitorListView.SelectedIndexChanged += monitorListView_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(11, 407);
            label10.Name = "label10";
            label10.Size = new Size(90, 20);
            label10.TabIndex = 5;
            label10.Text = "ReleaseList";
            // 
            // releaseListView
            // 
            releaseListView.FullRowSelect = true;
            releaseListView.Location = new Point(12, 433);
            releaseListView.Name = "releaseListView";
            releaseListView.Size = new Size(369, 342);
            releaseListView.TabIndex = 6;
            releaseListView.UseCompatibleStateImageBehavior = false;
            releaseListView.View = View.Details;
            releaseListView.SelectedIndexChanged += releaseListView_SelectedIndexChanged;
            // 
            // setVerButton
            // 
            setVerButton.Location = new Point(230, 808);
            setVerButton.Name = "setVerButton";
            setVerButton.Size = new Size(147, 35);
            setVerButton.TabIndex = 7;
            setVerButton.Text = "Set Current Ver.";
            setVerButton.UseVisualStyleBackColor = true;
            setVerButton.Click += setVerButton_Click;
            // 
            // silenceBox
            // 
            silenceBox.AutoSize = true;
            silenceBox.Enabled = false;
            silenceBox.Location = new Point(112, 814);
            silenceBox.Name = "silenceBox";
            silenceBox.Size = new Size(112, 24);
            silenceBox.TabIndex = 8;
            silenceBox.Text = "No Prompt";
            silenceBox.UseVisualStyleBackColor = true;
            silenceBox.CheckStateChanged += silenceBox_CheckStateChanged;
            silenceBox.Click += silenceBox_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(731, 821);
            progressBar1.MarqueeAnimationSpeed = 20;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(218, 21);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 9;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(11, 781);
            label11.Name = "label11";
            label11.Size = new Size(76, 20);
            label11.TabIndex = 10;
            label11.Text = "Now Ver.";
            // 
            // nowTagBox
            // 
            nowTagBox.Location = new Point(91, 778);
            nowTagBox.Name = "nowTagBox";
            nowTagBox.ReadOnly = true;
            nowTagBox.Size = new Size(128, 27);
            nowTagBox.TabIndex = 11;
            // 
            // nowDateBox
            // 
            nowDateBox.Location = new Point(225, 778);
            nowDateBox.Name = "nowDateBox";
            nowDateBox.ReadOnly = true;
            nowDateBox.Size = new Size(150, 27);
            nowDateBox.TabIndex = 12;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 850);
            Controls.Add(nowDateBox);
            Controls.Add(nowTagBox);
            Controls.Add(label11);
            Controls.Add(progressBar1);
            Controls.Add(silenceBox);
            Controls.Add(setVerButton);
            Controls.Add(releaseListView);
            Controls.Add(label10);
            Controls.Add(monitorListView);
            Controls.Add(label9);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "MainForm";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox prereleaseCheckBox;
        private TextBox urlBox;
        private Label label1;
        private TextBox nameBox;
        private Label label3;
        private TextBox tagBox;
        private Label label2;
        private TextBox createTimeBox;
        private Label label4;
        private TextBox publishTimeBox;
        private Label label5;
        private TextBox bodyBox;
        private Label label6;
        private GroupBox groupBox2;
        private Button monitorButton;
        private TextBox repoBox;
        private TextBox ownerBox;
        private Label label8;
        private Label label7;
        private Label label9;
        private ListView monitorListView;
        private Label label10;
        private ListView releaseListView;
        private Button setVerButton;
        private CheckBox silenceBox;
        private ProgressBar progressBar1;
        private Button deleteButton;
        private Label label11;
        private TextBox nowTagBox;
        private TextBox nowDateBox;
    }
}