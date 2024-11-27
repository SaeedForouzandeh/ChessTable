using System;
using System.Web.UI;


namespace Chess
{
    public partial class Error : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        void Application_Error(object sender, EventArgs e)
        {
            // دریافت خطای کلی
            Exception exception = Server.GetLastError();
            // می‌توانید در اینجا اطلاعات بیشتری برای لاگ کردن خطا اضافه کنید
            Server.ClearError();
            Response.Redirect("~/Error.aspx");
        }
    }
}

