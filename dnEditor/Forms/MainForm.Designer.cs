﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace dnEditor.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.dgBody = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emptyBodyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createNewInstructionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewExceptionHandlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgVariables = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emptyVariableMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createNewVariableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.rtbILSpy = new System.Windows.Forms.RichTextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.lblAnalysis = new System.Windows.Forms.Label();
            this.listAnalysis = new System.Windows.Forms.ListView();
            this.columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgDetails = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.cbSearchType = new System.Windows.Forms.ToolStripComboBox();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.lblMagicRegex = new System.Windows.Forms.ToolStripLabel();
            this.txtMagicRegex = new System.Windows.Forms.ToolStripTextBox();
            this.instructionMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertBeforeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertAfterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.nopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.saveInstructionsToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.goToEntryPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToModuleCCtorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.collapseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collapseAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.variableMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.exceptionHandlerMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgBody)).BeginInit();
            this.emptyBodyMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVariables)).BeginInit();
            this.emptyVariableMenu.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetails)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.instructionMenu.SuspendLayout();
            this.treeMenu.SuspendLayout();
            this.variableMenu.SuspendLayout();
            this.exceptionHandlerMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.HideSelection = false;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList2;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.ShowNodeToolTips = true;
            this.treeView1.Size = new System.Drawing.Size(242, 393);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterExpand);
            this.treeView1.NodeMouseHover += new System.Windows.Forms.TreeNodeMouseHoverEventHandler(this.treeView1_NodeMouseHover);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseDoubleClick);
            this.treeView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView_DragDrop);
            this.treeView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView_DragEnter);
            this.treeView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeView1_KeyDown);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Assembly.png");
            this.imageList2.Images.SetKeyName(1, "AssemblyList.png");
            this.imageList2.Images.SetKeyName(2, "AssemblyWarning.png");
            this.imageList2.Images.SetKeyName(3, "Back.png");
            this.imageList2.Images.SetKeyName(4, "Break.png");
            this.imageList2.Images.SetKeyName(5, "Breakpoint.png");
            this.imageList2.Images.SetKeyName(6, "Class.png");
            this.imageList2.Images.SetKeyName(7, "ClearSearch.png");
            this.imageList2.Images.SetKeyName(8, "Constructor.png");
            this.imageList2.Images.SetKeyName(9, "CurrentLine.png");
            this.imageList2.Images.SetKeyName(10, "Delegate.png");
            this.imageList2.Images.SetKeyName(11, "Delete.png");
            this.imageList2.Images.SetKeyName(12, "DisabledBreakpoint.png");
            this.imageList2.Images.SetKeyName(13, "Enum.png");
            this.imageList2.Images.SetKeyName(14, "EnumValue.png");
            this.imageList2.Images.SetKeyName(15, "Event.png");
            this.imageList2.Images.SetKeyName(16, "ExtensionMethod.png");
            this.imageList2.Images.SetKeyName(17, "Field.png");
            this.imageList2.Images.SetKeyName(18, "FieldReadOnly.png");
            this.imageList2.Images.SetKeyName(19, "Find.png");
            this.imageList2.Images.SetKeyName(20, "FindAssembly.png");
            this.imageList2.Images.SetKeyName(21, "Folder.Closed.png");
            this.imageList2.Images.SetKeyName(22, "Folder.Open.png");
            this.imageList2.Images.SetKeyName(23, "Forward.png");
            this.imageList2.Images.SetKeyName(24, "ILSpy.ico");
            this.imageList2.Images.SetKeyName(25, "ILSpy-Large.ico");
            this.imageList2.Images.SetKeyName(26, "Indexer.png");
            this.imageList2.Images.SetKeyName(27, "Interface.png");
            this.imageList2.Images.SetKeyName(28, "Library.png");
            this.imageList2.Images.SetKeyName(29, "Literal.png");
            this.imageList2.Images.SetKeyName(30, "Method.png");
            this.imageList2.Images.SetKeyName(31, "NameSpace.png");
            this.imageList2.Images.SetKeyName(32, "OK.png");
            this.imageList2.Images.SetKeyName(33, "Open.png");
            this.imageList2.Images.SetKeyName(34, "Operator.png");
            this.imageList2.Images.SetKeyName(35, "OverlayCompilerControlled.png");
            this.imageList2.Images.SetKeyName(36, "OverlayInternal.png");
            this.imageList2.Images.SetKeyName(37, "OverlayPrivate.png");
            this.imageList2.Images.SetKeyName(38, "OverlayProtected.png");
            this.imageList2.Images.SetKeyName(39, "OverlayProtectedInternal.png");
            this.imageList2.Images.SetKeyName(40, "OverlayStatic.png");
            this.imageList2.Images.SetKeyName(41, "PInvokeMethod.png");
            this.imageList2.Images.SetKeyName(42, "PrivateInternal.png");
            this.imageList2.Images.SetKeyName(43, "Property.png");
            this.imageList2.Images.SetKeyName(44, "ReferenceFolder.Closed.png");
            this.imageList2.Images.SetKeyName(45, "ReferenceFolder.Open.png");
            this.imageList2.Images.SetKeyName(46, "Refresh.png");
            this.imageList2.Images.SetKeyName(47, "Resource.png");
            this.imageList2.Images.SetKeyName(48, "ResourceImage.png");
            this.imageList2.Images.SetKeyName(49, "ResourceResourcesFile.png");
            this.imageList2.Images.SetKeyName(50, "ResourceXml.png");
            this.imageList2.Images.SetKeyName(51, "ResourceXsd.png");
            this.imageList2.Images.SetKeyName(52, "ResourceXsl.png");
            this.imageList2.Images.SetKeyName(53, "ResourceXslt.png");
            this.imageList2.Images.SetKeyName(54, "SaveFile.png");
            this.imageList2.Images.SetKeyName(55, "Search.png");
            this.imageList2.Images.SetKeyName(56, "StaticClass.png");
            this.imageList2.Images.SetKeyName(57, "Struct.png");
            this.imageList2.Images.SetKeyName(58, "SubTypes.png");
            this.imageList2.Images.SetKeyName(59, "SuperTypes.png");
            this.imageList2.Images.SetKeyName(60, "ViewCode.png");
            this.imageList2.Images.SetKeyName(61, "VirtualMethod.png");
            // 
            // dgBody
            // 
            this.dgBody.AllowUserToAddRows = false;
            this.dgBody.AllowUserToDeleteRows = false;
            this.dgBody.AllowUserToResizeColumns = false;
            this.dgBody.AllowUserToResizeRows = false;
            this.dgBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgBody.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgBody.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgBody.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBody.ColumnHeadersVisible = false;
            this.dgBody.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.offset,
            this.opcode,
            this.operand});
            this.dgBody.ContextMenuStrip = this.emptyBodyMenu;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgBody.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgBody.Location = new System.Drawing.Point(0, 0);
            this.dgBody.Name = "dgBody";
            this.dgBody.ReadOnly = true;
            this.dgBody.RowHeadersVisible = false;
            this.dgBody.RowTemplate.Height = 16;
            this.dgBody.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgBody.Size = new System.Drawing.Size(554, 367);
            this.dgBody.TabIndex = 1;
            this.dgBody.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBody_CellDoubleClick);
            this.dgBody.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgBody_CellMouseDown);
            this.dgBody.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgBody_MouseClick);
            // 
            // index
            // 
            this.index.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.index.HeaderText = "Index";
            this.index.Name = "index";
            this.index.ReadOnly = true;
            this.index.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.index.Width = 5;
            // 
            // offset
            // 
            this.offset.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.offset.HeaderText = "Offset";
            this.offset.Name = "offset";
            this.offset.ReadOnly = true;
            this.offset.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.offset.Width = 5;
            // 
            // opcode
            // 
            this.opcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.opcode.HeaderText = "OpCode";
            this.opcode.Name = "opcode";
            this.opcode.ReadOnly = true;
            this.opcode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.opcode.Width = 5;
            // 
            // operand
            // 
            this.operand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.operand.HeaderText = "Operand";
            this.operand.Name = "operand";
            this.operand.ReadOnly = true;
            this.operand.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // emptyBodyMenu
            // 
            this.emptyBodyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewInstructionToolStripMenuItem,
            this.createNewExceptionHandlerToolStripMenuItem});
            this.emptyBodyMenu.Name = "emptyBodyMenu";
            this.emptyBodyMenu.Size = new System.Drawing.Size(231, 48);
            this.emptyBodyMenu.Opened += new System.EventHandler(this.emptyBodyMenu_Opened);
            // 
            // createNewInstructionToolStripMenuItem
            // 
            this.createNewInstructionToolStripMenuItem.Name = "createNewInstructionToolStripMenuItem";
            this.createNewInstructionToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.createNewInstructionToolStripMenuItem.Text = "Create new instruction";
            this.createNewInstructionToolStripMenuItem.Click += new System.EventHandler(this.createNewInstructionToolStripMenuItem_Click);
            // 
            // createNewExceptionHandlerToolStripMenuItem
            // 
            this.createNewExceptionHandlerToolStripMenuItem.Name = "createNewExceptionHandlerToolStripMenuItem";
            this.createNewExceptionHandlerToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.createNewExceptionHandlerToolStripMenuItem.Text = "Create new exception handler";
            this.createNewExceptionHandlerToolStripMenuItem.Click += new System.EventHandler(this.createNewExceptionHandlerToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(819, 399);
            this.splitContainer1.SplitterDistance = 247;
            this.splitContainer1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(562, 393);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgBody);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(554, 367);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "IL";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgVariables);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(554, 367);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Variables";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgVariables
            // 
            this.dgVariables.AllowUserToAddRows = false;
            this.dgVariables.AllowUserToDeleteRows = false;
            this.dgVariables.AllowUserToResizeColumns = false;
            this.dgVariables.AllowUserToResizeRows = false;
            this.dgVariables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgVariables.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgVariables.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgVariables.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgVariables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVariables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgVariables.ContextMenuStrip = this.emptyVariableMenu;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgVariables.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgVariables.Location = new System.Drawing.Point(0, 0);
            this.dgVariables.Name = "dgVariables";
            this.dgVariables.ReadOnly = true;
            this.dgVariables.RowHeadersVisible = false;
            this.dgVariables.RowTemplate.Height = 16;
            this.dgVariables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVariables.Size = new System.Drawing.Size(554, 367);
            this.dgVariables.TabIndex = 2;
            this.dgVariables.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVariables_CellDoubleClick);
            this.dgVariables.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgVariables_CellMouseDown);
            this.dgVariables.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgVariables_MouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "Index";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 58;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "Variable name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.Width = 99;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Variable type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // emptyVariableMenu
            // 
            this.emptyVariableMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewVariableToolStripMenuItem});
            this.emptyVariableMenu.Name = "emptyBodyMenu";
            this.emptyVariableMenu.Size = new System.Drawing.Size(134, 26);
            this.emptyVariableMenu.Opened += new System.EventHandler(this.createNewVariableToolStripMenuItem_Opened);
            // 
            // createNewVariableToolStripMenuItem
            // 
            this.createNewVariableToolStripMenuItem.Name = "createNewVariableToolStripMenuItem";
            this.createNewVariableToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.createNewVariableToolStripMenuItem.Text = "Create new";
            this.createNewVariableToolStripMenuItem.Click += new System.EventHandler(this.createNewVariableToolStripMenuItem_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.rtbILSpy);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(554, 367);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "ILSpy";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // rtbILSpy
            // 
            this.rtbILSpy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbILSpy.BackColor = System.Drawing.SystemColors.Info;
            this.rtbILSpy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbILSpy.DetectUrls = false;
            this.rtbILSpy.Location = new System.Drawing.Point(3, 3);
            this.rtbILSpy.Name = "rtbILSpy";
            this.rtbILSpy.ReadOnly = true;
            this.rtbILSpy.Size = new System.Drawing.Size(548, 361);
            this.rtbILSpy.TabIndex = 0;
            this.rtbILSpy.Text = "";
            this.rtbILSpy.WordWrap = false;
            this.rtbILSpy.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rtbILSpy_MouseDown);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage5.Controls.Add(this.lblAnalysis);
            this.tabPage5.Controls.Add(this.listAnalysis);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(554, 367);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "Analysis";
            // 
            // lblAnalysis
            // 
            this.lblAnalysis.AutoSize = true;
            this.lblAnalysis.Location = new System.Drawing.Point(7, 6);
            this.lblAnalysis.Name = "lblAnalysis";
            this.lblAnalysis.Size = new System.Drawing.Size(45, 13);
            this.lblAnalysis.TabIndex = 1;
            this.lblAnalysis.Text = "Empty...";
            // 
            // listAnalysis
            // 
            this.listAnalysis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listAnalysis.BackColor = System.Drawing.SystemColors.Info;
            this.listAnalysis.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader});
            this.listAnalysis.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listAnalysis.Location = new System.Drawing.Point(3, 31);
            this.listAnalysis.Name = "listAnalysis";
            this.listAnalysis.ShowGroups = false;
            this.listAnalysis.Size = new System.Drawing.Size(548, 333);
            this.listAnalysis.TabIndex = 0;
            this.listAnalysis.UseCompatibleStateImageBehavior = false;
            this.listAnalysis.View = System.Windows.Forms.View.Details;
            this.listAnalysis.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listAnalysis_MouseDoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgDetails);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(554, 367);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Details";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgDetails
            // 
            this.dgDetails.AllowUserToAddRows = false;
            this.dgDetails.AllowUserToDeleteRows = false;
            this.dgDetails.AllowUserToResizeColumns = false;
            this.dgDetails.AllowUserToResizeRows = false;
            this.dgDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgDetails.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetails.ColumnHeadersVisible = false;
            this.dgDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDetails.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgDetails.Location = new System.Drawing.Point(0, 0);
            this.dgDetails.Name = "dgDetails";
            this.dgDetails.ReadOnly = true;
            this.dgDetails.RowHeadersVisible = false;
            this.dgDetails.RowTemplate.Height = 16;
            this.dgDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDetails.Size = new System.Drawing.Size(554, 367);
            this.dgDetails.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn9.HeaderText = "Index";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn9.Width = 5;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn10.HeaderText = "Offset";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn10.Width = 5;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn11.HeaderText = "OpCode";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn11.Width = 5;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn12.HeaderText = "Operand";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Green;
            this.imageList1.Images.SetKeyName(0, "Class.Browser16.1.bmp");
            this.imageList1.Images.SetKeyName(1, "Class.Browser16.2.bmp");
            this.imageList1.Images.SetKeyName(2, "Class.Browser16.3.bmp");
            this.imageList1.Images.SetKeyName(3, "Class.Browser16.4.bmp");
            this.imageList1.Images.SetKeyName(4, "Class.Browser16.5.bmp");
            this.imageList1.Images.SetKeyName(5, "Class.Browser16.6.bmp");
            this.imageList1.Images.SetKeyName(6, "Class.Browser16.7.bmp");
            this.imageList1.Images.SetKeyName(7, "Class.Browser16.8.bmp");
            this.imageList1.Images.SetKeyName(8, "Class.Browser16.9.bmp");
            this.imageList1.Images.SetKeyName(9, "Class.Browser16.10.bmp");
            this.imageList1.Images.SetKeyName(10, "Class.Browser16.11.bmp");
            this.imageList1.Images.SetKeyName(11, "Class.Browser16.12.bmp");
            this.imageList1.Images.SetKeyName(12, "Class.Browser16.13.bmp");
            this.imageList1.Images.SetKeyName(13, "Class.Browser16.14.bmp");
            this.imageList1.Images.SetKeyName(14, "Class.Browser16.15.bmp");
            this.imageList1.Images.SetKeyName(15, "Class.Browser16.16.bmp");
            this.imageList1.Images.SetKeyName(16, "Class.Browser16.17.bmp");
            this.imageList1.Images.SetKeyName(17, "Class.Browser16.18.bmp");
            this.imageList1.Images.SetKeyName(18, "Class.Browser16.19.bmp");
            this.imageList1.Images.SetKeyName(19, "Class.Browser16.20.bmp");
            this.imageList1.Images.SetKeyName(20, "Class.Browser16.21.bmp");
            this.imageList1.Images.SetKeyName(21, "Class.Browser16.22.bmp");
            this.imageList1.Images.SetKeyName(22, "Class.Browser16.23.bmp");
            this.imageList1.Images.SetKeyName(23, "Class.Browser16.24.bmp");
            this.imageList1.Images.SetKeyName(24, "Class.Browser16.25.bmp");
            this.imageList1.Images.SetKeyName(25, "Class.Browser16.26.bmp");
            this.imageList1.Images.SetKeyName(26, "Class.Browser16.27.bmp");
            this.imageList1.Images.SetKeyName(27, "Class.Browser16.28.bmp");
            this.imageList1.Images.SetKeyName(28, "Class.Browser16.29.bmp");
            this.imageList1.Images.SetKeyName(29, "Class.Browser16.30.bmp");
            this.imageList1.Images.SetKeyName(30, "Class.Browser16.31.bmp");
            this.imageList1.Images.SetKeyName(31, "Class.Browser16.32.bmp");
            this.imageList1.Images.SetKeyName(32, "Class.Browser16.33.bmp");
            this.imageList1.Images.SetKeyName(33, "Class.Browser16.34.bmp");
            this.imageList1.Images.SetKeyName(34, "Class.Browser16.35.bmp");
            this.imageList1.Images.SetKeyName(35, "Class.Browser16.36.bmp");
            this.imageList1.Images.SetKeyName(36, "Class.Browser16.37.bmp");
            this.imageList1.Images.SetKeyName(37, "Class.Browser16.38.bmp");
            this.imageList1.Images.SetKeyName(38, "Class.Browser16.39.bmp");
            this.imageList1.Images.SetKeyName(39, "Class.Browser16.40.bmp");
            this.imageList1.Images.SetKeyName(40, "Class.Browser16.41.bmp");
            this.imageList1.Images.SetKeyName(41, "Class.Browser16.42.bmp");
            this.imageList1.Images.SetKeyName(42, "Class.Browser16.43.bmp");
            this.imageList1.Images.SetKeyName(43, "Class.Browser16.44.bmp");
            this.imageList1.Images.SetKeyName(44, "Class.Browser16.45.bmp");
            this.imageList1.Images.SetKeyName(45, "Class.Browser16.46.bmp");
            this.imageList1.Images.SetKeyName(46, "Class.Browser16.47.bmp");
            this.imageList1.Images.SetKeyName(47, "Class.Browser16.48.bmp");
            this.imageList1.Images.SetKeyName(48, "Class.Browser16.49.bmp");
            this.imageList1.Images.SetKeyName(49, "Class.Browser16.50.bmp");
            this.imageList1.Images.SetKeyName(50, "Class.Browser16.51.bmp");
            this.imageList1.Images.SetKeyName(51, "Class.Browser16.52.bmp");
            this.imageList1.Images.SetKeyName(52, "Class.Browser16.53.bmp");
            this.imageList1.Images.SetKeyName(53, "Class.Browser16.54.bmp");
            this.imageList1.Images.SetKeyName(54, "Class.Browser16.55.bmp");
            this.imageList1.Images.SetKeyName(55, "Class.Browser16.56.bmp");
            this.imageList1.Images.SetKeyName(56, "Class.Browser16.57.bmp");
            this.imageList1.Images.SetKeyName(57, "Class.Browser16.58.bmp");
            this.imageList1.Images.SetKeyName(58, "Class.Browser16.59.bmp");
            this.imageList1.Images.SetKeyName(59, "Class.Browser16.60.bmp");
            this.imageList1.Images.SetKeyName(60, "Class.Browser16.61.bmp");
            this.imageList1.Images.SetKeyName(61, "Class.Browser16.62.bmp");
            this.imageList1.Images.SetKeyName(62, "Class.Browser16.63.bmp");
            this.imageList1.Images.SetKeyName(63, "Class.Browser16.64.bmp");
            this.imageList1.Images.SetKeyName(64, "Class.Browser16.65.bmp");
            this.imageList1.Images.SetKeyName(65, "Class.Browser16.66.bmp");
            this.imageList1.Images.SetKeyName(66, "Class.Browser16.67.bmp");
            this.imageList1.Images.SetKeyName(67, "Class.Browser16.68.bmp");
            this.imageList1.Images.SetKeyName(68, "Class.Browser16.69.bmp");
            this.imageList1.Images.SetKeyName(69, "Class.Browser16.70.bmp");
            this.imageList1.Images.SetKeyName(70, "Class.Browser16.71.bmp");
            this.imageList1.Images.SetKeyName(71, "Class.Browser16.72.bmp");
            this.imageList1.Images.SetKeyName(72, "Class.Browser16.73.bmp");
            this.imageList1.Images.SetKeyName(73, "Class.Browser16.74.bmp");
            this.imageList1.Images.SetKeyName(74, "Class.Browser16.75.bmp");
            this.imageList1.Images.SetKeyName(75, "Class.Browser16.76.bmp");
            this.imageList1.Images.SetKeyName(76, "Class.Browser16.77.bmp");
            this.imageList1.Images.SetKeyName(77, "Class.Browser16.78.bmp");
            this.imageList1.Images.SetKeyName(78, "Class.Browser16.79.bmp");
            this.imageList1.Images.SetKeyName(79, "Class.Browser16.80.bmp");
            this.imageList1.Images.SetKeyName(80, "Class.Browser16.81.bmp");
            this.imageList1.Images.SetKeyName(81, "Class.Browser16.82.bmp");
            this.imageList1.Images.SetKeyName(82, "Class.Browser16.83.bmp");
            this.imageList1.Images.SetKeyName(83, "Class.Browser16.84.bmp");
            this.imageList1.Images.SetKeyName(84, "Class.Browser16.85.bmp");
            this.imageList1.Images.SetKeyName(85, "Class.Browser16.86.bmp");
            this.imageList1.Images.SetKeyName(86, "Class.Browser16.87.bmp");
            this.imageList1.Images.SetKeyName(87, "Class.Browser16.88.bmp");
            this.imageList1.Images.SetKeyName(88, "Class.Browser16.89.bmp");
            this.imageList1.Images.SetKeyName(89, "Class.Browser16.90.bmp");
            this.imageList1.Images.SetKeyName(90, "Class.Browser16.91.bmp");
            this.imageList1.Images.SetKeyName(91, "Class.Browser16.92.bmp");
            this.imageList1.Images.SetKeyName(92, "Class.Browser16.93.bmp");
            this.imageList1.Images.SetKeyName(93, "Class.Browser16.94.bmp");
            this.imageList1.Images.SetKeyName(94, "Class.Browser16.95.bmp");
            this.imageList1.Images.SetKeyName(95, "Class.Browser16.96.bmp");
            this.imageList1.Images.SetKeyName(96, "Class.Browser16.97.bmp");
            this.imageList1.Images.SetKeyName(97, "Class.Browser16.98.bmp");
            this.imageList1.Images.SetKeyName(98, "Class.Browser16.99.bmp");
            this.imageList1.Images.SetKeyName(99, "Class.Browser16.100.bmp");
            this.imageList1.Images.SetKeyName(100, "Class.Browser16.101.bmp");
            this.imageList1.Images.SetKeyName(101, "Class.Browser16.102.bmp");
            this.imageList1.Images.SetKeyName(102, "Class.Browser16.103.bmp");
            this.imageList1.Images.SetKeyName(103, "Class.Browser16.104.bmp");
            this.imageList1.Images.SetKeyName(104, "Class.Browser16.105.bmp");
            this.imageList1.Images.SetKeyName(105, "Class.Browser16.106.bmp");
            this.imageList1.Images.SetKeyName(106, "Class.Browser16.107.bmp");
            this.imageList1.Images.SetKeyName(107, "Class.Browser16.108.bmp");
            this.imageList1.Images.SetKeyName(108, "Class.Browser16.109.bmp");
            this.imageList1.Images.SetKeyName(109, "Class.Browser16.110.bmp");
            this.imageList1.Images.SetKeyName(110, "Class.Browser16.111.bmp");
            this.imageList1.Images.SetKeyName(111, "Class.Browser16.112.bmp");
            this.imageList1.Images.SetKeyName(112, "Class.Browser16.113.bmp");
            this.imageList1.Images.SetKeyName(113, "Class.Browser16.114.bmp");
            this.imageList1.Images.SetKeyName(114, "Class.Browser16.115.bmp");
            this.imageList1.Images.SetKeyName(115, "Class.Browser16.116.bmp");
            this.imageList1.Images.SetKeyName(116, "Class.Browser16.117.bmp");
            this.imageList1.Images.SetKeyName(117, "Class.Browser16.118.bmp");
            this.imageList1.Images.SetKeyName(118, "Class.Browser16.119.bmp");
            this.imageList1.Images.SetKeyName(119, "Class.Browser16.120.bmp");
            this.imageList1.Images.SetKeyName(120, "Class.Browser16.121.bmp");
            this.imageList1.Images.SetKeyName(121, "Class.Browser16.122.bmp");
            this.imageList1.Images.SetKeyName(122, "Class.Browser16.123.bmp");
            this.imageList1.Images.SetKeyName(123, "Class.Browser16.124.bmp");
            this.imageList1.Images.SetKeyName(124, "Class.Browser16.125.bmp");
            this.imageList1.Images.SetKeyName(125, "Class.Browser16.126.bmp");
            this.imageList1.Images.SetKeyName(126, "Class.Browser16.127.bmp");
            this.imageList1.Images.SetKeyName(127, "Class.Browser16.128.bmp");
            this.imageList1.Images.SetKeyName(128, "Class.Browser16.129.bmp");
            this.imageList1.Images.SetKeyName(129, "Class.Browser16.130.bmp");
            this.imageList1.Images.SetKeyName(130, "Class.Browser16.131.bmp");
            this.imageList1.Images.SetKeyName(131, "Class.Browser16.132.bmp");
            this.imageList1.Images.SetKeyName(132, "Class.Browser16.133.bmp");
            this.imageList1.Images.SetKeyName(133, "Class.Browser16.134.bmp");
            this.imageList1.Images.SetKeyName(134, "Class.Browser16.135.bmp");
            this.imageList1.Images.SetKeyName(135, "Class.Browser16.136.bmp");
            this.imageList1.Images.SetKeyName(136, "Class.Browser16.137.bmp");
            this.imageList1.Images.SetKeyName(137, "Class.Browser16.138.bmp");
            this.imageList1.Images.SetKeyName(138, "Class.Browser16.139.bmp");
            this.imageList1.Images.SetKeyName(139, "Class.Browser16.140.bmp");
            this.imageList1.Images.SetKeyName(140, "Class.Browser16.141.bmp");
            this.imageList1.Images.SetKeyName(141, "Class.Browser16.142.bmp");
            this.imageList1.Images.SetKeyName(142, "Class.Browser16.143.bmp");
            this.imageList1.Images.SetKeyName(143, "Class.Browser16.144.bmp");
            this.imageList1.Images.SetKeyName(144, "Class.Browser16.145.bmp");
            this.imageList1.Images.SetKeyName(145, "Class.Browser16.146.bmp");
            this.imageList1.Images.SetKeyName(146, "Class.Browser16.147.bmp");
            this.imageList1.Images.SetKeyName(147, "Class.Browser16.148.bmp");
            this.imageList1.Images.SetKeyName(148, "Class.Browser16.149.bmp");
            this.imageList1.Images.SetKeyName(149, "Class.Browser16.150.bmp");
            this.imageList1.Images.SetKeyName(150, "Class.Browser16.151.bmp");
            this.imageList1.Images.SetKeyName(151, "Class.Browser16.152.bmp");
            this.imageList1.Images.SetKeyName(152, "Class.Browser16.153.bmp");
            this.imageList1.Images.SetKeyName(153, "Class.Browser16.154.bmp");
            this.imageList1.Images.SetKeyName(154, "Class.Browser16.155.bmp");
            this.imageList1.Images.SetKeyName(155, "Class.Browser16.156.bmp");
            this.imageList1.Images.SetKeyName(156, "Class.Browser16.157.bmp");
            this.imageList1.Images.SetKeyName(157, "Class.Browser16.158.bmp");
            this.imageList1.Images.SetKeyName(158, "Class.Browser16.159.bmp");
            this.imageList1.Images.SetKeyName(159, "Class.Browser16.160.bmp");
            this.imageList1.Images.SetKeyName(160, "Class.Browser16.161.bmp");
            this.imageList1.Images.SetKeyName(161, "Class.Browser16.162.bmp");
            this.imageList1.Images.SetKeyName(162, "Class.Browser16.163.bmp");
            this.imageList1.Images.SetKeyName(163, "Class.Browser16.164.bmp");
            this.imageList1.Images.SetKeyName(164, "Class.Browser16.165.bmp");
            this.imageList1.Images.SetKeyName(165, "Class.Browser16.166.bmp");
            this.imageList1.Images.SetKeyName(166, "Class.Browser16.167.bmp");
            this.imageList1.Images.SetKeyName(167, "Class.Browser16.168.bmp");
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpen,
            this.btnSave,
            this.btnAbout,
            this.toolStripSeparator4,
            this.cbSearchType,
            this.txtSearch,
            this.toolStripSeparator5,
            this.btnSearch,
            this.toolStripSeparator6,
            this.toolStripSeparator8,
            this.lblMagicRegex,
            this.txtMagicRegex});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(843, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnOpen
            // 
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Green;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(56, 22);
            this.btnOpen.Text = "Open";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(51, 22);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(44, 22);
            this.btnAbout.Text = "About";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // cbSearchType
            // 
            this.cbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchType.Items.AddRange(new object[] {
            "Any name",
            "MDToken",
            "String (global)",
            "String",
            "OpCode",
            "Operand"});
            this.cbSearchType.Name = "cbSearchType";
            this.cbSearchType.Size = new System.Drawing.Size(121, 25);
            // 
            // txtSearch
            // 
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(135, 25);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSearch
            // 
            this.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(49, 22);
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // lblMagicRegex
            // 
            this.lblMagicRegex.Name = "lblMagicRegex";
            this.lblMagicRegex.Size = new System.Drawing.Size(77, 22);
            this.lblMagicRegex.Text = "Magic Regex:";
            this.lblMagicRegex.ToolTipText = "All symbols matching this regex will not be displayed";
            this.lblMagicRegex.Click += new System.EventHandler(this.lblMagicRegex_Click);
            // 
            // txtMagicRegex
            // 
            this.txtMagicRegex.Name = "txtMagicRegex";
            this.txtMagicRegex.Size = new System.Drawing.Size(100, 25);
            this.txtMagicRegex.TextChanged += new System.EventHandler(this.txtMagicRegex_TextChanged);
            // 
            // instructionMenu
            // 
            this.instructionMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.insertBeforeToolStripMenuItem,
            this.insertAfterToolStripMenuItem,
            this.toolStripSeparator1,
            this.nopToolStripMenuItem,
            this.toolStripSeparator2,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator3,
            this.removeToolStripMenuItem,
            this.toolStripSeparator9,
            this.saveInstructionsToFileToolStripMenuItem});
            this.instructionMenu.Name = "instructionMenu";
            this.instructionMenu.Size = new System.Drawing.Size(197, 226);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // insertBeforeToolStripMenuItem
            // 
            this.insertBeforeToolStripMenuItem.Name = "insertBeforeToolStripMenuItem";
            this.insertBeforeToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.insertBeforeToolStripMenuItem.Text = "Insert Before";
            this.insertBeforeToolStripMenuItem.Click += new System.EventHandler(this.insertBeforeToolStripMenuItem_Click);
            // 
            // insertAfterToolStripMenuItem
            // 
            this.insertAfterToolStripMenuItem.Name = "insertAfterToolStripMenuItem";
            this.insertAfterToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.insertAfterToolStripMenuItem.Text = "Insert After";
            this.insertAfterToolStripMenuItem.Click += new System.EventHandler(this.insertAfterToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(193, 6);
            // 
            // nopToolStripMenuItem
            // 
            this.nopToolStripMenuItem.Name = "nopToolStripMenuItem";
            this.nopToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.nopToolStripMenuItem.Text = "Nop";
            this.nopToolStripMenuItem.Click += new System.EventHandler(this.nopToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(193, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(193, 6);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(193, 6);
            // 
            // saveInstructionsToFileToolStripMenuItem
            // 
            this.saveInstructionsToFileToolStripMenuItem.Name = "saveInstructionsToFileToolStripMenuItem";
            this.saveInstructionsToFileToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.saveInstructionsToFileToolStripMenuItem.Text = "Save instructions to file";
            this.saveInstructionsToFileToolStripMenuItem.Click += new System.EventHandler(this.saveInstructionsToFileToolStripMenuItem_Click);
            // 
            // treeMenu
            // 
            this.treeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToEntryPointToolStripMenuItem,
            this.goToModuleCCtorToolStripMenuItem,
            this.toolStripSeparator11,
            this.collapseToolStripMenuItem,
            this.expandToolStripMenuItem,
            this.collapseAllToolStripMenuItem,
            this.toolStripSeparator7,
            this.closeToolStripMenuItem});
            this.treeMenu.Name = "treeMenu";
            this.treeMenu.Size = new System.Drawing.Size(179, 148);
            this.treeMenu.Opened += new System.EventHandler(this.treeMenu_Opened);
            // 
            // goToEntryPointToolStripMenuItem
            // 
            this.goToEntryPointToolStripMenuItem.Name = "goToEntryPointToolStripMenuItem";
            this.goToEntryPointToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.goToEntryPointToolStripMenuItem.Text = "Go to EntryPoint";
            this.goToEntryPointToolStripMenuItem.Click += new System.EventHandler(this.goToEntryPointToolStripMenuItem_Click);
            // 
            // goToModuleCCtorToolStripMenuItem
            // 
            this.goToModuleCCtorToolStripMenuItem.Name = "goToModuleCCtorToolStripMenuItem";
            this.goToModuleCCtorToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.goToModuleCCtorToolStripMenuItem.Text = "Go to ModuleCCtor";
            this.goToModuleCCtorToolStripMenuItem.Click += new System.EventHandler(this.goToModuleCCtorToolStripMenuItem_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(175, 6);
            // 
            // collapseToolStripMenuItem
            // 
            this.collapseToolStripMenuItem.Name = "collapseToolStripMenuItem";
            this.collapseToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.collapseToolStripMenuItem.Text = "Collapse";
            this.collapseToolStripMenuItem.Click += new System.EventHandler(this.collapseToolStripMenuItem_Click);
            // 
            // expandToolStripMenuItem
            // 
            this.expandToolStripMenuItem.Name = "expandToolStripMenuItem";
            this.expandToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.expandToolStripMenuItem.Text = "Expand";
            this.expandToolStripMenuItem.Click += new System.EventHandler(this.expandToolStripMenuItem_Click);
            // 
            // collapseAllToolStripMenuItem
            // 
            this.collapseAllToolStripMenuItem.Name = "collapseAllToolStripMenuItem";
            this.collapseAllToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.collapseAllToolStripMenuItem.Text = "Collapse all";
            this.collapseAllToolStripMenuItem.Click += new System.EventHandler(this.collapseAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(175, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.closeToolStripMenuItem.Text = "Close assembly";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // variableMenu
            // 
            this.variableMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripSeparator10,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripSeparator12,
            this.toolStripMenuItem8});
            this.variableMenu.Name = "instructionMenu";
            this.variableMenu.Size = new System.Drawing.Size(141, 170);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.toolStripMenuItem1.Text = "Edit";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.editVariableToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(140, 22);
            this.toolStripMenuItem2.Text = "Insert Before";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.insertVariableBeforeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(140, 22);
            this.toolStripMenuItem3.Text = "Insert After";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.insertVariableAfterToolStripMenuItem_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(137, 6);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(140, 22);
            this.toolStripMenuItem5.Text = "Cut";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.cutVariableToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(140, 22);
            this.toolStripMenuItem6.Text = "Copy";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.copyVariableToolStripMenuItem_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(140, 22);
            this.toolStripMenuItem7.Text = "Paste";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.pasteVariableToolStripMenuItem_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(137, 6);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(140, 22);
            this.toolStripMenuItem8.Text = "Remove";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.deleteVariableToolStripMenuItem_Click);
            // 
            // exceptionHandlerMenu
            // 
            this.exceptionHandlerMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem1,
            this.removeToolStripMenuItem1});
            this.exceptionHandlerMenu.Name = "exceptionHandlerMenu";
            this.exceptionHandlerMenu.Size = new System.Drawing.Size(118, 48);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.editToolStripMenuItem1.Text = "Edit";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.editToolStripMenuItem1_Click);
            // 
            // removeToolStripMenuItem1
            // 
            this.removeToolStripMenuItem1.Name = "removeToolStripMenuItem1";
            this.removeToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem1.Text = "Remove";
            this.removeToolStripMenuItem1.Click += new System.EventHandler(this.removeToolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(843, 439);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "dnEditor v0.75 Beta ~ViRb3";
            ((System.ComponentModel.ISupportInitialize)(this.dgBody)).EndInit();
            this.emptyBodyMenu.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgVariables)).EndInit();
            this.emptyVariableMenu.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDetails)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.instructionMenu.ResumeLayout(false);
            this.treeMenu.ResumeLayout(false);
            this.variableMenu.ResumeLayout(false);
            this.exceptionHandlerMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TreeView treeView1;
        public DataGridView dgBody;
        private SplitContainer splitContainer1;
        private ImageList imageList1;
        private ImageList imageList2;
        private DataGridViewTextBoxColumn index;
        private DataGridViewTextBoxColumn offset;
        private DataGridViewTextBoxColumn opcode;
        private DataGridViewTextBoxColumn operand;
        private ToolStrip toolStrip1;
        private ToolStripButton btnSave;
        private ToolStripButton btnOpen;
        private ContextMenuStrip instructionMenu;
        private ToolStripMenuItem removeToolStripMenuItem;
        private ToolStripMenuItem insertBeforeToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem insertAfterToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem nopToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btnAbout;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripComboBox cbSearchType;
        private ToolStripTextBox txtSearch;
        private ToolStripButton btnSearch;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripSeparator toolStripSeparator6;
        private ContextMenuStrip treeMenu;
        private ToolStripMenuItem collapseAllToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem collapseToolStripMenuItem;
        private ToolStripMenuItem expandToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripLabel lblMagicRegex;
        private ToolStripTextBox txtMagicRegex;
        private ContextMenuStrip emptyBodyMenu;
        private ToolStripMenuItem createNewInstructionToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripMenuItem saveInstructionsToFileToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        public DataGridView dgVariables;
        private TabPage tabPage3;
        public DataGridView dgDetails;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private ContextMenuStrip variableMenu;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripSeparator toolStripSeparator12;
        private ToolStripMenuItem toolStripMenuItem8;
        private ContextMenuStrip emptyVariableMenu;
        private ToolStripMenuItem createNewVariableToolStripMenuItem;
        private ContextMenuStrip exceptionHandlerMenu;
        private ToolStripMenuItem editToolStripMenuItem1;
        private ToolStripMenuItem removeToolStripMenuItem1;
        private ToolStripMenuItem createNewExceptionHandlerToolStripMenuItem;
        private TabPage tabPage4;
        private RichTextBox rtbILSpy;
        private TabPage tabPage5;
        private Label lblAnalysis;
        private ListView listAnalysis;
        private ColumnHeader columnHeader;
        private ToolStripMenuItem goToEntryPointToolStripMenuItem;
        private ToolStripMenuItem goToModuleCCtorToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator11;
    }
}

