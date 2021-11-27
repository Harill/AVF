
namespace Vfi.Server.Core.DataModel.Models.Production
{
    public enum StatusEnumDomain
    {
        Open = 1,
        Pending = 2,
        Approved = 3,
        Rejected = 4,
        Complete = 5
    }

    public class CastStatusEnumDomain
    {
        public static string GetTextStatusEnumDomain(int status)
        {
            var rs = "";
            
            switch (status)
            {
                case 1:
                    rs = StatusEnumDomain.Open.ToString();
                    break;
                case 2:
                    rs = StatusEnumDomain.Pending.ToString();
                    break;
                case 3:
                    rs = StatusEnumDomain.Approved.ToString();
                    break;
                case 4:
                    rs = StatusEnumDomain.Rejected.ToString();
                    break;
                case 5:
                    rs = StatusEnumDomain.Complete.ToString();
                    break;
            }

            return rs;
        }
    }
}
