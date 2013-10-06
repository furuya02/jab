using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace JavaAccessBridge{
    public partial class mainForm : Form{
        private Log _log;



        private void mainForm_Load(object sender, EventArgs e) {
            _log = new Log(textBoxLog);
            try{
                JabApi.Windows_run();
            } catch (Exception ex){
                MessageBox.Show(ex.Message);

            }
        }

        private void buttonClear_Click(object sender, EventArgs e) {
            textBoxLog.Text = "";
        }

        private void buttonSearchWindow_Click(object sender, EventArgs e) {
            const int sec = 2;
            var getWindows = new GetWindow(sec);
            for (int i = 0; i < sec*12; i++){
                Thread.Sleep(100);
            }
            _log.Add(getWindows.Handle.ToString());
            _log.Add(getWindows.Text);
            _log.Add(getWindows.ClassName);

            textBoxHandle.Text = getWindows.Handle.ToString();
            textBoxHandle.Tag = getWindows.Handle;

        }

//        private void buttonSearchJava_Click(object sender, EventArgs e){
//            IntPtr hWnd = (IntPtr)textBoxHandle.Tag;
//
//            Application.DoEvents();
//
//            Thread.Sleep(100);
//
//            int id=0;
//            Jab.AccessibleTreeItem item = Jab.GetComponentTree(hWnd, out id);
//            _log.Add(string.Format("id = {0}",id));
//            _log.Add(Jab.screenContentsString);
//        }

        private void buttonGetItems_Click(object sender, EventArgs e) {
            foreach (var a in GetItem()) {
                var s = string.Format("{0} | {1} | {2} | {3} | {4} | {5} | {6} | {7}", a.Tab, a.Key, a.Name, a.Role, a.Status,a.Text,a.Count,a.Selected);
                _log.Add(s);
            }
        }

        private void buttonGetList_Click(object sender, EventArgs e){
            foreach (var a in GetItem()) {
                if (a.Key.IndexOf(textBoxGetList.Text) == 0){
                    _log.Add(a.Name);
                }
            }
        }

        private void buttonSelectedItem_Click(object sender, EventArgs e){
            foreach (var a in GetItem()) {
                if (a.Status.IndexOf("selected") != -1){
                    _log.Add(a.Name);
                }
            }
        }

        List<OneJavaItem> GetItem(){
            try{
                var ar = new List<OneJavaItem>();
                var hWnd = new IntPtr(Int32.Parse(textBoxHandle.Text));
                GetItemList(GetItem(hWnd), "", 0, ar);
                return ar;
            } catch (Exception ex) {
                return new List<OneJavaItem>();
            }
        } 

        Jab.AccessibleTreeItem GetItem(IntPtr hWnd){
            if (JabApi.isJavaWindow(hWnd) != 1) {
                return null;
            }
            Jab.AccessibleTreeItem item = new Jab.AccessibleTreeItem();
            int vmID = 0;
            unsafe {
                IntPtr acPtr;

                if (JabApi.getAccessibleContextFromHWND(hWnd, out vmID, out acPtr)) {
                    AccessibleContextInfo ac = new AccessibleContextInfo();
                    return Jab.GetAccessibleContextInfo(vmID, acPtr, out ac, null, 0, string.Empty); // RECURSION SEED
                }
            }
            return null;
        }

        void GetItemList(Jab.AccessibleTreeItem item, string key, int n, List<OneJavaItem> ar) {
            if (item == null){
                return;
            }
            var tab = new StringBuilder();
            for (var i = 0; i < n; i++){
                tab.Append("  ");
            }
            key = string.Format("{0},{1}", key, item.indexInParent);

            ar.Add(new OneJavaItem(tab.ToString(), key, item.name,item.textValue, item.role, item.states_en_US,item.x,item.y,item.height,item.width,item.childrenCount,item.selected));
            if (item.children.Count != 0){
                foreach (var i in item.children){
                    GetItemList(i, key, n + 1, ar); //再帰処理       
                }
            }
        }

        [DllImport("user32.dll")]
        static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);
        
        [StructLayout(LayoutKind.Sequential)]
        internal struct RECT
        {
            internal int left;
            internal int top;
            internal int right;
            internal int bottom;
        }


        private void timerMousePos_Tick(object sender, EventArgs e) {
            int X = Cursor.Position.X;
            int Y = Cursor.Position.Y;
            textBoxX.Text = X.ToString();
            textBoxY.Text = Y.ToString();

            if (textBoxHandle.Text != ""){
                RECT rect = new RECT();
                var hWnd = new IntPtr(Int32.Parse(textBoxHandle.Text));
                GetWindowRect(hWnd,out rect);

                textBox_x.Text = (Y - rect.top).ToString();
                textBox_y.Text = (X-rect.left).ToString();

            } else{
                textBox_x.Text = "";
                textBox_y.Text = "";
            }

        }
        

    }
}
