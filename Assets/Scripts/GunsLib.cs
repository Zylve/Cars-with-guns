using System.Collections.Generic;

namespace ZylveLib.Guns.Constants {
    public static class Constants {
        public static class OneShot {
            public static readonly Dictionary<string, object> Pistol = new Dictionary<string, object>() {
                { "Damage", new float[] { 30f, 35f, 40f, 50f, 60f } },
                { "DamageSpread", 1 },
                { "ReloadTime", new float[] { 0.5f, 0.33f, 0.2f, 0.1f, 0.025f } },
                { "AmmoCost", 5 },
                { "MagazineMax", 20 },
                { "MagazineReloadTime", new float[] { 2f, 1.75f, 1.5f, 1.3f, 1f } },
                { "GunName", "Pistol" },
                { "GunType", "oneshot" }
            };

            public static readonly Dictionary<string, object> Revolver = new Dictionary<string, object>() {
                { "Damage", new float[] { 25f, 30f, 38f, 45f, 50f } },
                { "DamageSpread", 1 },
                { "ReloadTime", new float[] { 1f, 0.8f, 0.66f, 0.4f, 0.2f } },
                { "AmmoCost", 1 },
                { "MagazineMax", 6 },
                { "MagazineReloadTime", new float[] { 5f, 4f, 3f, 2f, 1f } },
                { "GunName", "Revolver" },
                { "GunType", "oneshot" }
            };

            public static readonly Dictionary<string, object> Shotgun = new Dictionary<string, object>() {
                { "Damage", new float[] { 40f, 50f, 60f, 70f, 80f } },
                { "DamageSpread", 1 },
                { "ReloadTime", new float[] { 2f, 1.75f, 1.5f, 1.33f, 1f } },
                { "AmmoCost", 15 },
                { "MagazineMax", 5 },
                { "MagazineReloadTime", new float[] { 6f, 5f, 4f, 3f, 2f } },
                { "GunName", "Shotgun" },
                { "GunType", "oneshot" }
            };

            public static readonly Dictionary<string, object> Laser = new Dictionary<string, object>() {
                { "Damage", new float[] { 80f, 125f, 140f, 180f, 250f } },
                { "DamageSpread", 1 },
                { "ReloadTime", new float[] { 15f, 12f, 9f, 6f, 3f } },
                { "AmmoCost", 80 },
                { "MagazineMax", 3 },
                { "MagazineReloadTime", new float[] { 10f, 8f, 6f, 4f, 3f } },
                { "GunName", "Laser" },
                { "GunType", "oneshot" }
            };
        }

        public static class SemiAuto {
            public static readonly Dictionary<string, object> SubMachine = new Dictionary<string, object>() {
                { "Damage", new float[] { 15f, 22f, 30f, 35f, 45f } },
                { "DamageSpread", 3 },
                { "ReloadTime", new float[] { 0.25f, 0.2f, 0.175f, 0.15f, 0.1f } },
                { "AmmoCost", 3 },
                { "MagazineMax", 35 },
                { "MagazineReloadTime", new float[] { 3f, 2.5f, 2f, 1.5f, 1f } },
                { "GunName", "Sub Machine Gun" },
                { "GunType", "semiauto" }
            };

            public static readonly Dictionary<string, object> Rifle = new Dictionary<string, object>() {
                { "Damage", new float[] { 10f, 15f, 20f, 30f, 40f } },
                { "DamageSpread", 3 },
                { "ReloadTime", new float[] { 0.15f, 0.125f, 0.1f, 0.08f, 0.05f } },
                { "AmmoCost", 3 },
                { "MagazineMax", 20 },
                { "MagazineReloadTime", new float[] { 4f, 3f, 2.5f, 2f, 1.5f } },
                { "GunName", "Rifle" },
                { "GunType", "semiauto" }
            };

            public static readonly Dictionary<string, object> PistolButAuto = new Dictionary<string, object>() {
                { "Damage", new float[] { 10f, 15f, 20f, 30f, 40f } },
                { "DamageSpread", 3 },
                { "ReloadTime", new float[] { 0.2f, 0.175f, 0.15f, 0.1f, 0.08f } },
                { "AmmoCost", 4 },
                { "MagazineMax", 30 },
                { "MagazineReloadTime", new float[] { 2f, 1.75f, 1.5f, 1.3f, 1f } },
                { "GunName", "Pistol but better?" },
                { "GunType", "semiauto" }
            };
        }

        public static class FullAuto {
            public static readonly Dictionary<string, object> AutoRifle = new Dictionary<string, object>() {
                { "Damage", new float[] { 8f, 10f, 15f, 20f, 25f } },
                { "DamageSpread", 5 },
                { "ReloadTime", new float[] { 0.1f, 0.08f, 0.075f, 0.066f, 0.05f } },
                { "AmmoCost", 10 },
                { "MagazineMax", 30 },
                { "MagazineReloadTime", new float[] { 0f, 0f, 0f, 0f, 0f } },
                { "GunName", "AutoRifle" },
                { "GunType", "fullauto" }
            };

            public static readonly Dictionary<string, object> Gatling = new Dictionary<string, object>() {
                { "Damage", new float[] { 1f, 2f, 3f, 4f, 5f } },
                { "DamageSpread", 5 },
                { "ReloadTime", new float[] { 0.15f, 0.125f, 0.1f, 0.08f, 0.75f } },
                { "AmmoCost", 12 },
                { "MagazineMax", 20 },
                { "MagazineReloadTime", new float[] { 0f, 0f, 0f, 0f, 0f } },
                { "GunName", "Gatling" },
                { "GunType", "fullauto" }
            };

            public static readonly Dictionary<string, object> LightSpeed = new Dictionary<string, object>() {
                { "Damage", new float[] { 1f, 2f, 2f, 3f, 4f } },
                { "DamageSpread", 1 },
                { "ReloadTime", new float[] { 0.05f, 0.04f, 0.04f, 0.03f, 0.02f } },
                { "AmmoCost", 1 },
                { "MagazineMax", 20 },
                { "MagazineReloadTime", new float[] { 0f, 0f, 0f, 0f, 0f } },
                { "GunName", "Light Speed" },
                { "GunType", "fullauto" }
            };
        }
    }
}