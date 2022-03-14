using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.EventSystems;

public class ShootController : MonoBehaviour
{

    public float power = 2.0f;
    //public int dots = 15;

    Vector2 startPosition;

    bool shoot, aiming;

    private GameObject dots;
    private List<GameObject> projectilePath;

    Rigidbody2D rbBallBody;


    private void Awake()
    {
        dots = GameObject.Find("Dots");
    }

    // Start is called before the first frame update
    void Start()
    {
        projectilePath = dots.transform.Cast<Transform>().ToList().ConvertAll(t => t.gameObject);
        HideDots();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ShowDots();
            PathCalculation();
        }
        else if(Input.GetMouseButtonUp(0))
        {
            HideDots();
        }
    }

    

    #region Dots Functions

    void ShowDots()
    {
        for (int i = 0; i < projectilePath.Count; i++)
        {
            projectilePath[i].GetComponent<Renderer>().enabled = true;
        }
    }

    void HideDots()
    {


        for(int i=0;i<projectilePath.Count;i++)
        {
            projectilePath[i].GetComponent<Renderer>().enabled = false;
        }
    }


    void PathCalculation()
    {
        //Vector2 velocity = ShootForce(Input.mousePosition) * Time.deltaTime / rbBallBody.mass;

        for(int i =0;i<projectilePath.Count;i++)
        {
            projectilePath[i].GetComponent<Renderer>().enabled = true;
            float time = i / 7.0f;

            //Vector3 point = DotPath(transform.position,velocity,time);
            //point.z = 1;
            //projectilePath[i].transform.position = point;
            projectilePath[i].transform.position = transform.position + Input.mousePosition * Time.fixedDeltaTime * time;
        }

    }


    #endregion


    Vector2 ShootForce(Vector3 force)
    {
        return (new Vector2(startPosition.x,startPosition.y) - new Vector2(force.x,force.y)) * power;
    }


    Vector2 DotPath(Vector2 startPos,Vector2 startVelocity,float t)
    {
        return startPos + startVelocity * t + 0.5f * Physics2D.gravity * t * t;
    }

}
