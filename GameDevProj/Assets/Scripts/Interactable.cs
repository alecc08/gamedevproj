using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    interface Interactable
    {
        void interact(GameObject player);
        bool isInteractable();
        string getLabel();
    }
}
