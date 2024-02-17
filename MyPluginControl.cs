using McTools.Xrm.Connection;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Metadata.Query;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using XrmToolBox.Extensibility;

namespace PowerBIOptionSetValueToTextConverter
{
    public partial class MyPluginControl : PluginControlBase
    {

        string LangId = "";
        string ObjectTypeCode1="";
        string AttributeName = "";

        private Settings mySettings;

        public MyPluginControl()
        {
            InitializeComponent();
        }
        private static List<EntityMetadata> GetEntityMetadataCollection(IOrganizationService organizationService)
        {
            List<EntityMetadata> lstEntityMetadata = new List<EntityMetadata>();
            try
            {
                MetadataFilterExpression metadataFilterExpression = new MetadataFilterExpression(LogicalOperator.And);
                MetadataPropertiesExpression metadataPropertiesExpression = new MetadataPropertiesExpression { AllProperties = false };
                metadataPropertiesExpression.PropertyNames.Add("LogicalName");
                metadataPropertiesExpression.PropertyNames.Add("ObjectTypeCode");
                EntityQueryExpression entityQueryExpression = new EntityQueryExpression();
                entityQueryExpression.Criteria = metadataFilterExpression;
                entityQueryExpression.Properties = metadataPropertiesExpression;
                RetrieveMetadataChangesRequest retrieveMetadataChangesRequest = new RetrieveMetadataChangesRequest();
                retrieveMetadataChangesRequest.Query = entityQueryExpression;
                RetrieveMetadataChangesResponse retrieveMetadataChangesResponse = (RetrieveMetadataChangesResponse)organizationService.Execute(retrieveMetadataChangesRequest);
                if (retrieveMetadataChangesResponse.EntityMetadata != null)
                { lstEntityMetadata.AddRange(retrieveMetadataChangesResponse.EntityMetadata); }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lstEntityMetadata;
        }

        private void MyPluginControl_Load(object sender, EventArgs e)
        {
            ShowInfoNotification("This is a notification that can lead to XrmToolBox repository", new Uri("https://github.com/MscrmTools/XrmToolBox"));

            // Loads or creates the settings for the plugin
            if (!SettingsManager.Instance.TryLoad(GetType(), out mySettings))
            {
                mySettings = new Settings();

                LogWarning("Settings not found => a new settings file has been created!");
            }
            else
            {
                LogInfo("Settings found and loaded");
            }
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            CloseTool();
        }

        private void tsbSample_Click(object sender, EventArgs e)
        {
            if (Service !=null)
            {
                getlang(toolStripComboBox1, Service);
                if (dgvallentites.Rows.Count > 0)
                {
                    dgvallentites.Rows.Clear();
                }

                // Create a progress bar control named "progressBar"
                ProgressBar progressBar = new ProgressBar();
                progressBar.Minimum = 0;
                progressBar.Maximum = 100;
                progressBar.Step = 1;
                progressBar.Width = 200;

                // Add the progress bar control to your form or container
                progressBar1.Controls.Add(progressBar);

                // Create and configure the RetrieveAllEntitiesRequest
                RetrieveAllEntitiesRequest request = new RetrieveAllEntitiesRequest()
                {
                    EntityFilters = EntityFilters.Entity,
                    RetrieveAsIfPublished = true
                };

                // Execute the request asynchronously
                Task.Run(() =>
                {
                    // Execute the request and retrieve the response
                    RetrieveAllEntitiesResponse response = (RetrieveAllEntitiesResponse)Service.Execute(request);

                    // Get the total number of entities
                    int totalEntities = response.EntityMetadata.Count();

                    // Sort the entities by logical name in ascending order
                    var sortedEntities = response.EntityMetadata.OrderBy(e1 => e1.LogicalName);

                    // Loop through the sorted entities and print their details
                    for (int i = 0; i < totalEntities; i++)
                    {
                        EntityMetadata entityMetadata = sortedEntities.ElementAt(i);

                        // Update the progress bar value based on the current entity index
                        int progress = (i + 1) * 100 / totalEntities;
                        progressBar.Invoke((MethodInvoker)delegate { progressBar.Value = progress; });

                        // Add the entity details to the DataGridView control
                        dgvallentites.Invoke((MethodInvoker)delegate
                        {
                            dgvallentites.Rows.Add(entityMetadata.LogicalName, entityMetadata.ObjectTypeCode);
                        });
                    }

                    // Hide or remove the progress bar control
                    progressBar.Invoke((MethodInvoker)delegate { progressBar.Dispose(); });
                });
            }
            else
            {
                MessageBox.Show("You must connect first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void GetAccounts()
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Getting accounts",
                Work = (worker, args) =>
                {
                    args.Result = Service.RetrieveMultiple(new QueryExpression("account")
                    {
                        TopCount = 50
                    });
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    var result = args.Result as EntityCollection;
                    if (result != null)
                    {
                        MessageBox.Show($"Found {result.Entities.Count} accounts");
                    }
                }
            });
        }

        /// <summary>
        /// This event occurs when the plugin is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyPluginControl_OnCloseTool(object sender, EventArgs e)
        {
            // Before leaving, save the settings
            SettingsManager.Instance.Save(GetType(), mySettings);
        }

        /// <summary>
        /// This event occurs when the connection has been updated in XrmToolBox
        /// </summary>
        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);

            if (mySettings != null && detail != null)
            {
                mySettings.LastUsedOrganizationWebappUrl = detail.WebApplicationUrl;
                LogInfo("Connection has changed to: {0}", detail.WebApplicationUrl);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvallentites_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvoptiosetfildes.Rows.Clear();



            string entityLogicalName = dgvallentites.CurrentRow.Cells["LogicalName"].Value.ToString();
            ObjectTypeCode1= dgvallentites.CurrentRow.Cells["ObjectTypeCode"].Value.ToString();
            RetrieveEntityRequest request = new RetrieveEntityRequest()
            {
                LogicalName = entityLogicalName,
                EntityFilters = EntityFilters.Attributes
            };

            RetrieveEntityResponse response = (RetrieveEntityResponse)Service.Execute(request);

            EntityMetadata entityMetadata = response.EntityMetadata;

            foreach (AttributeMetadata attributeMetadata in entityMetadata.Attributes)
            {
                if (attributeMetadata.AttributeType == AttributeTypeCode.Picklist ||
                    attributeMetadata.AttributeType == AttributeTypeCode.State ||
                    attributeMetadata.AttributeType == AttributeTypeCode.Status)
                {
                    dgvoptiosetfildes.Rows.Add(attributeMetadata.LogicalName);
                }
            }
        }

       public static void getlang(ToolStripComboBox toolStripComboBox1,IOrganizationService Service)
        {
            toolStripComboBox1.Items.Clear();
            RetrieveAvailableLanguagesRequest request = new RetrieveAvailableLanguagesRequest();

            RetrieveAvailableLanguagesResponse response = (RetrieveAvailableLanguagesResponse)Service.Execute(request);

            foreach (int languageCode in response.LocaleIds)
            {
                var languageName = CultureInfo.GetCultureInfo(languageCode).DisplayName;
                toolStripComboBox1.Items.Add(new KeyValuePair<string, string>(languageCode.ToString(), languageName));

            }
            toolStripComboBox1.SelectedIndex = 0;

        }
        private void dgvoptiosetfildes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            AttributeName = dgvoptiosetfildes.CurrentRow.Cells["FiledName"].Value.ToString();

            
           

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvoptiosetfildes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (Service !=null)
            {
                string selectedKey = ((KeyValuePair<string, string>)toolStripComboBox1.SelectedItem).Key;

                LangId = selectedKey.ToString();
                if (LangId != "" && ObjectTypeCode1 != "" && AttributeName != "")
                {
                    //label3.Visible = true;
                    txtresult.Visible = true;

                    txtresult.Font = new Font("Courier New", 10);
                    txtresult.Text = $@"(Value) =>
let
    GetFilteredValue = (Value) =>  // Update the parameter name to 'Value'
    let
        filteredTable = Table.SelectRows(
            StringMap,
            each
                 [AttributeValue] = Value  and
                 [ObjectTypeCode] = {ObjectTypeCode1} and
                 [AttributeName] = ""{AttributeName}""  and
                 [LangId] = {LangId}
        ),
      singleValue = if Table.RowCount(filteredTable) > 0 then filteredTable{{0}} [Value] else null
    in
        singleValue
in
    GetFilteredValue(Value)

";
                    //                txtresult.Text = $@"let
                    //    GetFilteredValue = (Value) =>  // Update the parameter name to 'Value'
                    //    let
                    //        filteredTable = Table.SelectRows(
                    //            StringMap,  
                    //            each 
                    //                 [AttributeValue] = Value  and  
                    //                 [ObjectTypeCode] = {ObjectTypeCode1} and  
                    //                 [AttributeName] = ""{AttributeName}""  and  
                    //                 [LangId] = {LangId}
                    //        ),
                    //       singleValue = if Table.RowCount(filteredTable) > 0 then filteredTable{0}[Value] else null
                    //    in
                    //        singleValue
                    //in
                    //    GetFilteredValue(Value)";
                    // Set color formatting for keywords
                    SetKeywordColor("let", Color.Blue);
                    SetKeywordColor("in", Color.Blue);
                    SetKeywordColor("// Update the parameter name to 'Value'", Color.Green);

                    // Set color formatting for placeholders and quoted words
                    SetTextColor("[AttributeValue]", Color.Green);
                    SetTextColor("[ObjectTypeCode]", Color.Green);
                    SetTextColor("[AttributeName]", Color.Green);
                    SetTextColor("[LangId]", Color.Green);
                    SetTextColor("\"Value\"", Color.Red);
                    SetTextColor("\"" + AttributeName + "\"", Color.Red);

                }

                else if (string.IsNullOrEmpty(ObjectTypeCode1))
                {
                    MessageBox.Show("Please select Entity Name record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrEmpty(AttributeName))
                {
                    MessageBox.Show("Please select Attribute Name record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrEmpty(LangId))
                {
                    MessageBox.Show("Please select Language record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You must connect first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
         
        }


        void SetKeywordColor(string keyword, Color color)
        {
            int index = 0;
            while (index < txtresult.TextLength)
            {
                int keywordStart = txtresult.Find(keyword, index, RichTextBoxFinds.WholeWord);
                if (keywordStart == -1)
                    break;

                txtresult.SelectionStart = keywordStart;
                txtresult.SelectionLength = keyword.Length;
                txtresult.SelectionColor = color;

                index = keywordStart + keyword.Length;
            }
        }

        void SetTextColor(string text, Color color)
        {
            int index = 0;
            while (index < txtresult.TextLength)
            {
                int textStart = txtresult.Find(text, index, RichTextBoxFinds.None);
                if (textStart == -1)
                    break;

                txtresult.SelectionStart = textStart;
                txtresult.SelectionLength = text.Length;
                txtresult.SelectionColor = color;

                index = textStart + text.Length;
            }
        }
            private void dgvlang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          //  LangId= dgvlang.CurrentRow.Cells["LangCode"].Value.ToString();

        }
    }
}