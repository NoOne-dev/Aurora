﻿using System;
using System.IO;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Aurora.Settings;
using Newtonsoft.Json;

namespace Aurora.Profiles.Blacklight
{
    public class Blacklight : Application
    {
        public Blacklight()
            : base(new LightEventConfig { Name = "Blacklight: Retribution", ID = "BLight", ProcessNames = new[] { "FoxGame-win32-Shipping.exe" }, SettingsType = typeof(FirstTimeApplicationSettings), ProfileType = typeof(BLightProfile), OverviewControlType = typeof(Control_BLight), GameStateType = typeof(GameState_Wrapper), Event = new GameEvent_Generic(), IconURI = "Resources/blacklight_64x64.png" })
        {
            Config.ExtraAvailableLayers.Add("WrapperLights");
        }
    }
}
