
using System;

namespace Vfi.Server.Core.DataModel.Models.Inv
{
    
    public class CastTaxInvoiceStatusEnumDomain2
    {
        public static string GetText(int status)
        {
            var rs = "";

            switch (status)
            {
                case 1:
                    rs = "Đợi duyệt";
                    break;
                case 2:
                    rs = "Hoàn thành";
                    break;
                case 3:
                    rs = "Huỷ bỏ";
                    break;
                case 4:
                    rs = "Đang tiến hành";
                    break;
                default:
                    rs = "Chưa giao";
                    break;
            }

            return rs;
        }
    }
    public class CastTaxInvoiceStatusEnumDomain
    {
        public static string GetText(int status)
        {
            var rs = "";

            switch (status)
            {
                case 1:
                    rs = "Chưa duyệt";
                    break;
                case 2:
                    rs = "Đã duyệt";
                    break;
                case 3:
                    rs = "Huỷ bỏ";
                    break;
                case 4:
                    rs = "Đang tiến hành";
                    break;
                default:
                    rs = "Chưa duyệt";
                    break;
            }

            return rs;
        }
    }

    public class CastPlatingFormStatusEnumDomain
    {
        public static string GetText(int status)
        {
            var rs = "";

            switch (status)
            {
                case 1:
                    rs = "Chưa duyệt";
                    break;
                case 2:
                    rs = "Hoàn thành";
                    break;
                case 3:
                    rs = "Huỷ bỏ";
                    break;
                case 4:
                    rs = "Đang tiến hành";
                    break;
                default:
                    rs = "Chưa duyệt";
                    break;
            }

            return rs;
        }
    }
    public class OrderOption
    {
        public static DateTime GetStartOrderDate()
        {
            return new DateTime(2014, 4, 1).AddSeconds(-1);
        }
    }
}
