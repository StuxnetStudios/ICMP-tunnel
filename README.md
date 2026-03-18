# ICMP Tunneller

Simple single-file C# utility that sends an ICMP echo (ping) with an optional payload.

**Files**: `ICMPTunnel.cs`

**Description**
- Prompts for a remote host or IP and an optional payload string, sends an ICMP Echo request, and prints the reply status, round-trip time, and address.

**Build**
- Requires .NET SDK (6.0/7.0+). Build the single source file:

```powershell
cd C:\workspace\code\TUNNEL
dotnet build ICMPTunnel.cs /property:GenerateFullPaths=true
```

**Run**
- After a successful build, run the produced assembly. The exact output path depends on the installed SDK and configuration (usually under `bin\Debug
et*`). Example:

```powershell
# locate the produced DLL/EXE in bin\Debug
et*
dotnet .in\Debug
et7.0\ICMPTunnel.dll
# or, if an EXE was produced:
.in\Debug
et7.0\ICMPTunnel.exe
```

- The program is interactive. Example session:

```
Enter the remote host or IP: 8.8.8.8
Enter the payload/text: hello
Status=Success, RTT=10ms, Addr=8.8.8.8
```

**Notes & Troubleshooting**
- Don't paste C# source lines into PowerShell; build and run through `dotnet` as shown above.
- If `dotnet build` reports language or syntax errors, fix the source in `ICMPTunnel.cs` first (for example, replace `Console.ReadLine(8)` with `Console.ReadLine()`).
- Sending ICMP may be blocked by local firewall or by policy on some systems; run in an environment where ICMP is allowed.

**Contributing / Pushing**
- Stage and commit changes, then push to your remote as usual:

```powershell
git add ICMPTunnel.cs README.md
git commit -m "Fix: use Console.ReadLine(); add README"
git remote add origin https://github.com/StuxnetStudios/Reddit-to-Bluesky.git
git branch -M main
git push -u origin main
```

**License**
- Add a license file if you want to publish this publicly.
