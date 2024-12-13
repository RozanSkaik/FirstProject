using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment26
{
    public class CreatureManager : MonoBehaviour
    {
        List<Creature> creatures;

        IRunnable[] runnables;
        IJumpable[] jumpables;
        ISwimmable[] swimmables;

        void Start()
        {
            creatures = new List<Creature> { new Kangaroo(), new Duck() };

            runnables = new IRunnable[] { new Kangaroo(), new Duck() };
            jumpables = new IJumpable[] { new Kangaroo() };
            swimmables = new ISwimmable[] { new Duck() };

            foreach (Creature creature in creatures)
            {
                creature.Speak();
            }
            Debug.Log("***************");
            foreach (IRunnable runnable in runnables)
            {
                runnable.Run();
            }
            Debug.Log("***************");
            foreach (IJumpable jumpable in jumpables)
            {
                jumpable.Jump();
            }
            Debug.Log("***************");
            foreach (ISwimmable swimmable in swimmables)
            {
                swimmable.Swim();
            }

        }


    }
}