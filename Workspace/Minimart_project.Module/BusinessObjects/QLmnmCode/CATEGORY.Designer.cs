﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.DC;
namespace Minimart_project.Module.BusinessObjects.QLmnm
{
    [DefaultClassOptions]
    [System.ComponentModel.DisplayName("Phân loại")]
    public partial class CATEGORY : XPObject
    {
        string fI_ID;
        public string I_ID
        {
            get { return fI_ID; }
            set { SetPropertyValue<string>(nameof(I_ID), ref fI_ID, value); }
        }
        string fI_Status;
        public string I_Status
        {
            get { return fI_Status; }
            set { SetPropertyValue<string>(nameof(I_Status), ref fI_Status, value); }
        }
        string fT_Name;
        [XafDisplayName("Tên loại")]
        public string T_Name
        {
            get { return fT_Name; }
            set { SetPropertyValue<string>(nameof(T_Name), ref fT_Name, value); }
        }
        string fT_Code;
        public string T_Code
        {
            get { return fT_Code; }
            set { SetPropertyValue<string>(nameof(T_Code), ref fT_Code, value); }
        }
        [Association(@"CATEGORYReferencesPRODUCT")]
        public XPCollection<PRODUCT> PRODUCTs { get { return GetCollection<PRODUCT>(nameof(PRODUCTs)); } }
    }

}
