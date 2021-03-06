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
namespace BadgES.Module.BusinessObjects.BadgES
{

    public partial class DetailedEntryExitPair : XPLiteObject
    {
        int fxrowid;
        [Key(true)]
        public int xrowid
        {
            get { return fxrowid; }
            set { SetPropertyValue<int>(nameof(xrowid), ref fxrowid, value); }
        }
        ResourceList fKeyLink;
        [ColumnDbDefaultValue("((-1))")]
        [Association(@"DetailedEntryExitPairReferencesResourceList")]
        public ResourceList KeyLink
        {
            get { return fKeyLink; }
            set { SetPropertyValue<ResourceList>(nameof(KeyLink), ref fKeyLink, value); }
        }
        string fRowNum;
        [Size(50)]
        public string RowNum
        {
            get { return fRowNum; }
            set { SetPropertyValue<string>(nameof(RowNum), ref fRowNum, value); }
        }
        string fCardNo;
        [Size(50)]
        public string CardNo
        {
            get { return fCardNo; }
            set { SetPropertyValue<string>(nameof(CardNo), ref fCardNo, value); }
        }
        string fName;
        [Size(50)]
        public string Name
        {
            get { return fName; }
            set { SetPropertyValue<string>(nameof(Name), ref fName, value); }
        }
        string fTransactionType1;
        [Size(50)]
        public string TransactionType1
        {
            get { return fTransactionType1; }
            set { SetPropertyValue<string>(nameof(TransactionType1), ref fTransactionType1, value); }
        }
        string fDateTime1;
        [Size(50)]
        public string DateTime1
        {
            get { return fDateTime1; }
            set { SetPropertyValue<string>(nameof(DateTime1), ref fDateTime1, value); }
        }
        string fTransactionType2;
        [Size(50)]
        public string TransactionType2
        {
            get { return fTransactionType2; }
            set { SetPropertyValue<string>(nameof(TransactionType2), ref fTransactionType2, value); }
        }
        string fDateTime2;
        [Size(50)]
        public string DateTime2
        {
            get { return fDateTime2; }
            set { SetPropertyValue<string>(nameof(DateTime2), ref fDateTime2, value); }
        }
        string fDoorLocation;
        [Size(50)]
        public string DoorLocation
        {
            get { return fDoorLocation; }
            set { SetPropertyValue<string>(nameof(DoorLocation), ref fDoorLocation, value); }
        }
        string fOfficeLocation;
        [Size(50)]
        public string OfficeLocation
        {
            get { return fOfficeLocation; }
            set { SetPropertyValue<string>(nameof(OfficeLocation), ref fOfficeLocation, value); }
        }
        string fInOffice;
        [Size(50)]
        public string InOffice
        {
            get { return fInOffice; }
            set { SetPropertyValue<string>(nameof(InOffice), ref fInOffice, value); }
        }
        string fRemarks;
        [Size(50)]
        public string Remarks
        {
            get { return fRemarks; }
            set { SetPropertyValue<string>(nameof(Remarks), ref fRemarks, value); }
        }
    }

}
