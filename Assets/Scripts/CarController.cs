using System.Collections.Generic;
using UnityEngine;
using ZylveLib;
using ZylveLib.Guns;
using ZylveLib.Guns.Constants;

public class CarController : MonoBehaviour {
    public float EngineTorque = 600f, MaxSteer = 20f;

    public Car Car { get; private set; }
    private List<Wheel> _wheels;

    private void Update() {
        Car.Steer(Input.GetAxis("Horizontal"));
        Car.Throttle(Input.GetAxis("Vertical"));

        Car.Drive();
    }

    private void Start() {
        _wheels = new List<Wheel>();
        foreach(WheelController w in GetComponentsInChildren<WheelController>()) {
            _wheels.Add(w.Wheel);
        }
        Transform com = transform.Find("com").transform;
        Rigidbody rb = GetComponent<Rigidbody>();
        Car = new Car(com, rb, _wheels, EngineTorque, MaxSteer);
    }
}