using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;

namespace ActiveDir
{
    class Control
    {
        public static void refreshCombobox(StringCollection _list, ComboBox _combo)
        {
            _combo.DataSource = null;
            _combo.Items.Clear();
            _combo.DataSource = _list;
        }
    }
}
