using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System.Threading.Tasks;

namespace CoolBoi{
public class Room
{
    public virtual Task<Room> enterRoom()
    {
        Debug.Log("Error");
        return null;
    }

}
}