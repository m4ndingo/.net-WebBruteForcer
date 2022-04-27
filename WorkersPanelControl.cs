using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBruteForcer
{
    public partial class WorkersPanelControl : UserControl
    {
        int cols = 10;
        public WorkersPanelControl()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            Start();
        }

        public workerControl[] w_controls { get; private set; }

        public int getWidth()
        {
            return cols * w_controls[0].Width;
        }
        public void Start()
        {
            w_controls = new workerControl[50];
            for (int i = 0; i < w_controls.Length; i++)
            {
                w_controls[i] = new workerControl();
                w_controls[i].Left = (i % cols) * w_controls[i].Width;
                w_controls[i].Top = Math.Abs(i / cols) * w_controls[i].Width;
                wPanel.Controls.Add(w_controls[i]);
            }

        }
    }
}
