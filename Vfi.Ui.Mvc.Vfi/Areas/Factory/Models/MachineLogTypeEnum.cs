using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Factory.Models
{
    public enum MachineLogTypeEnum
    {
        State = 1,
        Product = 2,
        Material = 3,
        Plan = 4,
    }
    public class CastMachineLogTypeEnum
    {
        public static string GetText(int status)
        {
            var rs = "";

            switch (status)
            {
                case 1:
                    rs = "Trạng thái";
                    break;
                case 2:
                    rs = "Sản phẩm";
                    break;
                case 3:
                    rs = "Nguyên liệu";
                    break;
                case 4:
                    rs = "Kế hoạch";
                    break;
                default:
                    rs = "";
                    break;
            }

            return rs;
        }
    }
    public enum MachineStateEnum
    {
        Normal = 1,
        Error = 2
    }

    public class CastMachineStateEnum
    {
        public static string GetText(int status)
        {
            var rs = "";

            switch (status)
            {
                case 1:
                    rs = "Bình thường";
                    break;
                case 2:
                    rs = "Lỗi";
                    break;
                default:
                    rs = "";
                    break;
            }

            return rs;

        }
    }



}
