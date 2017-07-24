using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class TrumpCntrl : MonoBehaviour {


    private Animation anim;
    private Rigidbody rb;
	[SerializeField]
	private float speed = 4f;

	void Start () {
		rb = GetComponent <Rigidbody> ();
        anim = GetComponent<Animation>();
		
	}
	
	
	void Update () {
        float x = CrossPlatformManager.GetAxis("Horizontal");
        float y = CrossPlatformManager.GetAxis("Vertical");

        Vector3 movement = new Vector3(x, 0, y);
        rb.velocity = movement * speed;

        if (x != 0 && y != 0)
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, Mathf.Atan2(x, y) * Mathf.Rad2Deg, transform.eulerAngles.x

        if (x != 0 || y != 0)
            anim.Play("Go");
        else
            anim.Play("Stand");


    }
}
