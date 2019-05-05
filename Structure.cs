using System;

enum AccountState
{
  New,
  Active,
  UnderAudit,
  Frozen,
  Closed
};

struct Account
{
	public AccountState State;
	public string Name;
	public string Address;
	public int AccountNumber;
	public int Balance;
	public int Overdraft;		
};

class BankProgram
{
  public static void Main()
  {
	  Account BobsAccount;
	  BobsAccount.State = AccountState.Active;
	  BobsAccount.Name = "Bob Barker";
	  BobsAccount.Address = "3503 Willie Way";
	  BobsAccount.AccountNumber = 12345678;
	  BobsAccount.Balance = 0;
	  BobsAccount.Overdraft = -1000;
	  
	  Console.WriteLine("Name is : " + BobsAccount.Name);
	  Console.WriteLine("Balance is : " + BobsAccount.Balance);
  }
}
