﻿using System.Runtime.Serialization;

namespace LiqPay.SDK.Dto.Enums
{
    public enum LiqPayResponseStatus
    {
        [EnumMember(Value = "error")]
        Error,
        [EnumMember(Value = "failure")]
        Failure,
        [EnumMember(Value = "sandbox")]
        Sandbox,
        [EnumMember(Value = "success")]
        Success,
        [EnumMember(Value = "invoice_wait")]
        InvoiceWait
    }
}