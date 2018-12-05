using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;

namespace BadgES.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class SendEmailController : ViewController
    {
        public SendEmailController()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }

        private void SendEmailAction_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            //var currentObject = View.ObjectSpace.GetObject(View.CurrentObject);
            //var currentObjectKey = View.ObjectSpace.GetKeyValue(View.CurrentObject);
            //or with multiple selected objects:
            //System.Collections.ArrayList a = (System.Collections.ArrayList)e.SelectedObjects;

            foreach (BusinessObjects.BadgES.ResourceList item in e.SelectedObjects)
            {
                Console.WriteLine(item.ResourceQlid);
            }
            //foreach (var obj in e.SelectedObjects)
            //{
            //    var selectedObject = View.ObjectSpace.GetObject(obj);
            //    Console.WriteLine(selectedObject.ToString());
            //}
            //var nameField = ((ListView)View).FindItem("ResourceQlid");
        }
    }
}
