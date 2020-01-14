#define Option2

//Option1 directive shows a pre-definted int array (Which is nullable)
//Option2 directive (else condition) shows a ArrayList that can grow (difference exceptions but same concept)

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WallaceT_Assn1_TDD_MS549
{
    public partial class frmPushPop : Form 
    {
        #region Variable Declaration
#if (Option1)
        private int?[] alInts;
        object propertyValue = new[] { 0, 0, 0, 0, 0};
#else
        private ArrayList alInts = new ArrayList();
#endif

        private List<string> lsHist = new List<string>();
        
        #endregion

        #region Constructors
        public frmPushPop()
        {
            InitializeComponent();
        }
        #endregion

        #region UserMethods
        public void Pop()
        {
            
            //Removes number from top of Array/Stack
            string sMsg = "";
            
            try
            {
#if (Option1)
                sMsg = string.Format("Pop (DEL) {0}\n", alInts[LastValue()-1]);
                alInts[LastValue()-1] = null;
#else
                sMsg = string.Format("Pop (DEL) {0}\n", alInts[alInts.Count - 1]);
                alInts.Remove(alInts[alInts.Count-1]);
#endif
            }

#if (Option1)
            catch (IndexOutOfRangeException)
            {
                sMsg = "Array is Empty, Nothing to Pop out.\n";
                //MessageBox.Show(sMsg);
            }
#else            
            catch (ArgumentOutOfRangeException)
            {
                sMsg = "Array is Empty, Nothing to Pop out.\n";
                //MessageBox.Show(sMsg);
            }
#endif
            LogHistory(sMsg);
            UpdateDisplays();
        }

        private void Push()
        {
            //Adds number to top of Array/Stack
            string sMsg = "";

#if (Option1)
            bool bBreak = false;
#endif

            //If Valid Number, Put it on the Stack
            try
            {
                if (ValidateValue(tbNumber, out int iVal))
                {

#if (Option1)
                    for (int i = 0; (i < alInts.Length + 1) && (!bBreak); i++)
                    {
                        if (alInts[i] == null)
                        {
                            alInts[i] = iVal;
                            bBreak = true;
                        }
                    }
#else
                alInts.Add(iVal);

#endif
                    sMsg = string.Format("Push (ADD): {0}\n", iVal);
                }
            } catch (IndexOutOfRangeException)
            {
                sMsg = "Array Limit Exceeded. Action Cancelled\n";
            }
            LogHistory(sMsg);
            UpdateDisplays();
        }

        private void Peak()
        {
            //Gets value from Top of Array/Stack, but doesn't remove anything
            string sMsg;
            try
            {
#if (Option1)
                sMsg = string.Format("Peak (TPV): {0}\n", alInts[LastValue()-1]);
#else
                sMsg = string.Format("Peak (TPV): {0}\n", alInts[alInts.Count-1]);
#endif
            }
#if (Option1)
            catch (IndexOutOfRangeException)
            {
                sMsg = "Array is Empty, Nothing to Peak at.\n";
                //MessageBox.Show(sMsg);
            }
#else
            catch (ArgumentOutOfRangeException) {
                sMsg = "Array is Empty, Nothing to Peak at.\n";
                //MessageBox.Show(sMsg);
            }
#endif
            LogHistory(sMsg);
            UpdateDisplays();
        }

        private void LogHistory(string Msg)
        {
            //Add activity to History
            if (Msg.Trim() != "") { lsHist.Add(Msg); }
        }
        
        private void UpdateDisplays()
        {
            //Update Display Windows for Array Item Count and Array Value Window
            string sHistList = "";
            tbHistory.Clear();
            int iCnt = 0;

            if (lsHist.Count > 0)
            {
                foreach (string sHistItem in lsHist)
                {
                    iCnt += 1;
                    sHistList += string.Format("{0:0000} - {1}",iCnt,sHistItem.Replace("\n", Environment.NewLine));
                }
                tbHistory.Text = sHistList;
                
            }

            //Refresh Controls and Scroll to end
            tbHistory.Refresh();
            tbHistory.SelectionStart = tbHistory.Text.Length;
            tbHistory.ScrollToCaret();

            ShowArrayInfo();  //Calls Array Info (Does the Count and Value List)
        }

        private void ShowArrayInfo()
        {
            //Display Array Item Count and Array Value Window
            string sOutput = "";
            
            tbItemList.Clear();
            lblItemCount.Text = "0";
#if (Option1)
            if (alInts.Length > 0)
            {
                //Walk thru array list backwards
                for (int i = alInts.Length; i > 0; i--)
                {

                    if (alInts[i-1] != null)
                    {
                        sOutput += string.Format("Array Item [{0}]: {1}\n", i - 1, alInts[i - 1]).Replace("\n", Environment.NewLine);
                    }
                }
#else
            if (alInts.Count > 0)
            {
                //Walk thru array list backwards
                for (int i = alInts.Count; i>0; i--)
                {
                    sOutput += string.Format("Array Item [{0}]: {1}\n", i - 1, alInts[i - 1]).Replace("\n", Environment.NewLine);
                }
#endif
                    tbItemList.Text = sOutput;

#if (Option1)
                lblItemCount.Text = string.Format("{0} of {1}",LastValue(),alInts.Length.ToString());
#else
                lblItemCount.Text = alInts.Count.ToString();
#endif
            }

            //Refresh Controls
            tbItemList.Refresh();
            lblItemCount.Refresh(); 
            
        }

        private bool ValidateValue(Control frmCtrl, out int iVal)
        {
            bool bResult;
            //Try and Parse integer, if valid store it in iVal
            bResult = int.TryParse(frmCtrl.Text.ToString(), out iVal) ? true : false;

            if (!bResult )
            {
                //If parse fails Prompt user to try again
                MessageBox.Show(this, "Please enter a valid integer value.\n\nBetween 0 - 2147483647", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                frmCtrl.Focus();
                frmCtrl.Text = "";
                frmCtrl.Refresh();
            }
            return bResult;
        }

#if (Option1)
        private int LastValue()
        {
            int iOut=0;
            //Returns last non-null array item
            for (int i=0; i < alInts.Length;i++)
            {
                if (alInts[i] != null) { iOut = i+1; }
            }

            return iOut;
        }
#endif
        #endregion

        #region Form Methods/Events
        private void btnPush_Click(object sender, EventArgs e)
        {
            // Call Push Method
            Push();
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            // Call Pop Method
            Pop();
        }

        private void btnPeak_Click(object sender, EventArgs e)
        {
            // Call Peak Method
            Peak();
        }
  

        private void tbNumber_KeyUp(object sender, KeyEventArgs e)
        {
            //If user hits enter key after typing in a value, call the Push method for them. (acts like they hit the button)
            if (e.KeyValue == 13) { Push(); }
        }
        

        private void frmPushPop_Load(object sender, EventArgs e)
        {
#if (Option1)
            alInts = ((IEnumerable)propertyValue).Cast<int?>().ToArray();
            for (int i=0; i<alInts.Length;i++)
            {
                alInts[i] = null;
            }

            
            gbInfo.Text = "Items Used";
            gbInfo.Refresh();
            ShowArrayInfo(); 
#endif
        }
#endregion
    }
}
