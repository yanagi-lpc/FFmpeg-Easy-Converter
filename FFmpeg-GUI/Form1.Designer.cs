namespace FFmpeg_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonout = new Button();
            buttonin = new Button();
            textBoxin = new TextBox();
            textBoxout = new TextBox();
            convbtn = new Button();
            title = new Label();
            label1 = new Label();
            label2 = new Label();
            textBoxopt = new TextBox();
            label3 = new Label();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // buttonout
            // 
            resources.ApplyResources(buttonout, "buttonout");
            buttonout.BackColor = SystemColors.ButtonFace;
            buttonout.Name = "buttonout";
            buttonout.UseVisualStyleBackColor = false;
            buttonout.Click += buttonout_Click;
            // 
            // buttonin
            // 
            resources.ApplyResources(buttonin, "buttonin");
            buttonin.BackColor = SystemColors.ButtonFace;
            buttonin.Name = "buttonin";
            buttonin.UseVisualStyleBackColor = false;
            buttonin.Click += buttonin_Click;
            // 
            // textBoxin
            // 
            resources.ApplyResources(textBoxin, "textBoxin");
            textBoxin.BackColor = SystemColors.ButtonHighlight;
            textBoxin.Name = "textBoxin";
            textBoxin.ReadOnly = true;
            textBoxin.TextChanged += textBoxin_TextChanged;
            // 
            // textBoxout
            // 
            resources.ApplyResources(textBoxout, "textBoxout");
            textBoxout.BackColor = SystemColors.ButtonHighlight;
            textBoxout.Name = "textBoxout";
            textBoxout.ReadOnly = true;
            textBoxout.TextChanged += textBoxout_TextChanged;
            // 
            // convbtn
            // 
            resources.ApplyResources(convbtn, "convbtn");
            convbtn.BackColor = SystemColors.ButtonFace;
            convbtn.Name = "convbtn";
            convbtn.UseVisualStyleBackColor = false;
            convbtn.Click += convbtn_Click;
            // 
            // title
            // 
            resources.ApplyResources(title, "title");
            title.Name = "title";
            title.Click += title_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            label2.Click += label2_Click;
            // 
            // textBoxopt
            // 
            resources.ApplyResources(textBoxopt, "textBoxopt");
            textBoxopt.BackColor = SystemColors.ButtonHighlight;
            textBoxopt.Name = "textBoxopt";
            textBoxopt.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.ForeColor = Color.Red;
            label4.Name = "label4";
            // 
            // linkLabel1
            // 
            resources.ApplyResources(linkLabel1, "linkLabel1");
            linkLabel1.ActiveLinkColor = Color.Black;
            linkLabel1.DisabledLinkColor = Color.Black;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Name = "linkLabel1";
            linkLabel1.TabStop = true;
            linkLabel1.VisitedLinkColor = Color.Black;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxopt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(title);
            Controls.Add(convbtn);
            Controls.Add(textBoxout);
            Controls.Add(textBoxin);
            Controls.Add(buttonin);
            Controls.Add(buttonout);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonout;
        private Button buttonin;
        private TextBox textBoxin;
        private TextBox textBoxout;
        private Button convbtn;
        private Label title;
        private Label label1;
        private Label label2;
        private TextBox textBoxopt;
        private Label label3;
        private Label label4;
        private LinkLabel linkLabel1;
    }
}
