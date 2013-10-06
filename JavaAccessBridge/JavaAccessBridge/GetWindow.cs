using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace JavaAccessBridge {
    class GetWindow{
        private readonly Thread _t;
        private readonly int _sec;
        
        public string MousePoint { get; private set; }
        public IntPtr Handle { get; private set; }
        public string FormLocation { get; private set; }
        public string ClassName { get; private set; }
        public string Text { get; private set; }
        

        public GetWindow(int sec) {
            _sec = sec;
            _t = new Thread(Job);
            _t.IsBackground = true;
           _t.Start();
        }

        void Job(){
            for(int i=0;i<_sec;i++){
                Thread.Sleep(1000);
            }

            var p = new Point();
            // Point p = Cursor.Position; でも良い

            // マウス座標の取得
            GetCursorPos(ref p);
            MousePoint = "X:" + p.X.ToString().PadLeft(4) + " " + "Y:" + p.Y.ToString().PadLeft(4);

            // マウス座標よりハンドル取得
            IntPtr hWnd;
            hWnd = WindowFromPoint(p);
            if (hWnd == IntPtr.Zero){
                Handle = IntPtr.Zero;
                return;
            }
            Handle = hWnd;

            // 現在のハンドルの座標値の取得
            var r = new RECT();
            var s = new System.Text.StringBuilder();
            var ret = GetWindowRect(hWnd, ref r);
            s.Append("Top    : " + r.top + "\n");
            s.Append("Left   : " + r.left.ToString() + "\n");
            s.Append("Bottom : " + r.bottom.ToString() + "\n");
            s.Append("Right  : " + r.right.ToString());
            FormLocation = s.ToString();

            // クラス名の取得
            var b = new StringBuilder(256);
            int n = 256;
            GetClassName(hWnd, b, n);
            ClassName = b.ToString().Trim();

            // テキストの取得
            GetWindowText(hWnd, b, n);
            if (b.ToString() == "") {
                // GetWindowTextでテキストが取得出来ない場合
                // GetWindowTextでは他アプリケーションのテキストを取得出来ない。
                SendMessage(hWnd, WM_GETTEXT, n, b);
            }
            Text = b.ToString();
        }

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern IntPtr WindowFromPoint(Point point);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern bool GetCursorPos(ref Point lpPoint);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern bool GetWindowRect(IntPtr hWnd, ref RECT lpRect);


        private struct RECT {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, int wParam, System.Text.StringBuilder lParam);

        private const uint WM_GETTEXT = 13;
    }
}
