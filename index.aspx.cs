using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BASICDB
{
    public partial class index : System.Web.UI.Page
    {
        DB1Entities edm = new DB1Entities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if((txtUser.Text.Trim() != "") && (txtPass.Text.Trim() != ""))
            {
                user u = new user();
                u.username = txtUser.Text.Trim();
                u.pass = txtPass.Text.Trim();

                if(edm.Database.Connection.State == System.Data.ConnectionState.Closed)
                {
                    edm.Database.Connection.Open();

                }
                edm.users.Add(u);
                edm.SaveChanges();

                txtPass.Text = "";
                txtUser.Text = "";
                showUser();
            }

        }
        private void showUser()
        {
            var us = from p in edm.users
                     orderby p.id descending
                     select new
                     {
                         id = p.id,
                         username = p.username
                     };
            if (us.Count() > 0)
            {
                GridView1.DataSource = us.ToList();
                GridView1.DataBind();
            }
        }
    }
}