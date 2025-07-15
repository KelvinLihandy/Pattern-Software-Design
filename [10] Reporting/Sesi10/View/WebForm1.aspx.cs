using Sesi10.Dataset;
using Sesi10.Handler;
using Sesi10.Model;
using Sesi10.Report;
using System;
using System.Collections.Generic;
using System.Data;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sesi10.View
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CrystalReport1 report = new CrystalReport1();
            CrystalReportViewer1.ReportSource = report;
            DataSet1 ds = GetData(TransactionHandler.GetData());
            report.SetDataSource(ds);
        }

        private static DataSet1 GetData(List<transaction> transactions)
        {
            DataSet1 data = new DataSet1();
            var headerTable = data.TableTransaction;
            var detailTable = data.TableTransactionDetail;
            foreach(transaction t  in transactions)
            {
                var hrow = headerTable.NewRow();
                hrow["id"] = t.Id;
                hrow["user_id"] = t.user_id;
                hrow["transaction_date"] = t.transaction_date;
                headerTable.Rows.Add(hrow);
                foreach(transactiondetail d in t.transactiondetails)
                {
                    var drow = detailTable.NewRow();
                    drow["transactionid"] =  d.transactionId;
                    drow["clothId"] = d.clothId;
                    drow["quantity"] = d.quantity;
                    detailTable.Rows.Add(drow);
                }
            }
            return data;
        }
    }
}