using System.Collections;
using UnityEngine;

public class ImpedimentCallback : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, ScoreCallback.CurrentSpeed);
        if (transform.position.z <= -7f)
        {
            var np = transform.position;
            np.x = 0;
            np += new Vector3(Random.Range(-2.3f, 2.3f), 0, Random.Range(20, 30));
            transform.position = np;
        }
    }
}