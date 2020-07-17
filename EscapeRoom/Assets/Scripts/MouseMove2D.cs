using UnityEngine;
using System.Collections;
 
public class MouseMove2D : MonoBehaviour {
 
    private Vector3 mousePosition;
    public float moveSpeed = 0.5f;
    public bool isPickedUp = false;
    public bool canPickUp = false;
    public bool clickable = false;
    public bool hasPurpose = false;
    public int ID;
 
    // Use this for initialization
    void Start () {
        
    }

    //makes an object able to be picked up
    public void makeCanPickUp()
    {
        canPickUp = true;
    }

    //make object clickable
    public void makeClickable()
    {
        clickable = true;
    }


    public void PickUp() {
        isPickedUp = true;
    }

    public void Drop() {
        isPickedUp = false;
    }
   
    // Update is called once per frame
    void Update () {
        if (canPickUp) {
            if (isPickedUp) {
                if (Input.GetMouseButton(0)) {
                    mousePosition = Input.mousePosition;
                    mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
                    transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
                } else {
                    this.Drop();
                }
            }
        }
    }

    //code for when clicked to progress story
    public void Purpose()
    {
        if(hasPurpose && clickable) {
            //debug stuff
            Debug.Log("Mouse Clicked");
            Debug.Log(this.name);

    

            //activate next objects
            int nextID = ID + 1;
            Debug.Log(nextID.ToString());
            GameObject.FindWithTag(nextID.ToString()).GetComponent<MouseMove2D>().makeCanPickUp();
            GameObject.FindWithTag(nextID.ToString()).GetComponent<MouseMove2D>().makeClickable();

        }
    }
}