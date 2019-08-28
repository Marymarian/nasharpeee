using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

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
        public Template template { get; set; }
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

        #region Window
        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        public static extern UInt32 GetWindowThreadProcessId(IntPtr hwnd, ref Int32 pid);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
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

                    if (khs.VirtualKeyCode==192)
                    {
                        string[] Data = Clipboard.GetText().Split(new string[] { template.Separator },StringSplitOptions.None);

                        SendKeys.SendWait("{BS}");
                        for (int counter = 0; counter < template.Rule.Count; counter++)
                        {
                            if (template.Rule[counter] != "")
                            {
                                if (template.Rule[counter].Contains("_"))
                                {
                                    string[] datatwo = template.Rule[counter].Split('_');
                                    for (int twocounter = 0; twocounter < datatwo.Length; twocounter++)
                                    {
                                        string element = datatwo[twocounter];
                                        if (element.Trim().Length != 0)

                                        {
                                            int index = Convert.ToInt32(element) - 1;
                                            SendKeys.Send(Convert.ToString(Data[index]));
                                        }
                                        SendKeys.Send(" ");
                                    }
                                }
                                else
                                {
                                    int index = Convert.ToInt32(template.Rule[counter]) - 1;
                                    SendKeys.Send(Convert.ToString(Data[index]));
                                }
                                SendKeys.SendWait("{TAB}");
                            }
                        }

                    }
                     
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
