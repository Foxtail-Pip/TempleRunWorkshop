using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private float speed = 5f;

    [SerializeField] private int lane = 0;
    [SerializeField] private float laneWidth = 2f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, 0f, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            lane -= 1;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow)) 
        { 
            lane += 1; 
        }

        lane = Mathf.Clamp(lane, -1, 1);

        transform.position = new Vector3(laneWidth * lane, transform.position.y, transform.position.z);

        /* Oooohh comment ooohh
         Wooooaah */
    }
}
