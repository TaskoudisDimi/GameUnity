using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveWithButtons : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    bool isPresses = false;
    public GameObject player;
    public float Force;


    // Update is called once per frame
    void Update()
    {
        if (isPresses)
        {
            player.transform.Translate(Force * Time.deltaTime, 0, 0);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isPresses = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPresses = false;
    }
}
