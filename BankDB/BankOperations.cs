using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDB
{ 
    public delegate string AccountStateHandler(string message);
    //переводы

    public class BankOperations
    {
        AccountStateHandler _del;
        
        Cards cards = new Cards();
        Client Client;
        int sum;
        public void RegisterHandler(AccountStateHandler del)
        {
            _del = del;
        }

        public void MoneyTransfer(Client client,string NamberCard,float price)
        {
            try
            {
                if (cards.NamberCard == NamberCard)
                {
                    client.Cards.Sum -= price;
                    cards.Sum += price;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }

        }
      
        public BankOperations(int count,Client client)
        {
           client.Cards.Sum = count;
            Client = client;
        }

        public double CurrentSum
        {

            get { return Client.Cards.Sum; }
        }

        public void Put(int count,Client client)
        {
            client.Cards.Sum += count;
            if (_del != null)
                _del($"Общая сумма счета {client.Cards.Sum} ");
        }

        public void Withdraw(int count,Client client)
        {
            if (count <= client.Cards.Sum)
            {
                client.Cards.Sum -= count;

                if (_del != null)
                    _del($"Сумма {count} снята со счета");
            }
            else
            {
                if (_del != null)
                    _del("Недостаточно денег на счете");
            }
        }
    }
}
