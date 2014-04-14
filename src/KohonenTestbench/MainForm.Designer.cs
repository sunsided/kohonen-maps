namespace KohonenTestbench
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStripContainerMain = new System.Windows.Forms.ToolStripContainer();
            this.toolStripElements = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButtonRngs = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownButtonMetrics = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownButtonNeighborhood = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownButtonLearningRate = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownButtonRadius = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripContainerMain.TopToolStripPanel.SuspendLayout();
            this.toolStripContainerMain.SuspendLayout();
            this.toolStripElements.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainerMain
            // 
            // 
            // toolStripContainerMain.ContentPanel
            // 
            this.toolStripContainerMain.ContentPanel.Size = new System.Drawing.Size(748, 460);
            this.toolStripContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainerMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainerMain.Name = "toolStripContainerMain";
            this.toolStripContainerMain.Size = new System.Drawing.Size(748, 485);
            this.toolStripContainerMain.TabIndex = 0;
            this.toolStripContainerMain.Text = "toolStripContainer1";
            // 
            // toolStripContainerMain.TopToolStripPanel
            // 
            this.toolStripContainerMain.TopToolStripPanel.Controls.Add(this.toolStripElements);
            // 
            // toolStripElements
            // 
            this.toolStripElements.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripElements.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripElements.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButtonRngs,
            this.toolStripDropDownButtonMetrics,
            this.toolStripDropDownButtonRadius,
            this.toolStripDropDownButtonNeighborhood,
            this.toolStripDropDownButtonLearningRate});
            this.toolStripElements.Location = new System.Drawing.Point(3, 0);
            this.toolStripElements.Name = "toolStripElements";
            this.toolStripElements.Size = new System.Drawing.Size(467, 25);
            this.toolStripElements.TabIndex = 0;
            // 
            // toolStripDropDownButtonRngs
            // 
            this.toolStripDropDownButtonRngs.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonRngs.Image")));
            this.toolStripDropDownButtonRngs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonRngs.Name = "toolStripDropDownButtonRngs";
            this.toolStripDropDownButtonRngs.Size = new System.Drawing.Size(65, 22);
            this.toolStripDropDownButtonRngs.Text = "RNGs";
            // 
            // toolStripDropDownButtonMetrics
            // 
            this.toolStripDropDownButtonMetrics.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonMetrics.Image")));
            this.toolStripDropDownButtonMetrics.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonMetrics.Name = "toolStripDropDownButtonMetrics";
            this.toolStripDropDownButtonMetrics.Size = new System.Drawing.Size(75, 22);
            this.toolStripDropDownButtonMetrics.Text = "Metrics";
            // 
            // toolStripDropDownButtonNeighborhood
            // 
            this.toolStripDropDownButtonNeighborhood.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonNeighborhood.Image")));
            this.toolStripDropDownButtonNeighborhood.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonNeighborhood.Name = "toolStripDropDownButtonNeighborhood";
            this.toolStripDropDownButtonNeighborhood.Size = new System.Drawing.Size(114, 22);
            this.toolStripDropDownButtonNeighborhood.Text = "Neighborhood";
            // 
            // toolStripDropDownButtonLearningRate
            // 
            this.toolStripDropDownButtonLearningRate.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonLearningRate.Image")));
            this.toolStripDropDownButtonLearningRate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonLearningRate.Name = "toolStripDropDownButtonLearningRate";
            this.toolStripDropDownButtonLearningRate.Size = new System.Drawing.Size(108, 22);
            this.toolStripDropDownButtonLearningRate.Text = "Learning Rate";
            // 
            // toolStripDropDownButtonRadius
            // 
            this.toolStripDropDownButtonRadius.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonRadius.Image")));
            this.toolStripDropDownButtonRadius.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonRadius.Name = "toolStripDropDownButtonRadius";
            this.toolStripDropDownButtonRadius.Size = new System.Drawing.Size(71, 22);
            this.toolStripDropDownButtonRadius.Text = "Radius";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 485);
            this.Controls.Add(this.toolStripContainerMain);
            this.Name = "MainForm";
            this.Text = "Self-Organizing Maps Testbench";
            this.toolStripContainerMain.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainerMain.TopToolStripPanel.PerformLayout();
            this.toolStripContainerMain.ResumeLayout(false);
            this.toolStripContainerMain.PerformLayout();
            this.toolStripElements.ResumeLayout(false);
            this.toolStripElements.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainerMain;
        private System.Windows.Forms.ToolStrip toolStripElements;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonRngs;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonMetrics;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonNeighborhood;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonLearningRate;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonRadius;
    }
}

