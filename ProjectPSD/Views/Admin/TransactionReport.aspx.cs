using ProjectPSD.Controllers;
using ProjectPSD.Dataset;
using ProjectPSD.Models;
using ProjectPSD.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectPSD.Views.Admin
{
    public partial class TransactionReport : System.Web.UI.Page
    {
        ReportController reportController = new ReportController();
        int grandTotal = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            CrystalReport1 report = new CrystalReport1();
            CrystalReportViewer1.ReportSource = report;
            DataSet1 data = getData(reportController.getTransactions());
            report.SetDataSource(data);
            report.SetParameterValue("GrandTotal", grandTotal);
        }

        private DataSet1 getData(List<TransactionHeader> transactions)
        {
            DataSet1 data = new DataSet1();
            var headerTable = data.TransactionHeader;
            var detailTable = data.TransactionDetail;
            foreach(TransactionHeader t in transactions)
            {
                var hrow = headerTable.NewRow();
                hrow["TransactionID"] = t.TransactionID;
                hrow["Username"] = t.User.UserName;
                hrow["TransactionDate"] = t.TransactionDate;
                hrow["Status"] = t.status;
                int htotal = 0;
                headerTable.Rows.Add(hrow);
                foreach (TransactionDetail d in t.TransactionDetails)
                {
                    var drow = detailTable.NewRow();
                    drow["TransactionID"] = d.TransactionID;
                    drow["MakeupName"] = d.Makeup.MakeupName;
                    drow["Weight"] = d.Makeup.MakeupWeight;
                    drow["Type"] = d.Makeup.MakeupType.MakeupTypeName;
                    drow["Brand"] = d.Makeup.MakeupBrand.MakeupBrandName;
                    drow["BrandRating"] = d.Makeup.MakeupBrand.MakeupBrandRating;
                    drow["Quantity"] = d.Quantity;
                    drow["Price"] = d.Makeup.MakeupPrice;
                    int dtotal = d.Quantity * d.Makeup.MakeupPrice;
                    drow["Total"] = dtotal;
                    htotal += dtotal;
                    detailTable.Rows.Add(drow);
                }
                hrow["Subtotal"] = htotal;
                grandTotal += htotal;
            }
            return data;
        }
    }
}