using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperHexabot
{
    /// <summary>
    /// Class that acts as a wrapper around Windows OpenProcess and 
    /// [Read/Write]ProcessMemory to allow reading of straight and base offset pointers.
    /// </summary>
    public class MemoryAPI
    {

        private int    ProcessID;

        private IntPtr ProcessHandle;

        public bool IsOpen { get; private set; }

        public bool Open( int processID )
        {
            IntPtr processHandle = OpenProcess( (uint)ProcessAccessFlags.All, false, processID );

            if( processHandle != IntPtr.Zero )
            {
                Log.Info( "OpenProcess() worked OK." );

                ProcessID     = processID;
                ProcessHandle = processHandle;

                IsOpen = true;
            }
            else
            {
                Log.Error( "OpenProcess() failed." );

                ProcessID     = 0;
                ProcessHandle = IntPtr.Zero;

                IsOpen = false;
            }

            return IsOpen;
        } 



        public void Close()
        {
            // Attempt to close the handle.
            CloseHandle( ProcessHandle );

            // Ensure class users know we are now disconnected from the process.
            IsOpen = false;

            // Ensure all handles are reset on close.
            ProcessID     = 0;
            ProcessHandle = IntPtr.Zero;
        }

        public int ReadInt( long address )
        {
            byte[] buffer = new byte[sizeof(int)];
            ReadProcessMemory(ProcessHandle, (UIntPtr)address, buffer, (UIntPtr)4, IntPtr.Zero);
            return BitConverter.ToInt32(buffer, 0);
        }

        public int ReadBasedInt( long basePointer, long address )
        {
            byte[] buffer = new byte[sizeof(int)];
            ReadProcessMemory(ProcessHandle, (UIntPtr)(basePointer + address), buffer, (UIntPtr)4, IntPtr.Zero);
            return BitConverter.ToInt32(buffer, 0);
        }

        public void WriteBasedInt(long basePointer, long address, int value)
        {
            byte[] buffer = BitConverter.GetBytes(value);
            WriteProcessMemory(ProcessHandle, (UIntPtr)(basePointer + address), buffer, (UIntPtr)buffer.Length, IntPtr.Zero);
        }

        public byte[] ReadBytes( long Address, int size )
        {
            byte[] buffer = new byte[size];
            ReadProcessMemory(ProcessHandle, (UIntPtr)Address, buffer, (UIntPtr)size, IntPtr.Zero);
            return buffer;
        }

        [DllImport("kernel32.dll")]
        private static extern bool ReadProcessMemory(IntPtr hProcess, UIntPtr lpBaseAddress, [Out] byte[] lpBuffer, UIntPtr nSize, IntPtr lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        private static extern bool WriteProcessMemory(IntPtr hProcess, UIntPtr lpBaseAddress, byte[] lpBuffer, UIntPtr nSize, IntPtr lpNumberOfBytesWritten);

        [DllImport("kernel32.dll")]
        private static extern IntPtr OpenProcess(uint dwDesiredAccess, bool bInheritHandle, int dwProcessId);

         [DllImport("kernel32.dll")]
        private static extern IntPtr CloseHandle( IntPtr hObject );

        [Flags]
        public enum ProcessAccessFlags : uint
        {
            All = 2035711,
            CreateThread = 2,
            DupHandle = 64,
            QueryInformation = 1024,
            SetInformation = 512,
            Synchronize = 1048576,
            Terminate = 1,
            VMOperation = 8,
            VMRead = 16,
            VMWrite = 32
        }
    }
}
