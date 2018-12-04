using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;

namespace BadgES.Module.BusinessObjects.BadgES
{
    [DefaultClassOptions]
    public partial class Summary
    {
        public Summary(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
