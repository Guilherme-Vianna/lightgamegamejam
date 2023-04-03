using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;


public class SoundController : MonoBehaviour
{
    [Range(0, 2)]
    public int danger;
    FMODUnity.StudioEventEmitter emitter;
    // Start is called before the first frame update
    void Start()
    {
        var target = GetComponent<FMODUnity.StudioEventEmitter>();
        emitter = target.GetComponent<FMODUnity.StudioEventEmitter>();
    }

    // Update is called once per frame
    void Update()
    {
        emitter.SetParameter("Danger", danger);
    }

    public void DoStep()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/Character/Footsteps");
    }

    public void GetBattery()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/Interactables/Battery");
    }

    public void CloseDoor()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/Interactables/ClosingDoor");
    }

    public void OpenDoor()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/Interactables/OpeningDoor");
    }

    public void LockedDoor()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/Interactables/LockedDoor");
    }

    public void UnlockDoor()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/Interactables/UnlockDoor");
    }

    public void ActiveSwitch()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/Interactables/Switch");
    }

    public void GetKeys()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/Interactables/Keys");
    }

    public void ToogleFlashlight()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/Interactables/Flashlight");
    }

    public void EnemySlide()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/Enemy/Slide");
    }

    public void EnemyFootsteep()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/Enemy/Footsteps");
    }

    public void Hint()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/Character/Hint");
    }

    public void SetDanger(int danger)
    {
        emitter.SetParameter("Danger", danger);
    }

    public void Death()
    {
        emitter.Stop();
        FMODUnity.RuntimeManager.PlayOneShot("event:/Music/Death");
    }
}