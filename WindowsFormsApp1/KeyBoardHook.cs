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
        public bool Play { get; set; } = false;
        public DataSeparateTemplate dataseparatetempl { get; set; }
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
                    try
                    {
                        if (khs.VirtualKeyCode == 192)
                        {
                            string[] Data = Clipboard.GetText().Split(new string[] { dataseparatetempl.Separator }, StringSplitOptions.None);

                            SendKeys.SendWait("{BS}");
                            for (int counter = 0; counter < template.Rule.Count; counter++)
                            {
                                if (template.Rule[counter] != "")//если у нас что то записано в правиле, то мы выполняем действия внутри
                                {
                                    if (template.Rule[counter].Contains("_"))//проверяем есть ли у нас в правиле признаки постановки пробела
                                    {
                                        string[] datatwo = template.Rule[counter].Split('_');
                                        for (int twocounter = 0; twocounter < datatwo.Length; twocounter++)
                                        {

                                            string element = datatwo[twocounter];
                                            Set_Data(Data, element, " ");
                                        }
                                    }
                                    else//если у нас в элементе правила ничего нет то мы пытаемся что-то разобрать. Странно не правда ли? 
                                        if (!Set_Data(Data, template.Rule[counter], ""))
                                        break;
                                }

                                System.Threading.Thread.Sleep(100);
                                SendKeys.SendWait("{TAB}");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "\nОбратитесь к разработчикам.", "Ошибка");
                    }
                }
                else
                    //if (!PressedVKC.Contains(khs.VirtualKeyCode) || (ConvertToInt(Converter.ConvertToString(khs.VirtualKeyCode)) != int.MinValue && wParam.ToInt32() == 260))

                    PressedVKC.Add(khs.VirtualKeyCode);
                return CallNextHookEx(m_hHook, nCode, wParam, lParam);
            }
        
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Data">Данные для внесения</param>
        /// <param name="Element">текущий элемент правила</param>
        /// <param name="SendKey">ключ который необходимо вставить после вставки данных</param>
        /// <returns></returns>
        private bool Set_Data(string[] Data, string Element, string SendKey)
        {
            
            bool Result = false;
            try
            {
                if (Element.Trim().Length != 0)
                {
                    int Index = 0;
                    if (int.TryParse(Element, out Index))
                    {
                        Index -= 1;//Index--;--Index;
                        if (Data.Length > Index)
                        {
                            Clipboard.SetText(Data[Index]);
                            SendKeys.SendWait("+{INS}");
                            Result = true;
                        }
                        else
                        {
                            //Если индекс больше чем массив данных, то надо с этим что то делать, наверное
                            DialogResult Dresult = MessageBox.Show("Не верно задано правило.\nИндекс правила превышает размер массива данных для вставки.\nДа-вставляем значение правила.\nОтмена-остановить выполнение.", "Сообщение", MessageBoxButtons.OKCancel);
                            if (Dresult == DialogResult.OK)
                            {
                                Clipboard.SetText(Element);
                                SendKeys.SendWait("+{INS}");
                                Result = true;
                            }
                            if (Dresult == DialogResult.Cancel)
                                Result = false;
                        }
                    }
                    else
                    {
                        //Если не смогли разобрать то, что было написано в правиле надо решить что с этим делать
                        Clipboard.SetText(Element);
                        SendKeys.SendWait("+{INS}");
                        Result = true;
                    }
                }
                if (SendKey.Length != 0)
                    SendKeys.Send(SendKey);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " in Set_Data"+":["+string.Join(";",Data)+","+Element+","+SendKey+"]",ex);
            }
            return Result;
        }

        public void SetHook()
        {
            Play = true;
            m_callback = LowLevelKeyboardHookProc;
            m_hHook = SetWindowsHookEx(WH_KEYBOARD_LL, m_callback, GetModuleHandle(IntPtr.Zero), 0);
        }

        public void Unhook()
        {
            Play = false;
            UnhookWindowsHookEx(m_hHook);
        }
    }
}
