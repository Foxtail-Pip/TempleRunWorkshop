using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] float laneChangeSpeed = 2f;
    [SerializeField] private int lane = 0;
    [SerializeField] private float laneWidth = 2f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, 0f, speed * Time.deltaTime);

        Vector3 pos = transform.position;
        pos.x = Mathf.Lerp(pos.x, lane * laneWidth, Time.deltaTime * laneChangeSpeed);
        transform.position = pos;

      /*  if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            lane -= 1;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow)) 
        { 
            lane += 1; 
        }

        lane = Mathf.Clamp(lane, -1, 1);

        transform.position = new Vector3(laneWidth * lane, transform.position.y, transform.position.z); */

    } 

    public void ChangeLane(InputAction.CallbackContext inputData)
    {
        Vector2 inputVector = inputData.ReadValue<Vector2>();

        Debug.Log(inputVector.x);

        if (inputVector.x != 0)
        {
            lane = Mathf.Clamp(lane + Mathf.RoundToInt(inputVector.x), -1, 1);
        }
    }
}
