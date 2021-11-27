using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ProductTotalByMonth
    {
        public int Id { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<int> Month { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<double> KhoSX2_CNC { get; set; }
        public Nullable<double> KhoSX2_SX2 { get; set; }
        public Nullable<double> KhoNhietLuyen { get; set; }
        public Nullable<double> KhoChoRungBong { get; set; }
        public Nullable<double> KhoChoGCN { get; set; }
        public Nullable<double> KhoNhaCungUng { get; set; }
        public Nullable<double> KhoQC_A { get; set; }
        public Nullable<double> KhoQC_B { get; set; }
        public Nullable<double> ChoXuLy { get; set; }
        public Nullable<double> PhePham { get; set; }
        public Nullable<double> ThanhPham_A { get; set; }
        public Nullable<double> ThanhPham_B { get; set; }
        public Nullable<double> LuyKeSanXuat { get; set; }
        public Nullable<double> LuyKeXuat { get; set; }
        public Nullable<double> DonHangConLai { get; set; }
        public virtual Product Product { get; set; }
    }
}
