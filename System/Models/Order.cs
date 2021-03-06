﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace System.Models
{
    public class Order
    {
        /// <summary>
        /// 訂單編號
        /// </summary>
        public int OrderId { get; set; }
        /// <summary>
        /// 客戶代號
        /// </summary>
        public string CustId { get; set; }
        /// <summary>
        /// 客戶名稱
        /// </summary>
        public string CustName { get; set; }
        /// <summary>
        /// 員工代號
        /// </summary>
        public int EmpId { get; set; }
        /// <summary>
        /// 員工姓名
        /// </summary>
        public string EmpName { get; set; }
        /// <summary>
        /// 訂單日期
        /// </summary>
        public DateTime ? OrderDate { get; set; }
        /// <summary>
        /// 需要日期
        /// </summary>
        public DateTime? RequiredDate { get; set; }
        /// <summary>
        /// 出貨日期
        /// </summary>
        public DateTime? ShippedDate { get; set; }
        /// <summary>
        /// 出貨公司代號
        /// </summary>
        public int ShipperId { get; set; }
        /// <summary>
        /// 出貨公司名稱
        /// </summary>
        public string ShipperName { get; set; }
        /// <summary>
        /// 運費
        /// </summary>
        public double Freight { get; set; }
        /// <summary>
        /// 出貨說明
        /// </summary>
        public string ShipName { get; set; }
        /// <summary>
        /// 出貨地址
        /// </summary>
        public string ShipAddress { get; set; }
        /// <summary>
        /// 出貨城市
        /// </summary>
        public string shipCity { get; set; }
        /// <summary>
        /// 出貨地區
        /// </summary>
        public string shipRegion { get; set; }
        /// <summary>
        /// 出貨郵遞區號
        /// </summary>
        public string shipPostalCode { get; set; }
        /// <summary>
        /// 出貨國家
        /// </summary>
        public string shipCountry { get; set; }


    }
}