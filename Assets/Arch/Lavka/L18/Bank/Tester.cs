using System;
using UnityEngine;

public class Tester : MonoBehaviour
    {
        private BankRepository bankRepository;
        private BankInteractor bankInteractor;

        private void Start()
        {
            this.bankRepository = new BankRepository();
            this.bankRepository.Initialize();

            this.bankInteractor = new BankInteractor(this.bankRepository);
            this.bankInteractor.Initialize();
            
            Debug.Log($"Start coins {Bank.coins}");
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A)){
                Bank.AddCoins(this, 5);
            Debug.Log($"Coin added(5), {Bank.coins}");
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                Bank.Spend(this, 10);
                Debug.Log($"Coin spend 10, {Bank.coins}");
            }
        }
    }