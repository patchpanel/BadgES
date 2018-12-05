namespace BadgES.Module.Controllers
{
    partial class SendEmailController
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
            this.SendEmailAction = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // SendEmailAction
            // 
            this.SendEmailAction.ActionMeaning = DevExpress.ExpressApp.Actions.ActionMeaning.Accept;
            this.SendEmailAction.Caption = "Send Email";
            this.SendEmailAction.Category = "RecordsNavigation";
            this.SendEmailAction.ConfirmationMessage = "This will send email to {0}. Do you want to continue?";
            this.SendEmailAction.Id = "SendEmailAction";
            this.SendEmailAction.ImageName = "Glyph_Mail";
            this.SendEmailAction.TargetObjectType = typeof(BadgES.Module.BusinessObjects.BadgES.ResourceList);
            this.SendEmailAction.TargetViewNesting = DevExpress.ExpressApp.Nesting.Root;
            this.SendEmailAction.TargetViewType = DevExpress.ExpressApp.ViewType.ListView;
            this.SendEmailAction.ToolTip = "Sends an email to the selected recipient";
            this.SendEmailAction.TypeOfView = typeof(DevExpress.ExpressApp.ListView);
            this.SendEmailAction.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.SendEmailAction_Execute);
            // 
            // SendEmailController
            // 
            this.Actions.Add(this.SendEmailAction);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction SendEmailAction;
    }
}
