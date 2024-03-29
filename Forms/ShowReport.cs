﻿using System;
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
                case "TDMamNon":
                    dt = TDMamNon(out para);
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLGV.Reports.TDMamNon.rdlc";
                    break;
                case "TDTieuHoc":
                    dt = TDTieuHoc(out para);
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLGV.Reports.TDMamNon.rdlc";
                    break;
                case "TDTHCS":
                    dt = TDTHCS(out para);
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLGV.Reports.TDMamNon.rdlc";
                    break;
                case "TDTH":
                    dt = TDTH(out para);
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLGV.Reports.TDTH.rdlc";
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

                    int tdgiao = int.Parse("0" + item["DuocGiaoCB"]) + int.Parse("0" + item["DuocGiaoHC"]) +
                        int.Parse("0" + item["DuocGiaoCNTT"]) + int.Parse("0" + item[tf.DuocGiaoGV]) + int.Parse("0" + item[tf.DuocGiaoTPT]);
                    duocgiaotong1 += tdgiao;
                    dr1["TongSoDuocGiao"] = tdgiao;
                    dr1["DuocGiaoGV"] = item[tf.DuocGiaoGV];
                    duocgiaogv1 += int.Parse("0" + item[tf.DuocGiaoGV]);
                    dr1["DuocGiaoHC"] = item["DuocGiaoHC"];
                    duocgiaohc1 += int.Parse("0" + item["DuocGiaoHC"]);
                    dr1["DuocGiaoCNTT"] = item["DuocGiaoCNTT"];
                    duocgiaocntt1 += int.Parse("0" + item["DuocGiaoCNTT"]);
                    dr1["DuocGiaoCBQL"] = int.Parse("0" + item[tf.DuocGiaoCB]); ;
                    duocgiaocbql1 += int.Parse("0" + item[tf.DuocGiaoCB]);
                    dr1["DuocGiaoTPT"] = int.Parse("0" + item[tf.DuocGiaoTPT]);
                    duocgiaotpt1 += int.Parse("0" + item[tf.DuocGiaoTPT]);

                    int comatcbql1_1 = int.Parse("0" + SQLiteUtils.GetTable("select count(1) from canbo where truongid=@truongid and chucvu=@chucvu", "@truongid", item[tf.ID], "@chucvu", ChucVu.CBQL).Rows[0][0]);
                    int comatgv1_1 = int.Parse("0" + SQLiteUtils.GetTable(
                    string.Format("select count(1) from canbo where truongid=@truongid and (chucvu='{0}' or chucvu='{1}' or chucvu='{2}')", ChucVu.GVBC, ChucVu.GVHDCBH, ChucVu.GVHDKBH), "@truongid", item[tf.ID]).Rows[0][0]);
                    int comattpt1_1 = int.Parse("0" + SQLiteUtils.GetTable("select count(1) from canbo where truongid=@truongid and chucvu=@chucvu", "@truongid", item[tf.ID], "@chucvu", ChucVu.TPTDoi).Rows[0][0]);
                    int comathc1_1 = int.Parse("0" + SQLiteUtils.GetTable("select count(1) from canbo where truongid=@truongid and chucvu=@chucvu", "@truongid", item[tf.ID], "@chucvu", ChucVu.HanhChinh).Rows[0][0]);
                    int comatcntt1_1 = int.Parse("0" + SQLiteUtils.GetTable("select count(1) from canbo where truongid=@truongid and chucvu=@chucvu", "@truongid", item[tf.ID], "@chucvu", ChucVu.CNTT).Rows[0][0]);
                    int tcm = comatcbql1_1 + comatgv1_1 + comattpt1_1 + comathc1_1 + comatcntt1_1;

                    dr1["TongSoCoMat"] = tcm; comattong1 += tcm;
                    dr1["CoMatGV"] = comatgv1_1; comatgv1 += comatgv1_1;
                    dr1["CoMatHC"] = comathc1_1; comathc1 += comathc1_1;
                    dr1["CoMatCNTT"] = comatcntt1_1; comatcntt1 += comatcntt1_1;
                    dr1["CoMatCBQL"] = comatcbql1_1; comatcbql1 += comatcbql1_1;
                    dr1["CoMatTPT"] = comattpt1_1; comattpt1 += comattpt1_1;

                    dr1["TongTT"] = tcm - tdgiao;
                    tttong1 += (tcm - tdgiao);
                    dr1["TTCBQL"] = comatcbql1_1 - int.Parse("0" + item[tf.DuocGiaoCB]);
                    ttcbql1 += comatcbql1_1 - int.Parse("0" + item[tf.DuocGiaoCB]);
                    dr1["TTGV"] = comatgv1_1 - int.Parse("0" + item[tf.DuocGiaoGV]);
                    ttgv1 += comatgv1_1 - int.Parse("0" + item[tf.DuocGiaoGV]);

                    dr1["TTHC"] = comathc1_1 - int.Parse("0" + item[tf.DuocGiaoHC]);
                    tthc1 += comathc1_1 - int.Parse("0" + item[tf.DuocGiaoHC]);

                    dr1["TTCNTT"] = comatcntt1_1 - int.Parse("0" + item[tf.DuocGiaoCNTT]);
                    ttcntt1 += comatcntt1_1 - int.Parse("0" + item[tf.DuocGiaoCNTT]);

                    dr1["TS"] = "Xét";// item["CoMatCB"];
                    dr1["TS1"] = "Xét";//int.Parse("0" + item["CoMatCB"]);
                    dr1["TS2"] = "Xét";//int.Parse("0" + item["CoMatCNTT"]) + int.Parse("0" + item["CoMatHC"]);
                    dt.Rows.Add(dr1);
                    i++;
                }
                #region Sum
                tsx = comattpt1; ts11 = comatcbql1 + comatgv1 + comattpt1; ts21 = comathc1 + comatcntt1;
                dr["STT"] = GetLaMa(k);
                dr["Title"] = "     " + row["Title"];
                dr["TongSoDuocGiao"] = duocgiaotong1;
                dr["DuocGiaoGV"] = duocgiaogv1;
                dr["DuocGiaoHC"] = duocgiaohc1; dr["DuocGiaoCNTT"] = duocgiaocntt1; dr["DuocGiaoCBQL"] = duocgiaocbql1; dr["DuocGiaoTPT"] = duocgiaotpt1;
                dr["TongSoCoMat"] = comattong1; dr["CoMatGV"] = comatgv1; dr["CoMatCNTT"] = comatcntt1; dr["CoMatCBQL"] = comatcbql1; dr["CoMatTPT"] = comattpt1; dr["CoMatHC"] = comathc1;
                dr["TongTT"] = tttong1; dr["TTGV"] = ttgv1; dr["TTHC"] = tthc1; dr["TTCNTT"] = ttcntt1; dr["TTCBQL"] = ttcbql1;
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
            foreach (DataRow item in dt.Rows)
            {
                for (int j = 3; j < dt.Columns.Count; j++)
                {
                    int x;
                    int.TryParse("0" + item[j], out x);
                    if(x==0) item[j] = null;
                }
            }
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

                CBQL1 = int.Parse("0" + SQLiteUtils.GetTable("select count(1) from canbo where truongid=@truongid and chucvu=@chucvu", "@truongid", item["ID"], "@chucvu", ChucVu.CBQL).Rows[0][0]);
                dr1["CBQL"] = CBQL1; CBQL += CBQL1;

                HanhChinh1 = int.Parse("0" + SQLiteUtils.GetTable("select count(1) from canbo where truongid=@truongid and chucvu=@chucvu", "@truongid", item["ID"], "@chucvu", ChucVu.HanhChinh).Rows[0][0]);
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
            foreach (DataRow item in dt.Rows)
            {
                for (int k = 3; k < dt.Columns.Count; k++)
                {
                    if (int.Parse("0" + item[k]) == 0) item[k] = null;
                }
            }
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

                int TSHS1 = int.Parse("0" + item[tf.SoHocSinh]);
                dr1["TSHS"] = TSHS1; TSHS += TSHS;

                int CBQL1 = int.Parse("0" + SQLiteUtils.GetTable("select count(1) from canbo where truongid=@truongid and chucvu=@chucvu", "@truongid", item["ID"], "@chucvu", ChucVu.CBQL).Rows[0][0]);
                dr1["CBQL"] = CBQL1; CBQL += CBQL1;

                int HanhChinh1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and chucvu=@chucvu", "@truongid", item["ID"], "@chucvu", ChucVu.HanhChinh));
                dr1["HanhChinh"] = HanhChinh1; HanhChinh += HanhChinh1;

                int TPTDoi1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and chucvu=@chucvu", "@truongid", item["ID"], "@chucvu", ChucVu.TPTDoi));
                dr1["TPTDoi"] = TPTDoi1; TPTDoi += TPTDoi1;

                int VanHoa1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and monday=@monday", "@truongid", item["ID"], "@monday", MonDay.VanHoa));
                dr1["VanHoa"] = VanHoa1; VanHoa += VanHoa1;
                int AmNhac1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and monday=@monday", "@truongid", item["ID"], "@monday", MonDay.AmNhac));
                dr1["AmNhac"] = AmNhac1; AmNhac += AmNhac1;
                int MiThuat1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and monday=@monday", "@truongid", item["ID"], "@monday", MonDay.MyThuat));
                dr1["MiThuat"] = MiThuat1; MiThuat += MiThuat1;
                int NgoaiNgu1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and monday=@monday", "@truongid", item["ID"], "@monday", MonDay.NN));
                dr1["NgoaiNgu"] = NgoaiNgu1; NgoaiNgu += NgoaiNgu1;
                int TinHoc1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and monday=@monday", "@truongid", item["ID"], "@monday", MonDay.Tin));
                dr1["TinHoc"] = TinHoc1; TinHoc += TinHoc1;
                int TheDuc1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and monday=@monday", "@truongid", item["ID"], "@monday", MonDay.TD));
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
            foreach (DataRow item in dt.Rows)
            {
                for (int k = 3; k < dt.Columns.Count; k++)
                {
                    if (int.Parse("0" + item[k]) == 0) item[k] = null;
                }
            }
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
                int Van1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and monday=@monday", "@truongid", item["ID"], "@monday", MonDay.Van));
                dr1["Van"] = Van1; Van += Van1;
                int Su1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and monday=@monday", "@truongid", item["ID"], "@monday", MonDay.Su));
                dr1["Su"] = Su1; Su += Su1;
                int Dia1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and monday=@monday", "@truongid", item["ID"], "@monday", MonDay.Dia));
                dr1["Dia"] = Dia1; Dia += Dia1;
                int GDCD1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and monday=@monday", "@truongid", item["ID"], "@monday", MonDay.GDCD));
                dr1["GDCD"] = GDCD1; GDCD += GDCD1;
                int TD1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and monday=@monday", "@truongid", item["ID"], "@monday", MonDay.TD));
                dr1["TD"] = TD1; TD1 += TD1;
                int NgoaiNgu1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and monday=@monday", "@truongid", item["ID"], "@monday", MonDay.NN));
                dr1["NN"] = NgoaiNgu1; NgoaiNgu += NgoaiNgu1;
                dr1["Su"] = Su1; Su += Su1;
                int Toan1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and monday=@monday", "@truongid", item["ID"], "@monday", MonDay.Toan));
                dr1["Toan"] = Toan1; Toan1 += Toan1;
                int Ly1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and monday=@monday", "@truongid", item["ID"], "@monday", MonDay.Ly));
                dr1["Ly"] = Ly1; Ly += Ly1;
                int Hoa1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and monday=@monday", "@truongid", item["ID"], "@monday", MonDay.MyThuat));
                dr1["Hoa"] = Hoa1; Hoa += Hoa1;
                int Sinh1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and monday=@monday", "@truongid", item["ID"], "@monday", MonDay.MyThuat));
                dr1["Sinh"] = Sinh1; Sinh += Sinh1;
                int KTCN1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and monday=@monday", "@truongid", item["ID"], "@monday", MonDay.KTCN));
                dr1["KTCN"] = KTCN1; KTCN += KTCN1;
                int KTNN1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and monday=@monday", "@truongid", item["ID"], "@monday", MonDay.MyThuat));
                dr1["KTNN"] = KTNN1; KTNN += KTNN1;
                int Tin1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and monday=@monday", "@truongid", item["ID"], "@monday", MonDay.Tin));
                dr1["Tin"] = Tin1; Tin += Tin1;
                int AmNhac1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and monday=@monday", "@truongid", item["ID"], "@monday", MonDay.AmNhac));
                dr1["AmNhac"] = AmNhac1; AmNhac += AmNhac1;
                int MiThuat1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and monday=@monday", "@truongid", item["ID"], "@monday", MonDay.TD));
                dr1["MyThuat"] = MiThuat1; MiThuat += MiThuat1;
                int CNTT1 = int.Parse("0" + SQLiteUtils.ExcuteScalar("select count(1) from canbo where truongid=@truongid and monday=@monday", "@truongid", item["ID"], "@monday", MonDay.TD));
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
            foreach (DataRow item in dt.Rows)
            {
                for (int k = 3; k < dt.Columns.Count; k++)
                {
                    if (int.Parse("0" + item[k]) == 0) item[k] = null;
                }
            }
            para = new List<ReportParameter>();
            return dt;
        }
        DataTable ThuaThieu(out List<ReportParameter> para)
        {
            var dttruong = SQLiteUtils.GetTable("select * from truonginfo where nhomtruongid=@nhom", "@nhom", 3);
            var dt = new DataSet1().ThuaThieu;
            int i = 0;
            foreach (DataRow item in dttruong.Rows)
            {
                var dr = dt.NewRow();
                CreateRowThuaThieu(dr, item[tf.ID], ++i, item[tf.Title].ToString(), GetLaMa(int.Parse("0" + item[tf.HangTruong])));
                dt.Rows.Add(dr);
            }
            var drt = dt.NewRow();
            foreach (DataRow item in dt.Rows)
            {
                for (int k = 3; k < dt.Columns.Count; k++)
                {
                    drt[k] = int.Parse("0" + drt[k]) + int.Parse("0" + item[k]);
                    if (int.Parse("0" + item[k]) == 0) item[k] = null;
                }
            }
            drt["Title"] = "Tổng số";
            dt.Rows.Add(drt);
            para = new List<ReportParameter>();
            return dt;
        }

        DataTable TDMamNon(out List<ReportParameter> para)
        {
            DataTable dt = new DataSet1().TDMamNon;
            var dttruong = SQLiteUtils.GetTable("select * from truonginfo where nhomtruongid=@nhom", "@nhom", 1);
            int i = 0;
            var drt1 = dt.NewRow(); drt1["Title"] = "Tổng";
            var drt2 = dt.NewRow(); drt2["Title"] = "CBQL";
            var drt3 = dt.NewRow(); drt3["Title"] = "Giáo viên";
            var drt4 = dt.NewRow(); drt4["Title"] = "Hành chính";
            foreach (DataRow item in dttruong.Rows)
            {
                var drql = dt.NewRow(); var drgv = dt.NewRow(); var drhc = dt.NewRow(); var drts = dt.NewRow();
                #region CBQL
                var td = new TrinhDo();
                Count(SQLiteUtils.GetTable("select * from canbo where truongid=@truongid and chucvu=@chucvu", "@truongid", item["ID"], "@chucvu", ChucVu.CBQL), td);
                drql["Title"] = "CBQL";
                drql["TS"] = td.TS;
                drql["CBQL"] = td.CBQL;
                drql["GV"] = td.GV;
                drql["NhanVienHC"] = td.NhanVienHC;
                drql["Nu"] = td.Nu;
                drql["DangVien"] = td.DangVien;
                drql["DanTocThieuSo"] = td.DanTocThieuSo;
                drql["Duoi30"] = td.Duoi30;
                drql["Tu30Den50"] = td.Tu30Den50;
                drql["TongSo"] = td.TongSo;
                drql["Nu54Nam59"] = td.Nu54Nam59;
                drql["TuoiHuuNu55Nam60"] = td.TuoiHuuNu55Nam60;
                drql["CV_TD"] = td.CV_TD;
                drql["CS_TD"] = td.CS_TD;
                drql["ConLai_TN"] = td.ConLai_TN;
                drql["ThacSi"] = td.ThacSi;
                drql["DaiHoc"] = td.DaiHoc;
                drql["CaoDang"] = td.CaoDang;
                drql["TrungCap"] = td.TrungCap;
                drql["ConLai_CM"] = td.ConLai_CM;
                drql["LLCuNhanCC"] = td.LLCuNhanCC;
                drql["LLTrungCap"] = td.LLTrungCap;
                drql["LLSoCap"] = td.LLSoCap;
                drql["THTrungCap"] = td.THTrungCap;
                drql["THChungChi"] = td.THChungChi;
                drql["NNTrungCap"] = td.NNTrungCap;
                drql["NNChungChi"] = td.NNChungChi;
                drql["ChungChiDT"] = td.ChungChiDT;
                #endregion
                #region Giao Vien
                td = new TrinhDo();
                Count(SQLiteUtils.GetTable(string.Format("select * from canbo where truongid=@truongid and (chucvu='{0}' or chucvu='{1}' or chucvu='{2}')", ChucVu.GVBC, ChucVu.GVHDCBH, ChucVu.GVHDKBH), "@truongid", item[tf.ID]), td);
                drgv["Title"] = "Giáo viên";
                drgv["TS"] = td.TS;
                drgv["CBQL"] = td.CBQL;
                drgv["GV"] = td.GV;
                drgv["NhanVienHC"] = td.NhanVienHC;
                drgv["Nu"] = td.Nu;
                drgv["DangVien"] = td.DangVien;
                drgv["DanTocThieuSo"] = td.DanTocThieuSo;
                drgv["Duoi30"] = td.Duoi30;
                drgv["Tu30Den50"] = td.Tu30Den50;
                drgv["TongSo"] = td.TongSo;
                drgv["Nu54Nam59"] = td.Nu54Nam59;
                drgv["TuoiHuuNu55Nam60"] = td.TuoiHuuNu55Nam60;
                drgv["CV_TD"] = td.CV_TD;
                drgv["CS_TD"] = td.CS_TD;
                drgv["ConLai_TN"] = td.ConLai_TN;
                drgv["ThacSi"] = td.ThacSi;
                drgv["DaiHoc"] = td.DaiHoc;
                drgv["CaoDang"] = td.CaoDang;
                drgv["TrungCap"] = td.TrungCap;
                drgv["ConLai_CM"] = td.ConLai_CM;
                drgv["LLCuNhanCC"] = td.LLCuNhanCC;
                drgv["LLTrungCap"] = td.LLTrungCap;
                drgv["LLSoCap"] = td.LLSoCap;
                drgv["THTrungCap"] = td.THTrungCap;
                drgv["THChungChi"] = td.THChungChi;
                drgv["NNTrungCap"] = td.NNTrungCap;
                drgv["NNChungChi"] = td.NNChungChi;
                drgv["ChungChiDT"] = td.ChungChiDT;
                #endregion
                #region Hanh Chinh
                td = new TrinhDo();
                Count(SQLiteUtils.GetTable(string.Format("select * from canbo where truongid=@truongid and (chucvu='{0}' or chucvu='{1}' or chucvu='{2}')", ChucVu.CNTT, ChucVu.HanhChinh, ChucVu.TPTDoi), "@truongid", item[tf.ID]), td);
                drhc["Title"] = "Nhân viên";
                drhc["TS"] = td.TS;
                drhc["CBQL"] = td.CBQL;
                drhc["GV"] = td.GV;
                drhc["NhanVienHC"] = td.NhanVienHC;
                drhc["Nu"] = td.Nu;
                drhc["DangVien"] = td.DangVien;
                drhc["DanTocThieuSo"] = td.DanTocThieuSo;
                drhc["Duoi30"] = td.Duoi30;
                drhc["Tu30Den50"] = td.Tu30Den50;
                drhc["TongSo"] = td.TongSo;
                drhc["Nu54Nam59"] = td.Nu54Nam59;
                drhc["TuoiHuuNu55Nam60"] = td.TuoiHuuNu55Nam60;
                drhc["CV_TD"] = td.CV_TD;
                drhc["CS_TD"] = td.CS_TD;
                drhc["ConLai_TN"] = td.ConLai_TN;
                drhc["ThacSi"] = td.ThacSi;
                drhc["DaiHoc"] = td.DaiHoc;
                drhc["CaoDang"] = td.CaoDang;
                drhc["TrungCap"] = td.TrungCap;
                drhc["ConLai_CM"] = td.ConLai_CM;
                drhc["LLCuNhanCC"] = td.LLCuNhanCC;
                drhc["LLTrungCap"] = td.LLTrungCap;
                drhc["LLSoCap"] = td.LLSoCap;
                drhc["THTrungCap"] = td.THTrungCap;
                drhc["THChungChi"] = td.THChungChi;
                drhc["NNTrungCap"] = td.NNTrungCap;
                drhc["NNChungChi"] = td.NNChungChi;
                drhc["ChungChiDT"] = td.ChungChiDT;
                #endregion
                drts[0] = ++i + "";
                drts[1] = item["Title"];
                drts["CBQL"] = int.Parse(drql["TS"].ToString());
                drts["GV"] = int.Parse(drgv["TS"].ToString());
                drts["NhanVienHC"] = int.Parse(drhc["TS"].ToString()); //4
                for (int k = 5; k < dt.Columns.Count; k++)
                {
                    drts[k] = int.Parse(drql[k].ToString()) + int.Parse(drgv[k].ToString()) + int.Parse(drhc[k].ToString());
                }
                for (int k = 2; k < dt.Columns.Count; k++)
                {
                    if (int.Parse("0" + drts[k]) == 0) drts[k] = null;
                    if (int.Parse(drql[k].ToString()) == 0) drql[k] = null;
                    if (int.Parse(drgv[k].ToString()) == 0) drgv[k] = null;
                    if (int.Parse(drhc[k].ToString()) == 0) drhc[k] = null;
                }
                dt.Rows.Add(drts); dt.Rows.Add(drql); dt.Rows.Add(drgv); dt.Rows.Add(drhc);

                for (int k = 2; k < dt.Columns.Count; k++)
                {
                    drt1[k] = int.Parse("0" + drt1[k].ToString()) + int.Parse("0" + drts[k].ToString());
                    drt2[k] = int.Parse("0" + drt2[k].ToString()) + int.Parse("0" + drql[k].ToString());
                    drt3[k] = int.Parse("0" + drt3[k].ToString()) + int.Parse("0" + drgv[k].ToString());
                    drt4[k] = int.Parse("0" + drt4[k].ToString()) + int.Parse("0" + drhc[k].ToString());
                }
            }
            dt.Rows.Add(drt1); dt.Rows.Add(drt2); dt.Rows.Add(drt3); dt.Rows.Add(drt4);
            para = new List<ReportParameter>();
            return dt;
        }
        DataTable TDTieuHoc(out List<ReportParameter> para)
        {
            DataTable dt = new DataSet1().TDMamNon;
            var dttruong = SQLiteUtils.GetTable("select * from truonginfo where nhomtruongid=@nhom", "@nhom", 2);
            int i = 0;
            var drt1 = dt.NewRow(); drt1["Title"] = "Tổng";
            var drt2 = dt.NewRow(); drt2["Title"] = "CBQL";
            var drt3 = dt.NewRow(); drt3["Title"] = "Giáo viên";
            var drt4 = dt.NewRow(); drt4["Title"] = "Hành chính";
            foreach (DataRow item in dttruong.Rows)
            {
                var drql = dt.NewRow(); var drgv = dt.NewRow(); var drhc = dt.NewRow(); var drts = dt.NewRow();
                #region CBQL
                var td = new TrinhDo();
                Count(SQLiteUtils.GetTable("select * from canbo where truongid=@truongid and chucvu=@chucvu", "@truongid", item["ID"], "@chucvu", ChucVu.CBQL), td);
                drql["Title"] = "CBQL";
                drql["TS"] = td.TS;
                drql["CBQL"] = td.CBQL;
                drql["GV"] = td.GV;
                drql["NhanVienHC"] = td.NhanVienHC;
                drql["Nu"] = td.Nu;
                drql["DangVien"] = td.DangVien;
                drql["DanTocThieuSo"] = td.DanTocThieuSo;
                drql["Duoi30"] = td.Duoi30;
                drql["Tu30Den50"] = td.Tu30Den50;
                drql["TongSo"] = td.TongSo;
                drql["Nu54Nam59"] = td.Nu54Nam59;
                drql["TuoiHuuNu55Nam60"] = td.TuoiHuuNu55Nam60;
                drql["CV_TD"] = td.CV_TD;
                drql["CS_TD"] = td.CS_TD;
                drql["ConLai_TN"] = td.ConLai_TN;
                drql["ThacSi"] = td.ThacSi;
                drql["DaiHoc"] = td.DaiHoc;
                drql["CaoDang"] = td.CaoDang;
                drql["TrungCap"] = td.TrungCap;
                drql["ConLai_CM"] = td.ConLai_CM;
                drql["LLCuNhanCC"] = td.LLCuNhanCC;
                drql["LLTrungCap"] = td.LLTrungCap;
                drql["LLSoCap"] = td.LLSoCap;
                drql["THTrungCap"] = td.THTrungCap;
                drql["THChungChi"] = td.THChungChi;
                drql["NNTrungCap"] = td.NNTrungCap;
                drql["NNChungChi"] = td.NNChungChi;
                drql["ChungChiDT"] = td.ChungChiDT;
                #endregion
                #region Giao Vien
                td = new TrinhDo();
                Count(SQLiteUtils.GetTable(string.Format("select * from canbo where truongid=@truongid and (chucvu='{0}' or chucvu='{1}' or chucvu='{2}')", ChucVu.GVBC, ChucVu.GVHDCBH, ChucVu.GVHDKBH), "@truongid", item[tf.ID]), td);
                drgv["Title"] = "Giáo viên";
                drgv["TS"] = td.TS;
                drgv["CBQL"] = td.CBQL;
                drgv["GV"] = td.GV;
                drgv["NhanVienHC"] = td.NhanVienHC;
                drgv["Nu"] = td.Nu;
                drgv["DangVien"] = td.DangVien;
                drgv["DanTocThieuSo"] = td.DanTocThieuSo;
                drgv["Duoi30"] = td.Duoi30;
                drgv["Tu30Den50"] = td.Tu30Den50;
                drgv["TongSo"] = td.TongSo;
                drgv["Nu54Nam59"] = td.Nu54Nam59;
                drgv["TuoiHuuNu55Nam60"] = td.TuoiHuuNu55Nam60;
                drgv["CV_TD"] = td.CV_TD;
                drgv["CS_TD"] = td.CS_TD;
                drgv["ConLai_TN"] = td.ConLai_TN;
                drgv["ThacSi"] = td.ThacSi;
                drgv["DaiHoc"] = td.DaiHoc;
                drgv["CaoDang"] = td.CaoDang;
                drgv["TrungCap"] = td.TrungCap;
                drgv["ConLai_CM"] = td.ConLai_CM;
                drgv["LLCuNhanCC"] = td.LLCuNhanCC;
                drgv["LLTrungCap"] = td.LLTrungCap;
                drgv["LLSoCap"] = td.LLSoCap;
                drgv["THTrungCap"] = td.THTrungCap;
                drgv["THChungChi"] = td.THChungChi;
                drgv["NNTrungCap"] = td.NNTrungCap;
                drgv["NNChungChi"] = td.NNChungChi;
                drgv["ChungChiDT"] = td.ChungChiDT;
                #endregion
                #region Hanh Chinh
                td = new TrinhDo();
                Count(SQLiteUtils.GetTable(string.Format("select * from canbo where truongid=@truongid and (chucvu='{0}' or chucvu='{1}' or chucvu='{2}')", ChucVu.CNTT, ChucVu.HanhChinh, ChucVu.TPTDoi), "@truongid", item[tf.ID]), td);
                drhc["Title"] = "Nhân viên";
                drhc["TS"] = td.TS;
                drhc["CBQL"] = td.CBQL;
                drhc["GV"] = td.GV;
                drhc["NhanVienHC"] = td.NhanVienHC;
                drhc["Nu"] = td.Nu;
                drhc["DangVien"] = td.DangVien;
                drhc["DanTocThieuSo"] = td.DanTocThieuSo;
                drhc["Duoi30"] = td.Duoi30;
                drhc["Tu30Den50"] = td.Tu30Den50;
                drhc["TongSo"] = td.TongSo;
                drhc["Nu54Nam59"] = td.Nu54Nam59;
                drhc["TuoiHuuNu55Nam60"] = td.TuoiHuuNu55Nam60;
                drhc["CV_TD"] = td.CV_TD;
                drhc["CS_TD"] = td.CS_TD;
                drhc["ConLai_TN"] = td.ConLai_TN;
                drhc["ThacSi"] = td.ThacSi;
                drhc["DaiHoc"] = td.DaiHoc;
                drhc["CaoDang"] = td.CaoDang;
                drhc["TrungCap"] = td.TrungCap;
                drhc["ConLai_CM"] = td.ConLai_CM;
                drhc["LLCuNhanCC"] = td.LLCuNhanCC;
                drhc["LLTrungCap"] = td.LLTrungCap;
                drhc["LLSoCap"] = td.LLSoCap;
                drhc["THTrungCap"] = td.THTrungCap;
                drhc["THChungChi"] = td.THChungChi;
                drhc["NNTrungCap"] = td.NNTrungCap;
                drhc["NNChungChi"] = td.NNChungChi;
                drhc["ChungChiDT"] = td.ChungChiDT;
                #endregion
                drts[0] = ++i + "";
                drts[1] = item["Title"];
                drts["CBQL"] = int.Parse(drql["TS"].ToString());
                drts["GV"] = int.Parse(drgv["TS"].ToString());
                drts["NhanVienHC"] = int.Parse(drhc["TS"].ToString()); //4
                for (int k = 5; k < dt.Columns.Count; k++)
                {
                    drts[k] = int.Parse(drql[k].ToString()) + int.Parse(drgv[k].ToString()) + int.Parse(drhc[k].ToString());
                }
                for (int k = 2; k < dt.Columns.Count; k++)
                {
                    if (int.Parse("0" + drts[k]) == 0) drts[k] = null;
                    if (int.Parse(drql[k].ToString()) == 0) drql[k] = null;
                    if (int.Parse(drgv[k].ToString()) == 0) drgv[k] = null;
                    if (int.Parse(drhc[k].ToString()) == 0) drhc[k] = null;
                }
                dt.Rows.Add(drts); dt.Rows.Add(drql); dt.Rows.Add(drgv); dt.Rows.Add(drhc);

                for (int k = 2; k < dt.Columns.Count; k++)
                {
                    drt1[k] = int.Parse("0" + drt1[k].ToString()) + int.Parse("0" + drts[k].ToString());
                    drt2[k] = int.Parse("0" + drt2[k].ToString()) + int.Parse("0" + drql[k].ToString());
                    drt3[k] = int.Parse("0" + drt3[k].ToString()) + int.Parse("0" + drgv[k].ToString());
                    drt4[k] = int.Parse("0" + drt4[k].ToString()) + int.Parse("0" + drhc[k].ToString());
                }
            }
            dt.Rows.Add(drt1); dt.Rows.Add(drt2); dt.Rows.Add(drt3); dt.Rows.Add(drt4);
            para = new List<ReportParameter>();
            return dt;
        }
        DataTable TDTHCS(out List<ReportParameter> para)
        {
            DataTable dt = new DataSet1().TDMamNon;
            var dttruong = SQLiteUtils.GetTable("select * from truonginfo where nhomtruongid=@nhom", "@nhom", 3);
            int i = 0;
            var drt1 = dt.NewRow(); drt1["Title"] = "Tổng";
            var drt2 = dt.NewRow(); drt2["Title"] = "CBQL";
            var drt3 = dt.NewRow(); drt3["Title"] = "Giáo viên";
            var drt4 = dt.NewRow(); drt4["Title"] = "Hành chính";
            foreach (DataRow item in dttruong.Rows)
            {
                var drql = dt.NewRow(); var drgv = dt.NewRow(); var drhc = dt.NewRow(); var drts = dt.NewRow();
                #region CBQL
                var td = new TrinhDo();
                Count(SQLiteUtils.GetTable("select * from canbo where truongid=@truongid and chucvu=@chucvu", "@truongid", item["ID"], "@chucvu", ChucVu.CBQL), td);
                drql["Title"] = "CBQL";
                drql["TS"] = td.TS;
                drql["CBQL"] = td.CBQL;
                drql["GV"] = td.GV;
                drql["NhanVienHC"] = td.NhanVienHC;
                drql["Nu"] = td.Nu;
                drql["DangVien"] = td.DangVien;
                drql["DanTocThieuSo"] = td.DanTocThieuSo;
                drql["Duoi30"] = td.Duoi30;
                drql["Tu30Den50"] = td.Tu30Den50;
                drql["TongSo"] = td.TongSo;
                drql["Nu54Nam59"] = td.Nu54Nam59;
                drql["TuoiHuuNu55Nam60"] = td.TuoiHuuNu55Nam60;
                drql["CV_TD"] = td.CV_TD;
                drql["CS_TD"] = td.CS_TD;
                drql["ConLai_TN"] = td.ConLai_TN;
                drql["ThacSi"] = td.ThacSi;
                drql["DaiHoc"] = td.DaiHoc;
                drql["CaoDang"] = td.CaoDang;
                drql["TrungCap"] = td.TrungCap;
                drql["ConLai_CM"] = td.ConLai_CM;
                drql["LLCuNhanCC"] = td.LLCuNhanCC;
                drql["LLTrungCap"] = td.LLTrungCap;
                drql["LLSoCap"] = td.LLSoCap;
                drql["THTrungCap"] = td.THTrungCap;
                drql["THChungChi"] = td.THChungChi;
                drql["NNTrungCap"] = td.NNTrungCap;
                drql["NNChungChi"] = td.NNChungChi;
                drql["ChungChiDT"] = td.ChungChiDT;
                #endregion
                #region Giao Vien
                td = new TrinhDo();
                Count(SQLiteUtils.GetTable(string.Format("select * from canbo where truongid=@truongid and (chucvu='{0}' or chucvu='{1}' or chucvu='{2}')", ChucVu.GVBC, ChucVu.GVHDCBH, ChucVu.GVHDKBH), "@truongid", item[tf.ID]), td);
                drgv["Title"] = "Giáo viên";
                drgv["TS"] = td.TS;
                drgv["CBQL"] = td.CBQL;
                drgv["GV"] = td.GV;
                drgv["NhanVienHC"] = td.NhanVienHC;
                drgv["Nu"] = td.Nu;
                drgv["DangVien"] = td.DangVien;
                drgv["DanTocThieuSo"] = td.DanTocThieuSo;
                drgv["Duoi30"] = td.Duoi30;
                drgv["Tu30Den50"] = td.Tu30Den50;
                drgv["TongSo"] = td.TongSo;
                drgv["Nu54Nam59"] = td.Nu54Nam59;
                drgv["TuoiHuuNu55Nam60"] = td.TuoiHuuNu55Nam60;
                drgv["CV_TD"] = td.CV_TD;
                drgv["CS_TD"] = td.CS_TD;
                drgv["ConLai_TN"] = td.ConLai_TN;
                drgv["ThacSi"] = td.ThacSi;
                drgv["DaiHoc"] = td.DaiHoc;
                drgv["CaoDang"] = td.CaoDang;
                drgv["TrungCap"] = td.TrungCap;
                drgv["ConLai_CM"] = td.ConLai_CM;
                drgv["LLCuNhanCC"] = td.LLCuNhanCC;
                drgv["LLTrungCap"] = td.LLTrungCap;
                drgv["LLSoCap"] = td.LLSoCap;
                drgv["THTrungCap"] = td.THTrungCap;
                drgv["THChungChi"] = td.THChungChi;
                drgv["NNTrungCap"] = td.NNTrungCap;
                drgv["NNChungChi"] = td.NNChungChi;
                drgv["ChungChiDT"] = td.ChungChiDT;
                #endregion
                #region Hanh Chinh
                td = new TrinhDo();
                Count(SQLiteUtils.GetTable(string.Format("select * from canbo where truongid=@truongid and (chucvu='{0}' or chucvu='{1}' or chucvu='{2}')", ChucVu.CNTT, ChucVu.HanhChinh, ChucVu.TPTDoi), "@truongid", item[tf.ID]), td);
                drhc["Title"] = "Nhân viên";
                drhc["TS"] = td.TS;
                drhc["CBQL"] = td.CBQL;
                drhc["GV"] = td.GV;
                drhc["NhanVienHC"] = td.NhanVienHC;
                drhc["Nu"] = td.Nu;
                drhc["DangVien"] = td.DangVien;
                drhc["DanTocThieuSo"] = td.DanTocThieuSo;
                drhc["Duoi30"] = td.Duoi30;
                drhc["Tu30Den50"] = td.Tu30Den50;
                drhc["TongSo"] = td.TongSo;
                drhc["Nu54Nam59"] = td.Nu54Nam59;
                drhc["TuoiHuuNu55Nam60"] = td.TuoiHuuNu55Nam60;
                drhc["CV_TD"] = td.CV_TD;
                drhc["CS_TD"] = td.CS_TD;
                drhc["ConLai_TN"] = td.ConLai_TN;
                drhc["ThacSi"] = td.ThacSi;
                drhc["DaiHoc"] = td.DaiHoc;
                drhc["CaoDang"] = td.CaoDang;
                drhc["TrungCap"] = td.TrungCap;
                drhc["ConLai_CM"] = td.ConLai_CM;
                drhc["LLCuNhanCC"] = td.LLCuNhanCC;
                drhc["LLTrungCap"] = td.LLTrungCap;
                drhc["LLSoCap"] = td.LLSoCap;
                drhc["THTrungCap"] = td.THTrungCap;
                drhc["THChungChi"] = td.THChungChi;
                drhc["NNTrungCap"] = td.NNTrungCap;
                drhc["NNChungChi"] = td.NNChungChi;
                drhc["ChungChiDT"] = td.ChungChiDT;
                #endregion
                drts[0] = ++i + "";
                drts[1] = item["Title"];
                drts["CBQL"] = int.Parse(drql["TS"].ToString());
                drts["GV"] = int.Parse(drgv["TS"].ToString());
                drts["NhanVienHC"] = int.Parse(drhc["TS"].ToString()); //4
                for (int k = 5; k < dt.Columns.Count; k++)
                {
                    drts[k] = int.Parse(drql[k].ToString()) + int.Parse(drgv[k].ToString()) + int.Parse(drhc[k].ToString());
                }
                for (int k = 2; k < dt.Columns.Count; k++)
                {
                    if (int.Parse("0" + drts[k]) == 0) drts[k] = null;
                    if (int.Parse(drql[k].ToString()) == 0) drql[k] = null;
                    if (int.Parse(drgv[k].ToString()) == 0) drgv[k] = null;
                    if (int.Parse(drhc[k].ToString()) == 0) drhc[k] = null;
                }
                dt.Rows.Add(drts); dt.Rows.Add(drql); dt.Rows.Add(drgv); dt.Rows.Add(drhc);

                for (int k = 2; k < dt.Columns.Count; k++)
                {
                    drt1[k] = int.Parse("0" + drt1[k].ToString()) + int.Parse("0" + drts[k].ToString());
                    drt2[k] = int.Parse("0" + drt2[k].ToString()) + int.Parse("0" + drql[k].ToString());
                    drt3[k] = int.Parse("0" + drt3[k].ToString()) + int.Parse("0" + drgv[k].ToString());
                    drt4[k] = int.Parse("0" + drt4[k].ToString()) + int.Parse("0" + drhc[k].ToString());
                }
            }
            dt.Rows.Add(drt1); dt.Rows.Add(drt2); dt.Rows.Add(drt3); dt.Rows.Add(drt4);
            para = new List<ReportParameter>();
            return dt;
        }
        DataTable TDTH(out List<ReportParameter> para)
        {
            int i = 0;
            DataTable dt = new DataSet1().TDTH;
            var mn_ql = dt.NewRow(); var mn_gv = dt.NewRow(); var mn_hc = dt.NewRow(); var mn_tong = dt.NewRow();//Mầm non
            CreateRow(mn_ql, 1, "Quản lý", ChucVu.CBQL);
            CreateRow(mn_gv, 1, "Giáo viên", ChucVu.GVBC, ChucVu.GVHDCBH, ChucVu.GVHDKBH);
            CreateRow(mn_hc, 1, "Hành chính", ChucVu.HanhChinh);

            mn_tong[0] = ++i + "";
            mn_tong[1] = "Khối mầm non";
            for (int k = 2; k < dt.Columns.Count; k++)
            {
                mn_tong[k] = int.Parse(mn_ql[k].ToString()) + int.Parse(mn_gv[k].ToString()) + int.Parse(mn_hc[k].ToString());
            }
            dt.Rows.Add(mn_tong); dt.Rows.Add(mn_ql); dt.Rows.Add(mn_gv); dt.Rows.Add(mn_hc);

            //////////////////////////////////////////////////////////////////
            var th_ql = dt.NewRow(); var th_tpt = dt.NewRow(); var th_gv = dt.NewRow(); var th_hc = dt.NewRow(); var th_tong = dt.NewRow();//Tiểu học
            CreateRow(th_ql, 2, "Quản lý", ChucVu.CBQL);
            CreateRow(th_tpt, 2, "Tổng phụ trách", ChucVu.TPTDoi);
            CreateRow(th_gv, 2, "Giáo viên", ChucVu.GVBC, ChucVu.GVHDCBH, ChucVu.GVHDKBH);
            CreateRow(th_hc, 2, "Hành chính", ChucVu.HanhChinh);

            th_tong[0] = ++i + "";
            th_tong[1] = "Khối tiểu học";
            for (int k = 2; k < dt.Columns.Count; k++)
            {
                th_tong[k] = int.Parse(th_ql[k].ToString()) + int.Parse(th_tpt[k].ToString()) + int.Parse(th_gv[k].ToString()) + int.Parse(th_hc[k].ToString());
            }
            dt.Rows.Add(th_tong); dt.Rows.Add(th_ql); dt.Rows.Add(th_tpt); dt.Rows.Add(th_gv); dt.Rows.Add(th_hc);

            ////////////////////////////////////////////////////////////////////////////////////////////////////
            var trh_ql = dt.NewRow(); var trh_tpt = dt.NewRow(); var trh_gv = dt.NewRow(); var trh_hc = dt.NewRow(); var trh_tong = dt.NewRow();//Trung học
            CreateRow(trh_ql, 3, "Quản lý", ChucVu.CBQL);
            CreateRow(trh_tpt, 3, "Tổng phụ trách", ChucVu.TPTDoi);
            CreateRow(trh_gv, 3, "Giáo viên", ChucVu.GVBC, ChucVu.GVHDCBH, ChucVu.GVHDKBH);
            CreateRow(trh_hc, 3, "Hành chính", ChucVu.HanhChinh);

            trh_tong[0] = ++i + "";
            trh_tong[1] = "Khối THCS";
            for (int k = 2; k < dt.Columns.Count; k++)
            {
                trh_tong[k] = int.Parse(trh_ql[k].ToString()) + int.Parse(trh_tpt[k].ToString()) + int.Parse(trh_gv[k].ToString()) + int.Parse(trh_hc[k].ToString());
            }
            dt.Rows.Add(trh_tong); dt.Rows.Add(trh_ql); dt.Rows.Add(trh_tpt); dt.Rows.Add(trh_gv); dt.Rows.Add(trh_hc);

            //////////////////////
            foreach (DataRow item in dt.Rows)
            {
                for (int k = 2; k < dt.Columns.Count; k++)
                {
                    if (int.Parse(item[k].ToString()) == 0) item[k] = null;
                }
            }

            para = new List<ReportParameter>();
            return dt;
        }

        string GetLaMa(int k)
        {
            return k == 1 ? "I" : k == 2 ? "II" : "III";
        }

        public void Count(DataTable dt, TrinhDo td)
        {
            int now = SysConfig.CurrentYear;
            td.TS = dt.Rows.Count;
            foreach (DataRow item in dt.Rows)
            {
                td.Nu += item[cbf.GioiTinh] == null ? 0 : (bool)item[cbf.GioiTinh] == false ? 1 : 0;
                td.DangVien += item[cbf.DoanVien] == null ? 0 : int.Parse(item[cbf.DoanVien].ToString()) == 2 ? 1 : 0;
                td.DanTocThieuSo += item[cbf.DanToc] == null ? 0 : int.Parse(item[cbf.DanToc].ToString()) > 1 ? 1 : 0;

                int tuoi = now - ((DateTime)item[cbf.NgaySinh]).Year;
                td.Duoi30 += tuoi < 30 ? 1 : 0;
                td.Tu30Den50 += (now - tuoi >= 30) && (now - tuoi <= 50) ? 1 : 0;
                if ((bool)item[cbf.GioiTinh] && tuoi > 50)
                {
                    td.Nu54Nam59 += tuoi < 60 ? 1 : 0;
                    td.TuoiHuuNu55Nam60 += tuoi >= 60 ? 1 : 0;
                }
                if (!(bool)item[cbf.GioiTinh] && tuoi > 50)
                {
                    td.Nu54Nam59 += tuoi < 54 ? 1 : 0;
                    td.TuoiHuuNu55Nam60 += tuoi >= 55 ? 1 : 0;
                }
                td.CV_TD += item[cbf.NgachLuong] == null ? 0 : (string)item[cbf.NgachLuong] == NghachLuong.CV_TĐ ? 1 : 0;
                td.CS_TD += item[cbf.NgachLuong] == null ? 0 : (string)item[cbf.NgachLuong] == NghachLuong.CS_TĐ ? 1 : 0;

                td.ThacSi += item[cbf.ChuyenMon] == null ? 0 : (string)item[cbf.ChuyenMon] == ChuyenMon.Ths ? 1 : 0;
                td.DaiHoc += item[cbf.ChuyenMon] == null ? 0 : (string)item[cbf.ChuyenMon] == ChuyenMon.DH ? 1 : 0;
                td.CaoDang += item[cbf.ChuyenMon] == null ? 0 : (string)item[cbf.ChuyenMon] == ChuyenMon.CD ? 1 : 0;
                td.TrungCap += item[cbf.ChuyenMon] == null ? 0 : (string)item[cbf.ChuyenMon] == ChuyenMon.TC ? 1 : 0;

                td.LLCuNhanCC += item[cbf.ChinhTri] == null ? 0 : ((string)item[cbf.ChinhTri] != LLCT.CC) || ((string)item[cbf.ChinhTri] != LLCT.CN) ? 1 : 0;
                td.LLTrungCap += item[cbf.ChinhTri] == null ? 0 : (string)item[cbf.ChinhTri] != LLCT.TC ? 1 : 0;
                td.LLSoCap += item[cbf.ChinhTri] == null ? 0 : (string)item[cbf.ChinhTri] != LLCT.SC ? 1 : 0;

                td.THTrungCap += item[cbf.TinHoc] == null ? 0 : (string)item[cbf.TinHoc] != TinHoc.TCTL ? 1 : 0;
                td.THChungChi += item[cbf.TinHoc] == null ? 0 : (string)item[cbf.TinHoc] != TinHoc.CC ? 1 : 0;

                td.NNTrungCap += item[cbf.NgoaiNgu] == null ? 0 : (string)item[cbf.NgoaiNgu] != NgoaiNgu.TCTL ? 1 : 0;
                td.NNChungChi += item[cbf.NgoaiNgu] == null ? 0 : (string)item[cbf.NgoaiNgu] != NgoaiNgu.CC ? 1 : 0;

                td.ChungChiDT += item[cbf.CoTiengDanToc] == null ? 0 : (bool)item[cbf.CoTiengDanToc] == true ? 1 : 0;
            }
            td.TongSo = td.Nu54Nam59 + td.TuoiHuuNu55Nam60;
            td.ConLai_CM = td.TS - td.ThacSi - td.DaiHoc - td.CaoDang - td.TrungCap;
            td.ConLai_TN = td.TS - td.CV_TD - td.CS_TD;
        }
        public void CountTH(DataTable dt, TrinhDoTH td)
        {
            int now = SysConfig.CurrentYear;
            td.TS = dt.Rows.Count;
            foreach (DataRow item in dt.Rows)
            {
                td.c2 += item[cbf.NgachLuong] == null ? 0 : (string)item[cbf.NgachLuong] == NghachLuong.CVCC_TĐ ? 1 : 0;
                td.c3 += item[cbf.NgachLuong] == null ? 0 : (string)item[cbf.NgachLuong] == NghachLuong.CVC_TĐ ? 1 : 0;
                td.c4 += item[cbf.NgachLuong] == null ? 0 : (string)item[cbf.NgachLuong] == NghachLuong.CV_TĐ ? 1 : 0;
                td.c5 += item[cbf.NgachLuong] == null ? 0 : (string)item[cbf.NgachLuong] == NghachLuong.CS_TĐ ? 1 : 0;

                td.c7 += item[cbf.ChuyenMon] == null ? 0 : (string)item[cbf.ChuyenMon] == ChuyenMon.TS_TSKH ? 1 : 0;
                td.c8 += item[cbf.ChuyenMon] == null ? 0 : (string)item[cbf.ChuyenMon] == ChuyenMon.Ths ? 1 : 0;
                td.c9 += item[cbf.ChuyenMon] == null ? 0 : (string)item[cbf.ChuyenMon] == ChuyenMon.DH ? 1 : 0;
                td.c10 += item[cbf.ChuyenMon] == null ? 0 : (string)item[cbf.ChuyenMon] == ChuyenMon.CD ? 1 : 0;
                td.c11 += item[cbf.ChuyenMon] == null ? 0 : (string)item[cbf.ChuyenMon] == ChuyenMon.TC ? 1 : 0;
                td.c12 += item[cbf.ChuyenMon] == null ? 0 : (string)item[cbf.ChuyenMon] == ChuyenMon.SC ? 1 : 0;

                td.c14 += item[cbf.ChinhTri] == null ? 0 : (string)item[cbf.ChinhTri] != LLCT.CC ? 1 : 0;
                td.c15 += item[cbf.ChinhTri] == null ? 0 : (string)item[cbf.ChinhTri] != LLCT.TC ? 1 : 0;

                td.c16 += item[cbf.TinHoc] == null ? 0 : (string)item[cbf.TinHoc] != TinHoc.TCTL ? 1 : 0;
                td.c17 += item[cbf.TinHoc] == null ? 0 : (string)item[cbf.TinHoc] != TinHoc.CC ? 1 : 0;

                td.c18 += item[cbf.NgoaiNgu] == null ? 0 : (string)item[cbf.NgoaiNgu] != NgoaiNgu.TCTL ? 1 : 0;
                td.c19 += item[cbf.NgoaiNgu] == null ? 0 : (string)item[cbf.NgoaiNgu] != NgoaiNgu.CC ? 1 : 0;
                td.c20 = 0;
                td.c21 = 0;

                td.c22 = 0;
                td.c23 = 0;

                int tuoi = now - ((DateTime)item[cbf.NgaySinh]).Year;
                td.c24 += tuoi < 30 ? 1 : 0;
                td.c25 += (now - tuoi >= 30) && (now - tuoi <= 50) ? 1 : 0;
                if (tuoi > 50)
                {
                    td.c26 += tuoi < 60 ? 1 : 0;
                }
                td.c27 += item[cbf.DoanVien] == null ? 0 : int.Parse(item[cbf.DoanVien].ToString()) == 2 ? 1 : 0;

                td.c28 += item[cbf.GioiTinh] == null ? 0 : (bool)item[cbf.GioiTinh] == false ? 1 : 0;
                td.c29 += item[cbf.DanToc] == null ? 0 : int.Parse(item[cbf.DanToc].ToString()) > 1 ? 1 : 0;
            }
            td.c6 = td.TS - td.c5 - td.c4 - td.c3 - td.c2;//còn lại nghạch công chức
            td.c13 = td.TS - td.c12 - td.c11 - td.c10 - td.c9 - td.c8 - td.c7;//Còn lại chuyên môn
        }
        public void CreateRow(DataRow dr, object nhomtruongid, string title, params string[] chucVuCode)
        {
            string chucvu = " ";
            for (int i = 0; i < chucVuCode.Length; i++)
            {
                string or = i == chucVuCode.Length - 1 ? null : "or";
                chucvu += string.Format("cb.chucvu='{0}' {1} ", chucVuCode[i], or);
            }
            string query = string.Format(@"select cb.* from canbo cb
inner join truonginfo tinfo on cb.truongid=tinfo.id where ({0}) and tinfo.nhomtruongid={1}", chucvu, nhomtruongid);
            DataTable dt = SQLiteUtils.GetTable(query);
            var td = new TrinhDoTH();
            CountTH(dt, td);
            dr["Title"] = title;
            dr["TS"] = td.TS;
            dr["c2"] = td.c2;
            dr["c3"] = td.c3;
            dr["c4"] = td.c4;
            dr["c5"] = td.c5;
            dr["c6"] = td.c6;
            dr["c7"] = td.c7;
            dr["c8"] = td.c8;
            dr["c9"] = td.c9;
            dr["c10"] = td.c10;
            dr["c11"] = td.c11;
            dr["c12"] = td.c12;
            dr["c13"] = td.c13;
            dr["c14"] = td.c14;
            dr["c15"] = td.c15;
            dr["c16"] = td.c16;
            dr["c17"] = td.c17;
            dr["c18"] = td.c18;
            dr["c19"] = td.c19;
            dr["c20"] = td.c20;
            dr["c21"] = td.c21;
            dr["c22"] = td.c22;
            dr["c23"] = td.c23;
            dr["c24"] = td.c24;
            dr["c25"] = td.c25;
            dr["c26"] = td.c26;
            dr["c27"] = td.c27;
            dr["c28"] = td.c28;
            dr["c29"] = td.c29;
        }
        public DataRow CreateRowThuaThieu(DataRow dr, object truongid, int stt, string title, string hangtruong)
        {
            string query = string.Format(@"select * from canbo where truongid={0}", truongid);
            DataTable dt = SQLiteUtils.GetTable(query);
            var td = new CountThuaThieu();
            foreach (DataRow item in dt.Rows)
            {
                td.CBQL += item[cbf.ChucVu] == null ? 0 : (string)item[cbf.ChucVu] == ChucVu.CBQL ? 1 : 0;
                td.HanhChinh += item[cbf.ChucVu] == null ? 0 : (string)item[cbf.ChucVu] == ChucVu.HanhChinh ? 1 : 0;
                td.TPTDoi += item[cbf.ChucVu] == null ? 0 : (string)item[cbf.ChucVu] == ChucVu.TPTDoi ? 1 : 0;

                td.Van += item[cbf.MonDay] == null ? 0 : (string)item[cbf.MonDay] == MonDay.Van ? 1 : 0;
                td.Su += item[cbf.MonDay] == null ? 0 : (string)item[cbf.MonDay] == MonDay.Su ? 1 : 0;
                td.Dia += item[cbf.MonDay] == null ? 0 : (string)item[cbf.MonDay] == MonDay.Dia ? 1 : 0;
                td.GDCD += item[cbf.MonDay] == null ? 0 : (string)item[cbf.MonDay] == MonDay.GDCD ? 1 : 0;
                td.TD += item[cbf.MonDay] == null ? 0 : (string)item[cbf.MonDay] == MonDay.TD ? 1 : 0;
                td.NN += item[cbf.MonDay] == null ? 0 : (string)item[cbf.MonDay] == MonDay.NN ? 1 : 0;
                td.Toan += item[cbf.MonDay] == null ? 0 : (string)item[cbf.MonDay] == MonDay.Toan ? 1 : 0;
                td.Ly += item[cbf.MonDay] == null ? 0 : (string)item[cbf.MonDay] == MonDay.Ly ? 1 : 0;
                td.Hoa += item[cbf.MonDay] == null ? 0 : (string)item[cbf.MonDay] == MonDay.Hoa ? 1 : 0;
                td.Sinh += item[cbf.MonDay] == null ? 0 : (string)item[cbf.MonDay] == MonDay.Sinh ? 1 : 0;
                td.KTCN += item[cbf.MonDay] == null ? 0 : (string)item[cbf.MonDay] == MonDay.KTCN ? 1 : 0;
                td.KTNN += item[cbf.MonDay] == null ? 0 : (string)item[cbf.MonDay] == MonDay.KTNN ? 1 : 0;
                td.Tin += item[cbf.MonDay] == null ? 0 : (string)item[cbf.MonDay] == MonDay.Tin ? 1 : 0;
                td.AmNhac += item[cbf.MonDay] == null ? 0 : (string)item[cbf.MonDay] == MonDay.AmNhac ? 1 : 0;
                td.MyThuat += item[cbf.MonDay] == null ? 0 : (string)item[cbf.MonDay] == MonDay.MyThuat ? 1 : 0;
                td.CNTT += item[cbf.MonDay] == null ? 0 : (string)item[cbf.MonDay] == MonDay.CNTT ? 1 : 0;
            }
            td.TongSo = td.CBQL + td.HanhChinh + td.TPTDoi;
            td.TSGV = td.Van + td.Su + td.Dia + td.GDCD + td.TD + td.NN + td.Toan + td.Ly + td.Hoa + td.Sinh + td.KTCN + td.KTNN + td.AmNhac + td.MyThuat + td.CNTT;
            #region Set datarow
            dr["STT"] = stt;
            dr["Title"] = title;
            dr["HangTruong"] = hangtruong;
            dr["TSL"] = td.TSL;
            dr["TongSo"] = td.TongSo;
            dr["CBQL"] = td.CBQL;
            dr["HanhChinh"] = td.HanhChinh;
            dr["TPTDoi"] = td.TPTDoi;
            dr["TSGV"] = td.TSGV;
            dr["Van"] = td.Van;
            dr["Su"] = td.Su;
            dr["Dia"] = td.Dia;
            dr["GDCD"] = td.GDCD;
            dr["TD"] = td.TD;
            dr["NN"] = td.NN;
            dr["Toan"] = td.Toan;
            dr["Ly"] = td.Ly;
            dr["Hoa"] = td.Hoa;
            dr["Sinh"] = td.Sinh;
            dr["KTCN"] = td.KTCN;
            dr["KTNN"] = td.KTNN;
            dr["Tin"] = td.Tin;
            dr["AmNhac"] = td.AmNhac;
            dr["MyThuat"] = td.MyThuat;
            dr["CNTT"] = td.CNTT;

            return dr;
            #endregion
        }
    }
}