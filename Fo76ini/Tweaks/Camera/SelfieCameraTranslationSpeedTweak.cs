﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fo76ini.Tweaks.Camera
{
    class SelfieCameraTranslationSpeedTweak : ITweak<float>, ITweakInfo
    {
        public string Description => "";

        public string AffectedFiles => "Fallout76Custom.ini";

        public string AffectedValues => "[Camera]fSelfieCameraTranslationSpeed";

        public float DefaultValue => 2.5f;

        public string Identifier => this.GetType().FullName;

        public float GetValue()
        {
            return IniFiles.GetFloat("Camera", "fSelfieCameraTranslationSpeed", DefaultValue);
        }

        public void SetValue(float value)
        {
            IniFiles.F76Custom.Set("Camera", "fSelfieCameraTranslationSpeed", value);
        }

        public void ResetValue()
        {
            IniFiles.F76Custom.Remove("Camera", "fSelfieCameraTranslationSpeed");
            //SetValue(DefaultValue);
        }
    }
}
