public abstract class SecurityThreat
{
    public string ThreatId { get; private set; }
    public string Source { get; set; }
    public DateTime DetectedAt { get; private set; }

    public SecurityThreat(string source)
    {
        ThreatId = Guid.NewGuid().ToString().Substring(0, 8).ToUpper();
        Source = source;
        DetectedAt = DateTime.UtcNow;
    }

    public abstract string ThreatType { get; }
    public abstract void Mitigate();

    public virtual void Log()
    {
        Console.WriteLine($"[{ThreatType}] ID: {ThreatId} | Source: {Source} | At: {DetectedAt}");
    }
}

public class MalwareAttack : SecurityThreat
{
    public string MalwareName { get; set; }

    public MalwareAttack(string source, string malwareName) : base(source)
    {
        MalwareName = malwareName;
    }

    public override string ThreatType => "MALWARE";

    public override void Mitigate()
    {
        Console.WriteLine($"Quarantining {MalwareName} from {Source}. Running AV scan.");
    }

    public override void Log()
    {
        base.Log();
        Console.WriteLine($"  Malware: {MalwareName}");
    }
}

public class BruteForceAttack : SecurityThreat
{
    public int AttemptCount { get; set; }

    public BruteForceAttack(string source, int attempts) : base(source)
    {
        AttemptCount = attempts;
    }

    public override string ThreatType => "BRUTE_FORCE";

    public override void Mitigate()
    {
        Console.WriteLine($"Blocking IP {Source} after {AttemptCount} failed attempts. Alerting admin.");
    }
}

public sealed class RansomwareAttack : MalwareAttack
{
    public double DemandedAmount { get; set; }

    public RansomwareAttack(string source, string name, double amount)
        : base(source, name)
    {
        DemandedAmount = amount;
    }

    public override void Mitigate()
    {
        Console.WriteLine($"CRITICAL: Isolating system. Ransom demand: ${DemandedAmount}. Do NOT pay.");
    }

    public override void Log()
    {
        base.Log();
        Console.WriteLine($"  Ransom Demand: ${DemandedAmount}");
    }
}

static class InheritanceAndPolymorphism
{
    public static void Run()
    {
        SecurityThreat[] threats =
{
            new MalwareAttack("192.168.1.10", "Trojan.GenericKD"),
            new BruteForceAttack("10.0.0.45", 847),
            new RansomwareAttack("172.16.0.5", "LockBit.3", 50000)
        };

        foreach (SecurityThreat threat in threats)
        {
            threat.Log();       // polymorphic — calls correct override
            threat.Mitigate();  // polymorphic
            Console.WriteLine();
        }
    }
}