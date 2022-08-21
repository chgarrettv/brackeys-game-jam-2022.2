using UnityEngine;

public class Rotator : MonoBehaviour {

    public float degreesPerSecond = 15f;
    float rotation = 0;

    void Update() {
        rotation += degreesPerSecond * Time.deltaTime;
        transform.localRotation = Quaternion.AngleAxis(rotation, Vector3.forward);
    }
}
