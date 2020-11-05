using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inLivros : inBase
{
    [FMODUnity.EventRef]
    public string LivrosInt;
    FMOD.Studio.EventInstance eBook;

    private int level = 1;
    public override void exclusivo()
    {
        // Setar emiter do som
        eBook = FMODUnity.RuntimeManager.CreateInstance(LivrosInt);
        FMODUnity.RuntimeManager.AttachInstanceToGameObject(eBook, GetComponent<Transform>(), GetComponent<Rigidbody>());

        // Play no som
        eBook.start();

        switch (level)
        {
            case 1:
                GameStatus.tempo += (60 * 2);
                level++;
                break;
            case 2:
                GameStatus.tempo += (60 * 4);
                level++;
                break;
            case 3:
                GameStatus.tempo += (60 * 6);
                level++;
                break;
        }
    }
}
