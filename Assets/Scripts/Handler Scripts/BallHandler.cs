using UnityEngine;
using Random = UnityEngine.Random;

public class BallHandler : MonoBehaviour
{
    public static float RotationSpeed = 130f;

    public static Color BaseColor = Color.cyan;
    public GameObject ball;

    public float speed = 100;

    private void Start()
    {
        MakeCircle();
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
        var go = Instantiate(ball, new Vector3(0f, 0f, -8f), Quaternion.identity);
        go.GetComponent<MeshRenderer>().material.color = BaseColor;
        go.GetComponent<Rigidbody>().AddForce(Vector3.forward * speed, ForceMode.Impulse);
    }

    private void MakeCircle()
    {
        var go = Instantiate(Resources.Load("Round" + Random.Range(1, 4))) as GameObject;
        go.transform.position = new Vector3(0f, 20f, 23f);
        go.name = "Circle";
    }
}