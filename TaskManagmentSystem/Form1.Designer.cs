namespace TaskManagmentSystem
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TreeView treeViewTasks;
        private System.Windows.Forms.ListView listViewTaskDetails;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripButton btnAddTask;
        private System.Windows.Forms.ToolStripButton btnEditTask;
        private System.Windows.Forms.ToolStripButton btnDeleteTask;
        private System.Windows.Forms.ToolStripButton btnChangeState;
        private System.Windows.Forms.ToolStripButton btnAddSubTask;

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddTask = new System.Windows.Forms.ToolStripButton();
            this.btnEditTask = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteTask = new System.Windows.Forms.ToolStripButton();
            this.btnChangeState = new System.Windows.Forms.ToolStripButton();
            this.btnAddSubTask = new System.Windows.Forms.ToolStripButton();
            this.treeViewTasks = new System.Windows.Forms.TreeView();
            this.listViewTaskDetails = new System.Windows.Forms.ListView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddTask,
            this.btnEditTask,
            this.btnDeleteTask,
            this.btnChangeState,
            this.btnAddSubTask});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnAddTask
            // 
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(58, 22);
            this.btnAddTask.Text = "Add Task";
            // 
            // btnEditTask
            // 
            this.btnEditTask.Name = "btnEditTask";
            this.btnEditTask.Size = new System.Drawing.Size(56, 22);
            this.btnEditTask.Text = "Edit Task";
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(69, 22);
            this.btnDeleteTask.Text = "Delete Task";
            // 
            // btnChangeState
            // 
            this.btnChangeState.Name = "btnChangeState";
            this.btnChangeState.Size = new System.Drawing.Size(81, 22);
            this.btnChangeState.Text = "Change State";
            // 
            // btnAddSubTask
            // 
            this.btnAddSubTask.Name = "btnAddSubTask";
            this.btnAddSubTask.Size = new System.Drawing.Size(78, 22);
            this.btnAddSubTask.Text = "Add SubTask";
            // 
            // treeViewTasks
            // 
            this.treeViewTasks.Location = new System.Drawing.Point(12, 52);
            this.treeViewTasks.Name = "treeViewTasks";
            this.treeViewTasks.Size = new System.Drawing.Size(200, 386);
            this.treeViewTasks.TabIndex = 2;
            // 
            // listViewTaskDetails
            // 
            this.listViewTaskDetails.HideSelection = false;
            this.listViewTaskDetails.Location = new System.Drawing.Point(218, 52);
            this.listViewTaskDetails.Name = "listViewTaskDetails";
            this.listViewTaskDetails.Size = new System.Drawing.Size(570, 386);
            this.listViewTaskDetails.TabIndex = 3;
            this.listViewTaskDetails.UseCompatibleStateImageBehavior = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 4;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listViewTaskDetails);
            this.Controls.Add(this.treeViewTasks);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Task Management System";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
