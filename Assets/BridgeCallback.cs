using UnityEngine;

public class BridgeCallback : MonoBehaviour
{
    private float startPosZ;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, ScoreCallback.CurrentSpeed);

        if (transform.localPosition.z <= -3.5f)
        {
            transform.position += new Vector3(0, 0, 70f);
        }
    }
}