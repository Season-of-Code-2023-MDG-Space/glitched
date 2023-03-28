using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;
using TMPro;

namespace Codes
{
    public class MasterScript : MonoBehaviour
    {
        public static Room current_room;
        public static PlayerData pd;
        string temp;
        void Start()
        {
            int x = PlayerPrefs.GetInt("LLLOOO");
            Debug.Log(Application.persistentDataPath);
            pd = SaveSystem.LoadData();
            temp = pd.load_room;
            begin();
        }
        async void begin()
        {
        lol:
            switch (temp)
            {
                case "Room1":
                    current_room = GetComponent<Room1>();
                    break;
                case "Room2":
                    current_room = GetComponent<Room2>();
                    break;
                case "Room3":
                    current_room = GetComponent<Room3>();
                    break;
                case "Room4":
                    current_room = GetComponent<Room4>();
                    break;
                case "Room5":
                    current_room = GetComponent<Room5>();
                    break;
                case "Room6":
                    current_room = GetComponent<Room6>();
                    break;
                case "Room7":
                    current_room = GetComponent<Room7>();
                    break;
                case "Room8":
                    current_room = GetComponent<Room8>();
                    break;
                case "Room9":
                    current_room = GetComponent<Room9>();
                    break;
                case "Room10":
                    current_room = GetComponent<Room10>();
                    break;
                case "ExploreSouth":
                    current_room = GetComponent<ExploreSouth>();
                    break;
                case "Room11l":
                    current_room = GetComponent<Room11l>();
                    break;
                case "Room11u":
                    current_room = GetComponent<Room11u>();
                    break;
                case "Ending2":
                    current_room = GetComponent<Ending2>();
                    break;
                case "Fight":
                    current_room = GetComponent<BossFight>();
                    break;
                case "BadEnding1":
                    current_room = GetComponent<BadEnding1>();
                    break;
                case "BadEnding2":
                    current_room = GetComponent<BadEnding2>();
                    break;
                case "GoodEnding1":
                    current_room = GetComponent<GoodEnding1>();
                    break;
                case "EndingLMAO":
                    current_room = GetComponent<EndingLMAO>();
                    break;
                default:
                    return;
            }
            temp = await current_room.enterRoom();
            if (temp != null)
                goto lol;
        }
        void OnApplicationQuit()
        {
            PlayerData temo = SaveSystem.LoadData();
            temo.load_room=temp;
            SaveSystem.SaveData(temo);
        }
    }
}