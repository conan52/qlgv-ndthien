using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace QLGV.Forms
{
    public partial class ShowReport : Form
    {
        public ShowReport()
        {
            InitializeComponent();
        }
        public ShowReport(string reportname)
        {
            InitializeComponent();
            this.ReportName = reportname;
        }
        public string ReportName { get; set; }
        private void ShowReport_Load(object sender, EventArgs e)
        {
            DataTable dt = null;
            List<ReportParameter> para = null;
            switch (ReportName)
            {
                case "ThongKeSoLuong":
                    dt = ThongKeSoLuong(out para);
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLGV.Reports.ThongKeSoLuong.rdlc";
                    break;
                case "C0":
                    dt = C0(out para);
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLGV.Reports.C0.rdlc";
                    break;
                case "C1":
                    dt = C1(out para);
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLGV.Reports.C1.rdlc";
                    break;
                case "C2":
                    dt = C2(out para);
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLGV.Reports.C2.rdlc";
                    break;
                case "ThuaThieu":
                    dt = ThuaThieu(out para);
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLGV.Reports.ThuaThieu.rdlc";
                    break;
                case "DacDiem":
                    dt = DacDiem(out para);
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLGV.Reports.DacDiem.rdlc";
                    break;
                case "SoLuong":
                    dt = ThongKeSoLuong(out para);
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLGV.Reports.SoLuong.rdlc";
                    break;
                default:
                    throw new Exception("No report");
            }
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            //reportViewer1.LocalReport.ReportPath = Server.MapPath("/Reports/" + reportName + ".rdlc");
            reportViewer1.LocalReport.DataSources.Clear();
            //ReportParameter[] parameters = null;
            reportViewer1.LocalReport.DataSources.Add(
            new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", (DataTable)dt));
            this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.RefreshReport();
        }

        DataTable ThongKeSoLuong(out List<ReportParameter> para)
        {
            int duocgiaotong = 0, duocgiaocbql = 0, duocgiaogv = 0, duocgiaotpt = 0, duocgiaohc = 0, duocgiaocntt = 0,
                comattong = 0, comatcbql = 0, comatgv = 0, comathc = 0, comattpt = 0, comatcntt = 0,
                tttong = 0, ttcbql = 0, ttgv = 0, tthc = 0, ttcntt = 0, ts = 0, ts1 = 0, ts2 = 0;
            var dtloai = SQLiteUtils.GetTable("select * from nhomtruong");
            var dt = new DataSet1().DataTable1;
            int k = 1;

            #region Repeat
            foreach (DataRow row in dtloai.Rows)
            {
                int duocgiaotong1 = 0, duocgiaocbql1 = 0, duocgiaogv1 = 0, duocgiaotpt1 = 0, duocgiaohc1 = 0, duocgiaocntt1 = 0,
                    comattong1 = 0, comatcbql1 = 0, comatgv1 = 0, comathc1 = 0, comattpt1 = 0, comatcntt1 = 0,
tttong1 = 0, ttcbql1 = 0, ttgv1 = 0, tthc1 = 0, ttcntt1 = 0, tsx = 0, ts11 = 0, ts21 = 0;
                var dr = dt.NewRow();
                dr["STT"] = GetLaMa(k);
                dr["Title"] = "     " + row["Title"];
                dt.Rows.Add(dr);
                var dttruong = SQLiteUtils.GetTable("select * from truonginfo where nhomtruongid=@nhom", "@nhom", row["ID"]);
                int i = 1;
                foreach (DataRow item in dttruong.Rows)
                {
                    var dr1 = dt.NewRow();
                    dr1["STT"] = i + "";
                    dr1["Title"] = item["Title"];
                    dr1["HangDonVi"] = GetLaMa(int.Parse("0" + item["HangTruong"]));

                    int tdgiao = int.Parse("0" + item["DuocGiaoCB"]) + int.Parse("0" + item["DuocGiaoHC"]) + int.Parse("0" + item["DuocGiaoCNTT"]);
                    duocgiaotong1 += tdgiao;
                    dr1["TongSoDuocGiao"] = tdgiao;
                    dr1["DuocGiaoCB"] = item["DuocGiaoCB"];
                    duocgiaogv1 += int.Parse("0" + item["DuocGiaoCB"]);
                    dr1["DuocGiaoHC"] = item["DuocGiaoHC"];
                    duocgiaohc1 += int.Parse("0" + item["DuocGiaoHC"]);
                    dr1["DuocGiaoCNTT"] = item["DuocGiaoCNTT"];
                    duocgiaocntt1 += int.Parse("0" + item["DuocGiaoCNTT"]);
                    dr1["DuocGiaoCBQL"] = 0;
                    dr1["DuocGiaoTPT"] = 0;

                    int tcm = int.Parse("0" + item["CoMatCB"]) + int.Parse("0" + item["CoMatHC"]) + int.Parse("0" + item["CoMatCNTT"]);
                    comattong1 += tcm;
                    dr1["TongSoCoMat"] = tcm;
                    dr1["CoMatCB"] = item["CoMatCB"];
                    comatgv1 += int.Parse("0" + item["CoMatCB"]);
                    dr1["CoMatHC"] = item["CoMatHC"];
                    comathc1 += int.Parse("0" + item["CoMatHC"]);
                    dr1["CoMatCNTT"] = item["CoMatCNTT"];
                    comatcntt1 += int.Parse("0" + item["CoMatCNTT"]);
                    dr1["CoMatCBQL"] = 0;
                    dr1["CoMatTPT"] = 0;

                    dr1["TongTT"] = tcm - tdgiao;
                    tttong1 += (tcm - tdgiao);
                    dr1["TTCB"] = int.Parse("0" + item["CoMatCB"]) - int.Parse("0" + item["DuocGiaoCB"]);
                    ttgv1 += int.Parse("0" + item["CoMatCB"]) - int.Parse("0" + item["DuocGiaoCB"]);
                    dr1["TTHC"] = int.Parse("0" + item["CoMatHC"]) - int.Parse("0" + item["DuocGiaoHC"]);
                    tthc1 += int.Parse("0" + item["CoMatHC"]) - int.Parse("0" + item["DuocGiaoHC"]);
                    dr1["TTCNTT"] = int.Parse("0" + item["CoMatCNTT"]) - int.Parse("0" + item["DuocGiaoCNTT"]);
                    ttcntt1 += int.Parse("0" + item["CoMatCNTT"]) - int.Parse("0" + item["DuocGiaoCNTT"]);
                    dr1["TTCBQL"] = 0;

                    dr1["TS"] = item["CoMatCB"];
                    dr1["TS1"] = int.Parse("0" + item["CoMatCB"]);
                    dr1["TS2"] = int.Parse("0" + item["CoMatCNTT"]) + int.Parse("0" + item["CoMatHC"]);
                    dt.Rows.Add(dr1);
                    i++;
                }
                #region Sum
                tsx = comattpt1; ts11 = comatcbql1 + comatgv1 + comattpt1; ts21 = comathc1 + comatcntt1;
                dr["STT"] = GetLaMa(k);
                dr["Title"] = "     " + row["Title"];
                dr["TongSoDuocGiao"] = duocgiaotong1;
                dr["DuocGiaoCB"] = duocgiaogv1;
                dr["DuocGiaoHC"] = duocgiaohc1; dr["DuocGiaoCNTT"] = duocgiaocntt1; dr["DuocGiaoCBQL"] = duocgiaocbql1; dr["DuocGiaoTPT"] = duocgiaotpt1;
                dr["TongSoCoMat"] = comattong1; dr["CoMatCB"] = comatgv1; dr["CoMatCNTT"] = comatcntt1; dr["CoMatCBQL"] = comatcbql1; dr["CoMatTPT"] = comattpt1; dr["CoMatHC"] = comathc1;
                dr["TongTT"] = tttong1; dr["TTCB"] = ttgv1; dr["TTHC"] = tthc1; dr["TTCNTT"] = ttcntt1; dr["TTCBQL"] = ttcbql1;
                dr["TS"] = tsx; dr["TS1"] = ts11; dr["TS2"] = ts21;
                k++;
                duocgiaotong += duocgiaotong1;
                duocgiaocbql += duocgiaocbql1;
                duocgiaogv += duocgiaogv1;
                duocgiaotpt += duocgiaotpt1;
                duocgiaohc += duocgiaohc1;
                duocgiaohc += duocgiaohc1;
                duocgiaohc += duocgiaohc1;
                duocgiaocntt += duocgiaocntt1;
                comattong += comattong1;
                comatcbql += comatcbql1;
                comatgv += comatgv1;
                comathc += comathc1;
                comattpt += comattpt1;
                comatcntt += comatcntt1;
                tttong += tttong1;
                ttcbql += ttcbql1;
                ttgv += ttgv1;
                tthc += tthc1;
                ttcntt += ttcntt1;
                #endregion
            }
            #endregion
            #region para
            ts = comattong; ts1 = comatcbql + comatgv + comattpt; ts2 = comathc + comatcntt;
            var rparam = new List<ReportParameter>();
            rparam.Add(new ReportParameter("duocgiaotong", duocgiaotong + ""));
            rparam.Add(new ReportParameter("duocgiaocbql", duocgiaocbql + ""));
            rparam.Add(new ReportParameter("duocgiaogv", duocgiaogv + ""));
            rparam.Add(new ReportParameter("duocgiaotpt", duocgiaotpt + ""));
            rparam.Add(new ReportParameter("duocgiaohc", duocgiaohc + ""));
            rparam.Add(new ReportParameter("duocgiaocntt", duocgiaocntt + ""));
            rparam.Add(new ReportParameter("comattong", comattong + ""));
            rparam.Add(new ReportParameter("comatcbql", comatcbql + ""));
            rparam.Add(new ReportParameter("comatgv", comatgv + ""));
            rparam.Add(new ReportParameter("comathc", comathc + ""));
            rparam.Add(new ReportParameter("comattpt", comattpt + ""));
            rparam.Add(new ReportParameter("comatcntt", comatcntt + ""));
            rparam.Add(new ReportParameter("tttong", tttong + ""));
            rparam.Add(new ReportParameter("ttcbql", ttcbql + ""));
            rparam.Add(new ReportParameter("ttgv", ttgv + ""));
            rparam.Add(new ReportParameter("tthc", tthc + ""));
            rparam.Add(new ReportParameter("ttcntt", ttcntt + ""));
            rparam.Add(new ReportParameter("ts", ts + ""));
            rparam.Add(new ReportParameter("ts1", ts1 + ""));
            rparam.Add(new ReportParameter("ts2", ts2 + ""));
            rparam.Add(new ReportParameter("ngay", DateTime.Now.ToString("dd/MM/yyyy") + ""));
            #endregion
            para = rparam;
            return dt;
        }
        DataTable C0(out List<ReportParameter> para)
        {
            DataTable dt = new DataSet1().C0;
            int TongSoLop = 0, TSHS = 0, TongBienChe = 0, CBQL = 0, HanhChinh = 0, TongSo = 0, GVVH = 0, GVK = 0;

            var dttruong = SQLiteUtils.GetTable("select * from truonginfo where nhomtruongid=@nhom", "@nhom", 1);
            #region Repeat
            int i = 1;
            foreach (DataRow item in dttruong.Rows)
            {
                var dr1 = dt.NewRow();
                dr1["STT"] = i + "";
                dr1["Title"] = item["Title"];
                dr1["HangTruong"] = GetLaMa(int.Parse("0" + item["HangTruong"]));

                int TongSoLop1 = 0, TSHS1 = 0, TongBienChe1 = 0, CBQL1 = 0, HanhChinh1 = 0, TongSo1 = 0, GVVH1 = 0, GVK1 = 0;
                TongSoLop1 = int.Parse("0" + item["SoLop"]);
                dr1["TongSoLop"] = TongSoLop1; TongSoLop += TongSoLop1; ;

                TSHS1 = int.Parse("0" + item["SoHocSinh"]);
                dr1["TSHS"] = TSHS1; TSHS += TSHS1;

                CBQL1 = int.Parse("0" + item["CoMatCB"]);
                dr1["CBQL"] = CBQL1; CBQL += CBQL1;

                CBQL1 = int.Parse("0" + item["CoMatHC"]);
                dr1["HanhChinh"] = HanhChinh1; HanhChinh += HanhChinh1;

                GVVH1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and chucvu=@chucvu", "@truongid", item["ID"], "@chucvu", ChucVu.GVBC));
                dr1["GVVH"] = GVVH1; GVVH += GVVH1;

                GVK1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and chucvu=@chucvu", "@truongid", item["ID"], "@chucvu", ChucVu.GVHDCBH));
                dr1["GVK"] = GVK1; GVK += GVK1;

                TongSo1 = GVVH1 + GVK1;
                dr1["TongSo"] = TongSo1; TongSo += TongSo1;

                TongBienChe1 = CBQL1 + HanhChinh1 + GVVH1 + GVK1;
                dr1["TongBienChe"] = TongBienChe1; TongBienChe += TongBienChe1;
                dt.Rows.Add(dr1);
                i++;
            }
            var dr = dt.NewRow();
            dr["Title"] = "Tổng số";
            dr["TongSoLop"] = TongSoLop; dr["TSHS"] = TSHS; dr["TongBienChe"] = TongBienChe; dr["CBQL"] = CBQL;
            dr["HanhChinh"] = HanhChinh; dr["TongSo"] = TongSo; dr["GVVH"] = GVVH; dr["GVK"] = GVK;
            dt.Rows.Add(dr);
            #endregion

            para = new List<ReportParameter>();
            return dt;
        }
        DataTable C1(out List<ReportParameter> para)
        {
            DataTable dt = new DataSet1().C1;
            var dttruong = SQLiteUtils.GetTable("select * from truonginfo where nhomtruongid=@nhom", "@nhom", 2);
            int TSL_TS = 0, TSL_LH = 0, TSHS = 0, TongSo = 0, CBQL = 0, HanhChinh = 0, TPTDoi = 0, TongSo1 = 0,
                AmNhac = 0, MiThuat = 0, NgoaiNgu = 0, TinHoc = 0, TheDuc = 0, VanHoa = 0;
            #region Repeat
            int i = 1;
            foreach (DataRow item in dttruong.Rows)
            {
                var dr1 = dt.NewRow();
                dr1["STT"] = i + "";
                dr1["Title"] = item["Title"];
                dr1["HangTruong"] = GetLaMa(int.Parse("0" + item["HangTruong"]));

                int TongSoLop1 = int.Parse("0" + item["SoLop"]);
                dr1["TSL_TS"] = TongSoLop1; TSL_TS += TongSoLop1; ;

                int TSL_LH1 = int.Parse("0" + item["SoLop2b"]);
                dr1["TSL_LH"] = TSL_LH1; TSL_LH += TSL_LH1;

                int TSHS1 = int.Parse("0" + item["CoMatCB"]);
                dr1["TSHS"] = TSHS1; TSHS += TSHS;

                int CBQL1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and chucvu=@chucvu", "@truongid", item["ID"], "@chucvu", ChucVu.CBQL));
                dr1["CBQL"] = CBQL1; CBQL += CBQL1;

                int HanhChinh1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and chucvu=@chucvu", "@truongid", item["ID"], "@chucvu", ChucVu.HanhChinh));
                dr1["HanhChinh"] = HanhChinh1; HanhChinh += HanhChinh1;

                int TPTDoi1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and chucvu=@chucvu", "@truongid", item["ID"], "@chucvu", ChucVu.TPTDoi));
                dr1["TPTDoi"] = TPTDoi1; TPTDoi += TPTDoi1;

                int VanHoa1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and chuyenmon=@chuyenmon", "@truongid", item["ID"], "@chuyenmon", MonDay.VanHoa));
                dr1["VanHoa"] = VanHoa1; VanHoa += VanHoa1;
                int AmNhac1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and chuyenmon=@chuyenmon", "@truongid", item["ID"], "@chuyenmon", MonDay.AmNhac));
                dr1["AmNhac"] = AmNhac1; AmNhac += AmNhac1;
                int MiThuat1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and chuyenmon=@chuyenmon", "@truongid", item["ID"], "@chuyenmon", MonDay.MyThuat));
                dr1["MiThuat"] = MiThuat1; MiThuat += MiThuat1;
                int NgoaiNgu1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and chuyenmon=@chuyenmon", "@truongid", item["ID"], "@chuyenmon", MonDay.NN));
                dr1["NgoaiNgu"] = NgoaiNgu1; NgoaiNgu += NgoaiNgu1;
                int TinHoc1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and chuyenmon=@chuyenmon", "@truongid", item["ID"], "@chuyenmon", MonDay.MyThuat));
                dr1["TinHoc"] = TinHoc1; TinHoc += TinHoc1;
                int TheDuc1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and chuyenmon=@chuyenmon", "@truongid", item["ID"], "@chuyenmon", MonDay.TD));
                dr1["TheDuc"] = TheDuc1; TheDuc += TheDuc1;

                int TongSo11 = VanHoa1 + AmNhac1 + NgoaiNgu1 + MiThuat1 + TinHoc1 + TheDuc1;
                dr1["TongSo1"] = TongSo11; TongSo1 += TongSo11;
                int TongSo_ = VanHoa1 + AmNhac1 + NgoaiNgu1 + MiThuat1 + TinHoc1 + TheDuc1;
                dr1["TongSo"] = TongSo_; TongSo += TongSo_;
                dt.Rows.Add(dr1);
                i++;
            }
            #endregion
            var dr = dt.NewRow();
            dr["Title"] = "Tổng số";
            dr["TSL_TS"] = TSL_TS; dr["TSL_LH"] = TSL_LH; dr["TSHS"] = TSHS; dr["TongSo"] = TongSo;
            dr["CBQL"] = CBQL; dr["HanhChinh"] = HanhChinh; dr["TPTDoi"] = TPTDoi; dr["TongSo1"] = TongSo1;
            dr["VanHoa"] = VanHoa; dr["AmNhac"] = AmNhac; dr["MiThuat"] = MiThuat; dr["NgoaiNgu"] = NgoaiNgu; dr["TinHoc"] = TinHoc; dr["TheDuc"] = TheDuc;
            dt.Rows.Add(dr);

            para = new List<ReportParameter>();
            return dt;
        }
        DataTable C2(out List<ReportParameter> para)
        {
            DataTable dt = new DataSet1().C2;
            var dttruong = SQLiteUtils.GetTable("select * from truonginfo where nhomtruongid=@nhom", "@nhom", 3);
            int TSL = 0, TongSo = 0, CBQL = 0, HanhChinh = 0, TPTDoi = 0, TSGV = 0, Van = 0, Su = 0, Dia = 0, GDCD = 0, TD = 0,
               NgoaiNgu = 0, Toan = 0, Ly = 0, Hoa = 0, Sinh = 0, KTCN = 0, KTNN = 0, Tin = 0, AmNhac = 0, MiThuat = 0, CNTT = 0;
            int i = 1;
            foreach (DataRow item in dttruong.Rows)
            {
                #region
                var dr1 = dt.NewRow();
                dr1["STT"] = i + "";
                dr1["Title"] = item["Title"];
                dr1["HangTruong"] = GetLaMa(int.Parse("0" + item["HangTruong"]));
                int TSL1 = int.Parse("0" + item[tf.SoLop]);
                dr1["TSL"] = TSL1; TSL = TSL1; ;
                int CBQL1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and chucvu=@chucvu", "@truongid", item["ID"], "@chucvu", ChucVu.CBQL));
                dr1["CBQL"] = CBQL1; CBQL += CBQL1;
                int HanhChinh1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and chucvu=@chucvu", "@truongid", item["ID"], "@chucvu", ChucVu.HanhChinh));
                dr1["HanhChinh"] = HanhChinh1; HanhChinh += HanhChinh1;
                int TPTDoi1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and chucvu=@chucvu", "@truongid", item["ID"], "@chucvu", ChucVu.TPTDoi));
                dr1["TPTDoi"] = TPTDoi1; TPTDoi += TPTDoi1;
                #endregion
                int Van1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and chuyenmon=@chuyenmon", "@truongid", item["ID"], "@chuyenmon", MonDay.Van));
                dr1["Van"] = Van1; Van += Van1;
                int Su1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and chuyenmon=@chuyenmon", "@truongid", item["ID"], "@chuyenmon", MonDay.Su));
                dr1["Su"] = Su1; Su += Su1;
                int Dia1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and chuyenmon=@chuyenmon", "@truongid", item["ID"], "@chuyenmon", MonDay.Dia));
                dr1["Dia"] = Dia1; Dia += Dia1;
                int GDCD1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and chuyenmon=@chuyenmon", "@truongid", item["ID"], "@chuyenmon", MonDay.GDCD));
                dr1["GDCD"] = GDCD1; GDCD += GDCD1;
                int TD1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and chuyenmon=@chuyenmon", "@truongid", item["ID"], "@chuyenmon", MonDay.TD));
                dr1["TD"] = TD1; TD1 += TD1;
                int NgoaiNgu1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and chuyenmon=@chuyenmon", "@truongid", item["ID"], "@chuyenmon", MonDay.NN));
                dr1["NN"] = NgoaiNgu1; NgoaiNgu += NgoaiNgu1;
                dr1["Su"] = Su1; Su += Su1;
                int Toan1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and chuyenmon=@chuyenmon", "@truongid", item["ID"], "@chuyenmon", MonDay.Toan));
                dr1["Toan"] = Toan1; Toan1 += Toan1;
                int Ly1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and chuyenmon=@chuyenmon", "@truongid", item["ID"], "@chuyenmon", MonDay.Ly));
                dr1["Ly"] = Ly1; Ly += Ly1;
                int Hoa1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and chuyenmon=@chuyenmon", "@truongid", item["ID"], "@chuyenmon", MonDay.MyThuat));
                dr1["Hoa"] = Hoa1; Hoa += Hoa1;
                int Sinh1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and chuyenmon=@chuyenmon", "@truongid", item["ID"], "@chuyenmon", MonDay.MyThuat));
                dr1["Sinh"] = Sinh1; Sinh += Sinh1;
                int KTCN1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and chuyenmon=@chuyenmon", "@truongid", item["ID"], "@chuyenmon", MonDay.KTCN));
                dr1["KTCN"] = KTCN1; KTCN += KTCN1;
                int KTNN1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and chuyenmon=@chuyenmon", "@truongid", item["ID"], "@chuyenmon", MonDay.MyThuat));
                dr1["KTNN"] = KTNN1; KTNN += KTNN1;
                int Tin1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and chuyenmon=@chuyenmon", "@truongid", item["ID"], "@chuyenmon", MonDay.Tin));
                dr1["Tin"] = Tin1; Tin += Tin1;
                int AmNhac1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and chuyenmon=@chuyenmon", "@truongid", item["ID"], "@chuyenmon", MonDay.AmNhac));
                dr1["AmNhac"] = AmNhac1; AmNhac += AmNhac1;
                int MiThuat1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and chuyenmon=@chuyenmon", "@truongid", item["ID"], "@chuyenmon", MonDay.TD));
                dr1["MyThuat"] = MiThuat1; MiThuat += MiThuat1;
                int CNTT1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and chuyenmon=@chuyenmon", "@truongid", item["ID"], "@chuyenmon", MonDay.TD));
                dr1["CNTT"] = CNTT1; CNTT += CNTT1;
                int TSGV1 = Van1 + Su1 + Dia1 + GDCD1 + TD1 + NgoaiNgu1 + Toan1 + Ly1 + Hoa1 + Sinh1 + KTCN1 + KTNN1 + Tin1 + AmNhac1 + MiThuat1;
                dr1["TSGV"] = TSGV1; TSGV += TSGV1;
                int TongSo1 = CBQL1 + HanhChinh1 + TPTDoi1 + TSGV1;
                dr1["TongSo"] = TongSo1; TongSo += TongSo1;
                dt.Rows.Add(dr1);
                i++;
            }
            var dr = dt.NewRow();
            dr["Title"] = "Tổng số";
            dr["TSL"] = TSL; dr["TongSo"] = TongSo; dr["TSGV"] = TSGV; dr["CBQL"] = CBQL; dr["HanhChinh"] = HanhChinh; dr["TPTDoi"] = TPTDoi; dr["TSGV"] = TSGV;
            dr["Van"] = Van; dr["Su"] = Su; dr["Dia"] = Dia; dr["GDCD"] = GDCD; dr["TD"] = TD; dr["NN"] = NgoaiNgu;
            dr["Toan"] = Toan; dr["Ly"] = Ly; dr["Hoa"] = Hoa; dr["Sinh"] = Sinh; dr["TD"] = TD; dr["KTCN"] = KTCN;
            dr["KTNN"] = KTNN; dr["Tin"] = Tin; dr["AmNhac"] = AmNhac; dr["MyThuat"] = MiThuat; dr["CNTT"] = CNTT; 
            dt.Rows.Add(dr);

            para = new List<ReportParameter>();
            return dt;
        }
        DataTable ThuaThieu(out List<ReportParameter> para)
        {
            var dt = new DataSet1().DacDiem;

            para = new List<ReportParameter>();
            return dt;
        }
        DataTable DacDiem(out List<ReportParameter> para)
        {
            var dt = new DataSet1().DacDiem;

            para = new List<ReportParameter>();
            return dt;
        }
        string GetLaMa(int k)
        {
            return k == 1 ? "I" : k == 2 ? "II" : "III";
        }
    }
}