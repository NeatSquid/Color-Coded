using System;
using System.Collections;
using Handler_Scripts;
using UnityEngine;

namespace Color_Scripts
{
    public class ColorChanger : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Red"))
            {
                var go = gameObject;
                go.GetComponent<Collider>().enabled = false;
                collision.gameObject.GetComponent<MeshRenderer>().enabled = true;
                collision.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
                gameObject.GetComponent<Rigidbody>().AddForce(Vector3.down * 50f, ForceMode.Impulse);
                Destroy(go);
                print("Game Over");
            }
            else
            {
                gameObject.GetComponent<Collider>().enabled = false;
                var go = Instantiate(Resources.Load("splash1"), collision.gameObject.transform, true) as GameObject;
                Destroy(go, .1f);

                collision.gameObject.name = "color";
                collision.gameObject.tag = "Red";
                StartCoroutine(ChangeColor(collision.gameObject));
            }
        }

        private IEnumerator ChangeColor(GameObject go)
        {
            yield return new WaitForSeconds(.1f);
            go.gameObject.GetComponent<MeshRenderer>().enabled = true;
            go.gameObject.GetComponent<MeshRenderer>().material.color = BallHandler.BaseColor;
            Destroy(gameObject);
        }
    }
}