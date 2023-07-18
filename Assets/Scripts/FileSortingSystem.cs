using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FileSortingSystem : MonoBehaviour
{
    public void SpawnFile()
    {
        int fileNumber = Random.Range(1, 21);

        // MusicFile
        if (fileNumber >= 1 && fileNumber <= 5)
        {
            
        }
        // PhoneFile
        else if (fileNumber >= 6 && fileNumber <= 10)
        {

        }
        // ShopFile
        else if (fileNumber >= 11 && fileNumber <= 15)
        {

        }
        // SpamFile
        else if (fileNumber >= 16 && fileNumber <= 20)
        {
            
        }

    }
}
