using ConsoleEvents;

namespace GUIEvents
{
    public partial class Form1 : Form
    {
        private const int maxVal = 2000000000;
        private SeqSummator ss = new(maxVal);
        private ParSummator ps = new(maxVal);
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowResult()
        {
            if (lblParSum.InvokeRequired)
                Invoke(ShowResult);
            else
                lblParSum.Text = ps.Result.ToString();
        }

        private void btnStartSeqSum_Click(object sender, EventArgs e)
        {
            ss.Sum();
            lblSeqSum.Text = ss.Result.ToString();
            ps.Finish += ShowResult;
            ps.Sum();
        }
    }
}