using UnityEngine;
using ZylveLib;

public class WheelController : MonoBehaviour {
    public bool Steer;
    public bool Power;

    public Wheel Wheel { get; private set; }

    private void Update() {
        Wheel.Turn();
    }

    private void Awake() {
        Wheel = new Wheel(Steer, Power, GetComponent<WheelCollider>(), GetComponentInChildren<MeshRenderer>().transform);
    }
}