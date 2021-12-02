using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MatchMaker : MonoBehaviour
{
    public List<GameObject> placedObjects = new List<GameObject>();
    public Transform PointA;
    public TextMeshProUGUI scoreText;
    public int score;
    private int mainScore = 0;
    public void Start()
    {
        score = mainScore;
        scoreText.text = "Score: " + score;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (placedObjects.Count == 0)
        {
            other.gameObject.transform.position = PointA.position;
            other.gameObject.transform.rotation = PointA.rotation;

            placedObjects.Add(other.gameObject);
        }
        else if(other.gameObject.transform.name.Contains(placedObjects[0].name)==true)
        {
            getScore(10);
            Destroy(other.gameObject);
            Destroy(placedObjects[0].gameObject);
            placedObjects.Clear();
        }
        else
        {
            other.GetComponent<Rigidbody>().velocity = new Vector3(0, 1, 1) * 120 * Time.deltaTime;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if(placedObjects.Contains(other.gameObject))

        {
            placedObjects.Remove(other.gameObject);
        }
    }

    public void  getScore(int dscore)
    {
        score += dscore;

        scoreText.text = "Score: " + score;
    }
}
