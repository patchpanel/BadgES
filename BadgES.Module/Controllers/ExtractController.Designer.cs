namespace BadgES.Module.Controllers
{
    partial class ExtractController
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ExtractToExcelAction = new DevExpress.ExpressApp.Actions.PopupWindowShowAction(this.components);
            // 
            // ExtractToExcelAction
            // 
            this.ExtractToExcelAction.AcceptButtonCaption = null;
            this.ExtractToExcelAction.ActionMeaning = DevExpress.ExpressApp.Actions.ActionMeaning.Accept;
            this.ExtractToExcelAction.CancelButtonCaption = null;
            this.ExtractToExcelAction.Caption = "Extract to Excel File";
            this.ExtractToExcelAction.Category = "RecordsNavigation";
            this.ExtractToExcelAction.Id = "ExtractToExcelAction";
            this.ExtractToExcelAction.ImageName = "Action_Export_ToXls";
            this.ExtractToExcelAction.TargetViewNesting = DevExpress.ExpressApp.Nesting.Root;
            this.ExtractToExcelAction.TargetViewType = DevExpress.ExpressApp.ViewType.ListView;
            this.ExtractToExcelAction.ToolTip = null;
            this.ExtractToExcelAction.TypeOfView = typeof(DevExpress.ExpressApp.ListView);
            this.ExtractToExcelAction.Execute += new DevExpress.ExpressApp.Actions.PopupWindowShowActionExecuteEventHandler(this.ExtractToExcelAction_Execute);
            // 
            // ExtractController
            // 
            this.Actions.Add(this.ExtractToExcelAction);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.PopupWindowShowAction ExtractToExcelAction;
    }
}
