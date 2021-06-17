using Newtonsoft.Json;
using OM.WS.DATOSEMPLEADO.BE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace NOM.WA.DATOSEMPLEADO.FE
{
    public partial class Default : System.Web.UI.Page
    {
        string BaseUrl = "http://localhost:64938/";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            List<Colaborador> colaboradors = new List<Colaborador>();

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl);

            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("/api/collaborators/").Result; 
            if (response.IsSuccessStatusCode)
            {
               
                var data = response.Content.ReadAsAsync<IEnumerable<Colaborador>>().Result;
                foreach(Colaborador colabo in data)
                {
                    
                    colaboradors.Add(colabo);
                }
                gridColaboradores.DataSource = colaboradors;
                gridColaboradores.DataBind();

            }
            
            client.Dispose();
        }

        private void gridColaboradores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                MessageBox.Show("EDIT button clicked at row: " + e.RowIndex);
            }
            else
            {
                if (e.ColumnIndex == 5)
                {
                    MessageBox.Show("DELETE button clicked at row: " + e.RowIndex);
                }
                else
                {
                    // buttons not clicked - ignoring
                    //MessageBox.Show("Button cells were not clicked -- row: " + e.RowIndex + " Column: " + e.ColumnIndex);
                }
            }
        }

        protected void gridColaboradores_SelectedIndexChanged1(object sender, EventArgs e)
        {
            var ele = gridColaboradores.SelectedRow.Cells[5].Text;
        

            string javaScript = "mostrarRiesgo("+ele+");";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", javaScript, true);

         
        }
    }
}