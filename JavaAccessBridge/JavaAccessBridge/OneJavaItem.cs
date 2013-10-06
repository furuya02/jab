using System;
using System.Collections.Generic;
using System.Text;

namespace JavaAccessBridge {
    class OneJavaItem {
        public String Tab { get; private set; }
        public String Key { get; private set; }
        public String Name { get; private set; }
        public String Text { get; private set; }
        public String Role { get; private set; }
        public String Status { get; private set; }
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Height { get; private set; }
        public int Width { get; private set; }
        public int Count { get; private set; }
        public String Selected { get; private set; }

        public OneJavaItem(string tab, string key, string name, string text, string role, string status, int x, int y, int height, int width,int count,string selected) {
            Tab = tab;
            Key = key;
            Name = name;
            Text = (text == null) ? "" : text;
            Role = role;
            Status = status;
            X = x;
            Y = y;
            Height = height;
            Width = width;
            Count = count;
            Selected = selected;
        }

    }
}
