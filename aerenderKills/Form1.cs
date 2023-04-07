using System.Diagnostics;
namespace aerenderKills
{
	public partial class Form1 : Form
	{
		private Process[] procs = new Process[0];
		public Form1()
		{
			InitializeComponent();
			btnRescan.Click += (sender, e) => { Scan(); };
			btnKill.Click += (sender, e) => { killCount = 0; KillExec(); };
			btnClose.Click += (sender, e) => { Application.Exit(); };
			Scan();
		}

		public void Scan()
		{
			Process[] ps2 = Process.GetProcessesByName("AfterFX.com");
			Process[] ps = Process.GetProcessesByName("aerender");
			listBox1.Items.Clear();
			List<Process> list = new List<Process>();
			foreach (System.Diagnostics.Process p in ps2)
			{
				list.Add(p);
			}
			foreach (System.Diagnostics.Process p in ps)
			{
				list.Add(p);
			}
			procs = list.ToArray();
			foreach (System.Diagnostics.Process p in procs)
			{
				listBox1.Items.Add($"{p.Id:D6}:{p.ProcessName} - {p.MainWindowTitle} ");
			}
			btnKill.Enabled = (procs.Length >= 1);
			if (procs.Length > 0)
			{
				label1.Text = "Find! aerender";
			}
			else
			{
				label1.Text = "no aerender.";
			}
		}
		private int killCount = 0;
		public void KillExec()
		{
			if (procs.Length <= 0) return;
			killCount++;
			if (killCount > 10) return;
			foreach (System.Diagnostics.Process? p in procs)
			{
				try
				{
					if (p != null)
					{
						p.Kill(true);
						p.WaitForExit(1000);
					}
				}
				catch
				{

				}
			}
			Scan();
			if (procs.Length >0) KillExec();
		}
	}
}