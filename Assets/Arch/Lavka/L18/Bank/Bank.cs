using System;
using Unity.VisualScripting;
using UnityEngine;

public static class Bank
{
    public static event Action OnBankInitializedEvent;
    public static int coins { get {CheckClass();
        return bankInteractor.coins;
        }
    }

    public static bool isInitialize { get; private set; }

    private static BankInteractor bankInteractor;
    
    public static void Initialize(BankInteractor interactor)
    {
        bankInteractor = interactor;
        isInitialize = true;
        OnBankInitializedEvent?.Invoke();
    }
    
    public static bool IsEnoughtCoins(int value)
    {
        CheckClass();
        return bankInteractor.IsEnoughtCoins(value);
    }

    public static void AddCoins(object sender, int value)
    {
        CheckClass();
        bankInteractor.AddCoins(sender, value);
    }

    public static void Spend(object sender, int value)
    {
        CheckClass();
        bankInteractor.Spend(sender, value);
    }

    private static void CheckClass()
    {
        if (!isInitialize)
        {
            throw new Exception("Bank is not initialize yet");
        }
    }
    
}
