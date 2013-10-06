using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace JavaAccessBridge {
    class Log{
        private TextBox _textBox;
        public Log(TextBox texbox){
            _textBox = texbox;
        }

        public void Add(string str){
            _textBox.Text = _textBox.Text + str + "\r\n";
        }
    }
}
