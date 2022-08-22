using System.Collections.Generic;
using UnityEngine;

namespace ZylveLib {
    public class Car {
        public readonly Transform Com;
#pragma warning disable IDE1006
        public readonly Rigidbody rb;
#pragma warning restore IDE1006
        public readonly List<Wheel> Wheels;

        private readonly float _engineTorque;
        private readonly float _maxSteer;
        public float SteerAngle { get; private set; }
        public float Torque { get; private set; }

        public void Steer(float iSteer) {
            this.SteerAngle = iSteer;
        }

        public void Throttle(float iThrottle) {
            this.Torque = -iThrottle;
        }

        public void Drive() {
            foreach(Wheel w in Wheels) {
                w.SteerAngle = this.SteerAngle * this._maxSteer;
                w.Torque = this.Torque * this._engineTorque;
            }
        }

        public Car(Transform com, Rigidbody rb, List<Wheel> wheels, float engineTorque, float maxSteer) {
            this.Com = com;
            this.rb = rb;
            this.Wheels = wheels;
            this._engineTorque = engineTorque;
            this._maxSteer = maxSteer;

            this.rb.centerOfMass = this.Com.localPosition;
        }
    }

    public class Wheel {
        private readonly WheelCollider _wCollider;
        private readonly Transform _wTransform;

        public bool Steer { get; private set; }
        public bool Power { get; private set; }
        public float SteerAngle { get; set; }
        public float Torque { get; set; }

        private void UpdateMesh() {
            _wCollider.GetWorldPose(out Vector3 pos, out Quaternion rot);
            _wTransform.position = pos;
            _wTransform.rotation = rot;
        }

        private void UpdateCollider() {
            if(Steer) {
                _wCollider.steerAngle = Mathf.LerpAngle(_wCollider.steerAngle, SteerAngle, 5 * Time.deltaTime);
            }

            if(Power) {
                _wCollider.motorTorque = Torque;
            }
        }

        public void Turn() {
            UpdateMesh();
            UpdateCollider();
        }

        public Wheel(bool steer, bool power, WheelCollider wCollider, Transform wTransform) {
            this.Steer = steer;
            this.Power = power;
            this._wCollider = wCollider;
            this._wTransform = wTransform;
        }
    }

    namespace Guns {
        public class Gun {
            public float Damage { get; internal set; }
            public int DamageSpread { get; internal set; }

            public float ReloadTime { get; internal set; }

            public int AmmoCost { get; internal set; }

            public int MagazineMax { get; internal set; }
            public float MagazineReloadTime { get; internal set; }

            public string GunName { get; internal set; }

            public int GunID { get; internal set; }
            public string GunType { get; internal set; }

            public void MagazineReload() { }

            public void Shoot() { }

            public void Reload() { }

            private void RaycastCalculations() { }

            internal Gun() { }
        }

        public static class GunFactory {
            public static Gun GetGun(Dictionary<string, object> gunStats, int damageLevel, int reloadLevel) {
                Gun gun = new Gun();

                gun.Damage = ((float[])gunStats["Damage"])[damageLevel];
                gun.DamageSpread = (int)gunStats["DamageSpread"];
                gun.ReloadTime = ((float[])gunStats["ReloadTime"])[reloadLevel];
                gun.AmmoCost = (int)gunStats["AmmoCost"];
                gun.MagazineMax = (int)gunStats["MagazineMax"];
                gun.MagazineReloadTime = ((float[])gunStats["MagazineReloadTime"])[reloadLevel];
                gun.GunName = (string)gunStats["GunName"];
                gun.GunType = (string)gunStats["GunType"];

                return gun;
            }
        }
    }
}