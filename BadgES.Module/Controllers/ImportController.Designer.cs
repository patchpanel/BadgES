namespace BadgES.Module.Controllers
{
    partial class ImportController
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
            this.ImportResourceListAction = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // ImportResourceListAction
            // 
            this.ImportResourceListAction.ActionMeaning = DevExpress.ExpressApp.Actions.ActionMeaning.Accept;
            this.ImportResourceListAction.Caption = "Import Resource List";
            this.ImportResourceListAction.Category = "Tools";
            this.ImportResourceListAction.ConfirmationMessage = null;
            this.ImportResourceListAction.Id = "ImportResourceListAction";
            this.ImportResourceListAction.ImageName = "EditDataSource";
            this.ImportResourceListAction.ToolTip = null;
            this.ImportResourceListAction.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.ImportResourceListAction_Execute);
            // 
            // ImportController
            // 
            this.Actions.Add(this.ImportResourceListAction);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction ImportResourceListAction;
    }
}
