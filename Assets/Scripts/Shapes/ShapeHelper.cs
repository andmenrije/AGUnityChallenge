using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(SpriteRenderer))]
public class ShapeHelper : MonoBehaviour, IShape
{
    private const float DOUBLE_CLICK_THRESHOLD = 0.2f;
    private Material shapeMat;
    private float previousClickTime;

    public void Draw()
    {
        
    }

    public void SetColor(Color newColor)
    {
        shapeMat.color = newColor;
    }

    // Start is called before the first frame update
    void Start()
    {
        shapeMat = GetComponent<SpriteRenderer>().material;

    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyUp(KeyCode.Alpha1))
        //{
        //    SetColor(UnityEngine.Random.ColorHSV());
        //}

    }

    private void OnMouseDown()
    {

        if(Input.GetMouseButtonDown(0))
        {
            float diffClickTime = Time.time - previousClickTime;
            if(diffClickTime <= DOUBLE_CLICK_THRESHOLD)
            {
                SetColor(UnityEngine.Random.ColorHSV());
                AudioManager.Instance.PlayAudio(AudioManager.AudioType.Click1);
            }
            else
            {
            }


            previousClickTime = Time.time;
        }


    }


}
