using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerPaddle : MonoBehaviour
{
    // variables
    protected Vector3 movDir = Vector3.zero;
    [SerializeField,Range(1,20)] protected float movSpeed = 10f;
    //[SerializeField,Range(10,29)] protected float maxSpeed = 25f;

    //methods
    private void Update()
    {
        MovePaddle();
    }
    //take input from action
    public void MoveInput(InputAction.CallbackContext aCon)
    {
        Vector2 av2 =  aCon.ReadValue<Vector2>();

        movDir.x = av2.x;
        //aMovDir.z = av2.y;
    }
    //move player
    public void MovePaddle()
    {
        transform.Translate(movDir* movSpeed * Time.deltaTime);
    }
    //accessors


}
