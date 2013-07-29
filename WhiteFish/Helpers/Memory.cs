﻿using GreyMagic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace WhiteFish
{
    class Memory
    {
        internal static ExternalProcessReader WoW { get; set; }
        internal static WoW.DirectX.Dirext3D WoWD3D { get; set; }

        internal static void Initialize(Process proc)
        {
            try
            {
                WoW = new ExternalProcessReader(proc);
                WoWD3D = new WoW.DirectX.Dirext3D(proc);
            }
            catch (Exception ex)
            {
                Debug.Log("Error: Failed to initialize WhiteFish.");
                Debug.Log(string.Format("Error: {0}", ex.Message));
            }
        }
    }
}
