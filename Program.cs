using System;
using System.Runtime.InteropServices;
string syspullver = "0.1";
Console.WriteLine("Syspull version: {0}", syspullver);
Console.WriteLine("==========");
var threads = Environment.ProcessorCount;
Console.WriteLine("CPU threads: {0}", threads);
var os = RuntimeInformation.OSDescription;
Console.WriteLine("OS: {0}", os);
var cpuarch = RuntimeInformation.OSArchitecture;
Console.WriteLine("CPU Arch: {0}", cpuarch);
Console.WriteLine("==========");


