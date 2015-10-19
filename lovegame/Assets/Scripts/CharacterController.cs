using UnityEngine;
using System.Collections;

public enum player {
    PLAYERONE = 0,
    PLAYERTWO = 1,
}

public class CharacterController : MonoBehaviour {
	public GameObject playerWithAbility; 
    //Script used for both characters.

    public bool isStickyNote;
    public bool isPen;
    private bool isNear;

    public GameObject OtherOne;
    public GameObject Abilities;
    public GameObject PlaySound;

    public float maxSpeed = 2.0f;
    public float minSpeed;
    public float speed = 10.0f;

    public player currentPlayer;
    private string horizontalControl;

	// Use this for initialization
	void Start () {
	    switch(currentPlayer) {
            case player.PLAYERONE:
                horizontalControl = "Horizontal";
                break;
            case player.PLAYERTWO:
                horizontalControl = "Horizontal2";
                break;
        }
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float translation = Input.GetAxis(horizontalControl) * speed;

        if (translation > 0)
        {
            translation = Mathf.Min(translation, maxSpeed);
        } else if (translation < 0)
        {
            translation = Mathf.Max(translation, -1*maxSpeed);
        } else
        {
            translation = 0;
        }
        transform.Translate(translation, 0, 0);
    }

	//void OnTriggerEnter2D(Collider2D col)
//	{
	//	if (col.tag == "Ability1") {
	//		Destroy(col.gameObject); 
	//		Instantiate(playerWithAbility,transform.position,Quaternion.identity); 
	//		Destroy(this.transform.gameObject, 0.5f); 
	//	}
	//}
}
