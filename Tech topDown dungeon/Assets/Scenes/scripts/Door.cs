using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public playermovement player;
    public BoxCollider2D box;
    public SpriteRenderer spriteChange;
    public Sprite openDoor;

    // Update is called once per frame
    void Update()
    {
        if(player.hasKey == true)
        {
            box.enabled = false;
            spriteChange.enabled = false;
            spriteChange.sprite = openDoor;
        }
    }
}
