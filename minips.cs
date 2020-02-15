using System;
using System.IO;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Text.RegularExpressions;
using System.Text;
                            
public class ClassExample {
	static int Main(string[] args) {
		while(true) {
			Console.Write("PS> ");
			string x = Console.ReadLine();
			try {
				Console.WriteLine(pscmd(x));
			}
			catch (Exception e) {
				Console.WriteLine(e.Message);
			}
			if (x=="exit") {
				return(0);
			} else if (x.IndexOf("cd ", StringComparison.OrdinalIgnoreCase) >= 0) {
				string dir = x.Substring(x.IndexOf("cd ", StringComparison.OrdinalIgnoreCase)+3);
				dir = dir.Replace("\"", string.Empty).Trim();
				try {
					Directory.SetCurrentDirectory(dir);
				}
				catch (Exception e) {
					Console.WriteLine( "The specified directory does not exist. {0}", e );
				}
			}
		}
	}
	public static string pscmd(string cmd) {
		Runspace r = RunspaceFactory.CreateRunspace();
		r.Open();
		RunspaceInvoke s = new RunspaceInvoke(r);
		s.Invoke("Set-ExecutionPolicy Unrestricted -Scope CurrentUser");
		Pipeline p = r.CreatePipeline();
		p.Commands.AddScript(cmd);
		p.Commands.Add("Out-String");
		Collection<PSObject> results = p.Invoke();
		r.Close();
		StringBuilder sb = new StringBuilder();
		foreach (PSObject obj in results) {
			sb.Append(obj);
		}
		return sb.ToString().Trim();
	}
	public static void RunPSFile(string script) {
		PowerShell ps = PowerShell.Create();
		ps.AddScript(script).Invoke();
	}
}
