using System.Diagnostics;

class WebSearch
{
	static void Main(string[] args)
	{
		String search = String.Join('+', args);
		String url = $"https://duckduckgo.com/?q={search}&t=h_&ia=web";
		
		Process proc = new Process();
		proc.StartInfo.FileName = "cmd.exe";
		proc.StartInfo.Arguments = $" /c start {url}";
		proc.StartInfo.UseShellExecute = false;
		proc.StartInfo.CreateNoWindow = true;
		proc.Start();
		
		System.Console.WriteLine(url);
	}
}
