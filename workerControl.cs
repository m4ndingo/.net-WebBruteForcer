using System;
using System.Windows.Forms;

namespace WebBruteForcer
{
    public partial class workerControl : UserControl
    {
        ToolTip toolTip = new ToolTip();
        public workerControl()
        {
            InitializeComponent();
        }

        public string state { get; private set; }
        public Worker worker { get; internal set; }

        internal void SetState(string state)
        {
            if (this.state!=null && this.state.Equals(state)) return;
            this.state = state;
            if (imageList1.Images.Count.Equals(0)) return;
            UpdateWorkerInfo(state);
            switch (state)
            {
                case "running":
                    picState.Image = imageList1.Images[1];
                    break;
                case "cleaned":
                    picState.Image = imageList1.Images[2];
                    break;
                case "idle":
                    picState.Image = imageList1.Images[0];
                    break;
                case "results_ready":
                    picState.Image = imageList1.Images[3];
                    break;
            }
            picState.Refresh();
        }

        private void UpdateWorkerInfo(string state)
        {
            string msg = state;
            msg += worker != null && worker.payload != null ? Environment.NewLine + "Payload: " + worker.payload : "";
            toolTip.SetToolTip(picState, msg);
        }
    }
}
