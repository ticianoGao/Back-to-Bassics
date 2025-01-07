using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : Singleton<InventoryManager>
{

    [Header("Player-Owned Combos")]
    [Tooltip("All combos the poncho currently unlocked")]
    public List<Combo> playerCombos = new List<Combo>();


    [Header("All Available Combos")]
    [Tooltip("All the combos that exist in the game, locked or unlocked")]
    public List<Combo> allCombos = new List<Combo>();


    private void Awake()
    {
        InitializeSingleton();
    }

    // Start is called before the first frame update
    private void Start()
    {
        InitializeCombos();
        // checking all available combos are added to the inventory manager
        /*
        foreach (Combo combo in allCombos)
        {
            Debug.Log(combo.StrId);
        }
        */
    }


    private void InitializeCombos()
    {
        // currently nothing because no combo is initially given.
            
    }

    public void ShowUnlockedCombos()
    {
        foreach(Combo combo in playerCombos)
        {
            Debug.Log(combo.StrId);
        }
    }

    public void AddCombo(Combo newCombo)
    {
        if (!playerCombos.Contains(newCombo))
        {
            playerCombos.Add(newCombo);
            Debug.Log($"[InventoryManager] Added combo: {newCombo.StrId}");
        }
        else
        {
            Debug.Log($"[InventoryManager] Combo already owned: {newCombo.StrId}");
        }
    }

    public void RemoveCombo(Combo combo)
    {
        // Currently not needed?
    }
}
