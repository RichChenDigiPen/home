using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour
{
    
    public Health playerHealth;
    public Score playerScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //vector and physics 2d computation
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            
        RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

        if (hit.collider != null) {
            if (Input.GetMouseButtonDown(0)) {

                //debug stuff
			    Debug.Log("Mouse Clicked");
                Debug.Log(hit.collider.gameObject.name);

                //pick up if can pick up
                // hit.collider.gameObject.GetComponent<MouseMove2D>().PickUp();

                
                Debug.Log("sdfsd");
                //get health and score changes
                int hc = hit.collider.gameObject.GetComponent<MouseMove2D>().getHealthChange;
                int sc = hit.collider.gameObject.GetComponent<MouseMove2D>().getScoreChange;
                Debug.Log(hc);
                Debug.Log(sc);
                Debug.Log("sdfsd");
                Action(hc, sc);
		    }
        }
    }

    //applies changes in healthaction and scoreaction
    public void Action(int healthAction, int scoreAction)
    {
        playerHealth.setChange(healthAction);
        playerScore.setChange(scoreAction);
    }
}
