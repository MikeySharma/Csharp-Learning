public class BankAccount
{
    // private fields
    private string _owner;
    private double _balance;

    // internal - accessible within the same assembly
    internal string BranchCode;

    // auto property - public getter and private setter
    public string AccountNumber { get; private set; }

    // contructors
    // default constructor
    public BankAccount()
    {
        _owner = "Unknown";
        _balance = 0.0;
        BranchCode = "DEFAULT";
        AccountNumber = "00000000";
    }

    // parameterized constructor
    public BankAccount(string owner, double initialBalance, string branchCode)
    {
        _owner = owner;
        _balance = initialBalance;
        BranchCode = branchCode;
        AccountNumber = Guid.NewGuid().ToString().Substring(0, 8).ToUpper();
    }

    // properties
    public string Owner
    {
        get { return _owner; }
    }

    public double Balance
    {
        get { return _balance; }
        private set
        {
            if (value < 0)
            {
                throw new InvalidOperationException("Insufficient funds.");
            }
            _balance = value;
        }
    }

    // public methods
    public void Deposit(double amount)
    {
        if (amount <= 0) throw new ArgumentException("Deposit must be positive.");
        Balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount <= 0) throw new ArgumentException("Withdrawal must be positive.");
        Balance -= amount;
    }

    public void DisplayAccountInfo()
    {
        Console.WriteLine($"Account Owner: {Owner}");
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Branch Code: {BranchCode}");
        Console.WriteLine($"Balance: ${Balance:F2}");
    }

}