using UnityEngine;

public class PlayerCallback : MonoBehaviour
{
    public Transform startMarker;
    public float speed = 1.0F;
    private float startTime;

    private float journeyLength;

    // Use this for initialization3
    private void Start()
    {
//        startTime = Time.time;
//        journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
    }

    // Update is called once per frame
    private void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Mouse X") * 0.1F, 0, 0);
        if (transform.position.x >= 2.3f)
            transform.position = new Vector3(2.3f, transform.position.y, transform.position.z);
        else if (transform.position.x <= -2.3f)
            transform.position = new Vector3(-2.3f, transform.position.y, transform.position.z);

        /////
//        var np = transform.position;
//        np.x = 0;
//        np += new Vector3(Input.GetAxis("Mouse X"), 0, 0);
//
//
//        float distCovered = (Time.time - startTime) * speed;
//        float fracJourney = distCovered / journeyLength;
//        transform.position = Vector3.Lerp(startMarker.position, np, fracJourney);
    }

    private void OnTriggerEnter(Collider obj)
    {
        if (obj.name == "boxCardboard")
        {
//            Debug.Log("Luckybox!");
//            ScoreCallback.CurrentSpeed += 0.02f;
        }
        else
        {
            ScoreCallback.GameArePlaying = false;
            ScoreCallback.CurrentScore = 0;
            ScoreCallback.CurrentSpeed = -0.02f;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}