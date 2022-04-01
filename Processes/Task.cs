using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Processes
{
    public partial class Task : Form
    { 

        public Task()
        {
            InitializeComponent();
        } 

        void GetAllApplicationRun() 
        {
            string localMachineName = Environment.MachineName;
            dGrdProcess.Rows.Clear();
            foreach (Process Item in Process.GetProcesses(localMachineName)) { 
                string FileDesc = string.Empty;
                if (Item != null)
                {
                    try
                    {
                        FileDesc = Item.Modules[0].FileVersionInfo.FileDescription;
                            
                    }
                    catch (Exception e) { }
                  
                }
                 dGrdProcess.Rows.Add(Item.Id.ToString(), FileDesc, Item.ProcessName, GetProcessOwner(Item.Id) );
                
            }
        }
         
        public string GetProcessOwner(int processId)
        {
            string query = "Select * From Win32_Process Where ProcessID = " + processId;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            ManagementObjectCollection processList = searcher.Get();

            foreach (ManagementObject obj in processList)
            { 
                string[] argList = new string[] { string.Empty, string.Empty };
                int returnVal = Convert.ToInt32(obj.InvokeMethod("GetOwner", argList));
                if (returnVal == 0)
                {
                    return argList[0];
                }
            } 

            return "";
        }

       private void Task_Load(object sender, EventArgs e)
        { 
            GetAllApplicationRun();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
             GetAllApplicationRun(); 
        }
 
    }
     
}
