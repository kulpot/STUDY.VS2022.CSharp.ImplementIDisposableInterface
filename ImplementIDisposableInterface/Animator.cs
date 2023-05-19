using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace ImplementIDisposableInterface
{
    class Animator : IDisposable
    {
        private Timer _timer = new Timer();
        private RichTextBox _box = new RichTextBox();

        public Animator()
        {
            _timer.Interval = 1000;
        }

        public void Dispose()
        {
            _timer.Dispose();
            _box.Dispose();
        }
    }
}
