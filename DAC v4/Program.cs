// Decompiled with JetBrains decompiler
// Type: DAC_v4.Program
// Assembly: DAC v4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: ADCD26C7-7115-49CB-A171-B101A2567B86
// Assembly location: C:\Users\Yssentrick\Desktop\DAC v4\DAC v4.exe

using System;
using System.Windows.Forms;

namespace DAC_v4
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new DAC());
    }
  }
}
