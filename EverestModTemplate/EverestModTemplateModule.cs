using System;
using Celeste.Mod;

namespace EverestModTemplate
{
    public class EverestModTemplateModule : EverestModule
    {
        public EverestModTemplateModule()
        {
            Instance = this;
        }

        private static EverestModTemplateModule Instance { get; set; }

        public override Type SettingsType => typeof(EverestModTemplateSettings);
        public static EverestModTemplateSettings Settings => (EverestModTemplateSettings) Instance._Settings;

        public override Type SaveDataType => typeof(EverestModTemplateSaveData);
        public static EverestModTemplateSaveData SaveData => (EverestModTemplateSaveData) Instance._SaveData;

        public override Type SessionType => typeof(EverestModTemplateSession);
        public static EverestModTemplateSession Session => (EverestModTemplateSession) Instance._Session;

        public override void Load()
        {
            // TODO Add loading logic
        }

        public override void Unload()
        {
            // TODO Add unloading logic
        }
    }
}