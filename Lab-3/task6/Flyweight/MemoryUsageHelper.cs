namespace Flyweight;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
public static class MemoryUsageHelper
{
    public static long GetCurrentMemoryUsage()
    {
        using (Process currentProcess = Process.GetCurrentProcess())
        {
            return currentProcess.WorkingSet64;
        }
    }
        
    public static string FormatMemorySize(long bytes)
    {
        string[] sizes = { "B", "KB", "MB", "GB", "TB" };
        int order = 0;
        double size = bytes;
            
        while (size >= 1024 && order < sizes.Length - 1)
        {
            order++;
            size = size / 1024;
        }
            
        return $"{size:0.##} {sizes[order]}";
    }
}