namespace DEMO
{
    partial class Serv_type
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Serv_type));
            this.щемелёв_ДемоDataSet = new DEMO.Щемелёв_ДемоDataSet();
            this.service_TypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.service_TypeTableAdapter = new DEMO.Щемелёв_ДемоDataSetTableAdapters.Service_TypeTableAdapter();
            this.tableAdapterManager = new DEMO.Щемелёв_ДемоDataSetTableAdapters.TableAdapterManager();
            this.service_TypeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.service_TypeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.service_TypeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.щемелёв_ДемоDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.service_TypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.service_TypeBindingNavigator)).BeginInit();
            this.service_TypeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.service_TypeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // щемелёв_ДемоDataSet
            // 
            this.щемелёв_ДемоDataSet.DataSetName = "Щемелёв_ДемоDataSet";
            this.щемелёв_ДемоDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // service_TypeBindingSource
            // 
            this.service_TypeBindingSource.DataMember = "Service_Type";
            this.service_TypeBindingSource.DataSource = this.щемелёв_ДемоDataSet;
            // 
            // service_TypeTableAdapter
            // 
            this.service_TypeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.C_ServiceTableAdapter = null;
            this.tableAdapterManager.Material_typeTableAdapter = null;
            this.tableAdapterManager.partner_historyTableAdapter = null;
            this.tableAdapterManager.PartnersTableAdapter = null;
            this.tableAdapterManager.Request_detailsTableAdapter = null;
            this.tableAdapterManager.RequestTableAdapter = null;
            this.tableAdapterManager.Service_MaterialsTableAdapter = null;
            this.tableAdapterManager.Service_TypeTableAdapter = this.service_TypeTableAdapter;
            this.tableAdapterManager.UpdateOrder = DEMO.Щемелёв_ДемоDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkersTableAdapter = null;
            // 
            // service_TypeBindingNavigator
            // 
            this.service_TypeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.service_TypeBindingNavigator.BindingSource = this.service_TypeBindingSource;
            this.service_TypeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.service_TypeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.service_TypeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.service_TypeBindingNavigatorSaveItem});
            this.service_TypeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.service_TypeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.service_TypeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.service_TypeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.service_TypeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.service_TypeBindingNavigator.Name = "service_TypeBindingNavigator";
            this.service_TypeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.service_TypeBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.service_TypeBindingNavigator.TabIndex = 0;
            this.service_TypeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // service_TypeBindingNavigatorSaveItem
            // 
            this.service_TypeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.service_TypeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("service_TypeBindingNavigatorSaveItem.Image")));
            this.service_TypeBindingNavigatorSaveItem.Name = "service_TypeBindingNavigatorSaveItem";
            this.service_TypeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.service_TypeBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.service_TypeBindingNavigatorSaveItem.Click += new System.EventHandler(this.service_TypeBindingNavigatorSaveItem_Click);
            // 
            // service_TypeDataGridView
            // 
            this.service_TypeDataGridView.AutoGenerateColumns = false;
            this.service_TypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.service_TypeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.service_TypeDataGridView.DataSource = this.service_TypeBindingSource;
            this.service_TypeDataGridView.Location = new System.Drawing.Point(46, 62);
            this.service_TypeDataGridView.Name = "service_TypeDataGridView";
            this.service_TypeDataGridView.Size = new System.Drawing.Size(358, 237);
            this.service_TypeDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "s_type";
            this.dataGridViewTextBoxColumn2.HeaderText = "s_type";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "coef";
            this.dataGridViewTextBoxColumn3.HeaderText = "coef";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(539, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Serv_type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.service_TypeDataGridView);
            this.Controls.Add(this.service_TypeBindingNavigator);
            this.Name = "Serv_type";
            this.Text = "Serv_type";
            this.Load += new System.EventHandler(this.Serv_type_Load);
            ((System.ComponentModel.ISupportInitialize)(this.щемелёв_ДемоDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.service_TypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.service_TypeBindingNavigator)).EndInit();
            this.service_TypeBindingNavigator.ResumeLayout(false);
            this.service_TypeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.service_TypeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Щемелёв_ДемоDataSet щемелёв_ДемоDataSet;
        private System.Windows.Forms.BindingSource service_TypeBindingSource;
        private Щемелёв_ДемоDataSetTableAdapters.Service_TypeTableAdapter service_TypeTableAdapter;
        private Щемелёв_ДемоDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator service_TypeBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton service_TypeBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView service_TypeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button1;
    }
}