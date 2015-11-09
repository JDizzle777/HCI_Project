namespace HCI_Project
{
    partial class Drum_Pad_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Drum_Pad_Form));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBPM = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMetronome = new System.Windows.Forms.ToolStripMenuItem();
            this.turnOnMet = new System.Windows.Forms.ToolStripMenuItem();
            this.turnOffMet = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.BackColor = System.Drawing.Color.DodgerBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.DodgerBlue;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.mnuOpen,
            this.mnuSave,
            this.mnuClose});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // mnuNew
            // 
            this.mnuNew.BackColor = System.Drawing.Color.PowderBlue;
            resources.ApplyResources(this.mnuNew, "mnuNew");
            this.mnuNew.Image = global::HCI_Project.Properties.Resources.music_plus_icon_icon;
            this.mnuNew.Name = "mnuNew";
            // 
            // mnuOpen
            // 
            this.mnuOpen.BackColor = System.Drawing.Color.PowderBlue;
            this.mnuOpen.Image = global::HCI_Project.Properties.Resources.Custom_Icon_Design_Pretty_Office_9_Open_file;
            this.mnuOpen.Name = "mnuOpen";
            resources.ApplyResources(this.mnuOpen, "mnuOpen");
            // 
            // mnuSave
            // 
            this.mnuSave.BackColor = System.Drawing.Color.PowderBlue;
            this.mnuSave.Image = global::HCI_Project.Properties.Resources.Custom_Icon_Design_Pretty_Office_7_Save;
            this.mnuSave.Name = "mnuSave";
            resources.ApplyResources(this.mnuSave, "mnuSave");
            // 
            // mnuClose
            // 
            this.mnuClose.BackColor = System.Drawing.Color.PowderBlue;
            this.mnuClose.Image = global::HCI_Project.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_application_exit;
            this.mnuClose.Name = "mnuClose";
            resources.ApplyResources(this.mnuClose, "mnuClose");
            this.mnuClose.Click += new System.EventHandler(this.mnuClose_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUndo,
            this.mnuRedo,
            this.mnuRecord});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            // 
            // mnuUndo
            // 
            this.mnuUndo.BackColor = System.Drawing.Color.PowderBlue;
            this.mnuUndo.Image = global::HCI_Project.Properties.Resources.Visualpharm_Must_Have_Undo;
            this.mnuUndo.Name = "mnuUndo";
            resources.ApplyResources(this.mnuUndo, "mnuUndo");
            // 
            // mnuRedo
            // 
            this.mnuRedo.BackColor = System.Drawing.Color.PowderBlue;
            this.mnuRedo.Image = global::HCI_Project.Properties.Resources.Visualpharm_Must_Have_Redo;
            this.mnuRedo.Name = "mnuRedo";
            resources.ApplyResources(this.mnuRedo, "mnuRedo");
            // 
            // mnuRecord
            // 
            this.mnuRecord.BackColor = System.Drawing.Color.PowderBlue;
            this.mnuRecord.Image = global::HCI_Project.Properties.Resources.Icons_Land_Play_Stop_Pause_Record_Normal;
            this.mnuRecord.Name = "mnuRecord";
            resources.ApplyResources(this.mnuRecord, "mnuRecord");
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBPM,
            this.mnuMetronome});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            resources.ApplyResources(this.toolsToolStripMenuItem, "toolsToolStripMenuItem");
            // 
            // mnuBPM
            // 
            this.mnuBPM.BackColor = System.Drawing.Color.PowderBlue;
            this.mnuBPM.Name = "mnuBPM";
            resources.ApplyResources(this.mnuBPM, "mnuBPM");
            // 
            // mnuMetronome
            // 
            this.mnuMetronome.BackColor = System.Drawing.Color.PowderBlue;
            this.mnuMetronome.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.turnOnMet,
            this.turnOffMet});
            this.mnuMetronome.Name = "mnuMetronome";
            resources.ApplyResources(this.mnuMetronome, "mnuMetronome");
            // 
            // turnOnMet
            // 
            this.turnOnMet.BackColor = System.Drawing.Color.PowderBlue;
            this.turnOnMet.CheckOnClick = true;
            this.turnOnMet.Name = "turnOnMet";
            resources.ApplyResources(this.turnOnMet, "turnOnMet");
            this.turnOnMet.Click += new System.EventHandler(this.turnOnMet_Click);
            // 
            // turnOffMet
            // 
            this.turnOffMet.BackColor = System.Drawing.Color.PowderBlue;
            this.turnOffMet.CheckOnClick = true;
            this.turnOffMet.Name = "turnOffMet";
            resources.ApplyResources(this.turnOffMet, "turnOffMet");
            this.turnOffMet.Click += new System.EventHandler(this.turnOffMet_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.BackColor = System.Drawing.Color.DodgerBlue;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tutorialToolStripMenuItem});
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            // 
            // tutorialToolStripMenuItem
            // 
            this.tutorialToolStripMenuItem.BackColor = System.Drawing.Color.PowderBlue;
            this.tutorialToolStripMenuItem.Image = global::HCI_Project.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_help_about;
            this.tutorialToolStripMenuItem.Name = "tutorialToolStripMenuItem";
            resources.ApplyResources(this.tutorialToolStripMenuItem, "tutorialToolStripMenuItem");
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Drum_Pad_Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Drum_Pad_Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuNew;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuUndo;
        private System.Windows.Forms.ToolStripMenuItem mnuRedo;
        private System.Windows.Forms.ToolStripMenuItem mnuRecord;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuBPM;
        private System.Windows.Forms.ToolStripMenuItem mnuMetronome;
        private System.Windows.Forms.ToolStripMenuItem turnOnMet;
        private System.Windows.Forms.ToolStripMenuItem turnOffMet;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem tutorialToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

