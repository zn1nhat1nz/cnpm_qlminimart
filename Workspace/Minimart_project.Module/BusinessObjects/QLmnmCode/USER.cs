using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace Minimart_project.Module.BusinessObjects.QLmnm
{

    public partial class USER
    {
        public USER(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
