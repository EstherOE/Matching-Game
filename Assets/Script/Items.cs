using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    Rigidbody rb;
    Vector3 screenPt;
    Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }



    private void OnMouseDown()
    {
        if (GameManager.Instance.isGameOver)
        {
            rb.useGravity = false;
            screenPt = Camera.main.WorldToScreenPoint(gameObject.transform.position);
            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPt.z));
        }
    }
    private void OnMouseDrag()
    {
        if (GameManager.Instance.isGameOver)
        {
            Vector3 cursorPt = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPt.z);
            Vector3 cursor = Camera.main.ScreenToWorldPoint(cursorPt) + offset;

            rb.position = cursor;

            rb.MovePosition(new Vector3(rb.position.x, 0.5f, rb.position.z));
        }
    }
    private void OnMouseUp()
    {
        if (GameManager.Instance.isGameOver)
        {
            rb.useGravity = true;

        }
    }
}
