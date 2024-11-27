using System;
using System.Web;

namespace ChessBoardApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // انتقال داده‌ها به صفحه نمایش جدول
            string rows = txtRows.Text;
            string columns = txtColumns.Text;

            if (int.TryParse(rows, out _) && int.TryParse(columns, out _))
            {
                Response.Redirect($"ChessTable.aspx?rows={rows}&columns={columns}");
            }
            else
            {
                Response.Write("<script>alert('لطفاً مقادیر معتبر وارد کنید!');</script>");
            }
        }
    }
}
