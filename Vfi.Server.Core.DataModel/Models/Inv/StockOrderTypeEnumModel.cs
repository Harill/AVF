
namespace Vfi.Server.Core.DataModel.Models.Inv
{
    public enum StockOrderTypeEnumModel
    {
        Export = 1,
        Import = 2
    }

    public class CastStockOrderTypeEnumModel
    {
        public static string GetTextStockOrderTypeEnumDomain(int stockOrderType)
        {
            var rs = "";

            switch (stockOrderType)
            {
                case 1:
                    rs = StockOrderTypeEnumModel.Export.ToString();
                    break;
                case 2:
                    rs = StockOrderTypeEnumModel.Import.ToString();
                    break;
            }

            return rs;
        }
    }
}
