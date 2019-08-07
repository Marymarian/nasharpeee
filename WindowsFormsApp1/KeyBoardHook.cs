using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Перехват клавиш и обработка событий нажатия на клавиши
    /// </summary>
    class KeyBoardHook
    {
        private const int WH_KEYBOARD_LL = 13;
        private LowLevelKeyboardProcDelegate m_callback;
        private IntPtr m_hHook;
        private List<int> PressedVKC = new List<int>();
        private List<int> Sequence = new List<int>();
        private List<int> StartStopCombination = new List<int>(new int[] { 162, 163, 164, 165, 150, 86 });//любые три из этой комбинации 
        private bool learning { get; set; }

        #region Hook
        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProcDelegate lpfn, IntPtr hMod, int dwThreadId);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("Kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetModuleHandle(IntPtr lpModuleName);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);
        #endregion

        [StructLayout(LayoutKind.Sequential)]
        private struct KeyboardHookStruct
        {
            public readonly int VirtualKeyCode;
            public readonly int ScanCode;
            public readonly int Flags;
            public readonly int Time;
            public readonly IntPtr ExtraInfo;
        }

        private delegate IntPtr LowLevelKeyboardProcDelegate(int nCode, IntPtr wParam, IntPtr lParam);

        private IntPtr LowLevelKeyboardHookProc(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode < 0)
                return CallNextHookEx(m_hHook, nCode, wParam, lParam);
            else
            {
                var khs = (KeyboardHookStruct)Marshal.PtrToStructure(lParam, typeof(KeyboardHookStruct));
                KeysConverter Converter = new KeysConverter();
                Console.WriteLine("Hook: Code: {0}, WParam: {1},VirtualKK: {2}, ScaneCode: {3}, Charer: {4}", nCode, wParam, khs.VirtualKeyCode, khs.ScanCode, Converter.ConvertToString(khs.VirtualKeyCode));

                if (wParam.ToInt32() == 257)
                {//отжали клавишу
                    //if (CheckStartStop && PressedVKC.Count >= 3)
                    //{
                    //    PressedVKC.Clear();
                    //    Learning = !Learning;
                    //    return new IntPtr(1);
                    //}
                    //if (Learning)
                    //{
                    //    if (PressedVKC.Count > 0)
                    //    {
                    //        Sequence.AddRange(PressedVKC);
                    //        RuleInfo.WindowName = Get_CurrentWindowProcess.MainWindowTitle;
                    //    }
                    //}
                    //else
                    //{//если  унас в буфере обмена есть данные для разбора 
                    //    if (CheckStartParse)
                    //    {
                    //        Sequence.Clear();
                    //        Fill_Fields(PressedVKC.Count);
                    //        return new IntPtr(1);
                    //    }
                    //}
                    //PressedVKC.Clear();
                }
                else
                    //if (!PressedVKC.Contains(khs.VirtualKeyCode) || (ConvertToInt(Converter.ConvertToString(khs.VirtualKeyCode)) != int.MinValue && wParam.ToInt32() == 260))
                    PressedVKC.Add(khs.VirtualKeyCode);
                return CallNextHookEx(m_hHook, nCode, wParam, lParam);
            }
        }

        public void SetHook()
        {
            m_callback = LowLevelKeyboardHookProc;
            m_hHook = SetWindowsHookEx(WH_KEYBOARD_LL, m_callback, GetModuleHandle(IntPtr.Zero), 0);
        }

        public void Unhook()
        {
            UnhookWindowsHookEx(m_hHook);
        }
    }
}
