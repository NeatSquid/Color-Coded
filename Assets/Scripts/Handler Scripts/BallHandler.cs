using UnityEngine;
using Random = UnityEngine.Random;

public class BallHandler : MonoBehaviour
{
    public static float RotationSpeed = 99f;
    public static float RotationTime = 3f;

    private int _ballsCount;
    private int _circleIndex;

    public static Color BaseColor = Color.cyan;
    public GameObject ball;

    public float speed = 100;

    private void Start()
    {
        var go = Instantiate(Resources.Load("Round" + Random.Range(1, 4))) as GameObject;
        go.transform.position = new Vector3(0f, 20f, 23f);
        go.name = "Circle" + _circleIndex;

        MakeCircle();

        _ballsCount = 4;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            HitBall();
        }
    }

    private void HitBall()
    {
        if (_ballsCount <= 1)
        {
            Invoke(nameof(MakeCircle), .4f);
            //temporary disable button
        }

        _ballsCount--;

        var go = Instantiate(ball, new Vector3(0f, 0f, -8f), Quaternion.identity);
        go.GetComponent<MeshRenderer>().material.color = BaseColor;
        go.GetComponent<Rigidbody>().AddForce(Vector3.forward * speed, ForceMode.Impulse);
    }

    private void MakeCircle()
    {
        var arr = GameObject.FindGameObjectsWithTag("circle");
        var goo = GameObject.Find("Circle" + _circleIndex);
        for (var i = 0; i < 24; i++)
        {
            goo.transform.GetChild(i).gameObject.SetActive(false);
        }

        goo.transform.GetChild(24).gameObject.GetComponent<MeshRenderer>().material.color = BaseColor;

        if (goo.GetComponent<iTween>())
        {
            goo.GetComponent<iTween>().enabled = false;
        }

        foreach (var item in arr)
        {
            iTween.MoveBy(item, iTween.Hash("y", -2.98f, "easetype", iTween.EaseType.spring, "time", .5));
        }

        _circleIndex++;

        var go = Instantiate(Resources.Load("Round" + Random.Range(1, 4))) as GameObject;
        go.transform.position = new Vector3(0f, 20f, 23f);
        go.name = "Circle" + _circleIndex;
    }
}