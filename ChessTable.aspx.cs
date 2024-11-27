using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChessBoardApp
{
    public partial class ChessTable : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // تلاش برای دریافت تعداد سطر و ستون از QueryString
                string rowsParam = Request.QueryString["rows"];
                string columnsParam = Request.QueryString["columns"];

                // بررسی اینکه پارامترها خالی نباشند
                if (string.IsNullOrEmpty(rowsParam) || string.IsNullOrEmpty(columnsParam))
                {
                    // اگر پارامترها وجود نداشتند، هدایت به صفحه خطا
                    Response.Redirect("~/Error.aspx");
                    return;
                }

                int rows;
                int columns;

                // تلاش برای تبدیل پارامترهای ورودی به عدد صحیح
                bool isValidRows = int.TryParse(rowsParam, out rows);
                bool isValidColumns = int.TryParse(columnsParam, out columns);

                // اگر یکی از مقادیر نادرست بود، هدایت به صفحه خطا
                if (!isValidRows || !isValidColumns || rows <= 0 || columns <= 0)
                {
                    Response.Redirect("~/Error.aspx");
                    return;
                }

                // تولید جدول شطرنج
                Table table = new Table();
                table.CssClass = "chess-board";

                for (int i = 0; i < rows; i++)
                {
                    TableRow row = new TableRow();
                    for (int j = 0; j < columns; j++)
                    {
                        TableCell cell = new TableCell();
                        // تعیین متن A یا B بر اساس موقعیت خانه
                        cell.Text = (i + j) % 2 == 0 ? "A" : "B";
                        row.Cells.Add(cell);
                    }
                    table.Rows.Add(row);
                }

                // افزودن جدول به PlaceHolder
                TablePlaceholder.Controls.Add(table);

                // نمایش اطلاعات جدول در لیبل
                lblTableInfo.Text = $"جدول دارای {rows} سطر و {columns} ستون است.";
            }
        }
    }
}
