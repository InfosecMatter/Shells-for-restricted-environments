# Shells for restricted environments

## Minips

 Minips is a minimalist PowerShell interpreter to bypass AppLocker restrictions, GPO or SRP restrictions preventing from running powershell.exe. Use your own PowerShell interpreter. There are 2 versions available:

### mini.cs

Compilation instructions:
```
# Go to the latest .NET version folder, e.g.:
cd C:\Windows\Microsoft.NET\Framework64\v4.0.30319

# Compile:
csc.exe /unsafe /reference:"C:\path\to\System.Management.Automation.dll" /out:C:\users\public\minips.exe /platform:x64 "C:\users\public\minips.cs"
```

### mini.xml
Simply start like this:
```
C:\Windows\Microsoft.NET\Framework64\v4.0.30319\msbuild.exe c:\path\to\minips.xml
```

## shell-pack.zip

Contains compiled and ready to use shells for bypassing AppLocker, GPO or SRP restrictions preventing from running Command Prompt (cmd.exe) or PowerShell interpreter (powershell.exe).

The pack contains the following shells:
* [cmd-dll](https://blog.didierstevens.com/2010/02/04/cmd-dll/)
* [CScriptShell](https://github.com/carnal0wnage/CScriptShell)
* Minips
* [MSBuildShell](https://github.com/Cn33liz/MSBuildShell)
* [NoPowerShell](https://github.com/bitsadmin/nopowershell)
* [nps](https://github.com/Ben0xA/nps)
* [p0wnedshell](https://github.com/Cn33liz/p0wnedShell)
* [PowerLine](https://github.com/fullmetalcache/PowerLine)
* [PowerOPS](https://github.com/fdiskyou/PowerOPS)
* [PowerShdll](https://github.com/p3nt4/PowerShdll)
* [PSShell](https://github.com/fdiskyou/PSShell)
* [SharpPick](https://github.com/TheKevinWang/SharpPick)

The archive is password protected in order to evade antivirus detection.

More information including the password can be found [here](https://www.infosecmatter.com/19-ways-to-bypass-software-restrictions-and-spawn-a-shell/).
