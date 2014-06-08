namespace ExcelAddInDataOutput
{
    partial class RibbonPopData : Microsoft.Office.Tools.Ribbon.OfficeRibbon
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public RibbonPopData()
        {
            InitializeComponent();
        }

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = new Microsoft.Office.Tools.Ribbon.RibbonTab();
            this.groupData = new Microsoft.Office.Tools.Ribbon.RibbonGroup();
            this.btnConfigure = new Microsoft.Office.Tools.Ribbon.RibbonButton();
            this.btnPopupData = new Microsoft.Office.Tools.Ribbon.RibbonButton();
            this.btnTableConfigure = new Microsoft.Office.Tools.Ribbon.RibbonButton();
            this.tab1.SuspendLayout();
            this.groupData.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.groupData);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // groupData
            // 
            this.groupData.Items.Add(this.btnConfigure);
            this.groupData.Items.Add(this.btnTableConfigure);
            this.groupData.Items.Add(this.btnPopupData);
            this.groupData.Label = "データ抽出";
            this.groupData.Name = "groupData";
            // 
            // btnConfigure
            // 
            this.btnConfigure.Label = "データベース設定";
            this.btnConfigure.Name = "btnConfigure";
            // 
            // btnPopupData
            // 
            this.btnPopupData.Label = "抽出";
            this.btnPopupData.Name = "btnPopupData";
            // 
            // btnTableConfigure
            // 
            this.btnTableConfigure.Label = "抽出テーブル設定";
            this.btnTableConfigure.Name = "btnTableConfigure";
            // 
            // RibbonPopData
            // 
            this.Name = "RibbonPopData";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.groupData.ResumeLayout(false);
            this.groupData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupData;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnConfigure;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnPopupData;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnTableConfigure;
    }

    partial class ThisRibbonCollection : Microsoft.Office.Tools.Ribbon.RibbonReadOnlyCollection
    {
        internal RibbonPopData Ribbon1
        {
            get { return this.GetRibbon<RibbonPopData>(); }
        }
    }
}
