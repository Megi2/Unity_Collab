using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSet : MonoBehaviour
{
    GameObject NPC;
    public int NPCTag;
    // Start is called before the first frame update
    public int Tag() {
        return NPCTag;
    }
}
