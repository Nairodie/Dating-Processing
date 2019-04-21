using System;

enum AccountState
{
  New,
  Active,
  UnderAudit,
  Frozen,
  CLosed
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
    
  }
}
