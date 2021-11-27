
namespace Vfi.Server.Core.DataModel.Models.Inv
{
    public enum StockOrderStatusEnumModel
    {
        Open = 1,
        Approved = 2,
        InProcess = 3,
        Finished = 4,
        Pending = 5,
        Rejected = 6
    }

    public class CastStockOrderStatusEnumDomain
    {
        public static string GetTextStockOrderStatusEnumDomain(int status)
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
                    rs = "Đợi duyệt";
                    break;
                case 4:
                    rs = StockOrderStatusEnumModel.Finished.ToString();
                    break;
                case 5:
                    rs = "Trả hàng";
                    break;
                case 6:
                    rs = "Từ chối";
                    break;
            }

            return rs;
        }
    }
}
