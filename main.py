import os
import platform
cpu = os.cpu_count()
cpuname = platform.machine()
osver = platform.version()
osname = platform.system()
syspullver = "0.1"
print("Syspull version: ", syspullver)
print("============")
print("CPU threads: ", cpu)
print("CPU Architecture: ", cpuname)
print("OS Name: ", osname)
print("OS version:", osver)
print("============")