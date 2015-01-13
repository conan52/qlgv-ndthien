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
