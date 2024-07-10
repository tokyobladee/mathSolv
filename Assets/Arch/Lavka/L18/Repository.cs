using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Repository
{
    public abstract void Initialize();
    public abstract void Save();
}
