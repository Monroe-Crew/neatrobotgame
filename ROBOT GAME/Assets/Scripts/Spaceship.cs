using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject spaceshiphud;
    public GameObject ship;
    Camera m_Camera;
    void Start(){
        m_Camera = Camera.main;
        spaceshiphud.SetActive(false);
    }

    void Update(){
        if (Input.GetMouseButtonDown(0)){
            Vector3 mousePosition = Input.mousePosition;
            Ray ray = m_Camera.ScreenPointToRay(mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit)){
                if(GameObject.ReferenceEquals(hit.transform.gameObject, ship)){
                    spaceshiphud.SetActive(true);
                }
            }
        }
    }
}
